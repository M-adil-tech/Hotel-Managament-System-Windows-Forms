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
    public partial class updateItemUC : UserControl
    {
        functions fn = new functions();
        String query;
        public updateItemUC()
        {
            InitializeComponent();
        }

        private void updateItemUC_Load(object sender, EventArgs e)
        {
            query = "Select * from Items";
            LoadData();
        }

        public void LoadData()
        {
            query = "Select * from items";
            DataSet ds = fn.getData(query);
            UpdatedDataGrid.DataSource = ds.Tables[0];
        }

        private void UpdateitemBox_TextChanged(object sender, EventArgs e)
        {
            query = "Select * from Items where item_name like '" + UpdateitemBox.Text + "%'";
            DataSet ds = fn.getData(query);
            UpdatedDataGrid.DataSource = ds.Tables[0];
        }

        private void UpdatedDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int id;
        private void UpdatedDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(UpdatedDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
            String category = UpdatedDataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            String name = UpdatedDataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            int price = int.Parse(UpdatedDataGrid.Rows[e.RowIndex].Cells[3].Value.ToString());

            categoryBox.Text = category;
            ItemNameBox .Text = name;
            PriceBox.Text = price.ToString();


        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            query = "Update Items set item_name = '" + ItemNameBox.Text + "',category ='" + categoryBox.Text + "',price = " + PriceBox.Text + " where id = " + id + "";
            fn.setData(query);
            LoadData();
            ItemNameBox.Clear();
            categoryBox.Clear();
            PriceBox.Clear();
        }
    }
}
