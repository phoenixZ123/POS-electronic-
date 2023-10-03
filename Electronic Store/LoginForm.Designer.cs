namespace Electronic_Store
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
            this.NamePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.PwdLAbel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.tryagain = new System.Windows.Forms.Label();
            this.btnforgot = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NamePanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NamePanel
            // 
            this.NamePanel.BackColor = System.Drawing.Color.SeaGreen;
            this.NamePanel.Controls.Add(this.label1);
            this.NamePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NamePanel.Location = new System.Drawing.Point(0, 0);
            this.NamePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NamePanel.Name = "NamePanel";
            this.NamePanel.Size = new System.Drawing.Size(1924, 101);
            this.NamePanel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ink Free", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(714, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(889, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "ELECTRONIC STORE POINT OF SALE MANAGEMENT ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnLogin);
            this.panel2.Controls.Add(this.btnRegister);
            this.panel2.Controls.Add(this.txtpass);
            this.panel2.Controls.Add(this.txtuser);
            this.panel2.Controls.Add(this.PwdLAbel);
            this.panel2.Controls.Add(this.userNameLabel);
            this.panel2.Location = new System.Drawing.Point(811, 293);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(584, 369);
            this.panel2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(241, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 46);
            this.label4.TabIndex = 6;
            this.label4.Text = "LOGIN";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.SeaGreen;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(305, 242);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(212, 59);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.LightCoral;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(43, 242);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(197, 59);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(200, 146);
            this.txtpass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(317, 36);
            this.txtpass.TabIndex = 3;
            // 
            // txtuser
            // 
            this.txtuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.Location = new System.Drawing.Point(200, 62);
            this.txtuser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(317, 36);
            this.txtuser.TabIndex = 2;
            // 
            // PwdLAbel
            // 
            this.PwdLAbel.AutoSize = true;
            this.PwdLAbel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PwdLAbel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PwdLAbel.Location = new System.Drawing.Point(36, 148);
            this.PwdLAbel.Name = "PwdLAbel";
            this.PwdLAbel.Size = new System.Drawing.Size(128, 37);
            this.PwdLAbel.TabIndex = 1;
            this.PwdLAbel.Text = "Password";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userNameLabel.Location = new System.Drawing.Point(36, 62);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(148, 37);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "User Name";
            // 
            // tryagain
            // 
            this.tryagain.AutoSize = true;
            this.tryagain.BackColor = System.Drawing.Color.Transparent;
            this.tryagain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tryagain.Location = new System.Drawing.Point(884, 266);
            this.tryagain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tryagain.Name = "tryagain";
            this.tryagain.Padding = new System.Windows.Forms.Padding(4);
            this.tryagain.Size = new System.Drawing.Size(8, 33);
            this.tryagain.TabIndex = 7;
            // 
            // btnforgot
            // 
            this.btnforgot.AutoSize = true;
            this.btnforgot.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnforgot.Location = new System.Drawing.Point(807, 683);
            this.btnforgot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnforgot.Name = "btnforgot";
            this.btnforgot.Size = new System.Drawing.Size(164, 24);
            this.btnforgot.TabIndex = 8;
            this.btnforgot.TabStop = true;
            this.btnforgot.Text = "Change Password";
            this.btnforgot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnforgot_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Electronic_Store.Properties.Resources.keyhole_6564596;
            this.pictureBox1.Location = new System.Drawing.Point(975, 107);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1924, 1040);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnforgot);
            this.Controls.Add(this.tryagain);
            this.Controls.Add(this.NamePanel);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.NamePanel.ResumeLayout(false);
            this.NamePanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel NamePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Label PwdLAbel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label tryagain;
        private System.Windows.Forms.LinkLabel btnforgot;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

