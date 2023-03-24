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

namespace Data_Base_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection cn;
        public void connections(){
        
        cn = new SqlConnection(@"Data Source=PIRACHA;Initial Catalog=Hotel_online;Integrated Security=True");
         
            cn.Open();
            if (cn.State == ConnectionState.Open)
            { MessageBox.Show("Connected to the SQl Server Database"); }
            else
                MessageBox.Show("Failed");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;

            if (panel2.Width >= 599)
            {
                timer1.Stop();
             Login login = new Login();
                login.Show();
                this.Hide();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
