namespace WindowsFormsApplication5
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.homeButton = new System.Windows.Forms.Button();
            this.registrationButton = new System.Windows.Forms.Button();
            this.logIn = new System.Windows.Forms.Button();
            this.loginUser1 = new WindowsFormsApplication5.LoginUser();
            this.regustrationUser1 = new WindowsFormsApplication5.RegustrationUser();
            this.homeControl1 = new WindowsFormsApplication5.HomeControl();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.logIn);
            this.panel1.Controls.Add(this.registrationButton);
            this.panel1.Controls.Add(this.homeButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 388);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "UCP APP";
            // 
            // homeButton
            // 
            this.homeButton.Location = new System.Drawing.Point(33, 118);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(75, 23);
            this.homeButton.TabIndex = 1;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // registrationButton
            // 
            this.registrationButton.Location = new System.Drawing.Point(33, 164);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(75, 23);
            this.registrationButton.TabIndex = 2;
            this.registrationButton.Text = "Registration";
            this.registrationButton.UseVisualStyleBackColor = true;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // logIn
            // 
            this.logIn.Location = new System.Drawing.Point(33, 210);
            this.logIn.Name = "logIn";
            this.logIn.Size = new System.Drawing.Size(75, 23);
            this.logIn.TabIndex = 3;
            this.logIn.Text = "Login";
            this.logIn.UseVisualStyleBackColor = true;
            this.logIn.Click += new System.EventHandler(this.logIn_Click);
            // 
            // loginUser1
            // 
            this.loginUser1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.loginUser1.Location = new System.Drawing.Point(147, 12);
            this.loginUser1.Name = "loginUser1";
            this.loginUser1.Size = new System.Drawing.Size(390, 352);
            this.loginUser1.TabIndex = 3;
            this.loginUser1.Load += new System.EventHandler(this.loginUser1_Load);
            // 
            // regustrationUser1
            // 
            this.regustrationUser1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.regustrationUser1.Location = new System.Drawing.Point(147, 5);
            this.regustrationUser1.Name = "regustrationUser1";
            this.regustrationUser1.Size = new System.Drawing.Size(390, 371);
            this.regustrationUser1.TabIndex = 2;
            this.regustrationUser1.Load += new System.EventHandler(this.regustrationUser1_Load);
            // 
            // homeControl1
            // 
            this.homeControl1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.homeControl1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.homeControl1.Location = new System.Drawing.Point(147, 0);
            this.homeControl1.Name = "homeControl1";
            this.homeControl1.Size = new System.Drawing.Size(390, 388);
            this.homeControl1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 388);
            this.Controls.Add(this.loginUser1);
            this.Controls.Add(this.regustrationUser1);
            this.Controls.Add(this.homeControl1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button logIn;
        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Label label1;
        private HomeControl homeControl1;
        private RegustrationUser regustrationUser1;
        private LoginUser loginUser1;
    }
}

