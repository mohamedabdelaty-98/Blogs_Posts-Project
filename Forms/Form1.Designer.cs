namespace Task2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btn_login = new Button();
            btn_regs = new Button();
            txt_username = new TextBox();
            txt_password = new TextBox();
            lbl_message = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkSeaGreen;
            label1.Location = new Point(455, 69);
            label1.Name = "label1";
            label1.Size = new Size(408, 50);
            label1.TabIndex = 0;
            label1.Text = "Welcome To My Blogs";
            // 
            // btn_login
            // 
            btn_login.Location = new Point(545, 299);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(242, 39);
            btn_login.TabIndex = 1;
            btn_login.Text = "LogIn";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // btn_regs
            // 
            btn_regs.Location = new Point(545, 353);
            btn_regs.Name = "btn_regs";
            btn_regs.Size = new Size(242, 39);
            btn_regs.TabIndex = 3;
            btn_regs.Text = "Register";
            btn_regs.UseVisualStyleBackColor = true;
            btn_regs.Click += btn_regs_Click;
            // 
            // txt_username
            // 
            txt_username.Location = new Point(545, 173);
            txt_username.Name = "txt_username";
            txt_username.PlaceholderText = "Enter your user name";
            txt_username.Size = new Size(242, 27);
            txt_username.TabIndex = 4;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(545, 216);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.PlaceholderText = "Enter your password";
            txt_password.Size = new Size(242, 27);
            txt_password.TabIndex = 5;
            // 
            // lbl_message
            // 
            lbl_message.AutoSize = true;
            lbl_message.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_message.ForeColor = SystemColors.ButtonShadow;
            lbl_message.Location = new Point(566, 260);
            lbl_message.Name = "lbl_message";
            lbl_message.Size = new Size(0, 23);
            lbl_message.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1285, 450);
            Controls.Add(lbl_message);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Controls.Add(btn_regs);
            Controls.Add(btn_login);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_login;
        private Button btn_regs;
        private TextBox txt_username;
        private TextBox txt_password;
        private Label lbl_message;
    }
}