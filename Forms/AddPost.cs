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
    public partial class AddPost : Form
    {
        int ID;
        public AddPost()
        {
            InitializeComponent();
        }
        public AddPost(int id) : this()
        {
            ID = id;
        }

        private void AddPost_Load(object sender, EventArgs e)
        {
            txt_author_id.Text = ID.ToString();
            using (Task2_DbContext dbContext = new Task2_DbContext())
            {

                cb_Catlog.DataSource = dbContext.catalogs.ToList();
                cb_Catlog.DisplayMember = "Name";
                cb_Catlog.ValueMember = "ID";
            }
        }

        private void btn_post_Click(object sender, EventArgs e)
        {
            using (Task2_DbContext dbContext = new Task2_DbContext())
            {
                DateTime time = dt_time.Value;
                Post post = new Post()
                {
                    Title = txt_title.Text,
                    Bref = txt_bref.Text,
                    Description = rtxt_description.Text,
                    Time = time.TimeOfDay,
                    Date = dt_date.Value.Date,
                    Authoer_id = int.Parse(txt_author_id.Text),
                    Cat_id = (int)cb_Catlog.SelectedValue,
                    Photo = ImageToByteArray(pictuer_addphoto.Image),
                };
                dbContext.posts.Add(post);
                dbContext.SaveChanges();
                MessageBox.Show("Successfully Register");
                clearinputs();
            }

        }
        void clearinputs()
        {
            txt_title.Text = txt_bref.Text = rtxt_description.Text = "";
            pictuer_addphoto.Image = null;
            dt_time.Value = dt_date.Value = DateTime.Now;
            cb_Catlog.SelectedValue = 0;
        }
        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;


                    pictuer_addphoto.Image = Image.FromFile(imagePath);
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            From_Author_info from_Author_Info = new From_Author_info(ID);
            from_Author_Info.Show();
        }
    }
}
