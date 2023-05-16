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
using System.Data.SqlClient;

namespace Banking_System
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            NewPassTb.Text = "";
            ThemeCb.SelectedIndex = -1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ThemeCb.SelectedIndex == -1)
            {
                MessageBox.Show("Select a Theme");
            }
            else if (ThemeCb.SelectedIndex == 0)
            {
                panel1.BackColor = Color.Orange;
            }
            else if (ThemeCb.SelectedIndex == 1)
            {
                panel1.BackColor = Color.Crimson;
            }
            else
            {
                panel1.BackColor = Color.Green;
            }
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pierre\Documents\Bankdb.mdf;Integrated Security=True;Connect Timeout=30");

        private void button1_Click(object sender, EventArgs e)
        {
            if (NewPassTb.Text == "")
            {
                MessageBox.Show("Enter New Password");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update AdminTbl set AdPass=@AP where AdId=@AKey", Con);
                    cmd.Parameters.AddWithValue("@AP", NewPassTb.Text);
                    cmd.Parameters.AddWithValue("@AKey", 1);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Password Updated!");
                    Con.Close();
                    NewPassTb.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
