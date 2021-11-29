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

        private void btnEnterUserName_Click(object sender, EventArgs e)
        {
            string userName = txtBox.Text;
            HelloUser helloUser = new HelloUser(userName);
            lblHelloUserName.Text = helloUser.Greetings;
        }
    }
}
