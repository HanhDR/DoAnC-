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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
            lock_unlock(Luu.KT);
            
        }
        void lock_unlock(bool kt)
        {
            mnudangnhap.Enabled = mnuthoat.Enabled = kt;
            mnudangxuat.Enabled = mnutracuu.Enabled = mnudanhmuc.Enabled = mnubanhang.Enabled = mnuthongke.Enabled=!kt;
        }



        private void mnudangnhap_Click(object sender, EventArgs e)
        {
            FrmLogin f = new FrmLogin();
            f.Show();
        }

        private void mnudanhmucloai_Click(object sender, EventArgs e)
        {
            FrmLoai f = new FrmLoai();
            f.Show();
        }

        private void mnudanhmucsp_Click(object sender, EventArgs e)
        {
            FrmDanhSachSanPham f = new FrmDanhSachSanPham();
            f.Show();
        }

        private void FrmAdmin_Activated(object sender, EventArgs e)
        {
           lock_unlock(Luu.KT);
        }

        private void mnudanhmuckh_Click(object sender, EventArgs e)
        {

        }

        private void mnutracuuhoadon_Click(object sender, EventArgs e)
        {
            FrmKhachHang f = new FrmKhachHang();
            f.Show();
            lock_unlock(!Luu.KT);
        }

        private void mnudanhmuc_Click(object sender, EventArgs e)
        {

        }

        private void mnukhachhang_Click(object sender, EventArgs e)
        {
            FrmKhachHang f = new FrmKhachHang();
            f.Show();
        }

        private void mnudangxuat_Click(object sender, EventArgs e)
        {


            this.Close();
            FrmAdmin f = new FrmAdmin();
            f.Show();
       

        }

        private void mnuthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {

        }

        private void hóaĐơnBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHoaDonBH f =new FrmHoaDonBH();
            f.Show();
        }

        private void mnuthongke_Click(object sender, EventArgs e)
        {
            FrmThongKe f = new FrmThongKe();
            f.Show();
        }

        private void mnubaocao_Click(object sender, EventArgs e)
        {
            FrmBanHang f = new FrmBanHang();
            f.Show();
        }
    }
}
