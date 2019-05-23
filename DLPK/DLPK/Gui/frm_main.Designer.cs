namespace DLPK
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_gktq = new System.Windows.Forms.Button();
            this.btn_bvpk = new System.Windows.Forms.Button();
            this.btn_bs = new System.Windows.Forms.Button();
            this.btn_ck = new System.Windows.Forms.Button();
            this.pnl_head = new System.Windows.Forms.Panel();
            this.menu_head = new System.Windows.Forms.MenuStrip();
            this.trangChủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dànhChoBệnhNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dànhChoBácSĩToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3.SuspendLayout();
            this.pnl_head.SuspendLayout();
            this.menu_head.SuspendLayout();
            this.SuspendLayout();
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.Location = new System.Drawing.Point(782, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(18, 450);
            this.vScrollBar1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.panel3.Controls.Add(this.pnl_head);
            this.panel3.Controls.Add(this.btn_gktq);
            this.panel3.Controls.Add(this.btn_bvpk);
            this.panel3.Controls.Add(this.btn_bs);
            this.panel3.Controls.Add(this.btn_ck);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(782, 450);
            this.panel3.TabIndex = 5;
            // 
            // btn_gktq
            // 
            this.btn_gktq.Location = new System.Drawing.Point(609, 282);
            this.btn_gktq.Name = "btn_gktq";
            this.btn_gktq.Size = new System.Drawing.Size(119, 108);
            this.btn_gktq.TabIndex = 0;
            this.btn_gktq.Text = "Chọn gói khám tổng quát";
            this.btn_gktq.UseVisualStyleBackColor = true;
            // 
            // btn_bvpk
            // 
            this.btn_bvpk.Location = new System.Drawing.Point(239, 282);
            this.btn_bvpk.Name = "btn_bvpk";
            this.btn_bvpk.Size = new System.Drawing.Size(119, 108);
            this.btn_bvpk.TabIndex = 0;
            this.btn_bvpk.Text = "Chọn Bệnh viện, Phòng khám";
            this.btn_bvpk.UseVisualStyleBackColor = true;
            // 
            // btn_bs
            // 
            this.btn_bs.Location = new System.Drawing.Point(420, 282);
            this.btn_bs.Name = "btn_bs";
            this.btn_bs.Size = new System.Drawing.Size(119, 108);
            this.btn_bs.TabIndex = 0;
            this.btn_bs.Text = "Chọn Bác sĩ";
            this.btn_bs.UseVisualStyleBackColor = true;
            this.btn_bs.Click += new System.EventHandler(this.btn_bs_Click);
            // 
            // btn_ck
            // 
            this.btn_ck.AutoSize = true;
            this.btn_ck.Location = new System.Drawing.Point(58, 282);
            this.btn_ck.Name = "btn_ck";
            this.btn_ck.Size = new System.Drawing.Size(119, 108);
            this.btn_ck.TabIndex = 0;
            this.btn_ck.Text = "Chọn Chuyên Khoa";
            this.btn_ck.UseVisualStyleBackColor = true;
            this.btn_ck.Click += new System.EventHandler(this.btn_ck_Click);
            // 
            // pnl_head
            // 
            this.pnl_head.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnl_head.Controls.Add(this.menu_head);
            this.pnl_head.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_head.Location = new System.Drawing.Point(0, 0);
            this.pnl_head.Name = "pnl_head";
            this.pnl_head.Size = new System.Drawing.Size(782, 53);
            this.pnl_head.TabIndex = 1;
            // 
            // menu_head
            // 
            this.menu_head.Dock = System.Windows.Forms.DockStyle.None;
            this.menu_head.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChủToolStripMenuItem,
            this.dànhChoBệnhNhânToolStripMenuItem,
            this.dànhChoBácSĩToolStripMenuItem});
            this.menu_head.Location = new System.Drawing.Point(234, 9);
            this.menu_head.Name = "menu_head";
            this.menu_head.Size = new System.Drawing.Size(435, 24);
            this.menu_head.TabIndex = 0;
            this.menu_head.Text = "menuStrip1";
            // 
            // trangChủToolStripMenuItem
            // 
            this.trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            this.trangChủToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.trangChủToolStripMenuItem.Text = "Trang Chủ";
            // 
            // dànhChoBệnhNhânToolStripMenuItem
            // 
            this.dànhChoBệnhNhânToolStripMenuItem.Name = "dànhChoBệnhNhânToolStripMenuItem";
            this.dànhChoBệnhNhânToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.dànhChoBệnhNhânToolStripMenuItem.Text = "Dành cho bệnh nhân";
            this.dànhChoBệnhNhânToolStripMenuItem.Click += new System.EventHandler(this.dànhChoBệnhNhânToolStripMenuItem_Click);
            // 
            // dànhChoBácSĩToolStripMenuItem
            // 
            this.dànhChoBácSĩToolStripMenuItem.Name = "dànhChoBácSĩToolStripMenuItem";
            this.dànhChoBácSĩToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.dànhChoBácSĩToolStripMenuItem.Text = "Dành cho Bác sĩ";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.vScrollBar1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnl_head.ResumeLayout(false);
            this.pnl_head.PerformLayout();
            this.menu_head.ResumeLayout(false);
            this.menu_head.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_gktq;
        private System.Windows.Forms.Button btn_bvpk;
        private System.Windows.Forms.Button btn_bs;
        private System.Windows.Forms.Button btn_ck;
        private System.Windows.Forms.Panel pnl_head;
        private System.Windows.Forms.MenuStrip menu_head;
        private System.Windows.Forms.ToolStripMenuItem trangChủToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dànhChoBệnhNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dànhChoBácSĩToolStripMenuItem;
    }
}

