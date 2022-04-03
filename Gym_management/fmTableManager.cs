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
    public partial class fmTableManager : Form
    {
        public fmTableManager()
        {
            InitializeComponent();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minibtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private Form currentFormChild;
        
        private void OpenChildform(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }    
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelBody.Controls.Add(childForm);
            panelBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
            

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            OpenChildform(new Khach_hang());
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            OpenChildform(new Nhan_vien());

        }

        private void btnPacket_Click(object sender, EventArgs e)
        {
            OpenChildform(new Goi_tap());

        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            OpenChildform(new Doanh_thu());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildform(new Thong_tin());

        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            OpenChildform(new Cap_TK());

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Logo_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildform(new Thiet_bic());
        }

        private void fmTableManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("You want to log out?", "Notification", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        int x;
        private void timer1_Tick(object sender, EventArgs e)
        {
            x = slogan.Location.X;
            x--;
            slogan.Location=new Point(x, slogan.Location.Y);
            if (x<-233)
            {
                fmTableManager tb=new fmTableManager();
                x = tb.Size.Width;
                slogan.Location= new Point(tb.Size.Width, slogan.Location.Y);
            }
        }
    }
}
