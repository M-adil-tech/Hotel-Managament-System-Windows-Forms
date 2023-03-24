using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Base_Project.UserControls
{
    public partial class AddItemUC : UserControl
    {
        functions fn = new functions();
        string query;
        public AddItemUC()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddItemUC_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            query = "insert into Items (item_name,category,price) values ('" + itemBox.Text + "','" + CategoryBox.Text + "','" + PriceBox.Text + "')";
            fn.setData(query);
            clearAll();
        }
        public void clearAll()
        {
            CategoryBox.SelectedIndex = -1;
            itemBox.Clear();
            PriceBox.Clear();
        }
    }
}
