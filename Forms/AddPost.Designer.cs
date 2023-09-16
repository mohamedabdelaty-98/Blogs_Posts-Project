namespace Task2.Forms
{
    partial class AddPost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPost));
            btn_upload = new Button();
            txt_author_id = new TextBox();
            pictuer_addphoto = new PictureBox();
            dt_date = new DateTimePicker();
            dt_time = new DateTimePicker();
            rtxt_description = new RichTextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txt_bref = new TextBox();
            txt_title = new TextBox();
            btn_post = new Button();
            label7 = new Label();
            cb_Catlog = new ComboBox();
            btn_back = new Button();
            ((System.ComponentModel.ISupportInitialize)pictuer_addphoto).BeginInit();
            SuspendLayout();
            // 
            // btn_upload
            // 
            btn_upload.Location = new Point(465, 147);
            btn_upload.Name = "btn_upload";
            btn_upload.Size = new Size(94, 29);
            btn_upload.TabIndex = 39;
            btn_upload.Text = "Upload";
            btn_upload.UseVisualStyleBackColor = true;
            btn_upload.Click += btn_upload_Click;
            // 
            // txt_author_id
            // 
            txt_author_id.Location = new Point(139, 233);
            txt_author_id.Name = "txt_author_id";
            txt_author_id.ReadOnly = true;
            txt_author_id.Size = new Size(139, 27);
            txt_author_id.TabIndex = 38;
            // 
            // pictuer_addphoto
            // 
            pictuer_addphoto.BackgroundImage = (Image)resources.GetObject("pictuer_addphoto.BackgroundImage");
            pictuer_addphoto.Location = new Point(404, 12);
            pictuer_addphoto.Name = "pictuer_addphoto";
            pictuer_addphoto.Size = new Size(211, 118);
            pictuer_addphoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pictuer_addphoto.TabIndex = 37;
            pictuer_addphoto.TabStop = false;
            // 
            // dt_date
            // 
            dt_date.CustomFormat = "yyyy-MM-dd";
            dt_date.Format = DateTimePickerFormat.Custom;
            dt_date.Location = new Point(139, 179);
            dt_date.Name = "dt_date";
            dt_date.Size = new Size(139, 27);
            dt_date.TabIndex = 35;
            dt_date.Value = new DateTime(2023, 9, 15, 0, 0, 0, 0);
            // 
            // dt_time
            // 
            dt_time.CustomFormat = "Time";
            dt_time.Format = DateTimePickerFormat.Time;
            dt_time.Location = new Point(139, 121);
            dt_time.Name = "dt_time";
            dt_time.Size = new Size(139, 27);
            dt_time.TabIndex = 34;
            // 
            // rtxt_description
            // 
            rtxt_description.BackColor = SystemColors.ActiveBorder;
            rtxt_description.Location = new Point(404, 214);
            rtxt_description.Name = "rtxt_description";
            rtxt_description.Size = new Size(571, 114);
            rtxt_description.TabIndex = 33;
            rtxt_description.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 303);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 32;
            label6.Text = "Catlog";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 236);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 31;
            label5.Text = "Author_id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 78);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 30;
            label4.Text = "Bref";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 126);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 29;
            label3.Text = "Time";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 184);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 28;
            label2.Text = "Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 30);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 27;
            label1.Text = "Title";
            // 
            // txt_bref
            // 
            txt_bref.Location = new Point(139, 78);
            txt_bref.Name = "txt_bref";
            txt_bref.Size = new Size(199, 27);
            txt_bref.TabIndex = 26;
            // 
            // txt_title
            // 
            txt_title.Location = new Point(139, 30);
            txt_title.Name = "txt_title";
            txt_title.Size = new Size(199, 27);
            txt_title.TabIndex = 25;
            // 
            // btn_post
            // 
            btn_post.Location = new Point(329, 375);
            btn_post.Name = "btn_post";
            btn_post.Size = new Size(428, 37);
            btn_post.TabIndex = 24;
            btn_post.Text = "Add Post";
            btn_post.UseVisualStyleBackColor = true;
            btn_post.Click += btn_post_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(620, 179);
            label7.Name = "label7";
            label7.Size = new Size(201, 28);
            label7.TabIndex = 40;
            label7.Text = "Write you description";
            // 
            // cb_Catlog
            // 
            cb_Catlog.FormattingEnabled = true;
            cb_Catlog.Location = new Point(139, 300);
            cb_Catlog.Name = "cb_Catlog";
            cb_Catlog.Size = new Size(151, 28);
            cb_Catlog.TabIndex = 41;
            // 
            // btn_back
            // 
            btn_back.Location = new Point(1058, 12);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(94, 29);
            btn_back.TabIndex = 42;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // AddPost
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1174, 450);
            Controls.Add(btn_back);
            Controls.Add(cb_Catlog);
            Controls.Add(label7);
            Controls.Add(btn_upload);
            Controls.Add(txt_author_id);
            Controls.Add(pictuer_addphoto);
            Controls.Add(dt_date);
            Controls.Add(dt_time);
            Controls.Add(rtxt_description);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_bref);
            Controls.Add(txt_title);
            Controls.Add(btn_post);
            Name = "AddPost";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddPost";
            Load += AddPost_Load;
            ((System.ComponentModel.ISupportInitialize)pictuer_addphoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_upload;
        private TextBox txt_author_id;
        private PictureBox pictuer_addphoto;
        private DateTimePicker dt_date;
        private DateTimePicker dt_time;
        private RichTextBox rtxt_description;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_bref;
        private TextBox txt_title;
        private Button btn_post;
        private Label label7;
        private ComboBox cb_Catlog;
        private Button btn_back;
    }
}