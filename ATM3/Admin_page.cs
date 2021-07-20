using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM3
{
    public partial class Admin_page : Form
    {
        public string connection;
        public SqlConnection myConnection;
        public SqlCommand sql_command;
        public SqlDataReader memberReader;
        public Admin_page()
        {
            InitializeComponent();

        }

        private void Admin_page_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'newest_Members_DataDataSet.Members' table. You can move, or remove it, as needed.
            this.membersTableAdapter.Fill(this.newest_Members_DataDataSet.Members);
            // TODO: This line of code loads data into the 'members_table_info.Members' table. You can move, or remove it, as needed.
            connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shai1\source\repos\ATM3\ATM3\Members_Data.mdf;Integrated Security=True;Connect Timeout=30";
            sql_command = new SqlCommand("select Member_Name from Members order by Member_Name asc", myConnection);
            memberReader = sql_command.ExecuteReader();
            while (memberReader.Read())
            {
                
            }


        }
    }
}
