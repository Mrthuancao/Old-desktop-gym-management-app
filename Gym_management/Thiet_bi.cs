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
            string query = "SELECT matb as [Mã thiết bị], tenthietbi as [Tên thiết bị], soluong as [Số lượng], gia as [Giá], tenltb as [Tên loại thiết bị], ngmua as [Ngày mua], ngsd as [Ngày sử dụng], hanbaotri as [Hạn bảo trì], tenhang as [Tên hãng]  from THIETBI, LOAITHIETBI, HANG where THIETBI.maltb= LOAITHIETBI.maltb and Hang.mahang=THIETBI.mahang";
            dtgtb.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        void loadbaotri()
        {
            string query = "SELECT matb as [Mã thiết bị], ngaybaotri as [Ngày bảo trì], chiphi as [Chi phí] from dbo.BAOTRI";
            dtgbaotri.DataSource = DataProvider.Instance.ExecuteQuery(query);

        }
        int index;
        private void dtgtb_Click(object sender, EventArgs e)
        {
            index = dtgtb.CurrentRow.Index;
            
            tb_matb.Text = dtgtb.Rows[index].Cells[0].Value.ToString();
            tb_tentb.Text = dtgtb.Rows[index].Cells[1].Value.ToString();
            tb_loaitb.Text = dtgtb.Rows[index].Cells[4].Value.ToString();
            dt_ngmua.Text = dtgtb.Rows[index].Cells[5].Value.ToString();
            dt_ngsd.Text = dtgtb.Rows[index].Cells[6].Value.ToString();
            dt_hanbh.Text = dtgtb.Rows[index].Cells[7].Value.ToString();
            tb_tenhang.Text = dtgtb.Rows[index].Cells[8].Value.ToString();
        }
    }
}
   