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

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        void LoadCusList() 
        {
            string query = "SELECT mahv as [Mã hội viên], hoten as [Họ và tên], sdt as [SDT], phai as [Giới tính] from dbo.HOIVIEN";

            DataProvider provider = new DataProvider();

            dtgCus.DataSource = provider.ExecuteQuery(query);
        }
    }
}
