using ClassLibraryHelloUser;
using System;
using System.Windows.Forms;

namespace NETDiversityWinForms
{
    public partial class Form1 : Form
    {
        private readonly IHelloUser helloUser;

        public Form1(IHelloUser helloUser)
        {
            this.helloUser = helloUser;
            InitializeComponent();
        }

        private void BtnEnterUserName_Click(object sender, EventArgs e)
        {
            string userName = txtBoxUserName.Text;
            string userEmail = txtBoxUserEmail.Text;
            this.helloUser.Init(userName, userEmail);
            lblHelloUserName.Text = helloUser.Greetings;
        }
    }
}
