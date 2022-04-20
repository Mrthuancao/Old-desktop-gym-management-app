
namespace Gym_management
{
    partial class Cap_TK
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpListAcc = new System.Windows.Forms.TabPage();
            this.btt_ctk = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDelAcc = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_sdt = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblMem = new System.Windows.Forms.Label();
            this.tb_tenNv = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbName = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgAccList = new System.Windows.Forms.DataGridView();
            this.matk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tbpListAcc.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAccList)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpListAcc);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(916, 495);
            this.tabControl1.TabIndex = 0;
            // 
            // tbpListAcc
            // 
            this.tbpListAcc.Controls.Add(this.btt_ctk);
            this.tbpListAcc.Controls.Add(this.panel3);
            this.tbpListAcc.Controls.Add(this.panel2);
            this.tbpListAcc.Controls.Add(this.panel1);
            this.tbpListAcc.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpListAcc.Location = new System.Drawing.Point(4, 22);
            this.tbpListAcc.Name = "tbpListAcc";
            this.tbpListAcc.Padding = new System.Windows.Forms.Padding(3);
            this.tbpListAcc.Size = new System.Drawing.Size(908, 469);
            this.tbpListAcc.TabIndex = 0;
            this.tbpListAcc.Text = "DS tài khoản";
            this.tbpListAcc.UseVisualStyleBackColor = true;
            // 
            // btt_ctk
            // 
            this.btt_ctk.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_ctk.ForeColor = System.Drawing.Color.DimGray;
            this.btt_ctk.Location = new System.Drawing.Point(640, 397);
            this.btt_ctk.Name = "btt_ctk";
            this.btt_ctk.Size = new System.Drawing.Size(101, 44);
            this.btt_ctk.TabIndex = 9;
            this.btt_ctk.Text = "Cấp TK";
            this.btt_ctk.UseVisualStyleBackColor = true;
            this.btt_ctk.Click += new System.EventHandler(this.btt_ctk_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnDelAcc);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(476, 111);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(425, 270);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnDelAcc
            // 
            this.btnDelAcc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelAcc.ForeColor = System.Drawing.Color.DimGray;
            this.btnDelAcc.Location = new System.Drawing.Point(163, 217);
            this.btnDelAcc.Name = "btnDelAcc";
            this.btnDelAcc.Size = new System.Drawing.Size(101, 44);
            this.btnDelAcc.TabIndex = 8;
            this.btnDelAcc.Text = "Xóa TK";
            this.btnDelAcc.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label4);
            this.panel8.Controls.Add(this.tb_sdt);
            this.panel8.Location = new System.Drawing.Point(17, 166);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(388, 33);
            this.panel8.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(3, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "SDT";
            // 
            // tb_sdt
            // 
            this.tb_sdt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tb_sdt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_sdt.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sdt.Location = new System.Drawing.Point(110, 3);
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.ReadOnly = true;
            this.tb_sdt.Size = new System.Drawing.Size(274, 27);
            this.tb_sdt.TabIndex = 7;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.tb_email);
            this.panel7.Location = new System.Drawing.Point(17, 127);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(388, 33);
            this.panel7.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Email";
            // 
            // tb_email
            // 
            this.tb_email.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tb_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_email.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email.Location = new System.Drawing.Point(110, 3);
            this.tb_email.Name = "tb_email";
            this.tb_email.ReadOnly = true;
            this.tb_email.Size = new System.Drawing.Size(274, 27);
            this.tb_email.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.tb_pass);
            this.panel6.Location = new System.Drawing.Point(17, 88);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(388, 33);
            this.panel6.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mật khẩu";
            // 
            // tb_pass
            // 
            this.tb_pass.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tb_pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_pass.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pass.Location = new System.Drawing.Point(110, 3);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.ReadOnly = true;
            this.tb_pass.Size = new System.Drawing.Size(274, 27);
            this.tb_pass.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.tb_user);
            this.panel4.Location = new System.Drawing.Point(17, 49);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(388, 33);
            this.panel4.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "User Name";
            // 
            // tb_user
            // 
            this.tb_user.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tb_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_user.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_user.Location = new System.Drawing.Point(110, 3);
            this.tb_user.Name = "tb_user";
            this.tb_user.ReadOnly = true;
            this.tb_user.Size = new System.Drawing.Size(274, 27);
            this.tb_user.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblMem);
            this.panel5.Controls.Add(this.tb_tenNv);
            this.panel5.Location = new System.Drawing.Point(17, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(388, 33);
            this.panel5.TabIndex = 2;
            // 
            // lblMem
            // 
            this.lblMem.AutoSize = true;
            this.lblMem.BackColor = System.Drawing.Color.Transparent;
            this.lblMem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMem.Location = new System.Drawing.Point(3, 6);
            this.lblMem.Name = "lblMem";
            this.lblMem.Size = new System.Drawing.Size(70, 22);
            this.lblMem.TabIndex = 10;
            this.lblMem.Text = "Tên Nv";
            // 
            // tb_tenNv
            // 
            this.tb_tenNv.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tb_tenNv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_tenNv.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tenNv.Location = new System.Drawing.Point(110, 3);
            this.tb_tenNv.Name = "tb_tenNv";
            this.tb_tenNv.ReadOnly = true;
            this.tb_tenNv.Size = new System.Drawing.Size(274, 27);
            this.tb_tenNv.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbName);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Location = new System.Drawing.Point(476, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(425, 38);
            this.panel2.TabIndex = 1;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbName.Location = new System.Drawing.Point(1, 7);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(42, 22);
            this.lbName.TabIndex = 9;
            this.lbName.Text = "Tên";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(49, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(279, 27);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.DimGray;
            this.btnSearch.Location = new System.Drawing.Point(334, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 34);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgAccList);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 457);
            this.panel1.TabIndex = 0;
            // 
            // dtgAccList
            // 
            this.dtgAccList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAccList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matk,
            this.username,
            this.manv,
            this.hoten,
            this.pass,
            this.email,
            this.luong});
            this.dtgAccList.Location = new System.Drawing.Point(2, 3);
            this.dtgAccList.Name = "dtgAccList";
            this.dtgAccList.Size = new System.Drawing.Size(459, 451);
            this.dtgAccList.TabIndex = 0;
            this.dtgAccList.Click += new System.EventHandler(this.dtgAccList_Click);
            // 
            // matk
            // 
            this.matk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.matk.DataPropertyName = "Mã tài khoản";
            this.matk.HeaderText = "Mã tài khoản";
            this.matk.Name = "matk";
            this.matk.ReadOnly = true;
            this.matk.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // username
            // 
            this.username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.username.DataPropertyName = "Tên tài khoản";
            this.username.HeaderText = "Tên tài khoản";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            this.username.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // manv
            // 
            this.manv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.manv.DataPropertyName = "Mã nhân viên";
            this.manv.HeaderText = "Mã nhân viên";
            this.manv.Name = "manv";
            this.manv.ReadOnly = true;
            this.manv.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // hoten
            // 
            this.hoten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hoten.DataPropertyName = "Tên nhân viên";
            this.hoten.HeaderText = "Tên nhân viên";
            this.hoten.Name = "hoten";
            this.hoten.Visible = false;
            // 
            // pass
            // 
            this.pass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pass.DataPropertyName = "Mật khẩu";
            this.pass.HeaderText = "Mật khẩu";
            this.pass.Name = "pass";
            this.pass.Visible = false;
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.email.DataPropertyName = "Email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.Visible = false;
            // 
            // luong
            // 
            this.luong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.luong.DataPropertyName = "Số điện thoại";
            this.luong.HeaderText = "Số điện thoại";
            this.luong.Name = "luong";
            this.luong.Visible = false;
            // 
            // Cap_TK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(918, 497);
            this.Controls.Add(this.tabControl1);
            this.Name = "Cap_TK";
            this.Text = "Cap_TK";
            this.tabControl1.ResumeLayout(false);
            this.tbpListAcc.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAccList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpListAcc;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgAccList;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_sdt;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblMem;
        private System.Windows.Forms.TextBox tb_tenNv;
        private System.Windows.Forms.Button btnDelAcc;
        private System.Windows.Forms.Button btt_ctk;
        private System.Windows.Forms.DataGridViewTextBoxColumn matk;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn pass;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn luong;
    }
}