﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            lblHelloUserName.Text = $"Hello {userName}";
        }
    }
}
