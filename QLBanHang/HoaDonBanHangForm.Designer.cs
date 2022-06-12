
namespace QLBanHang
{
    partial class HoaDonBanHangForm
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
			this.dgvDSHoaDon = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnTimKiem = new System.Windows.Forms.Button();
			this.dtpToDate = new System.Windows.Forms.DateTimePicker();
			this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
			this.txtTenKhachHang = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtTenNV = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvDSHoaDon)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvDSHoaDon
			// 
			this.dgvDSHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDSHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
			this.dgvDSHoaDon.Location = new System.Drawing.Point(24, 271);
			this.dgvDSHoaDon.MultiSelect = false;
			this.dgvDSHoaDon.Name = "dgvDSHoaDon";
			this.dgvDSHoaDon.RowHeadersWidth = 51;
			this.dgvDSHoaDon.RowTemplate.Height = 29;
			this.dgvDSHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDSHoaDon.Size = new System.Drawing.Size(781, 322);
			this.dgvDSHoaDon.TabIndex = 0;
			this.dgvDSHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSHoaDon_CellContentClick);
			this.dgvDSHoaDon.DoubleClick += new System.EventHandler(this.dgvDSHoaDon_DoubleClick);
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "MaHD";
			this.Column1.HeaderText = "Mã hóa đơn";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			this.Column1.Width = 125;
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "TenNhanVien";
			this.Column2.HeaderText = "Tên nhân viên";
			this.Column2.MinimumWidth = 6;
			this.Column2.Name = "Column2";
			this.Column2.Width = 125;
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "MaKH";
			this.Column3.HeaderText = "Tên KH";
			this.Column3.MinimumWidth = 6;
			this.Column3.Name = "Column3";
			this.Column3.Width = 125;
			// 
			// Column4
			// 
			this.Column4.DataPropertyName = "NgayXuat";
			this.Column4.HeaderText = "Ngày xuất";
			this.Column4.MinimumWidth = 6;
			this.Column4.Name = "Column4";
			this.Column4.Width = 125;
			// 
			// Column5
			// 
			this.Column5.DataPropertyName = "TongTien";
			this.Column5.HeaderText = "Tổng tiền";
			this.Column5.MinimumWidth = 6;
			this.Column5.Name = "Column5";
			this.Column5.Width = 125;
			// 
			// Column6
			// 
			this.Column6.DataPropertyName = "GiamGia";
			this.Column6.HeaderText = "Giảm giá";
			this.Column6.MinimumWidth = 6;
			this.Column6.Name = "Column6";
			this.Column6.Width = 125;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(24, 248);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(136, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Danh sách hóa đơn";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(249, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(306, 40);
			this.label2.TabIndex = 1;
			this.label2.Text = "HÓA ĐƠN BÁN HÀNG";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnTimKiem);
			this.groupBox1.Controls.Add(this.dtpToDate);
			this.groupBox1.Controls.Add(this.dtpFromDate);
			this.groupBox1.Controls.Add(this.txtTenKhachHang);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtTenNV);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Location = new System.Drawing.Point(45, 52);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(760, 193);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Tìm kiếm hóa đơn";
			// 
			// btnTimKiem
			// 
			this.btnTimKiem.Location = new System.Drawing.Point(636, 77);
			this.btnTimKiem.Name = "btnTimKiem";
			this.btnTimKiem.Size = new System.Drawing.Size(94, 29);
			this.btnTimKiem.TabIndex = 3;
			this.btnTimKiem.Text = "Tìm kiếm";
			this.btnTimKiem.UseVisualStyleBackColor = true;
			this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
			// 
			// dtpToDate
			// 
			this.dtpToDate.CustomFormat = "dd/MM/yyyy";
			this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpToDate.Location = new System.Drawing.Point(456, 133);
			this.dtpToDate.Name = "dtpToDate";
			this.dtpToDate.Size = new System.Drawing.Size(143, 27);
			this.dtpToDate.TabIndex = 2;
			// 
			// dtpFromDate
			// 
			this.dtpFromDate.CustomFormat = "dd/MM/yyyy";
			this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpFromDate.Location = new System.Drawing.Point(175, 135);
			this.dtpFromDate.Name = "dtpFromDate";
			this.dtpFromDate.Size = new System.Drawing.Size(152, 27);
			this.dtpFromDate.TabIndex = 2;
			this.dtpFromDate.Value = new System.DateTime(2022, 5, 1, 0, 0, 0, 0);
			// 
			// txtTenKhachHang
			// 
			this.txtTenKhachHang.Location = new System.Drawing.Point(175, 81);
			this.txtTenKhachHang.Name = "txtTenKhachHang";
			this.txtTenKhachHang.Size = new System.Drawing.Size(424, 27);
			this.txtTenKhachHang.TabIndex = 0;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(366, 140);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(72, 20);
			this.label6.TabIndex = 1;
			this.label6.Text = "Đến ngày";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(28, 140);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(62, 20);
			this.label5.TabIndex = 1;
			this.label5.Text = "Từ ngày";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(28, 81);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(111, 20);
			this.label4.TabIndex = 1;
			this.label4.Text = "Tên khách hàng";
			// 
			// txtTenNV
			// 
			this.txtTenNV.Location = new System.Drawing.Point(175, 33);
			this.txtTenNV.Name = "txtTenNV";
			this.txtTenNV.Size = new System.Drawing.Size(424, 27);
			this.txtTenNV.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(28, 33);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(99, 20);
			this.label3.TabIndex = 1;
			this.label3.Text = "Tên nhân viên";
			// 
			// HoaDonBanHangForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(845, 617);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvDSHoaDon);
			this.Name = "HoaDonBanHangForm";
			this.Text = "HoaDonBanHangForm";
			this.Load += new System.EventHandler(this.HoaDonBanHangForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvDSHoaDon)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTimKiem;
    }
}