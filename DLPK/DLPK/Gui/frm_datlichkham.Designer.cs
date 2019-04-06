namespace DLPK.Gui
{
    partial class frm_datlichkham
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
            this.pnl_datlichkham = new System.Windows.Forms.Panel();
            this.pnl_thongtin_nguoikham = new System.Windows.Forms.Panel();
            this.tb_note = new System.Windows.Forms.TextBox();
            this.cbb_year = new System.Windows.Forms.ComboBox();
            this.cb_male = new System.Windows.Forms.CheckBox();
            this.cb_female = new System.Windows.Forms.CheckBox();
            this.cb_car = new System.Windows.Forms.CheckBox();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.pnl_thongtin_datlichkham = new System.Windows.Forms.Panel();
            this.lb_header_datlich = new System.Windows.Forms.Label();
            this.cb_baohiem = new System.Windows.Forms.CheckBox();
            this.btn_submit_datlich = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_head.SuspendLayout();
            this.menu_head.SuspendLayout();
            this.pnl_datlichkham.SuspendLayout();
            this.pnl_thongtin_nguoikham.SuspendLayout();
            this.pnl_thongtin_datlichkham.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_head
            // 
            this.pnl_head.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnl_head.Controls.Add(this.menu_head);
            this.pnl_head.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_head.Location = new System.Drawing.Point(0, 0);
            this.pnl_head.Name = "pnl_head";
            this.pnl_head.Size = new System.Drawing.Size(800, 53);
            this.pnl_head.TabIndex = 3;
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
            this.menu_head.Size = new System.Drawing.Size(315, 24);
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
            // 
            // dànhChoBácSĩToolStripMenuItem
            // 
            this.dànhChoBácSĩToolStripMenuItem.Name = "dànhChoBácSĩToolStripMenuItem";
            this.dànhChoBácSĩToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.dànhChoBácSĩToolStripMenuItem.Text = "Dành cho Bác sĩ";
            // 
            // pnl_datlichkham
            // 
            this.pnl_datlichkham.Controls.Add(this.pnl_thongtin_nguoikham);
            this.pnl_datlichkham.Controls.Add(this.pnl_thongtin_datlichkham);
            this.pnl_datlichkham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_datlichkham.Location = new System.Drawing.Point(0, 53);
            this.pnl_datlichkham.Name = "pnl_datlichkham";
            this.pnl_datlichkham.Size = new System.Drawing.Size(800, 451);
            this.pnl_datlichkham.TabIndex = 4;
            // 
            // pnl_thongtin_nguoikham
            // 
            this.pnl_thongtin_nguoikham.Controls.Add(this.label1);
            this.pnl_thongtin_nguoikham.Controls.Add(this.btn_submit_datlich);
            this.pnl_thongtin_nguoikham.Controls.Add(this.tb_note);
            this.pnl_thongtin_nguoikham.Controls.Add(this.cbb_year);
            this.pnl_thongtin_nguoikham.Controls.Add(this.cb_male);
            this.pnl_thongtin_nguoikham.Controls.Add(this.cb_female);
            this.pnl_thongtin_nguoikham.Controls.Add(this.cb_baohiem);
            this.pnl_thongtin_nguoikham.Controls.Add(this.cb_car);
            this.pnl_thongtin_nguoikham.Controls.Add(this.tb_address);
            this.pnl_thongtin_nguoikham.Controls.Add(this.tb_email);
            this.pnl_thongtin_nguoikham.Controls.Add(this.tb_phone);
            this.pnl_thongtin_nguoikham.Controls.Add(this.tb_name);
            this.pnl_thongtin_nguoikham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_thongtin_nguoikham.Location = new System.Drawing.Point(0, 142);
            this.pnl_thongtin_nguoikham.Name = "pnl_thongtin_nguoikham";
            this.pnl_thongtin_nguoikham.Size = new System.Drawing.Size(800, 309);
            this.pnl_thongtin_nguoikham.TabIndex = 1;
            // 
            // tb_note
            // 
            this.tb_note.Location = new System.Drawing.Point(234, 195);
            this.tb_note.Name = "tb_note";
            this.tb_note.Size = new System.Drawing.Size(315, 20);
            this.tb_note.TabIndex = 4;
            this.tb_note.Text = "lí do khám";
            // 
            // cbb_year
            // 
            this.cbb_year.FormattingEnabled = true;
            this.cbb_year.Location = new System.Drawing.Point(234, 119);
            this.cbb_year.Name = "cbb_year";
            this.cbb_year.Size = new System.Drawing.Size(315, 21);
            this.cbb_year.TabIndex = 3;
            this.cbb_year.Text = "Năm sinh (Bắt buộc)";
            // 
            // cb_male
            // 
            this.cb_male.AutoSize = true;
            this.cb_male.Location = new System.Drawing.Point(234, 44);
            this.cb_male.Name = "cb_male";
            this.cb_male.Size = new System.Drawing.Size(48, 17);
            this.cb_male.TabIndex = 2;
            this.cb_male.Text = "Nam";
            this.cb_male.UseVisualStyleBackColor = true;
            // 
            // cb_female
            // 
            this.cb_female.AutoSize = true;
            this.cb_female.Location = new System.Drawing.Point(288, 44);
            this.cb_female.Name = "cb_female";
            this.cb_female.Size = new System.Drawing.Size(40, 17);
            this.cb_female.TabIndex = 2;
            this.cb_female.Text = "Nữ";
            this.cb_female.UseVisualStyleBackColor = true;
            // 
            // cb_car
            // 
            this.cb_car.AutoSize = true;
            this.cb_car.Location = new System.Drawing.Point(234, 172);
            this.cb_car.Name = "cb_car";
            this.cb_car.Size = new System.Drawing.Size(124, 17);
            this.cb_car.TabIndex = 1;
            this.cb_car.Text = "Bạn cần chỗ để ô tô";
            this.cb_car.UseVisualStyleBackColor = true;
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(234, 146);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(315, 20);
            this.tb_address.TabIndex = 0;
            this.tb_address.Text = "Địa chỉ";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(234, 93);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(315, 20);
            this.tb_email.TabIndex = 0;
            this.tb_email.Text = "Email";
            // 
            // tb_phone
            // 
            this.tb_phone.Location = new System.Drawing.Point(234, 67);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(315, 20);
            this.tb_phone.TabIndex = 0;
            this.tb_phone.Text = "Số điện thoại liên hệ (Bắt buộc)";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(234, 18);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(315, 20);
            this.tb_name.TabIndex = 0;
            this.tb_name.Text = "Họ tên bệnh nhân (Bắt buộc)";
            // 
            // pnl_thongtin_datlichkham
            // 
            this.pnl_thongtin_datlichkham.Controls.Add(this.lb_header_datlich);
            this.pnl_thongtin_datlichkham.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_thongtin_datlichkham.Location = new System.Drawing.Point(0, 0);
            this.pnl_thongtin_datlichkham.Name = "pnl_thongtin_datlichkham";
            this.pnl_thongtin_datlichkham.Size = new System.Drawing.Size(800, 142);
            this.pnl_thongtin_datlichkham.TabIndex = 0;
            // 
            // lb_header_datlich
            // 
            this.lb_header_datlich.AutoSize = true;
            this.lb_header_datlich.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_header_datlich.Location = new System.Drawing.Point(162, 0);
            this.lb_header_datlich.Name = "lb_header_datlich";
            this.lb_header_datlich.Size = new System.Drawing.Size(282, 36);
            this.lb_header_datlich.TabIndex = 0;
            this.lb_header_datlich.Text = "ĐẶT LỊCH KHÁM";
            // 
            // cb_baohiem
            // 
            this.cb_baohiem.AutoSize = true;
            this.cb_baohiem.Location = new System.Drawing.Point(234, 221);
            this.cb_baohiem.Name = "cb_baohiem";
            this.cb_baohiem.Size = new System.Drawing.Size(210, 17);
            this.cb_baohiem.TabIndex = 1;
            this.cb_baohiem.Text = "Bạn có thể sử dụng bảo hiểm (tư nhân)";
            this.cb_baohiem.UseVisualStyleBackColor = true;
            // 
            // btn_submit_datlich
            // 
            this.btn_submit_datlich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_submit_datlich.Location = new System.Drawing.Point(234, 265);
            this.btn_submit_datlich.Name = "btn_submit_datlich";
            this.btn_submit_datlich.Size = new System.Drawing.Size(315, 32);
            this.btn_submit_datlich.TabIndex = 5;
            this.btn_submit_datlich.Text = "Xác nhận đặt lịch";
            this.btn_submit_datlich.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Chúng tôi sẽ liên hệ lại để xác nhận và cung cấp thêm thông tin đi khám";
            // 
            // frm_datlichkham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.pnl_datlichkham);
            this.Controls.Add(this.pnl_head);
            this.Name = "frm_datlichkham";
            this.Text = "frm_datlichkham";
            this.pnl_head.ResumeLayout(false);
            this.pnl_head.PerformLayout();
            this.menu_head.ResumeLayout(false);
            this.menu_head.PerformLayout();
            this.pnl_datlichkham.ResumeLayout(false);
            this.pnl_thongtin_nguoikham.ResumeLayout(false);
            this.pnl_thongtin_nguoikham.PerformLayout();
            this.pnl_thongtin_datlichkham.ResumeLayout(false);
            this.pnl_thongtin_datlichkham.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_head;
        private System.Windows.Forms.MenuStrip menu_head;
        private System.Windows.Forms.ToolStripMenuItem trangChủToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dànhChoBệnhNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dànhChoBácSĩToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_datlichkham;
        private System.Windows.Forms.Panel pnl_thongtin_nguoikham;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Panel pnl_thongtin_datlichkham;
        private System.Windows.Forms.Label lb_header_datlich;
        private System.Windows.Forms.CheckBox cb_female;
        private System.Windows.Forms.CheckBox cb_car;
        private System.Windows.Forms.ComboBox cbb_year;
        private System.Windows.Forms.CheckBox cb_male;
        private System.Windows.Forms.TextBox tb_note;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_submit_datlich;
        private System.Windows.Forms.CheckBox cb_baohiem;
    }
}