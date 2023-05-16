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

namespace Banking_System
{
    public partial class Transactions : Form
    {
        public Transactions()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pierre\Documents\Bankdb.mdf;Integrated Security=True;Connect Timeout=30");

        int Balance;

        private void CheckBalance()
        {
            Con.Open();
            string Query = "select * from AccountTbl where ACNum=" + CheckBalTb.Text + "";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                BalanceLbl.Text = "Php"+dr["AcBal"].ToString();
                Balance = Convert.ToInt32(dr["AcBal"].ToString());
            }
            Con.Close();
        }

        private void CheckAvailableBal()
        {
            //Con.Open();
            string Query = "select * from AccountTbl where ACNum=" + FromTb.Text + "";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                BalanceLabel.Text = "Php" + dr["AcBal"].ToString();
                Balance = Convert.ToInt32(dr["AcBal"].ToString());
            }
            //Con.Close();
        }

        private void GetNewBalance(string Account)
        {
            Con.Open();
            string Query = "select * from AccountTbl where ACNum=" + Account + "";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                //BalanceLbl.Text = "Php" + dr["AcBal"].ToString();
                Balance = Convert.ToInt32(dr["AcBal"].ToString());
            }
            Con.Close();
        }

        private void CheckBalBtn_Click(object sender, EventArgs e)
        {
            if (CheckBalTb.Text == "")
            {
                MessageBox.Show("Enter Account Number");
            }
            else
            {
                CheckBalance();
                if (BalanceLbl.Text == "")
                {
                    MessageBox.Show("Account Not Found");
                    CheckBalTb.Text = "";
                }
            }
        }

        private void Deposit()
        {
            try
            {
                Con.Open();
                //SqlCommand cmd = new SqlCommand("insert into TransactionTbl(TName,TDate,TAmt,TACNum)values(@TN,@TD,@TA,@TAC)", Con);
                SqlCommand cmd = new SqlCommand("insert into TransactionTbl(Tname,TDate,TAmt, TACNum)values(@TN,@TD,@TA,@TAC)", Con);
                cmd.Parameters.AddWithValue("@TN", "Deposit");
                cmd.Parameters.AddWithValue("@TD", DateTime.Now.Date); 
                cmd.Parameters.AddWithValue("@TA", DepAmtTb.Text);
                cmd.Parameters.AddWithValue("@TAC", DepAmtTb.Text);
                cmd.ExecuteNonQuery();

                Con.Close(); 

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                Con.Close();
            }
        }

        private void Withdraw()
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into TransactionTbl(Tname,TDate,TAmt,TACNum)values(@TN,@TD,@TA,@TAC)", Con);
                cmd.Parameters.AddWithValue("@TN", "Withdrawn");
                cmd.Parameters.AddWithValue("@TD", DateTime.Now.Date);
                cmd.Parameters.AddWithValue("@TA", DepAmtTb.Text);
                cmd.Parameters.AddWithValue("@TAC", DepAmtTb.Text);
                cmd.ExecuteNonQuery();
                Con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                Con.Close();
            }
        }

        private void AddBal()
        {
            GetNewBalance(ToTb.Text);
            int newBal = Balance + Convert.ToInt32(TransAmtTb.Text);

            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("Update AccountTbl set AcBal=@AB where ACNUm=@AcKey", Con);
                cmd.Parameters.AddWithValue("@AB", newBal);
                cmd.Parameters.AddWithValue("@AcKey", ToTb.Text);
                cmd.ExecuteNonQuery();
                Con.Close();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void SubtractBal()
        {
            GetNewBalance(FromTb.Text);
            int newBal = Balance - Convert.ToInt32(TransAmtTb.Text);

            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("Update AccountTbl set AcBal=@AB where ACNUm=@AcKey", Con);
                cmd.Parameters.AddWithValue("@AB", newBal);
                cmd.Parameters.AddWithValue("@AcKey", FromTb.Text);
                cmd.ExecuteNonQuery();
                Con.Close();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void DepositBtn_Click(object sender, EventArgs e)
        {
            if (DepAccountTb.Text == "" || DepAmtTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                Deposit();
                GetNewBalance(DepAccountTb.Text);
                int newBal = Balance + Convert.ToInt32(DepAmtTb.Text);

                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update AccountTbl set AcBal=@AB where ACNUm=@AcKey", Con);
                    cmd.Parameters.AddWithValue("@AB", newBal);

                    cmd.Parameters.AddWithValue("@AcKey", DepAccountTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Money Deposit!");
                    Con.Close();
                    DepAmtTb.Text = "";
                    DepAccountTb.Text = "";
                    BalanceLbl.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void WdBtn_Click(object sender, EventArgs e)
        {
            if (WdAccountTb.Text == "" || WdAmtTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                GetNewBalance(DepAccountTb.Text);
                Withdraw();
                if (Balance < Convert.ToInt32(WdAmtTb.Text))
                {
                    MessageBox.Show("Insufficient Balance");
                }
                else
                {
                    int newBal = Balance - Convert.ToInt32(WdAmtTb.Text);

                    try
                    {
                        Con.Open();
                        SqlCommand cmd = new SqlCommand("Update AccountTbl set AcBal=@AB where ACNUm=@AcKey", Con);
                        cmd.Parameters.AddWithValue("@AB", newBal);
                        cmd.Parameters.AddWithValue("@AcKey", WdAccountTb.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Money Withdrawn!");
                        Con.Close();
                        WdAmtTb.Text = "";
                        WdAccountTb.Text = "";
                        BalanceLbl.Text = "";
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }
                }
                

                
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (FromTb.Text == "")
            {
                MessageBox.Show("Enter Source Account");
            }
            else
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from AccountTbl where ACNum='" + FromTb.Text + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    CheckAvailableBal();
                    Con.Close();
                }
                else
                {
                    MessageBox.Show("Account Does not Exist");
                    FromTb.Text = "";
                }
                Con.Close();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (ToTb.Text == "")
            {
                MessageBox.Show("Enter Destination Account");
            }
            else
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from AccountTbl where ACNum='" + ToTb.Text + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    //CheckAvailableBal();
                    MessageBox.Show("Account Found");
                    Con.Close();
                    if (ToTb.Text == FromTb.Text)
                    {
                        MessageBox.Show("Source and Destination Accounts are the same");
                        ToTb.Text = "";
                    }
                    else
                    {

                    }
                }
                else
                {
                    MessageBox.Show("Account Does Not Exist");
                    ToTb.Text = "";
                }
                Con.Close();
            }
        }

        private void Transfer()
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into TransferTbl(TrSrc,TrDest,TrAmt,TrDate)values(@TS,@TD,@TA,@TDa)", Con);
                cmd.Parameters.AddWithValue("@TS", FromTb.Text);
                cmd.Parameters.AddWithValue("@TD", ToTb.Text);
                cmd.Parameters.AddWithValue("@TA", TransAmtTb.Text);
                cmd.Parameters.AddWithValue("@TDa", DateTime.Now.Date);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Money Transfered");
                Con.Close();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                Con.Close();
            }
        }

        private void TransBtn_Click(object sender, EventArgs e)
        {
            if (ToTb.Text == "" || FromTb.Text == "" || TransAmtTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else if (Convert.ToInt32(TransAmtTb.Text)>Balance)
            {
                MessageBox.Show("Insufficient Balance");
            }
            else
            {
                Transfer();
                SubtractBal();
                AddBal();
                FromTb.Text = "";
                ToTb.Text = "";
                TransAmtTb.Text = "";

            }
        }
    }
}
