using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM3
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            MemberCheck member_login = new MemberCheck();

            member_login.Show();

        }

        private void adminButton_Click(object sender, EventArgs e)
        {
           // Admin_page admin = new Admin_page();
            //admin.Show();
            
        }
    }
}
