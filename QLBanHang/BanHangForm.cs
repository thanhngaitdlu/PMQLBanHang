using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBanHang;

namespace PMQLBanHang
{
	public partial class BanHangForm : Form
	{
		private string connectionString ;
		private DataTable _table;

		

		public BanHangForm()
		{
			InitializeComponent();
			
			connectionString = Utilities.ConnectionString;
			dgvCTHoaDon.AutoGenerateColumns = false;
			dgvCTHoaDon.ReadOnly = true;
		}

		private void BanHangForm_Load(object sender, EventArgs e)
		{
			LoadTenHang();
			LoadKhachHang();
			_table = CreateSchema();
			dgvCTHoaDon.DataSource = _table;
			
		}

		private void LoadTenHang()
		{
			var conn = new SqlConnection(connectionString);

			var command = conn.CreateCommand();
			command.CommandText = "SELECT MaMatHang, TenMatHang, DonGia FROM MatHang";

			conn.Open();

			var adapter = new SqlDataAdapter(command);
			var table = new DataTable("MatHang");

			adapter.Fill(table);

			dgcTenHang.DataSource = table;
			dgcTenHang.DisplayMember = "TenMatHang";
			dgcTenHang.ValueMember = "MaMatHang";

			conn.Close();
		}

		private void LoadKhachHang()
		{
			var conn = new SqlConnection(connectionString);

			var command = conn.CreateCommand();
			command.CommandText = "SELECT MaKH, TênKH FROM KhachHang";

			conn.Open();

			var adapter = new SqlDataAdapter(command);
			var table = new DataTable("KhachHang");

			adapter.Fill(table);

			cbbKhachHang.DataSource = table;
			cbbKhachHang.DisplayMember = "TênKH";
			cbbKhachHang.ValueMember = "MaKH";


			conn.Close();
		}

		private void dgvCTHoaDon_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			if (e.RowIndex > 0)
			{
					dgvCTHoaDon["dgcMaHD", e.RowIndex - 1].Value = txtMaHD.Text;
			}
				
		}

		private DataTable CreateSchema()
		{
			var table = new DataTable("CTHoaDon");
			table.Columns.Add("MaHD");
			table.Columns.Add("MaMatHang");
			var dtcSoLuong = table.Columns.Add("SoLuong");
			var dtcDonGia = table.Columns.Add("DonGia");
			var dtcThanhTien = table.Columns.Add("ThanhTien");
			dtcSoLuong.DataType = typeof(int);
			dtcDonGia.DataType = typeof(int);
			dtcThanhTien.DataType = typeof(int);
			dtcThanhTien.Expression = "SoLuong * DonGia";
			return table;
		}

