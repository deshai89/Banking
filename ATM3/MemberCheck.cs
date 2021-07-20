using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace ATM3
{
    public partial class MemberCheck : Form
    {
        string connection;
        public MemberCheck()
        {
           InitializeComponent();
            // connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Member_info.mdf;Integrated Security=True;Connect Timeout=30";
            connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shai1\source\repos\ATM3\ATM3\Members_Data.mdf;Integrated Security=True;Connect Timeout=30";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (memberTextbox.Text == "99999" && pinTextbox.Text == "0389")
            {
                Close();
                Admin_page admin = new Admin_page();
                admin.Show();
                return;
            }

            if (memberTextbox.TextLength == 0 || pinTextbox.TextLength == 0)
            {
                incorrectLogin();
                return;
            }
            SqlConnection myConnection = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("Select Member_Name, Member_Funds, Member_Login, Member_ID from Members where Member_ID =@username and Member_Pin=@password ", myConnection);
            cmd.Parameters.AddWithValue("@username", memberTextbox.Text);
            cmd.Parameters.AddWithValue("@password", pinTextbox.Text);
            myConnection.Open();

            SqlDataReader memberReader;
            memberReader = cmd.ExecuteReader();
            memberReader.Read();
            while (!memberReader.HasRows)
                {
                incorrectLogin();
                return;
                }

            //label1.Text = dr[0].ToString();
            label1.Text = memberReader["Member_Name"].ToString();
            Member_Home home = new Member_Home(memberReader["Member_Name"].ToString(), Convert.ToDecimal(memberReader["Member_funds"]), memberReader["Member_Login"].ToString(),Convert.ToInt32(memberReader["Member_ID"]));
            home.Show();
            memberReader.Close();
            myConnection.Close();


        }

        private void incorrectLogin()
        {
            MessageBox.Show("Member number or pin number incorrect. Try Again");

        }

        private void Numbersonly_keypress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
