using Gym_management.DAO;
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

namespace Gym_management
{
    public partial class Khach_hang : Form
    {
        public Khach_hang()
        {
            InitializeComponent();
            LoadCusList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HoiVien_Input f = new HoiVien_Input();
            f.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        void LoadCusList() 
        {
            string query = "SELECT HOIVIEN.mahv as [Mã hội viên], hoten as [Họ và tên], sdt as [SDT], phai as [Giới tính], ngsinh as [Ngày sinh], ngdangki as [Ngày đăng kí], tengoi as [Tên gói], nvquanli as [Nhân viên quản lý] from HOIVIEN, DANGKY, GOITAP where HOIVIEN.mahv=DANGKY.mahv and DANGKY.magoi=GOITAP.magoi";


            dtgCus.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        int index;

        private void dtgCus_Click(object sender, EventArgs e)
        {
            index = dtgCus.CurrentRow.Index;
            tb_maHV.Text = dtgCus.Rows[index].Cells[0].Value.ToString();
            tb_hoten.Text = dtgCus.Rows[index].Cells[1].Value.ToString();
            tb_sdt.Text = dtgCus.Rows[index].Cells[2].Value.ToString();
            tb_gioitinh.Text = dtgCus.Rows[index].Cells[3].Value.ToString();
            dt_ngsinh.Text = dtgCus.Rows[index].Cells[4].Value.ToString();
            dt_ngdk.Text = dtgCus.Rows[index].Cells[5].Value.ToString();
            tb_tengt.Text = dtgCus.Rows[index].Cells[6].Value.ToString();
            tb_maPT.Text = dtgCus.Rows[index].Cells[7].Value.ToString();
        }
    }
}
