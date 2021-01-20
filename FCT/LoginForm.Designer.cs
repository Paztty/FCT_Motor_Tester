namespace FCT
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnLogin = new System.Windows.Forms.Panel();
            this.tbPasswordLogin = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.btOK = new System.Windows.Forms.Button();
            this.btCancle = new System.Windows.Forms.Button();
            this.pnChangePass = new System.Windows.Forms.Panel();
            this.lbPasswordChange = new System.Windows.Forms.Label();
            this.tbPasswordChange = new System.Windows.Forms.TextBox();
            this.lbPassNew = new System.Windows.Forms.Label();
            this.tbPasswordNew = new System.Windows.Forms.TextBox();
            this.lbPassReNew = new System.Windows.Forms.Label();
            this.tbPasswordRetype = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnLogin.SuspendLayout();
            this.pnChangePass.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnLogin
            // 
            this.pnLogin.Controls.Add(this.lbPassword);
            this.pnLogin.Controls.Add(this.tbPasswordLogin);
            this.pnLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLogin.Location = new System.Drawing.Point(0, 0);
            this.pnLogin.Name = "pnLogin";
            this.pnLogin.Size = new System.Drawing.Size(367, 97);
            this.pnLogin.TabIndex = 0;
            // 
            // tbPasswordLogin
            // 
            this.tbPasswordLogin.Location = new System.Drawing.Point(89, 37);
            this.tbPasswordLogin.Name = "tbPasswordLogin";
            this.tbPasswordLogin.PasswordChar = '*';
            this.tbPasswordLogin.Size = new System.Drawing.Size(266, 20);
            this.tbPasswordLogin.TabIndex = 0;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(30, 40);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(53, 13);
            this.lbPassword.TabIndex = 2;
            this.lbPassword.Text = "Password";
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(199, 111);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 1;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btCancle
            // 
            this.btCancle.Location = new System.Drawing.Point(280, 111);
            this.btCancle.Name = "btCancle";
            this.btCancle.Size = new System.Drawing.Size(75, 23);
            this.btCancle.TabIndex = 2;
            this.btCancle.Text = "Cancle";
            this.btCancle.UseVisualStyleBackColor = true;
            this.btCancle.Click += new System.EventHandler(this.btCancle_Click);
            // 
            // pnChangePass
            // 
            this.pnChangePass.Controls.Add(this.lbPassReNew);
            this.pnChangePass.Controls.Add(this.tbPasswordRetype);
            this.pnChangePass.Controls.Add(this.lbPassNew);
            this.pnChangePass.Controls.Add(this.tbPasswordNew);
            this.pnChangePass.Controls.Add(this.lbPasswordChange);
            this.pnChangePass.Controls.Add(this.tbPasswordChange);
            this.pnChangePass.Location = new System.Drawing.Point(0, 0);
            this.pnChangePass.Name = "pnChangePass";
            this.pnChangePass.Size = new System.Drawing.Size(367, 105);
            this.pnChangePass.TabIndex = 3;
            // 
            // lbPasswordChange
            // 
            this.lbPasswordChange.AutoSize = true;
            this.lbPasswordChange.Location = new System.Drawing.Point(12, 10);
            this.lbPasswordChange.Name = "lbPasswordChange";
            this.lbPasswordChange.Size = new System.Drawing.Size(53, 13);
            this.lbPasswordChange.TabIndex = 2;
            this.lbPasswordChange.Text = "Password";
            // 
            // tbPasswordChange
            // 
            this.tbPasswordChange.Location = new System.Drawing.Point(130, 3);
            this.tbPasswordChange.Name = "tbPasswordChange";
            this.tbPasswordChange.PasswordChar = '*';
            this.tbPasswordChange.Size = new System.Drawing.Size(225, 20);
            this.tbPasswordChange.TabIndex = 0;
            // 
            // lbPassNew
            // 
            this.lbPassNew.AutoSize = true;
            this.lbPassNew.Location = new System.Drawing.Point(12, 39);
            this.lbPassNew.Name = "lbPassNew";
            this.lbPassNew.Size = new System.Drawing.Size(103, 13);
            this.lbPassNew.TabIndex = 4;
            this.lbPassNew.Text = "Enter new password";
            // 
            // tbPasswordNew
            // 
            this.tbPasswordNew.Location = new System.Drawing.Point(130, 34);
            this.tbPasswordNew.Name = "tbPasswordNew";
            this.tbPasswordNew.PasswordChar = '*';
            this.tbPasswordNew.Size = new System.Drawing.Size(225, 20);
            this.tbPasswordNew.TabIndex = 3;
            // 
            // lbPassReNew
            // 
            this.lbPassReNew.AutoSize = true;
            this.lbPassReNew.Location = new System.Drawing.Point(12, 68);
            this.lbPassReNew.Name = "lbPassReNew";
            this.lbPassReNew.Size = new System.Drawing.Size(112, 13);
            this.lbPassReNew.TabIndex = 6;
            this.lbPassReNew.Text = "Retype new password";
            // 
            // tbPasswordRetype
            // 
            this.tbPasswordRetype.Location = new System.Drawing.Point(130, 65);
            this.tbPasswordRetype.Name = "tbPasswordRetype";
            this.tbPasswordRetype.PasswordChar = '*';
            this.tbPasswordRetype.Size = new System.Drawing.Size(225, 20);
            this.tbPasswordRetype.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(30, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Change Password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 137);
            this.Controls.Add(this.pnLogin);
            this.Controls.Add(this.pnChangePass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btCancle);
            this.Controls.Add(this.btOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnLogin.ResumeLayout(false);
            this.pnLogin.PerformLayout();
            this.pnChangePass.ResumeLayout(false);
            this.pnChangePass.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnLogin;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tbPasswordLogin;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btCancle;
        private System.Windows.Forms.Panel pnChangePass;
        private System.Windows.Forms.Label lbPasswordChange;
        private System.Windows.Forms.TextBox tbPasswordChange;
        private System.Windows.Forms.Label lbPassReNew;
        private System.Windows.Forms.TextBox tbPasswordRetype;
        private System.Windows.Forms.Label lbPassNew;
        private System.Windows.Forms.TextBox tbPasswordNew;
        private System.Windows.Forms.Label label2;
    }
}