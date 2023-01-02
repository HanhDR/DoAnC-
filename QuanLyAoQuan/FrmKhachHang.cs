using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyAoQuan
{
    public partial class FrmKhachHang : Form
    {
        KhachHang model = new KhachHang();
        public FrmKhachHang()
        {
            InitializeComponent();
            loadDatatoGridView();
        }
        void lock_unlock(bool kt)
        {
            btnadd.Enabled = kt;
            btndelete.Enabled = btnup.Enabled = !kt;
        }
        void loadDatatoGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            using (QLAQEntities db = new QLAQEntities())
            {
                dataGridView1.DataSource = Luu.CreateDataTable<KhachHang>(db.KhachHangs.ToList<KhachHang>());


            }
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn thoát", "Thông báo");
            Close();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (txtht.Text != "")
            {
                using (QLAQEntities db = new QLAQEntities())
                {
                    dataGridView1.DataSource = Luu.CreateDataTable<KhachHang>(db.KhachHangs.SqlQuery("select * from KhachHang where tenkh like N'%" +
                         txtht.Text + "%'").ToList());
                    txtht.Text = "";
                }
            }
            else
            {
                loadDatatoGridView();
            }

        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtht.Text = "";
            txtdiachi.Text = "";
            txtemail.Text = "";
            txtmkh.Text = "";
            txtsdt.Text = "";
            
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            txtmkh.Text = dataGridView1[0, i].Value.ToString();
            txtht.Text = dataGridView1[1, i].Value.ToString();
            txtsdt.Text = dataGridView1[2, i].Value.ToString();
            txtdiachi.Text = dataGridView1[3, i].Value.ToString();
            txtemail.Text = dataGridView1[4, i].Value.ToString();
            btnadd.Enabled = false;
            btndelete.Enabled = btnup.Enabled = true;

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            model.makh = long.Parse(txtmkh.Text);
            model.tenkh = txtht.Text;
            model.sdt = txtsdt.Text;
            model.email=txtemail.Text;
           
            using (QLAQEntities db = new QLAQEntities())
            {
                db.Entry(model).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
                MessageBox.Show("Delete thành công", "Thông báo");
                txtmkh.Text = "";
                txtht.Text = "";
                txtemail.Text = "";
                txtdiachi.Text = "";
                btnadd.Enabled = true;
                btndelete.Enabled = btnup.Enabled = false;
                loadDatatoGridView();
            }

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
           
            model.tenkh = txtht.Text;
            model.sdt = txtsdt.Text;
            model.email = txtemail.Text;
            model.diachi = txtdiachi.Text;
            using (QLAQEntities db = new QLAQEntities())
            {
               db.KhachHangs.Add(model);
                db.SaveChanges();
                MessageBox.Show("Add thành công", "Thông báo");
                txtmkh.Text = "";
                txtht.Text = "";
                txtemail.Text = "";
                txtdiachi.Text = "";
                loadDatatoGridView();

            }
        }

        private void btnup_Click(object sender, EventArgs e)
        {

            model.makh = long.Parse(txtmkh.Text);
            model.tenkh = txtht.Text;
            model.sdt = txtsdt.Text;
            model.email = txtemail.Text;
            model.diachi = txtdiachi.Text;
            using (QLAQEntities db = new QLAQEntities())
            {
                db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                MessageBox.Show("Update thành công", "Thông báo");
                txtmkh.Text = "";
                txtht.Text = "";
                txtemail.Text = "";
                txtdiachi.Text = "";
                btnadd.Enabled = true;
                btndelete.Enabled = btnup.Enabled = false;
                loadDatatoGridView();
            }
        }
    }
}
