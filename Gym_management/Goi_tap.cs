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
            string query = "SELECT magoi as [Mã gói], tengoi as [Tên gói] from dbo.GOITAP";
            DataProvider provider = new DataProvider();
            dtggoi.DataSource = provider.ExecuteQuery(query);
        }
    }
}
