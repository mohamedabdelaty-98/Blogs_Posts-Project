namespace Task2.Forms
{
    partial class From_Author_info
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
            pictur_box = new PictureBox();
            lbla_name = new Label();
            btn_logout = new Button();
            btn_addpost = new Button();
            btn_mypost = new Button();
            richTextBox1 = new RichTextBox();
            picture_post = new PictureBox();
            btn_next = new Button();
            btn_all = new Button();
            btn_editeprofile = new Button();
            ((System.ComponentModel.ISupportInitialize)pictur_box).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picture_post).BeginInit();
            SuspendLayout();
            // 
            // pictur_box
            // 
            pictur_box.Location = new Point(12, 12);
            pictur_box.Name = "pictur_box";
            pictur_box.Size = new Size(212, 118);
            pictur_box.SizeMode = PictureBoxSizeMode.StretchImage;
            pictur_box.TabIndex = 0;
            pictur_box.TabStop = false;
            // 
            // lbla_name
            // 
            lbla_name.AutoSize = true;
            lbla_name.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbla_name.ForeColor = Color.Olive;
            lbla_name.Location = new Point(12, 142);
            lbla_name.Name = "lbla_name";
            lbla_name.Size = new Size(76, 31);
            lbla_name.TabIndex = 1;
            lbla_name.Text = "label1";
            // 
            // btn_logout
            // 
            btn_logout.Location = new Point(1009, 12);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(94, 29);
            btn_logout.TabIndex = 2;
            btn_logout.Text = "LogOut";
            btn_logout.UseVisualStyleBackColor = true;
            btn_logout.Click += btn_logout_Click;
            // 
            // btn_addpost
            // 
            btn_addpost.Location = new Point(441, 42);
            btn_addpost.Name = "btn_addpost";
            btn_addpost.Size = new Size(106, 29);
            btn_addpost.TabIndex = 3;
            btn_addpost.Text = "Add Post";
            btn_addpost.UseVisualStyleBackColor = true;
            btn_addpost.Click += btn_addpost_Click;
            // 
            // btn_mypost
            // 
            btn_mypost.Location = new Point(580, 42);
            btn_mypost.Name = "btn_mypost";
            btn_mypost.Size = new Size(106, 29);
            btn_mypost.TabIndex = 4;
            btn_mypost.Text = "My Posts";
            btn_mypost.UseVisualStyleBackColor = true;
            btn_mypost.Click += btn_mypost_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(250, 239);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(487, 154);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // picture_post
            // 
            picture_post.Location = new Point(387, 98);
            picture_post.Name = "picture_post";
            picture_post.Size = new Size(212, 118);
            picture_post.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_post.TabIndex = 6;
            picture_post.TabStop = false;
            // 
            // btn_next
            // 
            btn_next.Location = new Point(441, 416);
            btn_next.Name = "btn_next";
            btn_next.Size = new Size(106, 29);
            btn_next.TabIndex = 7;
            btn_next.Text = "Next Post";
            btn_next.UseVisualStyleBackColor = true;
            btn_next.Click += btn_next_Click;
            // 
            // btn_all
            // 
            btn_all.Location = new Point(717, 42);
            btn_all.Name = "btn_all";
            btn_all.Size = new Size(106, 29);
            btn_all.TabIndex = 8;
            btn_all.Text = "All Posts";
            btn_all.UseVisualStyleBackColor = true;
            btn_all.Click += btn_all_Click;
            // 
            // btn_editeprofile
            // 
            btn_editeprofile.Location = new Point(294, 42);
            btn_editeprofile.Name = "btn_editeprofile";
            btn_editeprofile.Size = new Size(106, 29);
            btn_editeprofile.TabIndex = 9;
            btn_editeprofile.Text = "Edit Profile";
            btn_editeprofile.UseVisualStyleBackColor = true;
            btn_editeprofile.Click += btn_editeprofile_Click;
            // 
            // From_Author_info
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 497);
            Controls.Add(btn_editeprofile);
            Controls.Add(btn_all);
            Controls.Add(btn_next);
            Controls.Add(picture_post);
            Controls.Add(richTextBox1);
            Controls.Add(btn_mypost);
            Controls.Add(btn_addpost);
            Controls.Add(btn_logout);
            Controls.Add(lbla_name);
            Controls.Add(pictur_box);
            Name = "From_Author_info";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "From_Author_info";
            Load += From_Author_info_Load;
            ((System.ComponentModel.ISupportInitialize)pictur_box).EndInit();
            ((System.ComponentModel.ISupportInitialize)picture_post).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictur_box;
        private Label lbla_name;
        private Button btn_logout;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button btn_addpost;
        private Button btn_mypost;
        private RichTextBox richTextBox1;
        private PictureBox picture_post;
        private Button btn_next;
        private Button btn_all;
        private Button btn_editeprofile;
    }
}