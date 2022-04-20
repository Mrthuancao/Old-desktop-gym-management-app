using Gym_management.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_management
{
    public partial class Cap_TK : Form
    {
        public Cap_TK()
        {
            InitializeComponent();
            LoadAccStaffList();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btt_ctk_Click(object sender, EventArgs e)
        {
            CapTaiKhoan ctk= new CapTaiKhoan();
            ctk.ShowDialog();
            this.Show();
        }
        void LoadAccStaffList()
        {
            string query = "SELECT matk as [Mã tài khoản], username as [Tên tài khoản], TAIKHOAN.manv as [Mã nhân viên], hoten as [Tên nhân viên], pass as [Mật khẩu], email as [Email], sdt as [Số điện thoại] from TAIKHOAN, NHANVIEN where TAIKHOAN.manv=NHANVIEN.manv";

            dtgAccList.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        int index;

        private void dtgAccList_Click(object sender, EventArgs e)
        {
            index = dtgAccList.CurrentRow.Index;
            tb_tenNv.Text = dtgAccList.Rows[index].Cells[3].Value.ToString();
            tb_user.Text = dtgAccList.Rows[index].Cells[1].Value.ToString();
            tb_pass.Text = dtgAccList.Rows[index].Cells[4].Value.ToString();
            tb_email.Text = dtgAccList.Rows[index].Cells[5].Value.ToString();
            tb_sdt.Text = dtgAccList.Rows[index].Cells[6].Value.ToString();
        }
    }
}
