using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking_System
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        int startP = 0;

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            startP += 1;
            Myprogress.Value = startP;
            if (Myprogress.Value == 100)
            {
                Myprogress.Value = 0;
                timer1.Stop();
                Login Obj = new Login();
                Obj.Show();
                this.Hide();
            }

        }
    }
}
