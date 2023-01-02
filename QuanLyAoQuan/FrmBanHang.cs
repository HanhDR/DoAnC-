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
    public partial class FrmBanHang : Form
    {
        string sql1 = "Server =LAPTOP-TNBT312N ; Initial Catalog = QLAQ; User ID = sa;" + "Password = 1234";
        SqlConnection con = new SqlConnection();
        HoaDonBH hd = new HoaDonBH();
        CTBanHang ctbh = new CTBanHang();
        public FrmBanHang()
        {
            InitializeComponent();
            loadDatatoGridViewsp();
        }
        
        private void loaddulieu()
        {
            string sql = "select max(mahd) as MaHD  from HoaDonBH ;";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void themsanpham()
        {
            string sql = "insert into CTBanHang(masp,mahd,soluong) values(" + long.Parse(txtmsp.Text) + "," + txtmhd.Text + "," + long.Parse(txtsl.Text) + ")";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

        }
        private void loadsp()
        {
            string sql = "select * from LSMuaHang where mahd=" + txtmhd.Text + "";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            datahoadon.DataSource = dt;
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
        public void sum()
        {
            long tong = 0;
            for (int i = 0; i < datahoadon.Rows.Count - 1; i++)
            {
                tong += long.Parse(datahoadon[5, 0].Value.ToString());
            }
            txttong.Text = tong.ToString();
        }
        void loadDatatoGridViewsp()
        {
            datasanpham.AutoGenerateColumns = false;
            using (QLAQEntities db = new QLAQEntities())
            {
                datasanpham.DataSource = Luu.CreateDataTable<SanPham>(db.SanPhams.ToList<SanPham>());


            }
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

      

        private void btnthemkh_Click(object sender, EventArgs e)
        {

        }

        private void datasanpham_Click(object sender, EventArgs e)
        {

            int i = datasanpham.CurrentRow.Index;
            txtsp.Text = datasanpham[1, i].Value.ToString();
            txtmsp.Text = datasanpham[0, i].Value.ToString();
        }

        private void btnthemsp_Click(object sender, EventArgs e)
        {
            if (txtmkh.Text != null)
            {
                hd.makh = long.Parse(txtmkh.Text);
                hd.ngaymua = dtngaymua.Value;

                using (QLAQEntities db = new QLAQEntities())
                {
                    db.HoaDonBHs.Add(hd);
                    db.SaveChanges();
                    MessageBox.Show("Chèn thành công", "Thông báo");
                    loadDatatoGridViewsp();
                }
            }
            else
            {
                MessageBox.Show("Mã khách hàng không được để trống", "Thông Báo");
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            txtmhd.Text = dataGridView1[0, i].Value.ToString();

        }

        private void btnmhd_Click(object sender, EventArgs e)
        {
            if (txtmkh.Text != null)
            {
                ketnoicsdl();
                loaddulieu();
            }
        }

        private void btnthemsp_Click_1(object sender, EventArgs e)
        {
            ketnoicsdl();
            themsanpham();
            loadsp();
            sum();


        }

        private void btncan_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (txttensp.Text != "")
            {
                using (QLAQEntities db = new QLAQEntities())
                {
                    dataGridView1.DataSource = Luu.CreateDataTable<SanPham>(db.SanPhams.SqlQuery("select * from SanPham where tensp like N'%" +
                         txttensp.Text + "%'").ToList());
                    txttensp.Text = "";
                }
            }
            else
            {
                loadDatatoGridViewsp();
            }
        }

        private void txtsl_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnthanhtoan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanh Toán Thành Công", "Thông Báo");
        }
    }
}
