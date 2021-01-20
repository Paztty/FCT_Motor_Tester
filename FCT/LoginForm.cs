using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FCT
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        string password = "1234";
        bool changePass = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btOK;
            this.ActiveControl = tbPasswordLogin;
            pnChangePass.Hide();
            if(File.Exists(@"C:\DaeyoungVN\FCT\config.cfg"))
                password = File.ReadAllText(@"C:\DaeyoungVN\FCT\config.cfg");
            else
                File.WriteAllText(@"C:\DaeyoungVN\FCT\config.cfg", password);
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if (!changePass)
            {
                if (tbPasswordLogin.Text == password)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    lbPassword.ForeColor = Color.Red;
                }
            }
            else
            {
                if (tbPasswordChange.Text != password)
                {
                    lbPasswordChange.ForeColor = Color.Red;
                }
                else if (tbPasswordNew.Text != tbPasswordRetype.Text)
                {
                    lbPassNew.ForeColor = Color.Red;
                    lbPassReNew.ForeColor = Color.Red;
                }
                else
                {
                    pnChangePass.Hide();
                    File.WriteAllText(@"C:\DaeyoungVN\FCT\config.cfg",password);
                }
            
            }
        }

        private void btCancle_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
