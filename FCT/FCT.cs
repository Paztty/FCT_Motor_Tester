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
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
using Label = System.Windows.Forms.Label;

namespace FCT
{
    public partial class FCT : Form
    {

        public const string Version = "1.3.0";

        #region Variable
        public WT310 WT310E = new WT310();

        public FCT_TESTER_MODEL _MODEL = new FCT_TESTER_MODEL();

        public string[] funtionList = {
                            FUNCTION.Model,
                            FUNCTION.Delay,
                            FUNCTION.Volt,
                            FUNCTION.Ampe,
                            FUNCTION.Watt,
                            FUNCTION.WattMax,
                            FUNCTION.WattMin,
                            FUNCTION.NOP,
                            FUNCTION.FREQUENCY,
                            FUNCTION.OFF_POWER_SOUCER,
                            FUNCTION.FINISH,
                            FUNCTION.SAVE,
                            FUNCTION.REPEAT,
                            FUNCTION.TIMEOUT
        };

        public static SerialPort PowerSwitchPort;

        public int NumberOK = 0, NumberNG = 0, NumberTotal;

        public bool ProgramChange = false;

        public bool startDrawGraph = false;

        DateTime startDraw = DateTime.Now;

        Random rand = new Random();

        public int CharCircle = 0;

        public bool result = false;

        bool startTest = true;

        // list color for data grid view columns color.
        List<Color> colors = new List<Color>() {
        Color.White,
        Color.FromArgb(153, 187, 255),
        Color.FromArgb(153, 255, 187),
        Color.FromArgb(153, 255, 187),
        Color.FromArgb(255, 221, 187),
        Color.White,
        };
        #endregion

        public FCT()
        {
            InitializeComponent();
            tsslbVersion.Text = "FCT Tester " + Version + "            ";
            string path = @"C:\DaeyoungVN\FCT\";
            if (!Directory.Exists(path)) Directory.CreateDirectory(path);

            PortMachine.PortName = WT310E.Port;
            PortMachine.BaudRate = WT310.Baudrate;
            PortMachine.DataBits = WT310.DataBit;
            PortMachine.Parity = WT310.parity;
            PortMachine.StopBits = WT310.stopBits;


            PortMachine.DataReceived += new SerialDataReceivedEventHandler(DataReciver);
            PortMachine.Open();

            PortSwitch.DataReceived += PortSwitch_DataReceived;
            PowerSwitchPort = PortSwitch;
            timerCheckCom.Start();
            timerDrawGrap.Start();

            if (File.Exists(path + "time.cfg"))
            {
                string[] dataConfig = File.ReadAllLines(path + "time.cfg");
                try
                {
                    int timeResetLabel = Convert.ToInt32(dataConfig[0]);
                    timerClearResultLabel.Interval = timeResetLabel;
                }
                catch (Exception)
                {

                }
            }
            else
            {
                string[] data = new string[] { timerClearResultLabel.Interval.ToString() };
                File.WriteAllLines(path + "time.cfg", data);
            }

            clFunc.DataSource = funtionList;

            for (int J = 0; J < dgwStep.Rows.Count - 1; J++)
            {
                for (int columnCount = 0; columnCount < dgwStep.Columns.Count; columnCount++)
                {
                    dgwStep[columnCount, J].Style.BackColor = colors[columnCount];
                }
                dgwStep.Rows[J].DefaultCellStyle.ForeColor = Color.Black;
                dgwStep[4, J].Value = 0;
            }


            zGCpowerView.AxisChange();
            zGCpowerView.Invalidate();

            GraphPane myPane = zGCpowerView.GraphPane;
            myPane.Title.Text = "";
            myPane.XAxis.Title.Text = "Time (ms)";
            myPane.YAxis.Title.Text = "W";

            myPane.Fill = new Fill(Color.FromArgb(200, 200, 200));
            myPane.Chart.Fill = new Fill(Color.Black, Color.Black);
            myPane.XAxis.MajorGrid.Color = Color.FromArgb(90, 90, 90);
            myPane.YAxis.MajorGrid.Color = Color.FromArgb(90, 90, 90);

            RollingPointPairList list = new RollingPointPairList(60000);
            LineItem curve = myPane.AddCurve("W", list, Color.Lime, SymbolType.None);

            myPane.XAxis.Scale.Min = 0;
            myPane.XAxis.Scale.Max = 9000;
            myPane.XAxis.Scale.MinorStep = 10;
            myPane.XAxis.Scale.MajorStep = 500;
            myPane.YAxis.Scale.Min = 0;
            myPane.YAxis.Scale.Max = 100;

            zGCpowerView.AxisChange();
        }

        #region Form control  
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
            string message = "Do you want to close this window?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                timerGetValue.Dispose();
                startTest = false;
                if (PortMachine.IsOpen)
                {
                    PortMachine.DiscardInBuffer();
                    PortMachine.Close();
                }

