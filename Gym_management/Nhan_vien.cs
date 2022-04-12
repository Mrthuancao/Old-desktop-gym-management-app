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
            string query = "SELECT manv as [Mã nhân viên], hoten as [Họ và tên], phai as [Giới tính], sdt as [SDT], email as [Email] from dbo.NHANVIEN";

            dtgStaff.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