		private void dgvCTHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void txtMaHD_TextChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(txtMaHD.Text))
			{
				dgvCTHoaDon.ReadOnly = false;
			}
		}

		private void dgvCTHoaDon_RowValidated(object sender, DataGridViewCellEventArgs e)
		{
			
			if (dgvCTHoaDon.Rows.Count > 1 && !string.IsNullOrEmpty(_table.Rows[0]["ThanhTien"].ToString()))
			{
				ThietLapTongTien();
			}
		}

		private void ThietLapTongTien()
		{
			CultureInfo vnConverter = new CultureInfo("vi-VN", false);
			var tongTien = int.Parse(_table.Compute("Sum(ThanhTien)", "").ToString());
			var phaiTra = tongTien - tongTien * nudGiamGia.Value/100;

			txtTongTien.Text = tongTien.ToString("C0", vnConverter);
			txtPhaiTra.Text = phaiTra.ToString("C0", vnConverter);
			txtTongTien.Tag = tongTien;
		}

		private void dgvCTHoaDon_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			var isDuplicate = false;
			if (e.RowIndex < 0)
				return;

			if (e.ColumnIndex == dgvCTHoaDon.Columns.IndexOf(dgcTenHang))
			{
				var productCell = dgvCTHoaDon[e.ColumnIndex, e.RowIndex] as DataGridViewComboBoxCell;

				var selectedProduct = productCell.Items.OfType<DataRowView>().FirstOrDefault(x => x[0] == productCell.Value);
				if (selectedProduct != null)
				{
					var productId = selectedProduct[0].ToString();
					for (int i = 0; i < e.RowIndex; i++)
					{
						if (dgvCTHoaDon.Rows[i].Cells[1].Value == productId)
						{
							MessageBox.Show("Mặt hàng đã tồn tại", "Thông báo");
							dgvCTHoaDon.Rows.Remove(dgvCTHoaDon.Rows[e.RowIndex]);
							isDuplicate = true;
							break;
						}
					}
					if(!isDuplicate)
						dgvCTHoaDon["dgcDonGia", e.RowIndex].Value = selectedProduct[2];
				}
					
			
				
			}
				
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			var numOfRowsEffected = 0;
			var conn = new SqlConnection(connectionString);

			var command = conn.CreateCommand();
			command.CommandText = "INSERT INTO HoaDonBH VALUES(@MaHD, @MaKH, @TenNhanVien, @NgayXuat, @TongTien, @GiamGia)";

			command.Parameters.AddWithValue("@MaHD", txtMaHD.Text);
			command.Parameters.AddWithValue("@MaKH", cbbKhachHang.SelectedValue.ToString());
			command.Parameters.AddWithValue("@TenNhanVien", txtTenNV.Text);
			command.Parameters.AddWithValue("@NgayXuat", DateTime.Now);
			command.Parameters.AddWithValue("@TongTien", int.Parse(txtTongTien.Tag.ToString()));
			command.Parameters.AddWithValue("@GiamGia", Convert.ToInt32(nudGiamGia.Value));

			conn.Open();

			var num = command.ExecuteNonQuery();
			if (num > 0)
			{
				command.Parameters.Clear();
				command.CommandText = "INSERT INTO CT_HoaDonBH VALUES(@MaMatHang, @MaHD, @SoLuong, @DonGia)";
				DataTable table = dgvCTHoaDon.DataSource as DataTable;

				command.Parameters.Add("@MaMatHang", SqlDbType.NVarChar);
				command.Parameters.Add("@MaHD", SqlDbType.NVarChar);
				command.Parameters.Add("@SoLuong", SqlDbType.Int);
				command.Parameters.Add("@DonGia", SqlDbType.Int);


				foreach (DataRow row in table.Rows)
				{
					
					command.Parameters["@MaMatHang"].Value =  row["MaMatHang"];
					command.Parameters["@MaHD"].Value = row["MaHD"];
					command.Parameters["@SoLuong"].Value = Convert.ToInt32(row["SoLuong"]);
					command.Parameters["@DonGia"].Value =  Convert.ToInt32(row["DonGia"]);

					numOfRowsEffected += command.ExecuteNonQuery();
				}
				if (numOfRowsEffected == dgvCTHoaDon.Rows.Count-1)
					MessageBox.Show("Tạo hóa đơn thành công", "Thông báo");
				else
				{
					MessageBox.Show("Có lỗi khi thêm chi tiết hóa đơn", "Thông báo");
				}
			}
			else
			{
				MessageBox.Show("Tạo hóa đơn không thành công.", "Thông báo");
			}

			
			conn.Close();
		}

		//private void LuuHoaDon()
		private void btnLoadDS_Click(object sender, EventArgs e)
		{
			var form = new HoaDonBanHangForm();
			if (form.ShowDialog() == DialogResult.OK)
			{
				var mahd = form.MaHDChon;
				if (mahd != "11111")
				{
					HienThiHDTheoMaHD(mahd);
					HienThiThongTinCTHDTheoMaHD(mahd);
					btnCapnhat.Enabled = true;
					btnXoa.Enabled = true;
				}
			}
		}


		private void HienThiHDTheoMaHD(string maHD)
		{
			var conn = new SqlConnection(connectionString);

			var command = conn.CreateCommand();
			command.CommandText = "SELECT * from HoaDonBH WHERE MaHD LIKE '" + maHD + "'";

			conn.Open();

			var reader = command.ExecuteReader();

			HienThiThongTinHoaDon(reader);
			conn.Close();
		}
		private void HienThiThongTinHoaDon(SqlDataReader reader)
		{
			
			while (reader.Read())
			{
				txtMaHD.Text = reader["MaHD"].ToString();
				txtTenNV.Text = reader["TenNhanVien"].ToString();
				dtpNgayXuat.Value = DateTime.Parse(reader["NgayXuat"].ToString());
				cbbKhachHang.SelectedValue = reader["MaKH"].ToString();
			}
			
		}

		private void HienThiThongTinCTHDTheoMaHD(string maHD)
		{
			var conn = new SqlConnection(connectionString);

			var command = conn.CreateCommand();
			command.CommandText = "SELECT * from CT_HoaDonBH WHERE MaHD LIKE '" + maHD + "'";

			var adapter = new SqlDataAdapter(command);
			
			conn.Open();
			
			adapter.Fill(_table);
			conn.Close();

			dgvCTHoaDon.DataSource = _table;
			ThietLapTongTien();
		}

		private void nudGiamGia_ValueChanged(object sender, EventArgs e)
		{
			ThietLapTongTien();
		}

		private void btnThemKH_Click(object sender, EventArgs e)
		{
			var dlg = new KhachHangForm();
			dlg.ShowDialog();
			if (dlg.MaKhachHang != "")
			{
				LoadKhachHang();
				cbbKhachHang.SelectedValue = dlg.MaKhachHang;
			}
				
		}

		private void dgvCTHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			var senderGrid = (DataGridView)sender;

			if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
			    e.RowIndex >= 0)
			{
				dgvCTHoaDon.Rows.Remove(dgvCTHoaDon.Rows[e.RowIndex]);
			}
		}
	}
}
