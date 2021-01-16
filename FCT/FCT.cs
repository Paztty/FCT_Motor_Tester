using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Management.Instrumentation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FCT
{
    public partial class FCT : Form
    {
        public WT310 WT310E = new WT310();

        public FCT_TESTER_MODEL _MODEL = new FCT_TESTER_MODEL();

        public string[] funtionList = { FUNCTION.Model, FUNCTION.Delay, FUNCTION.Volt, FUNCTION.Ampe, FUNCTION.Wat, FUNCTION.NOP, FUNCTION.FREQUENCY, FUNCTION.OFF_POWER_SOUCER, FUNCTION.FINISH, FUNCTION.SAVE, FUNCTION.REPEAT };

        public int NumberOK = 0, NumberNG = 0, NumberTotal; 
        public FCT()
        {
            InitializeComponent();

            PortMachine.PortName = WT310E.Port;
            PortMachine.BaudRate = WT310.Baudrate;
            PortMachine.DataBits = WT310.DataBit;
            PortMachine.Parity = WT310.parity;
            PortMachine.StopBits = WT310.stopBits;

            PortMachine.Open();

            PortMachine.DataReceived += new SerialDataReceivedEventHandler(DataReciver);

            timerCheckCom.Start();

            Column2.DataSource = funtionList;

            backgroundWorker.RunWorkerAsync();
        }

        private void DataReciver(object obj, SerialDataReceivedEventArgs e)
        {
            if (!PortMachine.IsOpen) return;
            string Frame = " ";
            try
            {
                Frame = PortMachine.ReadLine();
                textBoxHistory.Invoke(new MethodInvoker(delegate
                {
                    textBoxHistory.AppendText(Frame + Environment.NewLine);
                    if (WT310E.GetFromString(Frame))
                    {
                        UpdateValue();
                        timerGetValue.Start();
                    }
                }));
            }
            catch (Exception)
            {
                textBoxHistory.Invoke(new MethodInvoker(delegate
                {
                    textBoxHistory.AppendText("Errrrrrr" + Environment.NewLine);
                }));
            }
        }

        //Auto recive com port 
        public string SearchCom()
        {
            string ComName = "";
            String Com_Scope = "root\\CIMV2";
            String Query_String = "SELECT * FROM Win32_PnPEntity WHERE ClassGuid=\"{4d36e978-e325-11ce-bfc1-08002be10318}\"";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(Com_Scope, Query_String);
            foreach (ManagementObject queryObj in searcher.Get())
            {
                if (queryObj["Caption"] != null)
                {
                    if (queryObj["Caption"].ToString().Contains("CH340") || queryObj["Caption"].ToString().Contains("Arduino"))
                    {
                        ComName = queryObj["Caption"].ToString();
                        ComName = ComName.Substring(ComName.LastIndexOf('(') + 1, ComName.LastIndexOf(')') - 1 - ComName.LastIndexOf('('));
                        break;
                    }
                }
            }
            return ComName;
        }

        private void timerCheckCom_Tick(object sender, EventArgs e)
        {
            if (PortSwitch.IsOpen)
            {
                tsslbCOM.ForeColor = Color.White;
                tsslbCOM.Text = PortSwitch.PortName + "                        ";
            }
            else
            {
                try
                {
                    tsslbCOM.ForeColor = Color.White;
                    PortSwitch.PortName = SearchCom();
                    tsslbCOM.Text = PortSwitch.PortName + "                        ";
                    PortSwitch.Open();
                }
                catch (Exception)
                {
                    tsslbCOM.ForeColor = Color.Red;
                    tsslbCOM.Text = "COM ERROR               ";
                }
            }
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void pnTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            PortMachine.DiscardInBuffer();
            PortMachine.Close();
            Environment.Exit(0);
            this.Close();
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                //this.MaximumSize = new System.Drawing.Size(Screen.PrimaryScreen.WorkingArea.Width + 20  , Screen.PrimaryScreen.WorkingArea.Height + 17);
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void DrawChart(int okNumber, int ngNumber, int charCicle)
        {
            int Total = okNumber + ngNumber;

            lbCounterNumberNG.Text = ngNumber.ToString();
            lbCounterNumberOK.Text = okNumber.ToString();
            lbCounterNumberTotal.Text = Total.ToString();
            float persentOk;
            if (Total > 0)
                persentOk = (float)okNumber / (float)Total * 100;
            else
                persentOk = 0;
            //lbCounterNumberDef.Text = persentOk.ToString("f1");

            if (Total == 0) Total = 10000000;
            float okRadian = (float)charCicle / Total * okNumber;
            float ngRadian = (float)charCicle - okRadian;

            int startRectY = pBChar.Size.Height / 2 - pBChar.Size.Width / 2;
            int startRectX = pBChar.Size.Width / 2 - pBChar.Size.Height / 2;
            int rectDimemtions = pBChar.Size.Width;

            if (startRectY < 0)
            {
                startRectY = 0;
                rectDimemtions = pBChar.Size.Height;
            }
            if (startRectX < 0)
            {
                startRectX = 0;
                rectDimemtions = pBChar.Size.Width;
            }

            if (pBChar.Size.Width > 50 && pBChar.Size.Height > 50)
            {
                Rectangle rect = new Rectangle(startRectX, startRectY, rectDimemtions, rectDimemtions);
                Rectangle rectInside = new Rectangle(startRectX + rectDimemtions / 4, startRectY + rectDimemtions / 4, rectDimemtions / 2, rectDimemtions / 2);
                Bitmap custormChart = new Bitmap(pBChar.Size.Width, pBChar.Size.Height);
                Graphics g = Graphics.FromImage(custormChart);

                Color okColor = Color.FromArgb(30, 136, 221);
                Color bacgroudColor = Color.FromArgb(62, 62, 62);
                SolidBrush brush = new SolidBrush(okColor);
                SolidBrush brushNumber = new SolidBrush(Color.White);
                SolidBrush brushInside = new SolidBrush(bacgroudColor);

                g.FillPie(brush, rect, 0, okRadian);
                g.FillPie(Brushes.Red, rect, okRadian, ngRadian);
                g.FillPie(brushInside, rectInside, 0, 360);

                string persenOkString = persentOk.ToString("F1") + " %";
                Font persentOkFont = new Font("Microsoft YaHei UI", rectDimemtions / 14, FontStyle.Bold);
                g.DrawString(persenOkString, persentOkFont, brushNumber, startRectX + rectDimemtions / 2 - (persenOkString.Length * 4 * rectDimemtions / 14 / 10), startRectY + rectDimemtions / 2 - rectDimemtions / 14);

                if (pBChar.Image != null)
                    pBChar.Image.Dispose();

                pBChar.Image = custormChart;
                brush.Dispose();
                brushInside.Dispose();
                brushNumber.Dispose();
                g.Dispose();
                //custormChart.Dispose();
            }
        }
        public int CharCircle = 0;
        private void timerUpdateChar_Tick(object sender, EventArgs e)
        {
            if (CharCircle <= 360)
            {
                DrawChart(NumberOK, NumberNG , CharCircle);
                CharCircle = CharCircle + (360 - CharCircle) / 50 + 1;
                timerUpdateChar.Start();
            }
            else
            {
                timerUpdateChar.Stop();
                //timerUpdateChar.Dispose();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timerUpdateChar.Start();
            timerGetValue.Start();
            PortMachine.Write(WT310.GETcontrol);
        }

        public void sellectRow(int index)
        {
            for (int i = 0; i < dgwStep.Rows.Count; i++)
            {
                dgwStep.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(60,60,60);
                dgwStep.Rows[i].DefaultCellStyle.ForeColor = Color.White;
            }
            dgwStep.Rows[index].DefaultCellStyle.BackColor = Color.Pink;
            dgwStep.Rows[index].DefaultCellStyle.ForeColor = Color.Black;
            dgwStep.Rows[index].Selected = true;
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            timerUpdateChar.Start();
            CharCircle = 0;
            dgwStep.Refresh();
        }
        public bool result = false;
        public bool startTest = true;
        public void RunTest()
        {
            while (startTest)
            {
                if (!_MODEL.testDone)
                {
                    for (int J = 0; J < dgwStep.Rows.Count; J++)
                    {
                        dgwStep.Rows[J].DefaultCellStyle.BackColor = Color.FromArgb(60, 60, 60);
                        dgwStep.Rows[J].DefaultCellStyle.ForeColor = Color.White;
                        dgwStep[4, J].Value = 0;
                    }
                    TESTTING_label(labelFinalResult);
                    int retry = 0;
                    bool testResult = false;
                    for (int i = 0; i < dgwStep.Rows.Count; i++)
                    {
                        //Thread.Sleep(250);
                        if (_MODEL.FCT_FUN_QUEUE[i] != null)
                        {
                            progressBar1.Invoke(new MethodInvoker(delegate { progressBar1.Value = 100 / (dgwStep.Rows.Count - 1) * i; }));
                            dgwStep.Invoke( new MethodInvoker( delegate {
                                dgwStep.CurrentCell = dgwStep[0, i-1];
                                for (int J = 0; J < dgwStep.Rows.Count; J++)
                                {
                                    dgwStep.Rows[J].DefaultCellStyle.BackColor = Color.FromArgb(40,40,40);
                                    dgwStep.Rows[J].DefaultCellStyle.ForeColor = Color.White;
                                }
                                dgwStep.Rows[i - 1].DefaultCellStyle.BackColor = Color.Pink;
                                dgwStep.Rows[i-  1].DefaultCellStyle.ForeColor = Color.Black;
                                dgwStep.Rows[i - 1].Selected = true;
                            }));
                            //sellectRow(i);
                            result = false;
                            while (!result)
                            {
                                result = _MODEL.FCT_FUN_QUEUE[i].RUN_CMD(dgwStep, WT310E, i-1);
                                if (retry < _MODEL.rEAPEAT)
                                    retry++;
                                else
                                    break;
                            }
                            if (result)
                            {
                                testResult = result;
                                TESTTING_label(labelFinalResult);
                            }
                            else
                            {
                                testResult = result;
                                NG_label(labelFinalResult);
                                break;
                            }
                        }
                    }
                    
                    dgwStep.Invoke(new MethodInvoker(delegate {
                        dgwStep.CurrentCell = dgwStep[0, 0];
                    }));
                    if (testResult)
                    {
                        OK_label(labelFinalResult);
                        NumberOK++;
                    }
                    else
                    {
                        NG_label(labelFinalResult);
                        NumberNG++;
                    }
                    while (WT310E.Ampe > 0.2)
                    { }
                    _MODEL.testDone = true;
                }
            }   
        }

        public void OK_label(Label label)
        {
            label.Invoke(new MethodInvoker(delegate { 
                label.Text = "OK";
                timerUpdateChar.Start();
                CharCircle = 0;
            }));
            label.BackColor = Color.FromArgb(27, 183, 234);
        }
        public void NG_label(Label label)
        {
            label.Invoke(new MethodInvoker(delegate {
                label.Text = "FAIL";
                timerUpdateChar.Start();
                CharCircle = 0;
            }));
            label.BackColor = Color.Red;
        }
        public void TESTTING_label(Label label)
        {
            label.Invoke(new MethodInvoker(delegate { label.Text = "TEST"; }));
            label.BackColor = Color.Yellow;
        }

        public void UpdateValue()
        {
            lbVol.Text = WT310E.Volt.ToString("f3");

            if (WT310E.Ampe < 0.001)
            {
                lbAmpe.Text = (WT310E.Ampe * 1000).ToString("f3");
                gbAmpe.Text = "Dòng điện (mA)";
            }
            else
            {
                lbAmpe.Text = WT310E.Ampe.ToString("f3");
                gbAmpe.Text = "Dòng điện (A)";
            }

            if (WT310E.Ampe < 0.001)
            {
                lbWat.Text = (WT310E.Wat * 1000).ToString("f3");
                gbWat.Text = "Công suất (mW)";
            }
            else
            {
                lbWat.Text = WT310E.Wat.ToString("f3");
                gbWat.Text = "Công suất (W)";
            }

            lbHz.Text = WT310E.Frequency.ToString("f3");


                if (_MODEL.testDone && WT310E.Ampe > 1)
                {
                    _MODEL.testDone = false;
                    for (int i = 0; i < dgwStep.Rows.Count; i++)
                    {
                        dgwStep.Rows[i].Selected = false;
                    }
                    startTest = true;
                }

        }

        private void timerGetValue_Tick(object sender, EventArgs e)
        {
            if (PortMachine.IsOpen)
            {
                PortMachine.Write(WT310.READvalue);
            }
        }

        private void timerExit_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _MODEL.Save(dgwStep);
        }

        private void readToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _MODEL.Open(dgwStep);
            for (int i = 0; i < _MODEL.FCT_FUN_QUEUE.Length; i++)
            {
                if (_MODEL.FCT_FUN_QUEUE[i] != null)
                {
                    if (_MODEL.FCT_FUN_QUEUE[i].CMD == FUNCTION.Model)
                    {
                        lbHeader.Text = _MODEL.FCT_FUN_QUEUE[i].NOTE;
                        break;
                    }
                }

            }
            sellectRow(0);
        }

        private void dgwStep_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            string titleText = dgwStep.Columns[1].HeaderText;
            if (titleText.Equals(""))
            {
                TextBox autoText = e.Control as TextBox;
                if (autoText != null)
                {
                    autoText.AutoCompleteMode = AutoCompleteMode.Suggest;
                    autoText.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
                    addItems(DataCollection);
                    autoText.AutoCompleteCustomSource = DataCollection;
                }
            }
        }

        public void addItems(AutoCompleteStringCollection col)
        {
            for (int i = 0; i < funtionList.Length; i++)
            {
                col.Add(funtionList[i]);
            }
        }

        private void timerDelay_Tick(object sender, EventArgs e)
        {
            timerDelay.Stop();
            result = true;
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            RunTest();
        }

        private void labelFinalResult_Click(object sender, EventArgs e)
        {
            _MODEL.testDone = false;
            for (int i = 0; i < dgwStep.Rows.Count; i++)
            {
                dgwStep.Rows[i].Selected = false;
            }
        }

        private void dgwStep_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _MODEL.Update(dgwStep);
            }
            catch (Exception) { }
        }

    }
    public class WT310
    {
        public const string GETcontrol = ":COMMunicate:REMote ON\r\n";
        public const string READvalue = ":NUMERIC:NORMAL:VALUE?\r\n";

        public string Port = "COM1";
        public const int Baudrate = 9600;
        public const int StartBit = 1;
        public const int DataBit = 8;
        public const Parity parity = Parity.None;
        public const StopBits stopBits = StopBits.One;

        public const string ENDline = "\r\n";

        public double Volt = 0;
        public double Ampe = 0;
        public double Wat = 0;
        public double Frequency = 0;
        public double Delay = 0;
        public int None = 0;
        public WT310() { }

        public bool GetFromString(string data)
        {
            string[] splitData = data.Split(',');
            if (splitData.Length >= 4)
            {
                if (splitData[0] != "NAN" && splitData[0] != "INF") this.Volt = Convert.ToDouble(splitData[0]); //(splitData[0].Substring(0, splitData[0].IndexOf('E'))) * Math.Pow(10, Convert.ToDouble(splitData[0].Substring(splitData[0].IndexOf('E') + 1)));
                else if (splitData[0] == "INF") this.Volt = 0;
                if (splitData[1] != "NAN" && splitData[1] != "INF") this.Ampe = Convert.ToDouble(splitData[1]); //.Substring(0, splitData[1].IndexOf('E'))) * Math.Pow(10, Convert.ToDouble(splitData[1].Substring(splitData[1].IndexOf('E') + 1)));
                else if (splitData[1] == "INF") this.Ampe = 0;
                if (splitData[2] != "NAN" && splitData[2] != "INF") this.Wat = Convert.ToDouble(splitData[2]); //.Substring(0, splitData[2].IndexOf('E'))) * Math.Pow(10, Convert.ToDouble(splitData[2].Substring(splitData[2].IndexOf('E') + 1)));
                else if (splitData[2] == "INF") this.Wat = 0;
                if (splitData[3] != "NAN" && splitData[3] != "INF") this.Frequency = Convert.ToDouble(splitData[3]); //.Substring(0, splitData[3].IndexOf('E'))) * Math.Pow(10, Convert.ToDouble(splitData[3].Substring(splitData[3].IndexOf('E') + 1)));
                else if (splitData[3] == "INF") this.Frequency = 0;

                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class FCT_TESTER_MODEL
    {
        public FUNCTION[] FCT_FUN_QUEUE = new FUNCTION[100];

        //public string path = @"C:\FCT\Model programs\";

        private OpenFileDialog OpenModel = new OpenFileDialog();
        private SaveFileDialog SaveModel = new SaveFileDialog();

        public bool testDone = false;
        public int rEAPEAT = 1;

        public FCT_TESTER_MODEL()
        {

        }

        public bool Open(DataGridView functionList)
        {
            OpenModel.DefaultExt = "fct";
            OpenModel.ShowDialog();

            string path = OpenModel.FileName;
            if (path != "")
            {
                functionList.Rows.Clear();
                string[] dataInLine;
                var lines = File.ReadAllLines(path);
                for (int i = 1; i < lines.Length; i++)
                {
                    if (lines[i] != "")
                    {
                        dataInLine = lines[i].Split('|');
                        functionList.Rows.Add(i, dataInLine[1], dataInLine[2], dataInLine[3], dataInLine[4], dataInLine[5]);
                        this.FCT_FUN_QUEUE[i] = new FUNCTION(dataInLine[1], Convert.ToDouble(dataInLine[2]), Convert.ToDouble(dataInLine[3]), dataInLine[5]);
                        string json = JsonConvert.SerializeObject(this.FCT_FUN_QUEUE[i], Formatting.Indented);
                        Console.WriteLine(json);
                    }
                }
                functionList.Refresh();
                return true;
            }
            else
                return false;

        }
        public bool Save(DataGridView functionList)
        {
            string path = "";
            string data = "" + Environment.NewLine;

            SaveModel.DefaultExt = "fct";
            SaveModel.ShowDialog();

            path = SaveModel.FileName;

            for (int i = 0; i < functionList.RowCount - 1; ++i)
            {
                for (int j = 0; j < functionList.ColumnCount; ++j)
                {
                    if (functionList.Rows[i].Cells[j].Value != null)
                    {
                        data += functionList.Rows[i].Cells[j].Value.ToString();
                    }
                    else
                        data += "0";
                    data += "|";
                }
                data += System.Environment.NewLine;
            }
            if (path != "")
            {
                File.WriteAllText(path, data);
                return true;
            }
            else
                return false;
        }

        public void Update(DataGridView functionList)
        {
            string path = @"C:\DaeyoungVN\FCT\";
            if (!Directory.Exists(path)) Directory.CreateDirectory(path);

            string data = "" + Environment.NewLine;
            for (int i = 0; i < functionList.RowCount - 1; ++i)
            {
                for (int j = 0; j < functionList.ColumnCount; ++j)
                {
                    if (functionList.Rows[i].Cells[j].Value != null)
                    {
                        data += functionList.Rows[i].Cells[j].Value.ToString();
                    }
                    else
                        data += "0";
                    data += "|";
                }
                data += System.Environment.NewLine;
            }
            File.WriteAllText(path + "temp.txt", data);
            functionList.Rows.Clear();
            string[] dataInLine;
            var lines = File.ReadAllLines(path + "temp.txt");
            for (int i = 1; i < lines.Length; i++)
            {
                if (lines[i] != "")
                {
                    dataInLine = lines[i].Split('|');
                    functionList.Rows.Add(dataInLine[0], dataInLine[1], dataInLine[2], dataInLine[3], dataInLine[4], dataInLine[5]);
                    this.FCT_FUN_QUEUE[i] = new FUNCTION(dataInLine[1], Convert.ToDouble(dataInLine[2]), Convert.ToDouble(dataInLine[3]), dataInLine[5]);
                }
            }
            functionList.Refresh();
        }
    }

    public class FUNCTION
    {
        public const string Model = "MODEL";
        public const string Delay = "TIMER";
        public const string Volt = "V";
        public const string Ampe = "A";
        public const string Wat = "W";
        public const string NOP = "NOP";
        public const string FREQUENCY = "HZ";
        public const string OFF_POWER_SOUCER = "TURN OFF";
        public const string FINISH = "FINISH";
        public const string SAVE = "SAVE";
        public const string REPEAT = "REPEAT";


        public string CMD = "";
        public double MIN = 0;
        public double MAX = 0;
        public double READ = 0;
        public string NOTE = "";

        public int rEAPEAT = 1;

        public FUNCTION(string command, double min, double max, string note)
        {
            this.CMD = command;
            this.MAX = max;
            this.MIN = min;
            this.NOTE = note;
        }

        public bool RUN_CMD(DataGridView functionList, WT310 value, int Row)
        {
            bool result = false;
            switch (this.CMD)
            {
                case Model:
                    {
                        functionList.Rows[Row].Cells[4].Value = this.MAX.ToString();
                        Thread.Sleep(100);
                        result = true;
                        break;
                    }
                case SAVE:
                    {
                        Thread.Sleep(100);
                        functionList.Rows[Row].Cells[4].Value = this.MIN.ToString();
                        result = true;
                        break;
                    }
                case Delay:
                    {
                        functionList.Rows[Row].Cells[4].Value = this.MAX.ToString();
                        Thread.Sleep(Convert.ToInt32(this.MAX));
                        result = true;
                        break;
                    }
                case REPEAT:
                    {
                        Thread.Sleep(100);
                        this.rEAPEAT = Convert.ToInt32(this.MAX);
                        result = true;
                        break;
                    }
                case Volt:
                    {
                        Thread.Sleep(100);
                        functionList.Rows[Row].Cells[4].Value = value.Volt.ToString();
                        if (value.Volt >= this.MIN && value.Volt <= this.MAX)
                            result = true;
                        else
                            result = false;
                        break;
                    }
                case Ampe:
                    {
                        Thread.Sleep(100);
                        functionList.Rows[Row].Cells[4].Value = value.Ampe.ToString();
                        if (value.Ampe >= this.MIN && value.Ampe <= this.MAX)
                            result = true;
                        else
                            result = false;
                        break;
                    }
                case FREQUENCY:
                    {
                        Thread.Sleep(100);
                        functionList.Rows[Row].Cells[4].Value = value.Frequency.ToString();
                        if (value.Frequency >= this.MIN && value.Frequency <= this.MAX)
                            result = true;
                        else
                            result = false;
                        break;
                    }
                case Wat:
                    {
                        Thread.Sleep(100);
                        functionList.Rows[Row].Cells[4].Value = value.Wat.ToString();
                        if (value.Wat >= this.MIN && value.Wat <= this.MAX)
                            result = true;
                        else
                            result = false;
                        break;
                    }
                case OFF_POWER_SOUCER:
                    {
                        Thread.Sleep(100);
                        functionList.Rows[Row].Cells[4].Value = this.MAX.ToString();
                        result = true;
                        break;
                    }
                case NOP:
                    {
                        Thread.Sleep(100);
                        result = true;
                        break;
                    }
                case FINISH:
                    {
                        Thread.Sleep(100);
                        functionList.Rows[Row].Cells[4].Value = this.MAX.ToString();
                        result = true;
                        break;
                    }
            }
            return result;
        }
    }


}
