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
    public partial class Form_Register : Form
    {
        public Form_Register()
        {
            InitializeComponent();
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;


                    picture_box.Image = Image.FromFile(imagePath);
                }
            }

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            using (Task2_DbContext task2_DbContext = new Task2_DbContext())
            {
                Author author = new Author()
                {
                    UserName = txt_username.Text,
                    Password = txt_pass.Text,
                    Age = (int)num_age.Value,
                    Email = txt_email.Text,
                    Photo = ImageToByteArray(picture_box.Image),
                };
                task2_DbContext.authors.Add(author);
                task2_DbContext.SaveChanges();
                MessageBox.Show("Successfully Register");
                clearinputs();
            }
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
        void clearinputs()
        {
            txt_username.Text = txt_email.Text = txt_pass.Text = "";
            picture_box.Image = null;
            num_age.Value = 10;
        }
        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        private void picture_box_Click(object sender, EventArgs e)
        {

        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_age_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }
    }
}
