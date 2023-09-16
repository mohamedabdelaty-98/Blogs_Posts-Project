namespace Task2.Forms
{
    partial class EditProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProfile));
            btn_submit = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txt_newpass = new TextBox();
            txt_email = new TextBox();
            btn_change = new Button();
            picture_box = new PictureBox();
            txt_username = new TextBox();
            label5 = new Label();
            txt_id = new TextBox();
            label6 = new Label();
            txt_oldpass = new TextBox();
            num_age = new NumericUpDown();
            btn_back = new Button();
            ((System.ComponentModel.ISupportInitialize)picture_box).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_age).BeginInit();
            SuspendLayout();
            // 
            // btn_submit
            // 
            btn_submit.Location = new Point(502, 448);
            btn_submit.Name = "btn_submit";
            btn_submit.Size = new Size(211, 29);
            btn_submit.TabIndex = 21;
            btn_submit.Text = "Submit";
            btn_submit.UseVisualStyleBackColor = true;
            btn_submit.Click += btn_submit_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(487, 399);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 20;
            label4.Text = "Age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(487, 356);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 19;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(487, 312);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 18;
            label2.Text = "New Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(487, 229);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 17;
            label1.Text = "User Name";
            // 
            // txt_newpass
            // 
            txt_newpass.Location = new Point(599, 312);
            txt_newpass.Name = "txt_newpass";
            txt_newpass.PasswordChar = '*';
            txt_newpass.Size = new Size(211, 27);
            txt_newpass.TabIndex = 16;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(599, 356);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(211, 27);
            txt_email.TabIndex = 15;
            // 
            // btn_change
            // 
            btn_change.Location = new Point(487, 131);
            btn_change.Name = "btn_change";
            btn_change.Size = new Size(114, 29);
            btn_change.TabIndex = 13;
            btn_change.Text = "Change Photo";
            btn_change.UseVisualStyleBackColor = true;
            btn_change.Click += btn_change_Click;
            // 
            // picture_box
            // 
            picture_box.BackColor = SystemColors.Control;
            picture_box.BackgroundImage = (Image)resources.GetObject("picture_box.BackgroundImage");
            picture_box.BackgroundImageLayout = ImageLayout.Stretch;
            picture_box.BorderStyle = BorderStyle.FixedSingle;
            picture_box.InitialImage = null;
            picture_box.Location = new Point(544, 33);
            picture_box.Name = "picture_box";
            picture_box.Size = new Size(145, 92);
            picture_box.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_box.TabIndex = 12;
            picture_box.TabStop = false;
            // 
            // txt_username
            // 
            txt_username.Location = new Point(599, 226);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(211, 27);
            txt_username.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(487, 183);
            label5.Name = "label5";
            label5.Size = new Size(24, 20);
            label5.TabIndex = 22;
            label5.Text = "ID";
            // 
            // txt_id
            // 
            txt_id.Location = new Point(599, 183);
            txt_id.Name = "txt_id";
            txt_id.ReadOnly = true;
            txt_id.Size = new Size(75, 27);
            txt_id.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(487, 272);
            label6.Name = "label6";
            label6.Size = new Size(98, 20);
            label6.TabIndex = 25;
            label6.Text = "Old Password";
            // 
            // txt_oldpass
            // 
            txt_oldpass.Location = new Point(599, 269);
            txt_oldpass.Name = "txt_oldpass";
            txt_oldpass.PasswordChar = '*';
            txt_oldpass.Size = new Size(211, 27);
            txt_oldpass.TabIndex = 24;
            // 
            // num_age
            // 
            num_age.Location = new Point(599, 397);
            num_age.Maximum = new decimal(new int[] { 70, 0, 0, 0 });
            num_age.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            num_age.Name = "num_age";
            num_age.Size = new Size(75, 27);
            num_age.TabIndex = 26;
            num_age.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // btn_back
            // 
            btn_back.Location = new Point(1128, 12);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(97, 29);
            btn_back.TabIndex = 27;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // EditProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1237, 503);
            Controls.Add(btn_back);
            Controls.Add(num_age);
            Controls.Add(label6);
            Controls.Add(txt_oldpass);
            Controls.Add(txt_id);
            Controls.Add(label5);
            Controls.Add(btn_submit);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_newpass);
            Controls.Add(txt_email);
            Controls.Add(btn_change);
            Controls.Add(picture_box);
            Controls.Add(txt_username);
            Name = "EditProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditProfile";
            Load += EditProfile_Load;
            ((System.ComponentModel.ISupportInitialize)picture_box).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_age).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_submit;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_newpass;
        private TextBox txt_email;
        private Button btn_change;
        private PictureBox picture_box;
        private TextBox txt_username;
        private Label label5;
        private TextBox txt_id;
        private Label label6;
        private TextBox txt_oldpass;
        private NumericUpDown num_age;
        private Button btn_back;
    }
}