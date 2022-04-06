using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_management
{
    public partial class fmTableManager : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        public fmTableManager()
        {
            random = new Random();
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panel1.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(192, 192, 192);
                    previousBtn.ForeColor = Color.Black;
                    previousBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
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
            ActivateButton(sender);
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            OpenChildform(new Nhan_vien());
            ActivateButton(sender);

        }

        private void btnPacket_Click(object sender, EventArgs e)
        {
            OpenChildform(new Goi_tap());
            ActivateButton(sender);

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
            OpenChildform(new Thiet_bi());
            ActivateButton(sender);
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

        private void pb_phongto_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void panelBody_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelControl_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            OpenChildform(new Thong_tin());
            ActivateButton(sender);
        }

        private void btnIncome_Click_1(object sender, EventArgs e)
        {
            OpenChildform(new Doanh_thu());
            ActivateButton(sender);
        }

        private void btnReg_Click_1(object sender, EventArgs e)
        {
            OpenChildform(new Cap_TK());
            ActivateButton(sender);
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender);
            this.Close();
        }
    }
}
