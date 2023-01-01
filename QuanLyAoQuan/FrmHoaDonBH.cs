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

   
    public partial class FrmHoaDonBH : Form
    {
        string sql1 = "Server =LAPTOP-TNBT312N ; Initial Catalog = QLAQ; User ID = sa;" + "Password = 1234";
        SqlConnection con = new SqlConnection();
        public FrmHoaDonBH()
        {
            InitializeComponent();
        }

        private void loaddulieu()
        {
            string sql = "select * from XacThucChiTiet";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void tim()
        {
            int nam = dateTimePicker1.Value.Year;
            int thang = dateTimePicker1.Value.Month;
            int ngay = dateTimePicker1.Value.Day;


            string sql = "select * from XacThucChiTiet where ngaymua between'"
                      + thang + '/' + ngay + '/' + nam + "' and'" + thang + '/' + ngay + '/' + nam + "'";

            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

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

        private void btnsearch_Click(object sender, EventArgs e)
        {
            ketnoicsdl();
            tim();
        }

        private void btnquay_Click(object sender, EventArgs e)
        {
            ketnoicsdl();
            loaddulieu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
