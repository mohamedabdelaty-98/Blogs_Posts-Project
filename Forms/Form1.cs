using System.Windows.Forms;
using Task2.Forms;
using Task2.Models;

namespace Task2;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

    }

    private void btn_regs_Click(object sender, EventArgs e)
    {
        this.Hide();
        Form_Register form_Register = new Form_Register();
        form_Register.Show();

    }
    private void btn_login_Click(object sender, EventArgs e)
    {
        using (Task2_DbContext dbContext = new Task2_DbContext())
        {
            Author author = dbContext.authors.Where(x => x.UserName == txt_username.Text && x.Password == txt_password.Text).SingleOrDefault();
            if (author != null)
            {
                From_Author_info from_Author_ = new From_Author_info(author.ID);
                this.Hide();
                from_Author_.Show();
            }
            else
            {
                clearinputs();
                lbl_message.Text = "Please Enter Correct username or password";
            }
        }

    }
    void clearinputs()
    {
        txt_username.Text = txt_password.Text = "";

    }
}