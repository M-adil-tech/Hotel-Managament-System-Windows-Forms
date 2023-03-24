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
    public partial class DeleteUC : UserControl
    {
        functions fn = new functions();
        String query;
        public DeleteUC()
        {
            InitializeComponent();
        }

        private void DeleteUC_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {

            query = "Select * from items";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void SearchBox_TextChanged_1(object sender, EventArgs e)
        {
            query = "Select * from Items where item_name like '" + SearchBox.Text + "%'";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(MessageBox.Show("Delete item?","Important Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                query = "Delete from items where id = " + id + "";
                fn.setData(query);
                LoadData();
            }
        }

        private void DeleteUC_Enter(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
