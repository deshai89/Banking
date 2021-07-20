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
    public partial class Member_Home : Form
    {
        public string fullName;
        public string time;
        public decimal funds;
        public int memberID;
        public string connection;
        public SqlConnection myConnection;
        public SqlCommand sql_commands;
        public SqlDataReader summaryReader;

        public Member_Home(string name, decimal memberFunds, string login, int ID)
        {
            InitializeComponent();
            connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shai1\source\repos\ATM3\ATM3\Members_Data.mdf;Integrated Security=True;Connect Timeout=30";
            fullName = name;
            funds = memberFunds;
            time = login;
            memberID = ID;

        }
        
        private void Member_Home_Load(object sender, EventArgs e)
        {

            welcomeLabel.Text = "Welcome " + fullName;
            availablefundsLabel.Text = funds.ToString("C");
            if (time == "")                     //if members first login, no past login time exists
            {
                lastloginLabel.Text = "";
            }
            else
            { 
                lastloginLabel.Text = "Last login was " + time; 
            }

            lastLogin();
            SummaryList();
            myConnection.Close();

        }

        private void Withdraw_Click(object sender, EventArgs e)
        {
            if (withdrawText.TextLength == 0)           //tells user there is a error in the withdraw process 
            {
                Incorrect("");
                return;
            }
            if (Convert.ToDecimal(withdrawText.Text) > funds)
            { 
                Incorrect("lowFunds");
                return;
            }
            errorText.ResetText();
            //withdraws amount from available funds
            sql_commands = new SqlCommand("Update Members Set Member_Funds= @withdraw where Member_Name =@username", myConnection);
            sql_commands.Parameters.AddWithValue("@withdraw", funds - Convert.ToDecimal(withdrawText.Text));
            sql_commands.Parameters.AddWithValue("username", fullName);
            myConnection.Open();
            sql_commands.ExecuteNonQuery();

            //saves new withdraw information to members summary table
            sql_commands = new SqlCommand("INSERT INTO MEMBERS_Log (Member_Log, Member_ID, Trans_Date) VALUES (@withdraw,@member_N,@date)", myConnection);
            sql_commands.Parameters.AddWithValue("@member_N", memberID);
            sql_commands.Parameters.AddWithValue("@withdraw", "W/D -" + Convert.ToDecimal(withdrawText.Text).ToString("C"));
            sql_commands.Parameters.AddWithValue("@date", DateTime.Today.Date);
            sql_commands.ExecuteNonQuery();
            myConnection.Close();
            availablefundsLabel.Text = (funds - Convert.ToDecimal(withdrawText.Text)).ToString("C");


        }

        public void Incorrect(string type)
        {
            if (type == "lowFunds")
                errorText.Text = "Lack the funds to complete request. Try again.";
            else
                errorText.Text = "Incorrect entry. Try again";
        }

        public void SummaryList()
        {
            //summaryListbox.Items.Clear();
            //fills summary list with users past deposits or withdraws
            SqlCommand summary = new SqlCommand("Select TOP 25 Member_Log, Trans_Date From Members_Log Where Member_ID = @summary Order By [Trans_Date] desc", myConnection);
            summary.Parameters.AddWithValue("@summary", memberID);
            summaryReader = summary.ExecuteReader();
            while (summaryReader.Read())
            {
                
                // summaryListbox.Items.Add(summaryReader["Member_Log"]);
                summaryListbox.Items.Insert(0, summaryReader["Member_Log"]);
                ListViewItem lv = new ListViewItem();
                //lv.SubItems.Add(summaryReader["Member_Log"].ToString());
                lv.SubItems.Add(summaryReader["Member_Log"].ToString()) ;
                lv.SubItems.Add(Convert.ToDateTime(summaryReader["Trans_Date"]).ToString("d"));
                //summaryListView.Items.Add(summaryReader["Member_Log"].ToString());
                //summaryListView.
                //lv.SubItems.Contains("W/D")
                
                summaryListView.Items.Add(lv);
                
            }
            
            
        }

        public void lastLogin()
        {
            string loginTime = DateTime.Now.ToString();             //creates latest login time and sends to table
            myConnection = new SqlConnection(connection);
            sql_commands = new SqlCommand("Update Members Set Member_Login= @time where Member_Name =@username", myConnection);
            sql_commands.Parameters.AddWithValue("@username", fullName);
            sql_commands.Parameters.AddWithValue("@time", loginTime);
            myConnection.Open();
            sql_commands.ExecuteNonQuery();
        }

        private void Account_summary_Click(object sender, EventArgs e)
        {
            summaryListbox.Items.Clear();
            summaryListView.Items.Clear();
            myConnection.Open();
            SummaryList();
            myConnection.Close();
        }

        private void DepositButton_Click(object sender, EventArgs e)
        {
            if (depositTextbox.TextLength == 0)           //tells user there is a error in the deposit process 
            {
                Incorrect("");
                return;
            }

            funds += Convert.ToDecimal(depositTextbox.Text);
            sql_commands = new SqlCommand("Update Members Set Member_Funds= @deposit where Member_Name =@username", myConnection);
            sql_commands.Parameters.AddWithValue("@deposit", funds + Convert.ToDecimal(depositTextbox.Text));
            sql_commands.Parameters.AddWithValue("username", fullName);
            myConnection.Open();
            sql_commands.ExecuteNonQuery();

            //saves new deposit information to members summary table
            sql_commands = new SqlCommand("INSERT INTO MEMBERS_Log (Member_Log, Member_ID, Trans_Date) VALUES (@deposit,@member_N,@date)", myConnection);
            sql_commands.Parameters.AddWithValue("@member_N", memberID);
            sql_commands.Parameters.AddWithValue("@deposit", "Deposit +" + Convert.ToDecimal(depositTextbox.Text).ToString("C"));
            sql_commands.Parameters.AddWithValue("@date", DateTime.Today.Date);
            sql_commands.ExecuteNonQuery();
            myConnection.Close();
            availablefundsLabel.Text = funds.ToString("C");
        }

        private void Numbersonly_keypress(object sender, KeyPressEventArgs e)
        {
            TextBox text = (TextBox)sender;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                summaryListView.Items.Clear();
                myConnection.Open();
                SummaryList();
                myConnection.Close();
            }
        }
    }
}