                if (PortSwitch.IsOpen)
                {
                    PortSwitch.Close();
                }
                this.Close();
            }
            else
            {
                // Do something  
            }
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.MaximumSize = new System.Drawing.Size(Screen.PrimaryScreen.WorkingArea.Width + 20, Screen.PrimaryScreen.WorkingArea.Height + 17);
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximumSize = new System.Drawing.Size(Screen.PrimaryScreen.WorkingArea.Width + 20, Screen.PrimaryScreen.WorkingArea.Height + 17);
            StartForm startForm = new StartForm();
            startForm.ShowDialog();

            timerUpdateChar.Start();
            timerGetValue.Start();
            PortMachine.Write(WT310.GETcontrol);

            Thread thread = new Thread(update_date_time);
            thread.IsBackground = true;
            thread.Start();

        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            timerUpdateChar.Start();
            CharCircle = 0;
            dgwStep.Refresh();
        }


        #endregion

        public bool login()
        {
            LoginForm login = new LoginForm();
            login.ShowDialog();
            if (login.DialogResult == DialogResult.OK)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #region Pie Chart drawing
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
                Color ngColor = Color.FromArgb(170, 0, 0);
                Color bacgroudColor = Color.FromArgb(60, 60, 60);
                SolidBrush brush = new SolidBrush(okColor);
                SolidBrush brushNG = new SolidBrush(ngColor);
                SolidBrush brushNumber = new SolidBrush(Color.White);
                SolidBrush brushInside = new SolidBrush(bacgroudColor);

                g.FillPie(brush, rect, 0, okRadian);
                g.FillPie(brushNG, rect, okRadian, ngRadian);
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

        private void timerUpdateChar_Tick(object sender, EventArgs e)
        {
            if (CharCircle <= 360)
            {
                DrawChart(NumberOK, NumberNG, CharCircle);
                CharCircle = CharCircle + (360 - CharCircle) / 50 + 1;
                timerUpdateChar.Start();
            }
            else
            {
                timerUpdateChar.Stop();
                //timerUpdateChar.Dispose();
            }
        }

        #endregion

        #region Serial data, machine value
        private void PortSwitch_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (!PortSwitch.IsOpen) return;
            string Frame = "";
            try
            {
                Frame = PortSwitch.ReadLine();
                if (Frame.Contains('@'))
                {
                    if (_MODEL.testDone)
                        POWER_ON_label(labelFinalResult);
                }
            }
            catch (Exception)
            {
                textBoxHistory.Invoke(new MethodInvoker(delegate
                {
                    textBoxHistory.AppendText("Power switch communication fail..." + Environment.NewLine);
                }));
            }
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
                    if (WT310E.GetFromString(Frame))
                    {
                        UpdateValue();
                    }
                }));
            }
            catch (Exception)
            {
                textBoxHistory.Invoke(new MethodInvoker(delegate
                {
                    textBoxHistory.AppendText("WT310 comunication fail..." + Environment.NewLine);
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
                    //PortSwitch.PortName = SearchCom();
                    tsslbCOM.Text = PortSwitch.PortName + "                        ";
                    PortSwitch.BaudRate = 115200;
                    PortSwitch.Open();
                }
                catch (Exception)
                {
                    tsslbCOM.ForeColor = Color.Red;
                    tsslbCOM.Text = "COM ERROR               ";
                }
            }
        }

        public void update_date_time()
        {
            lbTime.Invoke(new MethodInvoker(delegate
            {
                lbTime.Text = DateTime.Now.ToString("hh:mm t") + 'M';
            }));
        }
        #endregion

        #region Label change
        public void OK_label(Label label)
        {
            label.Invoke(new MethodInvoker(delegate
            {
                label.Text = "OK";
                timerUpdateChar.Start();
                CharCircle = 0;
            }));
            label.BackColor = Color.FromArgb(4, 117, 24);
            label.ForeColor = Color.White;
        }
        public void NG_label(Label label, string Item)
        {
            label.Invoke(new MethodInvoker(delegate
            {
                label.Text = "FAIL - " + Item;
                timerUpdateChar.Start();
                CharCircle = 0;
            }));
            label.BackColor = Color.FromArgb(170, 0, 0);
            label.ForeColor = Color.Black;
        }
        public void TESTTING_label(Label label)
        {
            label.Invoke(new MethodInvoker(delegate { label.Text = "TEST"; }));
            label.BackColor = Color.FromArgb(198, 198, 85);
            label.ForeColor = Color.Black;
        }
        public void READY_label(Label label)
        {
            label.Invoke(new MethodInvoker(delegate { label.Text = "READY"; }));
            label.BackColor = Color.FromArgb(0, 81, 136);
            label.ForeColor = Color.White;
        }
        public void POWER_ON_label(Label label)
        {
            label.Invoke(new MethodInvoker(delegate { label.Text = "POWER ON"; }));
            label.BackColor = Color.FromArgb(68, 0, 170);
            label.ForeColor = Color.White;
        }
        #endregion

        #region Main testing func
        public void UpdateValue()
        {
            lbVol.Text = WT310E.Volt.ToString("f3");

            if (WT310E.Ampe < 0.001)
            {
                lbAmpe.Text = (WT310E.Ampe * 1000).ToString("f1");
                gbAmpe.Text = "Ampe (mA)";
            }
            else
            {
                lbAmpe.Text = WT310E.Ampe.ToString("f1");
                gbAmpe.Text = "Ampe (A)";
            }

            if (WT310E.Ampe < 0.001)
            {
                lbWat.Text = (WT310E.Wat * 1000).ToString("f1");
                gbWat.Text = "Watt (mW)";
            }
            else
            {
                lbWat.Text = WT310E.Wat.ToString("f1");
                gbWat.Text = "Watt (W)";
            }

            lbHz.Text = WT310E.Frequency.ToString("f1");
            if (startDrawGraph)
            {
                double realtime = DateTime.Now.Subtract(startDraw).TotalMilliseconds;
                Draw(realtime, WT310E.Wat);
            }

            if (_MODEL.testDone && labelFinalResult.Text != "TEST")
            {
                if (WT310E.Ampe > 2)
                {
                    _MODEL.testDone = false;
                    backgroundWorker.RunWorkerAsync();
                }
                WT310E.WattMax = 0;
                for (int i = 0; i < dgwStep.Rows.Count; i++)
                {
                    dgwStep.Rows[i].Selected = false;
                }
            }
        }

        private void timerGetValue_Tick(object sender, EventArgs e)
        {
            if (PortMachine.IsOpen)
            {
                PortMachine.Write(WT310.READvalue);
            }
        }


        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            RunTest();
        }

        public void RunTest()
        {
                if (!_MODEL.testDone)
                {
                    zGCpowerView.Invoke(new MethodInvoker(delegate
                    {
                        ClearZedGraph();
                        startDraw = DateTime.Now;
                        startDrawGraph = true;
                    }));
                    for (int J = 0; J < dgwStep.Rows.Count - 1; J++)
                    {
                        for (int columnCount = 0; columnCount < dgwStep.Columns.Count; columnCount++)
                        {
                            dgwStep[columnCount, J].Style.BackColor = colors[columnCount];
                            dgwStep[columnCount, J].Style.ForeColor = Color.Black;
                            dgwStep[columnCount, J].Style.SelectionBackColor = Color.FromArgb(118, 58, 118);
                            dgwStep[columnCount, J].Style.SelectionForeColor = Color.White;
                        }
                        dgwStep[4, J].Value = 0;
                    }
                    TESTTING_label(labelFinalResult);
                    int retry = 0;
                    bool testResult = false;
                    progressBar.Invoke(new MethodInvoker(delegate { progressBar.Maximum = dgwStep.RowCount - 2; }));
                    for (int i = 0; i < dgwStep.Rows.Count - 1; i++)
                    {
                        if (_MODEL.FCT_FUN_QUEUE[i] != null)
                        {
                            progressBar.Invoke(new MethodInvoker(delegate
                            {
                                progressBar.Value = i;
                                dgwStep.Rows[i].Selected = true;
                            }));
                            result = false;
                            while (!result)
                            {
                                result = _MODEL.FCT_FUN_QUEUE[i].RUN_CMD(dgwStep, WT310E, i);
                                if (PortSwitch.IsOpen && _MODEL.FCT_FUN_QUEUE[i].CMD == FUNCTION.OFF_POWER_SOUCER)
                                {
                                    PortSwitch.Write("@");
                                }
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
                                NG_label(labelFinalResult, _MODEL.FCT_FUN_QUEUE[i].CMD);
                                break;
                            }
                        }
                    }
                    if (testResult)
                    {
                        OK_label(labelFinalResult);
                        NumberOK++;
                    }
                    else
                    {
                        NumberNG++;
                    }
                    NumberTotal = NumberOK + NumberNG;

                    startDrawGraph = false;
                    while (WT310E.Ampe > 0.2)
                    { }

                    writeReport(dgwStep, testResult);
                    _MODEL.testDone = true;
                    dgwStep.Invoke(new MethodInvoker(delegate
                    {
                        timerClearResultLabel.Start();
                        dgwStep.CurrentCell = dgwStep[0, 0];
                        textBoxHistory.AppendText(DateTime.Now.ToString("yyyy/MM/dd") + "   " + DateTime.Now.ToString("hh:mm:ss") + "   " + tbModelName.Text + "   " + labelFinalResult.Text + Environment.NewLine);
                    }));
                }
                else
                {
                    Thread.Sleep(100);
                }
        }
        public void writeReport(DataGridView data, bool testResult)
        {
            string fileReportName = @"C:\DaeyoungVN\FCT\History\";
            DateTime dateNew = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 7, 30, 0);
            var moment = DateTime.Now;

            string today;
            int resultDay = DateTime.Compare(dateNew, moment);
            Console.WriteLine(dateNew);
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(resultDay);
            if (resultDay > 0)
            {
                moment = moment.AddDays(-1);
            }
            today = moment.ToString("yyyy") + "\\" + moment.ToString("MMMM") + "\\" + moment.ToString("dd") + "\\";
            fileReportName += today;


            if (!Directory.Exists(fileReportName))
            {
                Directory.CreateDirectory(fileReportName);
            }

            if (ProgramChange && File.Exists(fileReportName + tbModelName.Text + ".txt"))
            {
                File.Move(fileReportName + tbModelName.Text + ".txt", fileReportName + tbModelName.Text + DateTime.Now.ToString("_hh-mm-ss") + ".txt");
                ProgramChange = false;
            }

            String resultString = "FAIL";
            if (result)
            {
                resultString = "PASS";
            }

            if (!File.Exists(fileReportName + tbModelName.Text + ".txt"))
            {
                string contents = "SN/Model/Result/Date/Time/";
                for (int i = 0; i < data.RowCount - 1; i++)
                {
                    if (data[1, i].Value.ToString() != FUNCTION.Model)
                        contents += data[1, i].Value.ToString() + "/";
                }
                contents += Environment.NewLine;

                contents += NumberTotal + "/" + tbModelName.Text + "/" + resultString + "/" + DateTime.Now.ToString("yyyy MM dd") + "/" + DateTime.Now.ToString("hh mm ss") + "/";

                for (int i = 0; i < data.RowCount - 1; i++)
                {
                    if (data[1, i].Value.ToString() != FUNCTION.Model)
                        contents += data[4, i].Value.ToString() + "/";
                }
                contents += Environment.NewLine;
                File.AppendAllText(fileReportName + tbModelName.Text + ".txt", contents);
            }
            else
            {
                string contents = NumberTotal + "/" + tbModelName.Text + "/" + resultString + "/" + DateTime.Now.ToString("yyyy MM dd") + "/" + DateTime.Now.ToString("hh mm ss") + "/";
                for (int i = 0; i < data.RowCount - 1; i++)
                {
                    if (data[1, i].Value.ToString() != FUNCTION.Model)
                        contents += data[4, i].Value.ToString() + "/";
                }
                contents += Environment.NewLine;
                File.AppendAllText(fileReportName + tbModelName.Text + ".txt", contents);
            }
        }
        #endregion

        #region toolStrip Menu
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (login())
            {
                tbModelName.ReadOnly = true;
                tbMotor.ReadOnly = true;
                dgwStep.ReadOnly = true;
                if (tbMotor.TextLength > 2)
                {
                    _MODEL.Save(dgwStep, tbModelName.Text, tbMotor.Text);
                }
                else
                {
                    MessageBox.Show("Please enter motor name!");
                }
            }
        }

        private void readToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbModelName.ReadOnly = true;
            tbMotor.ReadOnly = true;
            dgwStep.ReadOnly = true;
            _MODEL.Open(dgwStep);
            tbModelName.Text = _MODEL.ModelName;
            tbMotor.Text = _MODEL.ModelMotor;

            dgwStep.Columns[0].HeaderCell.Style.BackColor = Color.FromArgb(255, 179, 128);
            dgwStep.Columns[1].HeaderCell.Style.BackColor = Color.FromArgb(102, 153, 255);
            dgwStep.Columns[2].HeaderCell.Style.BackColor = Color.FromArgb(102, 255, 153);
            dgwStep.Columns[3].HeaderCell.Style.BackColor = Color.FromArgb(204, 153, 255);
            dgwStep.Columns[4].HeaderCell.Style.BackColor = Color.FromArgb(255, 204, 153);
            dgwStep.Columns[5].HeaderCell.Style.BackColor = Color.FromArgb(102, 255, 255);


            for (int J = 0; J < dgwStep.Rows.Count - 1; J++)
            {
                for (int columnCount = 0; columnCount < dgwStep.Columns.Count; columnCount++)
                {
                    dgwStep[columnCount, J].Style.BackColor = colors[columnCount];
                }
                dgwStep.Rows[J].DefaultCellStyle.ForeColor = Color.Black;
                dgwStep[4, J].Value = 0;
            }
        }
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Do you want to close this window?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                startTest = false;
                PortMachine.DiscardInBuffer();
                PortMachine.Close();
                Environment.Exit(0);
                this.Close();
                Application.Exit();
            }
            else
            {
                // Do something  
            }
        }
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NumberNG = 0;
            NumberOK = 0;
            NumberTotal = 0;
            lbCounterNumberTotal.Text = NumberTotal.ToString();
            lbCounterNumberOK.Text = NumberOK.ToString();
            lbCounterNumberNG.Text = NumberNG.ToString();
            CharCircle = 0;
            timerUpdateChar.Start();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (login())
            {
                tbModelName.ReadOnly = false;
                tbMotor.ReadOnly = false;
                dgwStep.ReadOnly = false;
            }
        }
        private void tsccbMeterPort_Click(object sender, EventArgs e)
        {
            string[] portList = SerialPort.GetPortNames();
            tsccbMeterPort.Items.Clear();
            for (int i = 0; i < portList.Length; i++)
            {
                tsccbMeterPort.Items.Add(portList[i]);
            }

        }
        private void tsccbMeterPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PortMachine.IsOpen)
            {
                PortMachine.Close();
            }
            PortMachine.PortName = tsccbMeterPort.SelectedItem.ToString();
            WT310PortName.Text = PortMachine.PortName;
            if (PortSwitch.PortName != PortMachine.PortName)
            {
                PortMachine.Open();
            }
            else
            {
                MessageBox.Show("Port ready user by power switch jig.");
            }

        }
        private void toolStripComboBox2_Click(object sender, EventArgs e)
        {
            string[] portList = SerialPort.GetPortNames();
            toolStripComboBox2.Items.Clear();
            for (int i = 0; i < portList.Length; i++)
            {
                toolStripComboBox2.Items.Add(portList[i]);
            }
        }

        private void toolStripComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            timerCheckCom.Stop();
            if (PortSwitch.IsOpen)
            {
                PortSwitch.Close();
            }
            PortSwitch.PortName = toolStripComboBox2.SelectedItem.ToString();
            tsslbCOM.Text = PortSwitch.PortName;
            if (PortSwitch.PortName != PortMachine.PortName)
            {
                PortSwitch.Open();
            }
            else
            {
                MessageBox.Show("Port ready user by WT310");
            }
            timerCheckCom.Start();
        }
        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.ShowDialog();
        }
        #endregion

        #region Datagridview edit
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
        private void dgwStep_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _MODEL.testDone = true;
                for (int i = 0; i < dgwStep.RowCount - 1; i++)
                {
                    if (_MODEL.FCT_FUN_QUEUE[i] != null)
                    {
                        Console.WriteLine(_MODEL.FCT_FUN_QUEUE[i].CMD);
                        if (dgwStep[1, i].Value.ToString() != _MODEL.FCT_FUN_QUEUE[i].CMD)
                        {
                            ProgramChange = true;
                            break;
                        }
                    }

                }
                _MODEL.Update(dgwStep);
            }
            catch (Exception) { }
        }
        private void dgwStep_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (Form.ModifierKeys == Keys.Control)
            {
                if (e.ColumnIndex == 0 && e.RowIndex < dgwStep.RowCount - 1)
                {
                    try
                    {
                        this.dgwStep.Rows.Insert(e.RowIndex + 1, dgwStep);
                        dgwStep[1, e.RowIndex + 1].Value = dgwStep[1, e.RowIndex].Value;
                        if (dgwStep[2, e.RowIndex].Value != null)
                            dgwStep[2, e.RowIndex + 1].Value = dgwStep[2, e.RowIndex].Value;
                        else
                            dgwStep[2, e.RowIndex + 1].Value = 0;
                        dgwStep[3, e.RowIndex + 1].Value = dgwStep[3, e.RowIndex].Value;
                        dgwStep[4, e.RowIndex + 1].Value = dgwStep[4, e.RowIndex].Value;
                        dgwStep[5, e.RowIndex + 1].Value = dgwStep[5, e.RowIndex].Value;

                        for (int i = 0; i < dgwStep.RowCount; i++)
                        {
                            dgwStep[0, i].Value = i + 1;
                        }
                    }
                    catch { }
                }
                else
                {
                    dgwStep.Rows.AddCopies(dgwStep.RowCount - 1, 1);
                    dgwStep[1, e.RowIndex + 1].Value = dgwStep[1, e.RowIndex].Value;
                    dgwStep[2, e.RowIndex + 1].Value = dgwStep[2, e.RowIndex].Value;
                    dgwStep[3, e.RowIndex + 1].Value = dgwStep[3, e.RowIndex].Value;
                    dgwStep[4, e.RowIndex + 1].Value = dgwStep[4, e.RowIndex].Value;
                    dgwStep[5, e.RowIndex + 1].Value = dgwStep[5, e.RowIndex].Value;
                    for (int i = 0; i < dgwStep.RowCount; i++)
                    {
                        dgwStep[0, i].Value = i + 1;
                    }
                }

            }
        }
        private void dgwStep_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
        #endregion

        #region Label result action
        private void labelFinalResult_Click(object sender, EventArgs e)
        {
                _MODEL.testDone = false;
                backgroundWorker.RunWorkerAsync();
            for (int i = 0; i < dgwStep.Rows.Count; i++)
            {
                dgwStep.Rows[i].Selected = false;
            }
        }

        private void timerDelay_Tick(object sender, EventArgs e)
        {
            if (_MODEL.testDone)
                READY_label(labelFinalResult);
        }
        #endregion

        #region Graph draw
        public void threadDraw()
        {
            while (true)
            {
                if (startDrawGraph)
                {
                    zGCpowerView.Invoke(new MethodInvoker(delegate
                    {
                        double realtime = DateTime.Now.Subtract(startDraw).TotalMilliseconds;
                        if (Datas.Count >= 1)
                            Draw(realtime, Datas[0]);
                        if (Datas.Count >= 2)
                            Datas.RemoveAt(0);
                    }));
                }
            }
        }

        private void Draw(double realtime, double datas)
        {

            if (zGCpowerView.GraphPane.CurveList.Count <= 0)
                return;

            LineItem curve = zGCpowerView.GraphPane.CurveList[0] as LineItem;
            curve.Line.Width = 2F;
            if (curve == null)
                return;

            IPointListEdit list = curve.Points as IPointListEdit;

            if (list == null)
                return;
            list.Add(realtime, datas); // Thêm điểm trên đồ thị

            Scale xScale = zGCpowerView.GraphPane.XAxis.Scale;
            Scale yScale = zGCpowerView.GraphPane.YAxis.Scale;

            // Tự động Scale theo trục x
            if (realtime > xScale.Max - xScale.MajorStep)
            {
                xScale.Max = realtime + xScale.MajorStep;
                xScale.Min = xScale.Max - 9000;
            }

            // Tự động Scale theo trục y
            if (datas > yScale.Max - yScale.MajorStep)
            {
                yScale.Max = datas + yScale.MajorStep;
            }
            else if (datas < yScale.Min + yScale.MajorStep)
            {
                yScale.Min = datas - yScale.MajorStep;
            }

            zGCpowerView.AxisChange();
            zGCpowerView.Invalidate();
            zGCpowerView.Refresh();
            //RealTime.Add(realtime);
            //Datas.Add(datas);
            //try
            //{
            //    GraphPane Zd_Pen1 = zGCpowerView.GraphPane;
            //    // Add Line to Graph
            //    var pList = new PointPairList(RealTime.ToArray(), Datas.ToArray());
            //    LineItem myCurve = Zd_Pen1.AddCurve("", pList, Color.LimeGreen, SymbolType.None);
            //    myCurve.Line.Width = 1F;
            //}
            //catch (Exception ex)
            //{
            //    //Pub.log[(int)IDX_Log.Insp].AddE("DrawBEMFGraph: " + ex.ToString());
            //}
            //zGCpowerView.AxisChange();
            //zGCpowerView.Invalidate();
            //zGCpowerView.Refresh();
        }
        List<double> RealTime = new List<double>();

        private void timerClearResultLabel_Tick(object sender, EventArgs e)
        {
            timerClearResultLabel.Stop();
            if (labelFinalResult.Text != "TEST")
            {
                READY_label(labelFinalResult);
            }
        }

        private void tsTimerResetLabel_KeyPress(object sender, KeyEventArgs e)
        {
            LoginForm login = new LoginForm();

            if (e.KeyCode == Keys.Enter)
            {
                if (login.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        timerClearResultLabel.Interval = Convert.ToInt32(tsTimerResetLabel.Text);
                        string[] data = new string[] { timerClearResultLabel.Interval.ToString() };
                        File.WriteAllLines(@"C:\DaeyoungVN\FCT\" + "time.cfg", data);
                    }
                    catch (Exception)
                    { }
                }
            }

        }

        private void FCT_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        List<double> Datas = new List<double>();
        // Xóa đồ thị, với ZedGraph thì phải khai báo lại như ở hàm Form1_Load, nếu không sẽ không hiển thị
        private void ClearZedGraph()
        {
            RealTime.Clear();
            Datas.Clear();

            zGCpowerView.GraphPane.CurveList.Clear(); // Xóa đường
            zGCpowerView.GraphPane.GraphObjList.Clear(); // Xóa đối tượng

            zGCpowerView.AxisChange();
            zGCpowerView.Invalidate();

            GraphPane myPane = zGCpowerView.GraphPane;
            myPane.Title.Text = "";
            myPane.XAxis.Title.Text = "Time (ms)";
            myPane.YAxis.Title.Text = "W";

            myPane.Fill = new Fill(Color.FromArgb(200, 200, 200));
            myPane.Chart.Fill = new Fill(Color.Black, Color.Black);
            myPane.XAxis.MajorGrid.Color = Color.FromArgb(90, 90, 90);
            myPane.YAxis.MajorGrid.Color = Color.FromArgb(90, 90, 90);

            RollingPointPairList list = new RollingPointPairList(60000);
            LineItem curve = myPane.AddCurve("W", list, Color.Lime, SymbolType.None);

            myPane.XAxis.Scale.Min = 0;
            myPane.XAxis.Scale.Max = 9000;
            myPane.XAxis.Scale.MinorStep = 10;
            myPane.XAxis.Scale.MajorStep = 500;
            myPane.YAxis.Scale.Min = -100;
            myPane.YAxis.Scale.Max = 100;

            zGCpowerView.AxisChange();
        }
        #endregion


    }
    public class WT310
    {
        public const string GETcontrol = ":COMMunicate:REMote ON\r\n";
        public const string SETRate100ms = ":RATE 100MS\r\n";
        public const string READvalue = ":NUMERIC:NORMAL:VALUE?\r\n";

        public string Port = "COM1";
        public const int Baudrate = 9600;
        public const int StartBit = 1;
        public const int DataBit = 8;
        public const Parity parity = Parity.None;
        public const StopBits stopBits = StopBits.One;

        public const string ENDline = "\r\n";

        public double Volt { get; set; } = 0;
        public double Ampe { get; set; } = 0;
        public double Wat { get; set; } = 0;
        public double WattMax { get; set; } = 0;
        public double WattMin { get; set; } = 0;
        public double Frequency { get; set; } = 0;
        public double Delay { get; set; } = 0;
        public int None { get; set; } = 0;
        public bool endCycle = false;
        public int timeOut = 4000;
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

                if (this.Wat > this.WattMax) this.WattMax = this.Wat;

                if (this.Wat < this.WattMin) this.WattMin = this.Wat;

                if (this.Wat - this.WattMin >= 100)
                {
                    endCycle = true;
                }
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
        public string ModelName = "";
        public string ModelMotor = "";
        public FUNCTION[] FCT_FUN_QUEUE = new FUNCTION[100];

        //public string path = @"C:\FCT\Model programs\";

        private OpenFileDialog OpenModel = new OpenFileDialog();
        private SaveFileDialog SaveModel = new SaveFileDialog();

        public bool testDone = true;
        public int rEAPEAT = 1;

        public FCT_TESTER_MODEL()
        {

        }

        public void Open(DataGridView functionList)
        {
            OpenModel.DefaultExt = "*.fct";
            OpenModel.ShowDialog();
            string path = OpenModel.FileName;
            if (path != "" && Path.GetExtension(path) == ".fct")
            {
                functionList.Rows.Clear();
                string[] dataInLine;
                var lines = File.ReadAllLines(path);
                ModelName = lines[0];
                ModelMotor = lines[1];
                for (int i = 2; i < lines.Length; i++)
                {
                    if (lines[i] != "")
                    {
                        dataInLine = lines[i].Split('|');
                        functionList.Rows.Add(i - 1, dataInLine[1], dataInLine[2], dataInLine[3], dataInLine[4], dataInLine[5]);
                    }
                }
                functionList.Refresh();
                for (int i = 0; i < functionList.RowCount - 1; i++)
                {
                    this.FCT_FUN_QUEUE[i] = new FUNCTION(functionList[1, i].Value.ToString(), Convert.ToDouble(functionList[2, i].Value.ToString()), Convert.ToDouble(functionList[3, i].Value.ToString()), functionList[5, i].Value.ToString());
                    string json = JsonConvert.SerializeObject(this.FCT_FUN_QUEUE[i], Formatting.Indented);
                    Console.WriteLine(json);
                }
                this.testDone = true;
            }
        }
        public bool Save(DataGridView functionList, string modelName, string motorName)
        {
            string data = modelName + Environment.NewLine;
            data += motorName + Environment.NewLine;

            SaveModel.DefaultExt = "fct";
            SaveModel.ShowDialog();

            string path = SaveModel.FileName;

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

            string data = ModelName + Environment.NewLine;
            data += ModelMotor + Environment.NewLine;

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
                data += Environment.NewLine;
            }
            File.WriteAllText(path + "temp.txt", data);
            functionList.Rows.Clear();
            string[] dataInLine;
            var lines = File.ReadAllLines(path + "temp.txt");

            for (int i = 2; i < lines.Length; i++)
            {
                Console.WriteLine(lines[i]);
                if (lines[i] != "")
                {
                    dataInLine = lines[i].Split('|');
                    functionList.Rows.Add(dataInLine[0], dataInLine[1], dataInLine[2], dataInLine[3], dataInLine[4], dataInLine[5]);
                }
            }
            functionList.Refresh();

            for (int i = 0; i < functionList.RowCount - 1; i++)
            {
                this.FCT_FUN_QUEUE[i] = new FUNCTION(functionList[1, i].Value.ToString(), Convert.ToDouble(functionList[2, i].Value.ToString()), Convert.ToDouble(functionList[3, i].Value.ToString()), functionList[5, i].Value.ToString());
                string json = JsonConvert.SerializeObject(this.FCT_FUN_QUEUE[i], Formatting.Indented);
                Console.WriteLine(json);
            }
            this.testDone = true;
        }
    }

    public class FUNCTION
    {
        public const string Model = "MODEL";
        public const string Delay = "DELAY";
        public const string Volt = "V";
        public const string Ampe = "A";
        public const string Watt = "W";
        public const string WattMax = "W_max";
        public const string WattMin = "W_min";
        public const string NOP = "NOP";
        public const string FREQUENCY = "HZ";
        public const string OFF_POWER_SOUCER = "TURN OFF";
        public const string FINISH = "END";
        public const string SAVE = "SAVE";
        public const string REPEAT = "REPEAT";
        public const string TIMEOUT = "TIME OUT";

        public SerialPort powerPort;

        public string CMD { get; set; } = "";
        public double MIN { get; set; } = 0;
        public double MAX { get; set; } = 0;
        public double READ { get; set; } = 0;
        public string NOTE { get; set; } = "";

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
                        functionList.Rows[Row].Cells[4].Value = this.MIN.ToString();
                        result = true;
                        break;
                    }
                case TIMEOUT:
                    {
                        functionList.Rows[Row].Cells[4].Value = this.MAX.ToString();
                        value.timeOut = (int)this.MAX;
                        result = true;
                        break;
                    }
                case Delay:
                    {
                        for (int i = 0; i < this.MAX * 1000 / 100; i++)
                        {
                            functionList.Rows[Row].Cells[4].Value = (i * 100 / (float)1000).ToString("F1");
                            Thread.Sleep(100);
                        }
                        functionList.Rows[Row].Cells[4].Value = this.MAX.ToString();
                        value.WattMin = 5000;
                        value.WattMax = 0;
                        value.endCycle = false;
                        result = true;
                        break;
                    }
                case REPEAT:
                    {
                        this.rEAPEAT = Convert.ToInt32(this.MAX);
                        result = true;
                        break;
                    }
                case Volt:
                    {
                        functionList.Rows[Row].Cells[4].Value = value.Volt.ToString();
                        if (value.Volt >= this.MIN && value.Volt <= this.MAX)
                            result = true;
                        else
                            result = false;
                        break;
                    }
                case Ampe:
                    {
                        functionList.Rows[Row].Cells[4].Value = value.Ampe.ToString();
                        if (value.Ampe >= this.MIN && value.Ampe <= this.MAX)
                            result = true;
                        else
                            result = false;
                        break;
                    }
                case FREQUENCY:
                    {
                        functionList.Rows[Row].Cells[4].Value = value.Frequency.ToString();
                        if (value.Frequency >= this.MIN && value.Frequency <= this.MAX)
                            result = true;
                        else
                            result = false;
                        break;
                    }
                case Watt:
                    {
                        functionList.Rows[Row].Cells[4].Value = value.Wat.ToString();
                        if (value.Wat >= this.MIN && value.Wat <= this.MAX)
                            result = true;
                        else
                            result = false;
                        break;
                    }
                case WattMax:
                    {
                        functionList.Rows[Row].Cells[4].Value = value.WattMax.ToString();
                        if (value.WattMax >= this.MIN && value.WattMax <= this.MAX)
                            result = true;
                        else
                            result = false;

                        break;
                    }
                case WattMin:
                    {
                        DateTime start = DateTime.Now;
                        while (!value.endCycle)
                        {
                            functionList.Rows[Row].Cells[4].Value = value.WattMin.ToString();
                            if (DateTime.Now.Subtract(start).TotalMilliseconds > value.timeOut)
                            {
                                break;
                            }
                        }
                        functionList.Rows[Row].Cells[4].Value = value.WattMin.ToString();
                        if (value.WattMin >= this.MIN && value.WattMin <= this.MAX)
                            result = true;
                        else
                            result = false;
                        break;
                    }
                case OFF_POWER_SOUCER:
                    {
                        functionList.Rows[Row].Cells[4].Value = this.MAX.ToString();
                        result = true;
                        break;
                    }
                case NOP:
                    {
                        value.WattMin = 5000;
                        value.WattMax = 0;
                        value.endCycle = false;
                        result = true;
                        break;
                    }
                case FINISH:
                    {
                        functionList.Rows[Row].Cells[4].Value = this.MAX.ToString();
                        result = true;
                        break;
                    }
            }
            return result;
        }
    }
}
