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
    public partial class FrmNVDN : Form
    {
        public FrmNVDN()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            using (QLAQEntities db = new QLAQEntities())
            {
                string s = "select * from NhanVien where convert(varchar(100),DecryptByPassPhrase('aaa',pass))='" +
                    txtpassword.Text + "'and tendn='" + txtusername.Text + "'";
                var list = db.NhanViens.SqlQuery(s).ToList();
                if (list.Count > 0)
                {
                    MessageBox.Show("Dăng Nhập Thành Công!", "Thông Báo");
                    Close();
                    FrmBanHang f = new FrmBanHang();
                    f.Show();
                   
                }
                else
                {
                    MessageBox.Show("Username or Password sai!", "Thông Báo");
                }
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
