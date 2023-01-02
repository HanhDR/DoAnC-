using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyAoQuan
{
    public partial class FrmDanhSachSanPham : Form
    {
        SanPham model = new SanPham();
        public FrmDanhSachSanPham()
        {
            InitializeComponent();
            loadDatatoGridView();
            loadDatatoCBBox();
            lock_unlock(Luu.KT);
            
        }

        void lock_unlock(bool kt)
        {
            
            btnadd.Enabled = btncancel.Enabled =! kt;
            btndelete.Enabled = btnup.Enabled = kt;
        }
        void loadDatatoGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            using ( QLAQEntities db = new QLAQEntities())
            {
                dataGridView1.DataSource = Luu.CreateDataTable<SanPham>(db.SanPhams.ToList<SanPham>());


            }
        }
        void loadDatatoCBBox()
        {
            using (QLAQEntities db = new QLAQEntities())
            {
                var loai = db.Loais.ToList<Loai>();
                foreach (var item in loai)
                {
                    cmbml.Items.Add(item.maloai);
                    

                }
            }
        }
      

     

     

     
        private void FrmDanhSachSanPham_Load(object sender, EventArgs e)
        {

        }

      

   
     

       

     
       

        private void btnsearch_Click_1(object sender, EventArgs e)
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
                loadDatatoGridView();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn ảnh minh hoạ cho sản phẩm";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(dlgOpen.FileName);
                txtanh.Text = dlgOpen.FileName;
            }
        }

        private void btnadd_Click_1(object sender, EventArgs e)
        {
            model.tensp = txttensp.Text;
            model.maloai = cmbml.SelectedItem.ToString();
            model.gia = long.Parse(txtgia.Text);
            model.tonkho = int.Parse(txttonkho.Text);
            model.anh = txtanh.Text;
            using (QLAQEntities db = new QLAQEntities())
            {
                db.SanPhams.Add(model);
                db.SaveChanges();
                MessageBox.Show("Chèn thành công", "Thông báo");
                txttensp.Text = "";
                cmbml.Text = "";
                txttonkho.Text = "";
                txtanh.Text = "";
                txtgia.Text = "";
              
                pictureBox1.Image = null;
                loadDatatoGridView();
            }
        }

        private void btnup_Click_1(object sender, EventArgs e)
        {
            model.masp = long.Parse(txtmasp.Text);
            model.tensp = txttensp.Text;
            model.maloai = cmbml.SelectedItem.ToString();
            model.gia = long.Parse(txtgia.Text);
            model.tonkho = int.Parse(txttonkho.Text);
            model.anh = txtanh.Text;
            using (QLAQEntities db = new QLAQEntities())
            {
                db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                MessageBox.Show("Update thành công", "Thông báo");
                txttensp.Text = "";
                cmbml.Text = "";
                txttonkho.Text = "";
                txtanh.Text = "";
                txtgia.Text = "";
                txtmasp.Text = "";
                pictureBox1.Image = null;
                btnadd.Enabled = btncancel.Enabled = true;
                btndelete.Enabled = btnup.Enabled = false;
                loadDatatoGridView();
            }
        }

        private void btndelete_Click_1(object sender, EventArgs e)
        {
            model.masp = long.Parse(txtmasp.Text);
            model.tensp = txttensp.Text;
            model.maloai = cmbml.SelectedItem.ToString();
            model.gia = long.Parse(txtgia.Text);
            model.tonkho = int.Parse(txttonkho.Text);
            model.anh = txtanh.Text;
            using (QLAQEntities db = new QLAQEntities())
            {
                db.Entry(model).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
                MessageBox.Show("Delete thành công", "Thông báo");
                txttensp.Text = "";
                cmbml.Text = "";
                txttonkho.Text = "";
                txtanh.Text = "";
                txtgia.Text = "";
                txtmasp.Text = "";
                pictureBox1.Image = null;
                btnadd.Enabled = btncancel.Enabled = true;
                btndelete.Enabled = btnup.Enabled = false;
                loadDatatoGridView();
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn thoát", "Thông báo");
            Close();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtmasp.Text = "";
            txttensp.Text = "";
            cmbml.Text = "";
            txttonkho.Text = "";
            txtanh.Text = "";
            txtgia.Text = "";
            pictureBox1.Image = null;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            txtmasp.Text = dataGridView1[1, i].Value.ToString();
            txttensp.Text = dataGridView1[2, i].Value.ToString();
            txttonkho.Text = dataGridView1[3, i].Value.ToString();
            txtgia.Text = dataGridView1[4, i].Value.ToString();
            cmbml.Text = dataGridView1[5, i].Value.ToString();
            txtanh.Text = dataGridView1[6, i].Value.ToString();
            pictureBox1.Image = Image.FromFile(txtanh.Text);
            btndelete.Enabled = btnup.Enabled = true;
            btnadd.Enabled = false;
        }
    }
}
