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
    public partial class Login : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=PIRACHA;Initial Catalog=Hotel_online;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        public Login()
        {
            InitializeComponent();
            passBox.PasswordChar = '*';
            passBox.MaxLength = 8;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = nameBox.Text;
            string password = passBox.Text;
            passBox.PasswordChar = '*';
            cmd = new SqlCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM LoginTable WHERE Username ='" +nameBox.Text + "' AND Password = '" + passBox.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Menu mainMenu = new Menu();
                mainMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Login please check username and password");
                nameBox.Text = "";
                passBox.Text = "";
            }
            conn.Close();
        }

        private void UsenameLbl_Click(object sender, EventArgs e)
        {

        }

        private void passBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
