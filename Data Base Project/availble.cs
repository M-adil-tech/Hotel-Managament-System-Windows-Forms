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
    public partial class availble : Form
    {
        public availble()
        {
            InitializeComponent();
        }

        SqlConnection cn;
        int id1;

        public void connections()
        {

            cn = new SqlConnection(@"Data Source=PIRACHA;Initial Catalog=Hotel_online;Integrated Security=True");
        }
        private void getstudentdata()
        {
            SqlCommand cmd = new SqlCommand("select *from reservations where Room_status='available' ", cn);
            DataTable dt = new DataTable();
            cn.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            cn.Close();
            dataGridView1.DataSource = dt;
        }

        private  void showavailableroom()
        {
            
        }
        private void Reset()
        {
            id1 = 0;
            name.Clear();
            cnic.Clear();
            person.Clear();
            din.Clear();
            dout.Clear();
            status.Clear();

        }
        private void availble_Load(object sender, EventArgs e)
        {
            connections();
            getstudentdata();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (id1 > 0)
            {

                SqlCommand cmd = new SqlCommand("UPDATE  reservations SET Room_id=@id,Client_Name=@name,Client_CNIC=@cnic,No_of_Person=@persons,date_in=@in,Date_out=@out,Room_status=@status WHERE Room_id=@id1", cn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", id.Text);
                cmd.Parameters.AddWithValue("@name", name.Text);
                cmd.Parameters.AddWithValue("@cnic", cnic.Text);
                cmd.Parameters.AddWithValue("@persons", person.Text);
                cmd.Parameters.AddWithValue("@in", din.Text);
                cmd.Parameters.AddWithValue("@out", dout.Text);
                cmd.Parameters.AddWithValue("@status", status.Text);
                cmd.Parameters.AddWithValue("@id1", this.id1);
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Updated Sucessfuly");
            }
            else
                MessageBox.Show("Please select a valid Record");
        
    }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id1 = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            name.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            cnic.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            person.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            din.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            dout.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            status.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reserve reserve = new Reserve();
            reserve.Show();
            this.Hide();
        }
    }
}
