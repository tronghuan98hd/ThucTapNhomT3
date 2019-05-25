namespace DLPK.Gui
{
    partial class frmBacSi
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
            this.pnl_head = new System.Windows.Forms.Panel();
            this.menu_head = new System.Windows.Forms.MenuStrip();
            this.trangChủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dànhChoBệnhNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dànhChoBácSĩToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbGiaKham = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbPhongKham = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flpTime = new System.Windows.Forms.FlowLayoutPanel();
            this.cbLichKham = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvBacSi = new System.Windows.Forms.ListView();
            this.lbMota = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnl_head.SuspendLayout();
            this.menu_head.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_head
            // 
            this.pnl_head.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnl_head.Controls.Add(this.menu_head);
            this.pnl_head.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_head.Location = new System.Drawing.Point(0, 0);
            this.pnl_head.Name = "pnl_head";
            this.pnl_head.Size = new System.Drawing.Size(811, 53);
            this.pnl_head.TabIndex = 2;
            // 
            // menu_head
            // 
            this.menu_head.Dock = System.Windows.Forms.DockStyle.None;
            this.menu_head.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChủToolStripMenuItem,
            this.dànhChoBệnhNhânToolStripMenuItem,
            this.dànhChoBácSĩToolStripMenuItem});
            this.menu_head.Location = new System.Drawing.Point(228, 9);
            this.menu_head.Name = "menu_head";
            this.menu_head.Size = new System.Drawing.Size(315, 24);
            this.menu_head.TabIndex = 0;
            this.menu_head.Text = "menuStrip1";
            // 
            // trangChủToolStripMenuItem
            // 
            this.trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            this.trangChủToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.trangChủToolStripMenuItem.Text = "Trang Chủ";
            this.trangChủToolStripMenuItem.Click += new System.EventHandler(this.trangChủToolStripMenuItem_Click);
            // 
            // dànhChoBệnhNhânToolStripMenuItem
            // 
            this.dànhChoBệnhNhânToolStripMenuItem.Name = "dànhChoBệnhNhânToolStripMenuItem";
            this.dànhChoBệnhNhânToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.dànhChoBệnhNhânToolStripMenuItem.Text = "Dành cho bệnh nhân";
            // 
            // dànhChoBácSĩToolStripMenuItem
            // 
            this.dànhChoBácSĩToolStripMenuItem.Name = "dànhChoBácSĩToolStripMenuItem";
            this.dànhChoBácSĩToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.dànhChoBácSĩToolStripMenuItem.Text = "Dành cho Bác sĩ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 62);
            this.panel1.TabIndex = 3;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(587, 21);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(201, 21);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(379, 20);
            this.txtTimKiem.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.lvBacSi);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 115);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(811, 420);
            this.panel2.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbMota);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbGiaKham);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbDiaChi);
            this.groupBox1.Controls.Add(this.lbPhongKham);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.flpTime);
            this.groupBox1.Controls.Add(this.cbLichKham);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(387, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 411);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết đặt lịch";
            // 
            // lbGiaKham
            // 
            this.lbGiaKham.AutoSize = true;
            this.lbGiaKham.Location = new System.Drawing.Point(81, 278);
            this.lbGiaKham.Name = "lbGiaKham";
            this.lbGiaKham.Size = new System.Drawing.Size(0, 13);
            this.lbGiaKham.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Giá khám";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Location = new System.Drawing.Point(81, 231);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(0, 13);
            this.lbDiaChi.TabIndex = 5;
            // 
            // lbPhongKham
            // 
            this.lbPhongKham.AutoSize = true;
            this.lbPhongKham.Location = new System.Drawing.Point(81, 197);
            this.lbPhongKham.Name = "lbPhongKham";
            this.lbPhongKham.Size = new System.Drawing.Size(0, 13);
            this.lbPhongKham.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Địa chỉ";
            // 
            // flpTime
            // 
            this.flpTime.Location = new System.Drawing.Point(26, 73);
            this.flpTime.Name = "flpTime";
            this.flpTime.Size = new System.Drawing.Size(386, 106);
            this.flpTime.TabIndex = 2;
            // 
            // cbLichKham
            // 
            this.cbLichKham.FormattingEnabled = true;
            this.cbLichKham.Location = new System.Drawing.Point(110, 28);
            this.cbLichKham.Name = "cbLichKham";
            this.cbLichKham.Size = new System.Drawing.Size(121, 21);
            this.cbLichKham.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đặt lịch khám";
            // 
            // lvBacSi
            // 
            this.lvBacSi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvBacSi.Location = new System.Drawing.Point(3, 3);
            this.lvBacSi.Name = "lvBacSi";
            this.lvBacSi.Size = new System.Drawing.Size(378, 414);
            this.lvBacSi.TabIndex = 0;
            this.lvBacSi.UseCompatibleStateImageBehavior = false;
            this.lvBacSi.View = System.Windows.Forms.View.List;
            this.lvBacSi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lsvBacSi_MouseClick);
            // 
            // lbMota
            // 
            this.lbMota.AutoSize = true;
            this.lbMota.Location = new System.Drawing.Point(81, 307);
            this.lbMota.Name = "lbMota";
            this.lbMota.Size = new System.Drawing.Size(0, 13);
            this.lbMota.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Chi tiết: ";
            // 
            // frmBacSi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 535);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_head);
            this.Name = "frmBacSi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmBacSi_Load);
            this.pnl_head.ResumeLayout(false);
            this.pnl_head.PerformLayout();
            this.menu_head.ResumeLayout(false);
            this.menu_head.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_head;
        private System.Windows.Forms.MenuStrip menu_head;
        private System.Windows.Forms.ToolStripMenuItem trangChủToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dànhChoBệnhNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dànhChoBácSĩToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lvBacSi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbGiaKham;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label lbPhongKham;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbLichKham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flpTime;
        private System.Windows.Forms.Label lbMota;
        private System.Windows.Forms.Label label5;
    }
}