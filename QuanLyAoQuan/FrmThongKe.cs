using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyAoQuan
{
    public partial class FrmThongKe : Form
    {
        string sql1 = "Server =LAPTOP-TNBT312N ; Initial Catalog = QLAQ; User ID = sa;" + "Password = 1234";
        SqlConnection con = new SqlConnection();
        public FrmThongKe()
        {
            InitializeComponent();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void loaddulieu()
        {
            string sql = "select * from XacThucChiTiet";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
      public void sum()
        {
            long tong = 0;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                tong += long.Parse(dataGridView1[5, 0].Value.ToString());
            }
            txttong.Text = tong.ToString();
        }
        private void ketnoicsdl()
        {
            try
            {
                con = new SqlConnection(sql1);
                con.Open();
                // 
            }
            catch
            {

            }
        }

        private void FrmThongKe_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
            loaddulieu();
         
        }

        private void btnthongke_Click(object sender, EventArgs e)
        {
            if (txtnam.Text != "0" && txtthang.Text != "0" && txtngay.Text != "0")
            {
                string sql = "select * from XacThucChiTiet\r\nwhere Day(ngaymua) = "
                    + int.Parse(txtngay.Text) + "and MONTH(ngaymua) = "
                    + int.Parse(txtthang.Text) + "and Year(ngaymua) = "
                    + int.Parse(txtnam.Text);

                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (txtthang.Text != "0" && txtnam.Text != "0")
            {
                string sql = "select * from XacThucChiTiet\r\nwhere MONTH(ngaymua) = "
                    + int.Parse(txtthang.Text) + "and Year(ngaymua) = "
                    + int.Parse(txtnam.Text);

                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else
            {

                string sql = "select * from XacThucChiTiet\r\nwhere  Year(ngaymua) = " + int.Parse(txtnam.Text);
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            sum();
        }

        private void btnquaylai_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}
