using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHang
{
    public partial class KhachHangForm : Form
    {
	    private BindingSource bindSource;

	    public string MaKhachHang = "";
        public KhachHangForm()
        {
            InitializeComponent();
        }


		private void KhachHangForm_Load(object sender, EventArgs e)
		{
			bindSource = new BindingSource();
            LoadDSKH();
            dgvDSKH.DataSource = bindSource;
            AddBinding();
		}

        private void LoadDSKH()
        {
            var conn = new SqlConnection(Utilities.ConnectionString);

            var command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM KhachHang";

            var adapter = new SqlDataAdapter(command);
            var table = new DataTable("KhachHang");

            conn.Open();
            adapter.Fill(table);

            conn.Close();

            bindSource.DataSource = table;
        }

        private void AddBinding()
        {
            txtMaKH.DataBindings.Add("Text", dgvDSKH.DataSource, "MaKH", false);
            txtTenKH.DataBindings.Add("Text", dgvDSKH.DataSource, "TênKH", false);
            mtxtSoDT.DataBindings.Add("Text", dgvDSKH.DataSource, "SoDienThoai", false);
            txtDiaChi.DataBindings.Add("Text", dgvDSKH.DataSource, "DiaChiGH", false);
        }


		private void btnThem_Click(object sender, EventArgs e)
		{
			var conn = new SqlConnection(Utilities.ConnectionString);
			SqlCommand command = conn.CreateCommand();

			var maKH = txtMaKH.Text;
			var tenKH = txtTenKH.Text;
			var diaChiGH = txtDiaChi.Text;
			var sodt = mtxtSoDT.Text;

			if (string.IsNullOrWhiteSpace(maKH) || string.IsNullOrWhiteSpace(tenKH) || string.IsNullOrWhiteSpace(sodt))
			{
				MessageBox.Show("Vui lòng nhập đầy đủ thông tin trước khi thêm", "Thông báo");
				return;
			}

			command.CommandText = "INSERT INTO KhachHang " +
			                      "VALUES(@makh, @tenkh, @sodt, @diachi)";

			command.Parameters.AddWithValue("@makh", maKH);
			command.Parameters.AddWithValue("@tenkh", tenKH);
			command.Parameters.AddWithValue("@sodt", sodt);
			command.Parameters.AddWithValue("@diachi", diaChiGH);



			conn.Open();
			int num = command.ExecuteNonQuery();

			if (num > 0)
			{
				MessageBox.Show("Thêm thành công.", "Thông báo");
				LoadDSKH();
				MaKhachHang = maKH;
				
			}
			else
			{
				MessageBox.Show("Đã có lỗi xảy ra khi thêm mới.", "Thông báo");
			}

			conn.Close();
        }
	}
}
