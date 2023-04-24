namespace WindowsFormsApplication8
{
    partial class Form1
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
            this.ucpAppPan = new System.Windows.Forms.Panel();
            this.loginBtn = new System.Windows.Forms.Button();
            this.registrationBtn = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userdetailsPan = new System.Windows.Forms.Panel();
            this.passwordOutput = new System.Windows.Forms.TextBox();
            this.usernameOutput = new System.Windows.Forms.TextBox();
            this.outputEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginControl1 = new WindowsFormsApplication8.LoginControl();
            this.registrationControl1 = new WindowsFormsApplication8.RegistrationControl();
            this.homeControl1 = new WindowsFormsApplication8.HomeControl();
            this.ucpAppPan.SuspendLayout();
            this.userdetailsPan.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucpAppPan
            // 
            this.ucpAppPan.Controls.Add(this.loginBtn);
            this.ucpAppPan.Controls.Add(this.registrationBtn);
            this.ucpAppPan.Controls.Add(this.homeBtn);
            this.ucpAppPan.Controls.Add(this.label5);
            this.ucpAppPan.Dock = System.Windows.Forms.DockStyle.Left;
            this.ucpAppPan.Location = new System.Drawing.Point(0, 0);
            this.ucpAppPan.Name = "ucpAppPan";
            this.ucpAppPan.Size = new System.Drawing.Size(133, 427);
            this.ucpAppPan.TabIndex = 1;
            this.ucpAppPan.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(29, 216);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 44);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // registrationBtn
            // 
            this.registrationBtn.Location = new System.Drawing.Point(29, 146);
            this.registrationBtn.Name = "registrationBtn";
            this.registrationBtn.Size = new System.Drawing.Size(75, 43);
            this.registrationBtn.TabIndex = 2;
            this.registrationBtn.Text = "Registration";
            this.registrationBtn.UseVisualStyleBackColor = true;
            this.registrationBtn.Click += new System.EventHandler(this.registrationBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.Location = new System.Drawing.Point(29, 72);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(75, 43);
            this.homeBtn.TabIndex = 2;
            this.homeBtn.Text = "Home";
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "UCP App";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Details";
            // 
            // userdetailsPan
            // 
            this.userdetailsPan.Controls.Add(this.passwordOutput);
            this.userdetailsPan.Controls.Add(this.usernameOutput);
            this.userdetailsPan.Controls.Add(this.outputEmail);
            this.userdetailsPan.Controls.Add(this.label4);
            this.userdetailsPan.Controls.Add(this.label3);
            this.userdetailsPan.Controls.Add(this.label2);
            this.userdetailsPan.Controls.Add(this.label1);
            this.userdetailsPan.Dock = System.Windows.Forms.DockStyle.Right;
            this.userdetailsPan.Location = new System.Drawing.Point(576, 0);
            this.userdetailsPan.Name = "userdetailsPan";
            this.userdetailsPan.Size = new System.Drawing.Size(200, 427);
            this.userdetailsPan.TabIndex = 5;
            // 
            // passwordOutput
            // 
            this.passwordOutput.Location = new System.Drawing.Point(76, 213);
            this.passwordOutput.Name = "passwordOutput";
            this.passwordOutput.Size = new System.Drawing.Size(100, 20);
            this.passwordOutput.TabIndex = 4;
            // 
            // usernameOutput
            // 
            this.usernameOutput.Location = new System.Drawing.Point(76, 143);
            this.usernameOutput.Name = "usernameOutput";
            this.usernameOutput.Size = new System.Drawing.Size(100, 20);
            this.usernameOutput.TabIndex = 4;
            // 
            // outputEmail
            // 
            this.outputEmail.Location = new System.Drawing.Point(76, 79);
            this.outputEmail.Name = "outputEmail";
            this.outputEmail.Size = new System.Drawing.Size(100, 20);
            this.outputEmail.TabIndex = 4;
            this.outputEmail.TextChanged += new System.EventHandler(this.outputEmail_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // loginControl1
            // 
            this.loginControl1.BackColor = System.Drawing.Color.SkyBlue;
            this.loginControl1.Location = new System.Drawing.Point(139, 12);
            this.loginControl1.Name = "loginControl1";
            this.loginControl1.Size = new System.Drawing.Size(403, 406);
            this.loginControl1.TabIndex = 6;
            // 
            // registrationControl1
            // 
            this.registrationControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.registrationControl1.Location = new System.Drawing.Point(140, 12);
            this.registrationControl1.Name = "registrationControl1";
            this.registrationControl1.Size = new System.Drawing.Size(402, 406);
            this.registrationControl1.TabIndex = 3;
            // 
            // homeControl1
            // 
            this.homeControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.homeControl1.Location = new System.Drawing.Point(139, 12);
            this.homeControl1.Name = "homeControl1";
            this.homeControl1.Size = new System.Drawing.Size(402, 403);
            this.homeControl1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 427);
            this.Controls.Add(this.userdetailsPan);
            this.Controls.Add(this.loginControl1);
            this.Controls.Add(this.registrationControl1);
            this.Controls.Add(this.homeControl1);
            this.Controls.Add(this.ucpAppPan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ucpAppPan.ResumeLayout(false);
            this.ucpAppPan.PerformLayout();
            this.userdetailsPan.ResumeLayout(false);
            this.userdetailsPan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ucpAppPan;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button registrationBtn;
        private System.Windows.Forms.Button homeBtn;
        private HomeControl homeControl1;
        private RegistrationControl registrationControl1;
        private LoginControl loginControl1;
        private System.Windows.Forms.Panel userdetailsPan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox passwordOutput;
        private System.Windows.Forms.TextBox usernameOutput;
        private System.Windows.Forms.TextBox outputEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

