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
    public partial class Goi_tap : Form
    {
        public Goi_tap()
        {
            InitializeComponent();
            LoadGoi();
        }
        void LoadGoi()
        { 
            string query = "SELECT magoi as [Mã gói], tengoi as [Tên gói], giamoithang as [Giá], coPT as [Có PT] from dbo.GOITAP";
            dtggoi.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        int index;
        private void dtggoi_Click(object sender, EventArgs e)
        {
            index = dtggoi.CurrentRow.Index;
            tb_magoi.Text = dtggoi.Rows[index].Cells[0].Value.ToString();
            tb_tengoi.Text = dtggoi.Rows[index].Cells[1].Value.ToString();
            tb_giamt.Text = dtggoi.Rows[index].Cells[2].Value.ToString();
            tb_coPT.Text = dtggoi.Rows[index].Cells[3].Value.ToString();

        }
    }
}
