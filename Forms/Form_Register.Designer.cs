namespace Task2.Forms
{
    partial class Form_Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Register));
            txt_username = new TextBox();
            picture_box = new PictureBox();
            btn_upload = new Button();
            txt_email = new TextBox();
            txt_pass = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btn_submit = new Button();
            num_age = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)picture_box).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_age).BeginInit();
            SuspendLayout();
            // 
            // txt_username
            // 
            txt_username.Location = new Point(521, 184);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(170, 27);
            txt_username.TabIndex = 0;
            txt_username.TextChanged += txt_username_TextChanged;
            // 
            // picture_box
            // 
            picture_box.BackColor = SystemColors.Control;
            picture_box.BackgroundImage = (Image)resources.GetObject("picture_box.BackgroundImage");
            picture_box.BackgroundImageLayout = ImageLayout.Stretch;
            picture_box.BorderStyle = BorderStyle.FixedSingle;
            picture_box.InitialImage = null;
            picture_box.Location = new Point(472, 22);
            picture_box.Name = "picture_box";
            picture_box.Size = new Size(145, 92);
            picture_box.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_box.TabIndex = 1;
            picture_box.TabStop = false;
            picture_box.Click += picture_box_Click;
            // 
            // btn_upload
            // 
            btn_upload.Location = new Point(404, 120);
            btn_upload.Name = "btn_upload";
            btn_upload.Size = new Size(94, 29);
            btn_upload.TabIndex = 2;
            btn_upload.Text = "Upload";
            btn_upload.UseVisualStyleBackColor = true;
            btn_upload.Click += btn_upload_Click;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(521, 271);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(170, 27);
            txt_email.TabIndex = 4;
            txt_email.TextChanged += txt_email_TextChanged;
            // 
            // txt_pass
            // 
            txt_pass.Location = new Point(521, 227);
            txt_pass.Name = "txt_pass";
            txt_pass.PasswordChar = '*';
            txt_pass.Size = new Size(170, 27);
            txt_pass.TabIndex = 5;
            txt_pass.TextChanged += txt_pass_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(416, 187);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 6;
            label1.Text = "User Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(416, 227);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 7;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(416, 271);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 8;
            label3.Text = "Email";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(416, 314);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 9;
            label4.Text = "Age";
            label4.Click += label4_Click;
            // 
            // btn_submit
            // 
            btn_submit.Location = new Point(435, 378);
            btn_submit.Name = "btn_submit";
            btn_submit.Size = new Size(211, 29);
            btn_submit.TabIndex = 10;
            btn_submit.Text = "Submit";
            btn_submit.UseVisualStyleBackColor = true;
            btn_submit.Click += btn_submit_Click;
            // 
            // num_age
            // 
            num_age.Location = new Point(521, 314);
            num_age.Maximum = new decimal(new int[] { 70, 0, 0, 0 });
            num_age.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            num_age.Name = "num_age";
            num_age.Size = new Size(150, 27);
            num_age.TabIndex = 11;
            num_age.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // Form_Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1078, 450);
            Controls.Add(num_age);
            Controls.Add(btn_submit);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_pass);
            Controls.Add(txt_email);
            Controls.Add(btn_upload);
            Controls.Add(picture_box);
            Controls.Add(txt_username);
            Name = "Form_Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_Register";
            ((System.ComponentModel.ISupportInitialize)picture_box).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_age).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_username;
        private PictureBox picture_box;
        private Button btn_upload;
        private TextBox txt_email;
        private TextBox txt_pass;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_submit;
        private NumericUpDown num_age;
    }
}