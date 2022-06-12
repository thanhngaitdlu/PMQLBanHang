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
    public partial class MatHangForm : Form
    {
        //private BindingSource bindingSource;
        public MatHangForm()
        {
            InitializeComponent();
        }

        private void MatHangForm_Load(object sender, EventArgs e)
        {
            //bindingSource = new BindingSource();
            //dgvDSMatHang.DataSource = bindingSource;
            LoadNhaCCToCbb();
            LoadLoaiHangToCbb();
            LoadDSMatHang();
            AddBinding(); 
        }

        private void AddBinding()
        {
            txtMaMH.DataBindings.Add("Text", dgvDSMatHang.DataSource, "MaMatHang", false);
            txtTenMH.DataBindings.Add("Text", dgvDSMatHang.DataSource, "TenMatHang", false);
            nudDonGia.DataBindings.Add("Text", dgvDSMatHang.DataSource, "DonGia", false);
            nudSoLuong.DataBindings.Add("Text", dgvDSMatHang.DataSource, "SoLuong", false);
            //cbbLoaiMH.DataBindings.Add("SelectedValue", dgvDSMatHang.DataSource, "MaLoai", false);
            //cbbNhaCC.DataBindings.Add("SelectedValue", dgvDSMatHang.DataSource, "MaNCC", false);
        }

        private void LoadNhaCCToCbb()
        {
            string connectionString = "server=.; database=QLBanHang; Integrated security=true";

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM NhaCungCap";

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            conn.Open();
            adapter.Fill(table);

            conn.Close();

            cbbNhaCC.DataSource = table;
            cbbNhaCC.DisplayMember = "TenNhaCC";
            cbbNhaCC.ValueMember = "MaNhaCC";
        }

        private void LoadLoaiHangToCbb()
        {
            string connectionString = "server=.; database=QLBanHang; Integrated security=true";

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM LoaiMatHang";

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            conn.Open();
            adapter.Fill(table);

            conn.Close();

            cbbLoaiMH.DataSource  = table;
            cbbLoaiMH.DisplayMember = "TenLoai";
            cbbLoaiMH.ValueMember = "MaLoai";
        }

        private void LoadDSMatHang()
        {
            string connectionString = "server=.; database=QLBanHang; Integrated security=true";

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM MatHang";

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            conn.Open();
            adapter.Fill(table);

            conn.Close();

            //bindingSource.DataSource = table;
            dgvDSMatHang.DataSource = table;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string connectionString = "server=.; database=QLBanHang; Integrated security=true";

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand command = conn.CreateCommand();

            var mamathang = txtMaMH.Text;
            var tenmathang = txtTenMH.Text;
            var soluong = Convert.ToInt32(nudSoLuong.Value);
            var dongia = Convert.ToInt32(nudDonGia.Value);
            var loaihang = cbbLoaiMH.SelectedValue.ToString();
            var nhacc = cbbNhaCC.SelectedValue.ToString();

            if (string.IsNullOrWhiteSpace(mamathang) 
                || string.IsNullOrWhiteSpace(tenmathang) 
                || soluong <= 0 
                || dongia <= 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin trước khi thêm", "Thông báo");
                return;
            }

            // INSERT [dbo].[MatHang] ([MaMatHang], [TenMatHang], [SoLuong], [DonGia], [MaNCC], [MaLoai])
            // VALUES (N'MH01', N'Bia 333', 20, 330000, N'NCC01', N'LH01')
            command.CommandText = "INSERT INTO MatHang " +
                                    "VALUES('" + mamathang + "', N'" +
                                    tenmathang + "', " + soluong + ", " +
                                    dongia + ", N'" + nhacc + "', N'"
                                    + loaihang + "')" ;

            conn.Open();
            int num = command.ExecuteNonQuery();

            if (num > 0)
            {
                MessageBox.Show("Thêm thành công.", "Thông báo");
                LoadDSMatHang();
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra khi thêm mới.", "Thông báo");
            }

            conn.Close();
        }

        private void cbbNhaCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            var maNhaCC = cbbNhaCC.SelectedValue.ToString();

            string connectionString = "server=.; database=QLBanHang; Integrated security=true";

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM MatHang WHERE MaNCC = N'" + maNhaCC + "'";

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            conn.Open();
            adapter.Fill(table);

            conn.Close();

            if(table.Rows.Count > 0)
                dgvDSMatHang.DataSource = table;
            //bindingSource.DataSource = table;

        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LoadDSMatHang();
        }

        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            NhaCCForm dlg = new NhaCCForm();
            dlg.ShowDialog();
        }

        private void btnThemLoaiHang_Click(object sender, EventArgs e)
        {
            LoaiMHForm form = new LoaiMHForm();
            form.ShowDialog();

            LoadLoaiHangToCbb();

        }
    }
}
