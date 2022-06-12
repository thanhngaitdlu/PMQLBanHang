using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLBanHang
{
    public partial class LoaiMHForm : Form
    {
        public LoaiMHForm()
        {
            InitializeComponent();
        }

        private void LoaiMHForm_Load(object sender, EventArgs e)
        {
            GetAllLoaiMH();
            AddBinding();
        }

        private void GetAllLoaiMH()
        {
            string connectionString = "server=.; database=QLBanHang; Integrated security=true" ;

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM LoaiMatHang";

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            conn.Open();
            adapter.Fill(table);

            conn.Close();

            dgvDSLoaiMH.DataSource = table;
        }

        private void AddBinding()
        {
            txtMaLoai.DataBindings.Add("Text", dgvDSLoaiMH.DataSource, "MaLoai", false);
            txtTenLoai.DataBindings.Add("Text", dgvDSLoaiMH.DataSource, "TenLoai", false);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string connectionString = "server=.; database=QLBanHang; Integrated security=true";

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand command = conn.CreateCommand();

            var maLoai = txtMaLoai.Text;
            var tenLoai = txtTenLoai.Text;
            if (string.IsNullOrWhiteSpace(maLoai) || string.IsNullOrWhiteSpace(tenLoai))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin trước khi thêm", "Thông báo");
                return;
            }

            // INSERT INTO LoaiMatHang VALUES('LH04', N'Sữa')
            command.CommandText = "INSERT INTO LoaiMatHang " +
                                    "VALUES('" + maLoai + "', N'" +
                                    tenLoai + "')";

            conn.Open();
            int num = command.ExecuteNonQuery();

            if (num > 0)
            {
                MessageBox.Show("Thêm thành công.", "Thông báo");
                GetAllLoaiMH();
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra khi thêm mới.", "Thông báo");
            }

            conn.Close();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string connectionString = "server=.; database=QLBanHang; Integrated security=true";

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand command = conn.CreateCommand();

            var maLoai = txtMaLoai.Text;
            var tenLoai = txtTenLoai.Text;
            if (string.IsNullOrWhiteSpace(maLoai) || string.IsNullOrWhiteSpace(tenLoai))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin trước khi thêm", "Thông báo");
                return;
            }

            // UPDATE LoaiMatHang SET TenLoai= N'Sữa bột' 
            // WHERE MaLoai = 'LH01'
            command.CommandText = "UPDATE LoaiMatHang " +
                                    "SET TenLoai = N'" + tenLoai +
                                    "' WHERE MaLoai = '" + maLoai + "'";

            conn.Open();
            int num = command.ExecuteNonQuery();

            if (num > 0)
            {
                MessageBox.Show("Cập nhật thành công.", "Thông báo");
                GetAllLoaiMH();
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra khi cập nhật.", "Thông báo");
            }

            conn.Close();
        }
    }
}
