using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Data_Base_Project
{
    internal class functions
    { 
        protected SqlConnection connection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=PIRACHA;Initial Catalog=Hotel_online;Integrated Security=True";
            return con;
        }

        public DataSet getData(String query)
        {
            SqlConnection con = connection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;

        }
        public void setData(String query)
        {
            SqlConnection con = connection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Added ");
        }
    }
}
