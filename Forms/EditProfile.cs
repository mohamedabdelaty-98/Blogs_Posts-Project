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
    public partial class EditProfile : Form
    {
        int ID;
        Author author_info;
        bool toggle = false;
        public EditProfile()
        {
            InitializeComponent();
        }
        public EditProfile(int id) : this()
        {
            ID = id;
        }
        private void EditProfile_Load(object sender, EventArgs e)
        {
            using (Task2_DbContext dbContext = new Task2_DbContext())
            {
                Author author = dbContext.authors.Where(x => x.ID == ID).SingleOrDefault();
                author_info = author;
                txt_id.Text = author.ID.ToString();
                txt_username.Text = author.UserName;
                txt_email.Text = author.Email;
                num_age.Value = author.Age;
                using (MemoryStream stream = new MemoryStream(author.Photo))
                {
                    picture_box.Image = Image.FromStream(stream);
                }




            }
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            toggle = true;
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

            if (!IsEmptyEnputs())
            {
                author_info.UserName = txt_username.Text;
                author_info.Email = txt_email.Text;
                author_info.Age = (int)num_age.Value;
                author_info.Photo = toggle ? ImageToByteArray(picture_box.Image) : author_info.Photo;
                if (txt_oldpass.Text == author_info.Password && txt_newpass.Text == "")
                    MessageBox.Show("Edite Successfully");
                else if (txt_oldpass.Text == author_info.Password && txt_newpass.Text != "")
                {
                    if (txt_oldpass.Text == txt_newpass.Text)
                        MessageBox.Show("Enter New Password");
                    author_info.Password = txt_newpass.Text;
                    MessageBox.Show("Edite Successfully");
                }
                else
                    MessageBox.Show("Enter Correct Password");
            }
            else
                MessageBox.Show("Please Enter your name, password and email");
            using (Task2_DbContext dbContext = new Task2_DbContext())
            {
                Author author = dbContext.authors.Where(x => x.ID == ID).SingleOrDefault();
                author.UserName = author_info.UserName;
                author.Email = author_info.Email;
                author.Age = author_info.Age;
                author.Photo = author_info.Photo;
                author.Password = author_info.Password;
                dbContext.SaveChanges();
            }




        }
        bool IsEmptyEnputs()
        {
            if (txt_username.Text == "" || txt_email.Text == "" || txt_oldpass.Text == "")
                return true;
            return false;
        }
        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            From_Author_info from_Author_Info = new From_Author_info(ID);
            this.Hide();
            from_Author_Info.Show();
        }
    }
}
