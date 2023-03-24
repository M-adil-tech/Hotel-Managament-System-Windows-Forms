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
    public partial class Cafe : Form
    {
        public Cafe()
        {
            InitializeComponent();
        }

        private void OrderBtn_Click(object sender, EventArgs e)
        {
            placeOrderUC1.Visible = true;
             placeOrderUC1.BringToFront(); 
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
             Menu mainMenu = new Menu();    
            mainMenu.Show();
            this.Hide();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            addItemUC1.Visible = true;
            addItemUC1.BringToFront();
        }

        private void Cafe_Load(object sender, EventArgs e)
        {
            addItemUC1.Visible=false;
            placeOrderUC1.Visible=false;
            updateItemUC1.Visible=false;
            deleteUC1.Visible=false;
        }

        private void placeOrderUC1_Load(object sender, EventArgs e)
        {

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            updateItemUC1.Visible = true;
            updateItemUC1.BringToFront();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            deleteUC1.Visible = true;
            deleteUC1.BringToFront();
        }
    }
}
