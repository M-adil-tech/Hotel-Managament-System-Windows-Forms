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
    public partial class LocateUs : Form
    {
        public LocateUs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu mainMenu = new Menu();
            mainMenu.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

            //Faisalabad
            string Faisalabad = "serena hotels faisalabad";

            StringBuilder location = new StringBuilder();
            location.Append("https://www.google.com/maps/d/viewer?mid=10K9ZDPjrrBM89g9R4f9EKgN6RuI&ll=31.40818521953245%2C73.1388953262981&z=13");

            if (Faisalabad != " ")
            {
                location.Append(Faisalabad + "," + "+");
            }
            webBrowser1.Navigate(location.ToString());

        }

        private void lahore_Click(object sender, EventArgs e)
        {

            //Lahore
            string Lahore = "serena hotels Lahore";

            StringBuilder location = new StringBuilder();
            location.Append("https://www.google.co.in/maps/place/Lahore+City,+Lahore,+Punjab,+Pakistan/@31.4623897,73.9211319,10z/data=!3m1!4b1!4m5!3m4!1s0x3918fde40e954753:0xb8ea639d79127a78!8m2!3d31.4329663!4d74.1944529");

            if (Lahore != " ")
            {
                location.Append(Lahore + "," + "+");
            }
            webBrowser1.Navigate(location.ToString());

        }

        private void Islamabad_Click(object sender, EventArgs e)
        {
            //Islamalabad
            string Islamabad = "serena hotels Islamabad";

            StringBuilder location = new StringBuilder();
            location.Append("https://www.google.com/maps/d/viewer?mid=1_wV22amgac2Wt4gvMqstKu57Fg0&ll=33.692924000000005%2C73.05702200000002&z=17");

            if (Islamabad != " ")
            {
                location.Append(Islamabad + "," + "+");
            }
            webBrowser1.Navigate(location.ToString());

        }
    }
}
