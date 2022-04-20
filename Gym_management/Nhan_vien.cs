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
    public partial class Nhan_vien : Form
    {
        public Nhan_vien()
        {
            InitializeComponent();
            LoadStaffList();
        }
        void LoadStaffList()
        {
            string query = "SELECT manv as [Mã nhân viên], hoten as [Họ và tên], phai as [Giới tính], sdt as [SDT], email as [Email], ngsinh as [Ngày sinh], ngvaolam as [Ngày vào làm], luong as [Lương], tenlnv as [Vị trí] from NHANVIEN, LOAINHANVIEN where NHANVIEN.malnv=LOAINHANVIEN.malnv";

            dtgStaff.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        int index;
        private void dtgStaff_Click(object sender, EventArgs e)
        {
            index = dtgStaff.CurrentRow.Index;
            tb_manv.Text = dtgStaff.Rows[index].Cells[0].Value.ToString();
            tb_hoten.Text = dtgStaff.Rows[index].Cells[1].Value.ToString();
            tb_goitinh.Text = dtgStaff.Rows[index].Cells[2].Value.ToString();
            tb_Sdt.Text = dtgStaff.Rows[index].Cells[3].Value.ToString();
            tb_email.Text = dtgStaff.Rows[index].Cells[4].Value.ToString();
            dt_ngaysinh.Text = dtgStaff.Rows[index].Cells[5].Value.ToString();
            dt_ngaybd.Text = dtgStaff.Rows[index].Cells[6].Value.ToString();
            tb_luong.Text = dtgStaff.Rows[index].Cells[7].Value.ToString();
            tb_vitri.Text = dtgStaff.Rows[index].Cells[8].Value.ToString();

        }
    }
}
