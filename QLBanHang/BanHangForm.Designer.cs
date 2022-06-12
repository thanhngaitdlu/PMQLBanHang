namespace PMQLBanHang
{
	partial class BanHangForm
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
			this.dgvCTHoaDon = new System.Windows.Forms.DataGridView();
			this.dgcMaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgcTenHang = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.dgcSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgcDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgcThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgcXoa = new System.Windows.Forms.DataGridViewButtonColumn();
			this.txtMaHD = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dtpNgayXuat = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.cbbKhachHang = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtTenNV = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.txtTongTien = new System.Windows.Forms.TextBox();
			this.txtPhaiTra = new System.Windows.Forms.TextBox();
			this.nudGiamGia = new System.Windows.Forms.NumericUpDown();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnCapnhat = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnThemKH = new System.Windows.Forms.Button();
			this.btnLoadDS = new System.Windows.Forms.Button();
			this.btnInHD = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvCTHoaDon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudGiamGia)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvCTHoaDon
			// 
			this.dgvCTHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCTHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcMaHD,
            this.dgcTenHang,
            this.dgcSoLuong,
            this.dgcDonGia,
            this.dgcThanhTien,
            this.dgcXoa});
			this.dgvCTHoaDon.Location = new System.Drawing.Point(37, 324);
			this.dgvCTHoaDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.dgvCTHoaDon.Name = "dgvCTHoaDon";
			this.dgvCTHoaDon.RowHeadersWidth = 51;
			this.dgvCTHoaDon.RowTemplate.Height = 24;
			this.dgvCTHoaDon.Size = new System.Drawing.Size(804, 336);
			this.dgvCTHoaDon.TabIndex = 0;
			this.dgvCTHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTHoaDon_CellContentClick);
			this.dgvCTHoaDon.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTHoaDon_CellEndEdit);
			this.dgvCTHoaDon.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvCTHoaDon_RowsAdded);
			this.dgvCTHoaDon.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTHoaDon_RowValidated);
			// 
			// dgcMaHD
			// 
			this.dgcMaHD.DataPropertyName = "MaHD";
			this.dgcMaHD.HeaderText = "Mã HD";
			this.dgcMaHD.MinimumWidth = 6;
			this.dgcMaHD.Name = "dgcMaHD";
			this.dgcMaHD.ReadOnly = true;
			this.dgcMaHD.Width = 125;
			// 
			// dgcTenHang
			// 
			this.dgcTenHang.DataPropertyName = "MaMatHang";
			this.dgcTenHang.HeaderText = "Tên hàng";
			this.dgcTenHang.MinimumWidth = 6;
			this.dgcTenHang.Name = "dgcTenHang";
			this.dgcTenHang.Width = 200;
			// 
			// dgcSoLuong
			// 
			this.dgcSoLuong.DataPropertyName = "SoLuong";
			this.dgcSoLuong.HeaderText = "Số lượng";
			this.dgcSoLuong.MinimumWidth = 6;
			this.dgcSoLuong.Name = "dgcSoLuong";
			this.dgcSoLuong.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dgcSoLuong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.dgcSoLuong.Width = 80;
			// 
			// dgcDonGia
			// 
			this.dgcDonGia.DataPropertyName = "DonGia";
			this.dgcDonGia.HeaderText = "Đơn giá";
			this.dgcDonGia.MinimumWidth = 6;
			this.dgcDonGia.Name = "dgcDonGia";
			this.dgcDonGia.Width = 125;
			// 
			// dgcThanhTien
			// 
			this.dgcThanhTien.DataPropertyName = "ThanhTien";
			this.dgcThanhTien.HeaderText = "Thành tiền";
			this.dgcThanhTien.MinimumWidth = 6;
			this.dgcThanhTien.Name = "dgcThanhTien";
			this.dgcThanhTien.ReadOnly = true;
			this.dgcThanhTien.Width = 150;
			// 
			// dgcXoa
			// 
			this.dgcXoa.HeaderText = "Xóa";
			this.dgcXoa.MinimumWidth = 6;
			this.dgcXoa.Name = "dgcXoa";
			this.dgcXoa.Text = "Xóa";
			this.dgcXoa.UseColumnTextForButtonValue = true;
			this.dgcXoa.Width = 80;
			// 
			// txtMaHD
			// 
			this.txtMaHD.Location = new System.Drawing.Point(299, 102);
			this.txtMaHD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtMaHD.Name = "txtMaHD";
			this.txtMaHD.Size = new System.Drawing.Size(200, 27);
			this.txtMaHD.TabIndex = 1;
			this.txtMaHD.TextChanged += new System.EventHandler(this.txtMaHD_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(146, 102);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Mã hóa đơn";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(146, 151);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Ngày xuất";
			// 
			// dtpNgayXuat
			// 
			this.dtpNgayXuat.CustomFormat = "dd/MM/yyyy";
			this.dtpNgayXuat.Enabled = false;
			this.dtpNgayXuat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpNgayXuat.Location = new System.Drawing.Point(299, 144);
			this.dtpNgayXuat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.dtpNgayXuat.Name = "dtpNgayXuat";
			this.dtpNgayXuat.Size = new System.Drawing.Size(200, 27);
			this.dtpNgayXuat.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(146, 191);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(86, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Khách hàng";
			// 
			// cbbKhachHang
			// 
			this.cbbKhachHang.FormattingEnabled = true;
			this.cbbKhachHang.Location = new System.Drawing.Point(299, 191);
			this.cbbKhachHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.cbbKhachHang.Name = "cbbKhachHang";
			this.cbbKhachHang.Size = new System.Drawing.Size(200, 28);
			this.cbbKhachHang.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(146, 244);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(99, 20);
			this.label4.TabIndex = 2;
			this.label4.Text = "Tên nhân viên";
			// 
			// txtTenNV
			// 
			this.txtTenNV.Location = new System.Drawing.Point(299, 238);
			this.txtTenNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtTenNV.Name = "txtTenNV";
			this.txtTenNV.Size = new System.Drawing.Size(200, 27);
			this.txtTenNV.TabIndex = 1;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(26, 286);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(148, 20);
			this.label5.TabIndex = 2;
			this.label5.Text = "Danh sách mặt hàng ";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label6.Location = new System.Drawing.Point(203, 11);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(427, 46);
			this.label6.TabIndex = 2;
			this.label6.Text = "PHIẾU KÊ BÁN HÀNG";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(26, 688);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(72, 20);
			this.label7.TabIndex = 2;
			this.label7.Text = "Tổng tiền";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(321, 688);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(69, 20);
			this.label8.TabIndex = 2;
			this.label8.Text = "Giảm giá";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(602, 688);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(59, 20);
			this.label9.TabIndex = 2;
			this.label9.Text = "Phải trả";
			// 
			// txtTongTien
			// 
			this.txtTongTien.Location = new System.Drawing.Point(100, 684);
			this.txtTongTien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtTongTien.Name = "txtTongTien";
			this.txtTongTien.ReadOnly = true;
			this.txtTongTien.Size = new System.Drawing.Size(176, 27);
			this.txtTongTien.TabIndex = 1;
			// 
			// txtPhaiTra
			// 
			this.txtPhaiTra.Location = new System.Drawing.Point(665, 684);
			this.txtPhaiTra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtPhaiTra.Name = "txtPhaiTra";
			this.txtPhaiTra.ReadOnly = true;
			this.txtPhaiTra.Size = new System.Drawing.Size(176, 27);
			this.txtPhaiTra.TabIndex = 1;
			// 
			// nudGiamGia
			// 
			this.nudGiamGia.Location = new System.Drawing.Point(391, 685);
			this.nudGiamGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.nudGiamGia.Name = "nudGiamGia";
			this.nudGiamGia.Size = new System.Drawing.Size(150, 27);
			this.nudGiamGia.TabIndex = 5;
			this.nudGiamGia.ValueChanged += new System.EventHandler(this.nudGiamGia_ValueChanged);
			// 
			// btnThem
			// 
			this.btnThem.Location = new System.Drawing.Point(324, 278);
			this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(149, 38);
			this.btnThem.TabIndex = 6;
			this.btnThem.Text = "Tạo hóa đơn";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// btnCapnhat
			// 
			this.btnCapnhat.Enabled = false;
			this.btnCapnhat.Location = new System.Drawing.Point(510, 278);
			this.btnCapnhat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnCapnhat.Name = "btnCapnhat";
			this.btnCapnhat.Size = new System.Drawing.Size(139, 38);
			this.btnCapnhat.TabIndex = 6;
			this.btnCapnhat.Text = "Cập nhật";
			this.btnCapnhat.UseVisualStyleBackColor = true;
			// 
			// btnXoa
			// 
			this.btnXoa.Enabled = false;
			this.btnXoa.Location = new System.Drawing.Point(692, 278);
			this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(141, 38);
			this.btnXoa.TabIndex = 6;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = true;
			// 
			// btnThemKH
			// 
			this.btnThemKH.Location = new System.Drawing.Point(532, 192);
			this.btnThemKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnThemKH.Name = "btnThemKH";
			this.btnThemKH.Size = new System.Drawing.Size(169, 29);
			this.btnThemKH.TabIndex = 6;
			this.btnThemKH.Text = "Thêm KH";
			this.btnThemKH.UseVisualStyleBackColor = true;
			this.btnThemKH.Click += new System.EventHandler(this.btnThemKH_Click);
			// 
			// btnLoadDS
			// 
			this.btnLoadDS.Location = new System.Drawing.Point(532, 95);
			this.btnLoadDS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnLoadDS.Name = "btnLoadDS";
			this.btnLoadDS.Size = new System.Drawing.Size(169, 29);
			this.btnLoadDS.TabIndex = 6;
			this.btnLoadDS.Text = "Chọn phiếu đã bán";
			this.btnLoadDS.UseVisualStyleBackColor = true;
			this.btnLoadDS.Click += new System.EventHandler(this.btnLoadDS_Click);
			// 
			// btnInHD
			// 
			this.btnInHD.Location = new System.Drawing.Point(532, 142);
			this.btnInHD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnInHD.Name = "btnInHD";
			this.btnInHD.Size = new System.Drawing.Size(169, 29);
			this.btnInHD.TabIndex = 6;
			this.btnInHD.Text = "In hóa đơn";
			this.btnInHD.UseVisualStyleBackColor = true;
			// 
			// BanHangForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(863, 735);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.btnCapnhat);
			this.Controls.Add(this.btnInHD);
			this.Controls.Add(this.btnLoadDS);
			this.Controls.Add(this.btnThemKH);
			this.Controls.Add(this.btnThem);
			this.Controls.Add(this.nudGiamGia);
			this.Controls.Add(this.cbbKhachHang);
			this.Controls.Add(this.dtpNgayXuat);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtTenNV);
			this.Controls.Add(this.txtPhaiTra);
			this.Controls.Add(this.txtTongTien);
			this.Controls.Add(this.txtMaHD);
			this.Controls.Add(this.dgvCTHoaDon);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "BanHangForm";
			this.Text = "Quản lý bán hàng";
			this.Load += new System.EventHandler(this.BanHangForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvCTHoaDon)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudGiamGia)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvCTHoaDon;
		private System.Windows.Forms.TextBox txtMaHD;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker dtpNgayXuat;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cbbKhachHang;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtTenNV;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtTongTien;
		private System.Windows.Forms.TextBox txtPhaiTra;
		private System.Windows.Forms.NumericUpDown nudGiamGia;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Button btnCapnhat;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnThemKH;
		private System.Windows.Forms.Button btnLoadDS;
		private System.Windows.Forms.Button btnInHD;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgcMaHD;
		private System.Windows.Forms.DataGridViewComboBoxColumn dgcTenHang;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgcSoLuong;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgcDonGia;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgcThanhTien;
		private System.Windows.Forms.DataGridViewButtonColumn dgcXoa;
	}
}