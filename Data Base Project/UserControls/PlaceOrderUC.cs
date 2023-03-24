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
    public partial class PlaceOrderUC : UserControl
    {
        functions fn = new functions();
        String query;
        public PlaceOrderUC()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        // Category

        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            String categorylist = comboCategory.Text;
            query = "Select item_name from Items where category ='" + categorylist + "'";
            ItemList(query);
        }

        // items Search Box

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            String categorylist = comboCategory.Text;
            query = "Select item_name from Items where category ='" + categorylist + "' and item_name like '"+SearchBox.Text+"%'";
            ItemList(query);
        }

        // items list box

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            quantityBox.ResetText();
            TotalBox.Clear();

            String text = listBox1.GetItemText(listBox1.SelectedItem);
            ItemBox.Text = text;
            query = "Select price from Items where item_name ='" + text + "'";
            DataSet ds = fn.getData(query);


            try
            {
                PriceBox.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            catch
            { }
            
        }

        // Quantity Box shows number of items

        private void quantityBox_ValueChanged(object sender, EventArgs e)
        {
            Int64 quantity = Int64.Parse(quantityBox.Value.ToString());
            Int64 price = Int64.Parse(PriceBox.Text);
            TotalBox.Text = (quantity * price).ToString();

        }
        protected int n, total = 0;
        private void CartBtn_Click(object sender, EventArgs e)
        {
            if (TotalBox.Text != "0" && TotalBox.Text != "")  {
                n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = ItemBox.Text;
                dataGridView1.Rows[n].Cells[1].Value = PriceBox.Text;
                dataGridView1.Rows[n].Cells[2].Value = quantityBox.Text;
                dataGridView1.Rows[n].Cells[3].Value = TotalBox.Text;

                total += int.Parse(TotalBox.Text);
                totalLbl.Text = "Rs. " + total;
            }
            else
            {
                MessageBox.Show("Minimum Quantity need to be 1");
            }

        }
        int amount;
       
        // Displays all data
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                amount = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch
            { }

        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);

            }
            catch { }

            total -= amount;
            totalLbl.Text = "Rs. " + total;
        }

        private void ItemList(String query)
        {
            listBox1.Items.Clear();
            DataSet ds = fn.getData(query);
            int i;
            for (i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }
    }
}
