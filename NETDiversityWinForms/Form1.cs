using ClassLibraryHelloUser;
using System;
using System.Windows.Forms;

namespace NETDiversityWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnEnterUserName_Click(object sender, EventArgs e)
        {
            string userName = txtBoxUserName.Text;
            string userEmail = txtBoxUserEmail.Text;
            HelloUser helloUser = new HelloUser(userName, userEmail);
            lblHelloUserName.Text = helloUser.Greetings;
        }
    }
}
