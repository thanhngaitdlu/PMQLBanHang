
namespace QLBanHang
{
    partial class KhachHangForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.mtxtSoDT = new System.Windows.Forms.MaskedTextBox();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.txtDiaChi = new System.Windows.Forms.TextBox();
			this.txtTenKH = new System.Windows.Forms.TextBox();
			this.txtMaKH = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnTimKiem = new System.Windows.Forms.Button();
			this.dgvDSKH = new System.Windows.Forms.DataGridView();
			this.dgcMaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rdTheoSDT = new System.Windows.Forms.RadioButton();
			this.rdTheoTen = new System.Windows.Forms.RadioButton();
			this.txtSearch = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvDSKH)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// mtxtSoDT
			// 
			this.mtxtSoDT.Location = new System.Drawing.Point(147, 91);
			this.mtxtSoDT.Mask = "0000000000";
			this.mtxtSoDT.Name = "mtxtSoDT";
			this.mtxtSoDT.Size = new System.Drawing.Size(239, 27);
			this.mtxtSoDT.TabIndex = 27;
			// 
			// btnXoa
			// 
			this.btnXoa.Location = new System.Drawing.Point(662, 183);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(94, 29);
			this.btnXoa.TabIndex = 24;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = true;
			// 
			// btnSua
			// 
			this.btnSua.Location = new System.Drawing.Point(539, 183);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(94, 29);
			this.btnSua.TabIndex = 25;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = true;
			// 
			// btnThem
			// 
			this.btnThem.Location = new System.Drawing.Point(409, 183);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(94, 29);
			this.btnThem.TabIndex = 26;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// txtDiaChi
			// 
			this.txtDiaChi.Location = new System.Drawing.Point(147, 136);
			this.txtDiaChi.Name = "txtDiaChi";
			this.txtDiaChi.Size = new System.Drawing.Size(615, 27);
			this.txtDiaChi.TabIndex = 21;
			// 
			// txtTenKH
			// 
			this.txtTenKH.Location = new System.Drawing.Point(147, 58);
			this.txtTenKH.Name = "txtTenKH";
			this.txtTenKH.Size = new System.Drawing.Size(240, 27);
			this.txtTenKH.TabIndex = 23;
			// 
			// txtMaKH
			// 
			this.txtMaKH.Location = new System.Drawing.Point(147, 16);
			this.txtMaKH.Name = "txtMaKH";
			this.txtMaKH.Size = new System.Drawing.Size(240, 27);
			this.txtMaKH.TabIndex = 14;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(17, 94);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(97, 20);
			this.label5.TabIndex = 17;
			this.label5.Text = "Số điện thoại";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(17, 136);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(126, 20);
			this.label4.TabIndex = 18;
			this.label4.Text = "Địa chỉ giao hàng";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(18, 206);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(156, 20);
			this.label3.TabIndex = 15;
			this.label3.Text = "Danh sách khách hàng";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(17, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(111, 20);
			this.label2.TabIndex = 19;
			this.label2.Text = "Tên khách hàng";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(19, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(109, 20);
			this.label1.TabIndex = 20;
			this.label1.Text = "Mã khách hàng";
			// 
			// btnTimKiem
			// 
			this.btnTimKiem.Location = new System.Drawing.Point(226, 60);
			this.btnTimKiem.Name = "btnTimKiem";
			this.btnTimKiem.Size = new System.Drawing.Size(94, 29);
			this.btnTimKiem.TabIndex = 26;
			this.btnTimKiem.Text = "Tìm kiếm";
			this.btnTimKiem.UseVisualStyleBackColor = true;
			// 
			// dgvDSKH
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			this.dgvDSKH.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvDSKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDSKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcMaKH,
            this.Column1,
            this.Column2,
            this.Column3});
			this.dgvDSKH.Location = new System.Drawing.Point(19, 239);
			this.dgvDSKH.Name = "dgvDSKH";
			this.dgvDSKH.RowHeadersWidth = 51;
			this.dgvDSKH.RowTemplate.Height = 29;
			this.dgvDSKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDSKH.Size = new System.Drawing.Size(753, 199);
			this.dgvDSKH.TabIndex = 28;
			// 
			// dgcMaKH
			// 
			this.dgcMaKH.HeaderText = "Mã KH";
			this.dgcMaKH.MinimumWidth = 6;
			this.dgcMaKH.Name = "dgcMaKH";
			this.dgcMaKH.Width = 125;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Tên khách hàng";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			this.Column1.Width = 200;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Số ĐT";
			this.Column2.MinimumWidth = 6;
			this.Column2.Name = "Column2";
			this.Column2.Width = 125;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Địa chỉ giao hàng";
			this.Column3.MinimumWidth = 6;
			this.Column3.Name = "Column3";
			this.Column3.Width = 300;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rdTheoSDT);
			this.groupBox1.Controls.Add(this.rdTheoTen);
			this.groupBox1.Controls.Add(this.btnTimKiem);
			this.groupBox1.Controls.Add(this.txtSearch);
			this.groupBox1.Location = new System.Drawing.Point(425, 15);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(346, 102);
			this.groupBox1.TabIndex = 29;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Tim kiếm";
			// 
			// rdTheoSDT
			// 
			this.rdTheoSDT.AutoSize = true;
			this.rdTheoSDT.Location = new System.Drawing.Point(203, 26);
			this.rdTheoSDT.Name = "rdTheoSDT";
			this.rdTheoSDT.Size = new System.Drawing.Size(89, 24);
			this.rdTheoSDT.TabIndex = 27;
			this.rdTheoSDT.Text = "TheoSDT";
			this.rdTheoSDT.UseVisualStyleBackColor = true;
			// 
			// rdTheoTen
			// 
			this.rdTheoTen.AutoSize = true;
			this.rdTheoTen.Checked = true;
			this.rdTheoTen.Location = new System.Drawing.Point(31, 27);
			this.rdTheoTen.Name = "rdTheoTen";
			this.rdTheoTen.Size = new System.Drawing.Size(88, 24);
			this.rdTheoTen.TabIndex = 27;
			this.rdTheoTen.TabStop = true;
			this.rdTheoTen.Text = "Theo tên";
			this.rdTheoTen.UseVisualStyleBackColor = true;
			// 
			// txtSearch
			// 
			this.txtSearch.Location = new System.Drawing.Point(31, 60);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(187, 27);
			this.txtSearch.TabIndex = 14;
			// 
			// KhachHangForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dgvDSKH);
			this.Controls.Add(this.mtxtSoDT);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.btnSua);
			this.Controls.Add(this.btnThem);
			this.Controls.Add(this.txtDiaChi);
			this.Controls.Add(this.txtTenKH);
			this.Controls.Add(this.txtMaKH);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "KhachHangForm";
			this.Text = "Quản lý khách hàng";
			this.Load += new System.EventHandler(this.KhachHangForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvDSKH)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtxtSoDT;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgvDSKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcMaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdTheoSDT;
        private System.Windows.Forms.RadioButton rdTheoTen;
        private System.Windows.Forms.TextBox txtSearch;
    }
}