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
    public partial class Thiet_bi : Form
    {
        public Thiet_bi()
        {
            InitializeComponent();
            loadthietbi();
            loadbaotri();
        }

        private void Thiet_bi_Load(object sender, EventArgs e)
        {

        }

        private void lblMem_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lbName_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
        void loadthietbi()
        {
            string query = "SELECT matb as [Mã thiết bị], tenthietbi as [Tên thiết bị], soluong as [Số lượng], gia as [Giá], tenltb as [Tên loại thiết bị] from THIETBI, LOAITHIETBI where THIETBI.maltb= LOAITHIETBI.maltb";
            dtgtb.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        void loadbaotri()
        {
            string query = "SELECT matb as [Mã thiết bị], ngaybaotri as [Ngày bảo trì], chiphi as [Chi phí] from dbo.BAOTRI";
            dtgbaotri.DataSource = DataProvider.Instance.ExecuteQuery(query);

        }
    }
}
   