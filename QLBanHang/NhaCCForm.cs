using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLBanHang
{
    public partial class NhaCCForm : Form
    {
        private BindingSource bindSource;
        public NhaCCForm()
        {
            InitializeComponent();
        }

        private void NhaCCForm_Load(object sender, EventArgs e)
        {
            bindSource = new BindingSource();
            dgvDSNhaCC.DataSource = bindSource;
            LoadDSNhaCC();
            AddBinding();
        }

        private void LoadDSNhaCC()
        {
            var connectionString = "server=.; Database=QLBanHang; Integrated Security=true";
            var conn = new SqlConnection(connectionString);

            var command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM NhaCungCap";

            var adapter = new SqlDataAdapter(command);
            var table = new DataTable("NhaCC");

            conn.Open();
            adapter.Fill(table);

            conn.Close();

            bindSource.DataSource = table;
        }

       private void AddBinding()
        {
            txtMaNhaCC.DataBindings.Add("Text", dgvDSNhaCC.DataSource, "MaNhaCC", false);
            txtTenNhaCC.DataBindings.Add("Text", dgvDSNhaCC.DataSource, "TenNhaCC", false);
            txtDiaChi.DataBindings.Add("Text", dgvDSNhaCC.DataSource, "DiaChi", false);
            mtxtSoDT.DataBindings.Add("Text", dgvDSNhaCC.DataSource, "SoDienThoai", false);
            txtMoTa.DataBindings.Add("Text", dgvDSNhaCC.DataSource, "MoTa", false);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string connectionString = "server=.; database=QLBanHang; Integrated security=true";

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand command = conn.CreateCommand();

            var maNhaCC = txtMaNhaCC.Text;
            var tenNhaCC = txtTenNhaCC.Text;
            var diaChi = txtDiaChi.Text;
            var sodt = mtxtSoDT.Text;
            var mota = txtMoTa.Text;
            if (string.IsNullOrWhiteSpace(maNhaCC) || string.IsNullOrWhiteSpace(tenNhaCC))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin trước khi thêm", "Thông báo");
                return;
            }

            // INSERT [dbo].[NhaCungCap] ([MaNhaCC], [TenNhaCC], [DiaChi], [SoDienThoai], [MoTa])
            // VALUES (N'NCC01', N'Đại lý ABC', N'2 An Dương Vương - P2', N'0263345545', N'Bia Sài gòn')
            command.CommandText = "INSERT INTO NhaCungCap " +
                                    "VALUES(@manhacc, @tennhacc, @diachi, @sodt, @mota)";

            command.Parameters.AddWithValue("@manhacc", maNhaCC);
            command.Parameters.AddWithValue("@tennhacc", tenNhaCC);
            command.Parameters.AddWithValue("@diachi", diaChi);
            command.Parameters.AddWithValue("@sodt", sodt);
            command.Parameters.AddWithValue("@mota", mota);


            conn.Open();
            int num = command.ExecuteNonQuery();

            if (num > 0)
            {
                MessageBox.Show("Thêm thành công.", "Thông báo");
                LoadDSNhaCC();
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra khi thêm mới.", "Thông báo");
            }

            conn.Close();
        }
    }
}
