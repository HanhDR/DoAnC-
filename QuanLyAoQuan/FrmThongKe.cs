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
        private void sum()
        {
            string sql = "select Sum(ThanhTien) as TongTien  from XacThucChiTiet";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
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
            sum();
        }
    }

}
