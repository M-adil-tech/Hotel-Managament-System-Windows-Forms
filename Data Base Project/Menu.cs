using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Base_Project
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdmLgnBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();

        }

        private void ResBtn_Click(object sender, EventArgs e)
        {
            Reserve reserve = new Reserve();    
            reserve.Show();
            this.Hide();
        }

        private void CafeBtn_Click(object sender, EventArgs e)
        {
            Cafe cafe = new Cafe();
            cafe.Show();
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void ContactBtn_Click(object sender, EventArgs e)
        {
            Contactus contactus = new Contactus();  
            contactus.Show();
            this.Hide();
        }

        private void locateBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LocateUs form1 = new LocateUs();
            form1.Show();
        }
    }
}
