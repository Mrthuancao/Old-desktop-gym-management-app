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
            string query = "SELECT matk as [Mã tài khoản], username as [Tên tài khoản], manv as [Mã nhân viên QL] from dbo.TAIKHOAN";

            dtgAccList.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
