using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task2.Models;

namespace Task2.Forms
{
    public partial class From_Author_info : Form
    {
        int ID;
        List<Post> post_user;
        public From_Author_info()
        {
            InitializeComponent();
        }
        public From_Author_info(int id) : this()
        {
            ID = id;
        }

        private void From_Author_info_Load(object sender, EventArgs e)
        {

            using (Task2_DbContext dbContext = new Task2_DbContext())
            {
                Author author = dbContext.authors.Where(x => x.ID == ID).SingleOrDefault();
                using (MemoryStream stream = new MemoryStream(author.Photo))
                {
                    pictur_box.Image = Image.FromStream(stream);
                }
                lbla_name.Text = author.UserName;




            }

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void btn_post_Click(object sender, EventArgs e)
        {

        }


        private void btn_upload_Click(object sender, EventArgs e)
        {

        }

        private void btn_addpost_Click(object sender, EventArgs e)
        {
            AddPost addPost = new AddPost(ID);
            this.Hide();
            addPost.Show();
        }

        private void btn_mypost_Click(object sender, EventArgs e)
        {
            using (Task2_DbContext dbContext = new Task2_DbContext())
            {
                List<Post> posts = dbContext.posts.Where(x => x.Authoer_id == ID).ToList();
                post_user = posts;
                Post post = posts.FirstOrDefault();
                if (post != null)
                {

                    richTextBox1.Text = $"{post.Title}\n{post.Time.Hours}:{post.Time.Minutes}" +
             $"\t{post.Date.Day}/ {post.Date.Month}/ {post.Date.Year}\n";
                    richTextBox1.Text += post.Description;

                    using (MemoryStream stream = new MemoryStream(post.Photo))
                    {
                        picture_post.Image = Image.FromStream(stream);
                    }
                }
                else
                {
                    richTextBox1.Text = "No more items to display.";
                }
            }
        }
        int currentIndex = 0;
        private void btn_next_Click(object sender, EventArgs e)
        {

            if (currentIndex < post_user.Count)
            {
                var item = post_user[currentIndex];

                richTextBox1.Text = $"{item.Title}\n{item.Time.Hours}:{item.Time.Minutes}" +
                    $"\t{item.Date.Day}/ {item.Date.Month}/ {item.Date.Year}\n";
                richTextBox1.Text += item.Description;
                using (MemoryStream stream = new MemoryStream(item.Photo))
                {
                    picture_post.Image = Image.FromStream(stream);
                }
            }
            else
            {
                richTextBox1.Text = "No more items to display.";
            }
            currentIndex = (currentIndex + 1) % post_user.Count;


        }

        private void btn_all_Click(object sender, EventArgs e)
        {
            using (Task2_DbContext dbContext = new Task2_DbContext())
            {
                List<Post> posts = dbContext.posts.ToList();
                post_user = posts;
                Post post = posts.FirstOrDefault();
                if (post != null)
                {
                    richTextBox1.Text = $"{post.Title}\n{post.Time.Hours}:{post.Time.Minutes}" +
                   $"\t{post.Date.Day}/ {post.Date.Month}/ {post.Date.Year}\n";
                    richTextBox1.Text += post.Description;
                    using (MemoryStream stream = new MemoryStream(post.Photo))
                    {
                        picture_post.Image = Image.FromStream(stream);
                    }
                }
                else
                {
                    richTextBox1.Text = "No more items to display.";
                }
            }
        }

        private void btn_editeprofile_Click(object sender, EventArgs e)
        {
            EditProfile editProfile = new EditProfile(ID);
            this.Hide();
            editProfile.Show();
        }
    }
}
