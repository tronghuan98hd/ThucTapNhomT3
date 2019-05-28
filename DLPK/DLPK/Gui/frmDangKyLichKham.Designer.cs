namespace DLPK.Gui
{
    partial class frmDangKyLichKham
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTenBS = new System.Windows.Forms.Label();
            this.dtgNgayKham = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.clbSang = new System.Windows.Forms.CheckedListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 76);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(319, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng ký lịch khám";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnXacNhan);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.dtgNgayKham);
            this.panel2.Controls.Add(this.lbTenBS);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 456);
            this.panel2.TabIndex = 1;
            // 
            // lbTenBS
            // 
            this.lbTenBS.AutoSize = true;
            this.lbTenBS.Location = new System.Drawing.Point(236, 33);
            this.lbTenBS.Name = "lbTenBS";
            this.lbTenBS.Size = new System.Drawing.Size(60, 13);
            this.lbTenBS.TabIndex = 0;
            this.lbTenBS.Text = "Tên bác sĩ";
            // 
            // dtgNgayKham
            // 
            this.dtgNgayKham.CustomFormat = "dd/MM/yyyy";
            this.dtgNgayKham.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtgNgayKham.Location = new System.Drawing.Point(239, 61);
            this.dtgNgayKham.Name = "dtgNgayKham";
            this.dtgNgayKham.Size = new System.Drawing.Size(200, 20);
            this.dtgNgayKham.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clbSang);
            this.groupBox1.Location = new System.Drawing.Point(239, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 328);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thời gian khám";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(468, 421);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(75, 23);
            this.btnXacNhan.TabIndex = 3;
            this.btnXacNhan.Text = "Ghi nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // clbSang
            // 
            this.clbSang.FormattingEnabled = true;
            this.clbSang.Location = new System.Drawing.Point(6, 19);
            this.clbSang.Name = "clbSang";
            this.clbSang.Size = new System.Drawing.Size(179, 289);
            this.clbSang.TabIndex = 1;
            // 
            // frmDangKyLichKham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmDangKyLichKham";
            this.Text = "frmDangKyLichKham";
            this.Load += new System.EventHandler(this.frmDangKyLichKham_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtgNgayKham;
        private System.Windows.Forms.Label lbTenBS;
        private System.Windows.Forms.CheckedListBox clbSang;
    }
}