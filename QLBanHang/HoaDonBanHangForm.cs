using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLBanHang
{
    public partial class HoaDonBanHangForm : Form
    {

	    public string MaHDChon = "11111";
         
        public HoaDonBanHangForm()
        {
            InitializeComponent();
        }

        private void HoaDonBanHangForm_Load(object sender, EventArgs e)
        {

            LoadDSHoaDon();
        }

        private void LoadDSHoaDon()
        {
            var conn = new SqlConnection(Utilities.ConnectionString);

            var command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM HoaDonBH";

            var adapter = new SqlDataAdapter(command);
            var table = new DataTable("HoaDon");

            conn.Open();
            adapter.Fill(table);

            conn.Close();

            dgvDSHoaDon.DataSource = table;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            
            var conn = new SqlConnection(Utilities.ConnectionString);

            var tennv = txtTenNV.Text;
            var makh = txtTenKhachHang.Text;
            var fromDate = dtpFromDate.Value.ToShortDateString();
            var toDate = dtpToDate.Value.ToShortDateString();
            
            var command = conn.CreateCommand();

            var str = "SELECT * FROM HoaDonBH" +
                " WHERE NgayXuat BETWEEN '" + fromDate + "' AND '" + toDate + "'";

            if (!string.IsNullOrWhiteSpace(tennv))
                str += " AND TenNhanVien LIKE N'" + tennv + "'";
            if(!string.IsNullOrWhiteSpace(makh))
                str += " AND MaKH LIKE N'" + makh + "'";
            //command.CommandText = "SELECT * FROM HoaDonBH WHERE TenNhanVien LIKE N'" + tennv +"'";
            command.CommandText = str;


            var adapter = new SqlDataAdapter(command);
            var table = new DataTable("HoaDon");

            conn.Open();
            adapter.Fill(table);

            conn.Close();

            dgvDSHoaDon.DataSource = table;
        }

        private void dgvDSHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

		private void dgvDSHoaDon_DoubleClick(object sender, EventArgs e)
		{
			var count = dgvDSHoaDon.SelectedRows.Count;
			if (count > 0)
			{
				MaHDChon = dgvDSHoaDon.SelectedRows[0].Cells[0].Value.ToString();
				this.DialogResult = DialogResult.OK;
			}
		}
	}
}
