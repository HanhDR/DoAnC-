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
    public partial class FrmLoai : Form
    {
        int ID;
        Loai model = new Loai();
        public FrmLoai()
        {
            InitializeComponent();
            loadDatatoGridView();
        }
        void lock_unlock(bool kt)
        {
           btnadd.Enabled = kt;
           btndelete.Enabled = btnup.Enabled=!kt;
        }
        void loadDatatoGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            using (QLAQEntities db = new QLAQEntities())
            {
                dataGridView1.DataSource = Luu.CreateDataTable<Loai>(db.Loais.ToList<Loai>());


            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;       
            txtml.Text = dataGridView1[1,i].Value.ToString();
            txttl.Text = dataGridView1[2, i].Value.ToString();
            btndelete.Enabled = btnup.Enabled = true;
            btnadd.Enabled = false;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            model .maloai=txtml.Text;
            model.tenloai=txttl.Text;
            using (QLAQEntities db = new QLAQEntities())
            {
                db.Loais.Add(model);
                db.SaveChanges();
                MessageBox.Show("Chèn thành công", "Thông báo");
                txttl.Text = "";
                txtml.Text = "";
                loadDatatoGridView();
            }

        }

        private void btnup_Click(object sender, EventArgs e)
        {
            model.maloai = txtml.Text;
            model.tenloai = txttl.Text;
            using (QLAQEntities db = new QLAQEntities())
            {
                db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                MessageBox.Show("Update thành công", "Thông báo");
                txttl.Text = "";
                txtml.Text = "";
                btndelete.Enabled = btnup.Enabled = false;
                btnadd.Enabled = true;
                loadDatatoGridView();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            model.maloai = txtml.Text;
            model.tenloai = txttl.Text;
            using (QLAQEntities db = new QLAQEntities())
            {
                db.Entry(model).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
                MessageBox.Show("Delete thành công", "Thông báo");
                txttl.Text = "";
                txtml.Text = "";
                btndelete.Enabled = btnup.Enabled = false;
                btnadd.Enabled = true;
                loadDatatoGridView();
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtml.Text = "";
            txttl.Text = "";
            btnup.Enabled = btndelete.Enabled= false;
            btnadd.Enabled= true;
            
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {

            if (txttl.Text != "")
            {
                using (QLAQEntities db = new QLAQEntities())
                {
                    dataGridView1.DataSource = Luu.CreateDataTable<SanPham>(db.SanPhams.SqlQuery("select * from loai where tenloai like N'%" +
                         txttl.Text + "%'").ToList());
                    txttl.Text = "";
                    txtml.Text = "";
                }
            }
            else
            {
                loadDatatoGridView();
            }
        }
    }
}
