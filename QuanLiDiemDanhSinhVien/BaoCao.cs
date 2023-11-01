using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLiDiemDanhSinhVien
{
    public partial class BaoCao : Form
    {
        SqlConnection conn; // khai bao chuoi connection
        DataSet ds_SinhVien;
        SqlDataAdapter adapt;
        private string sql = @"Data Source=BIMBIM; Initial Catalog = QLSINHVIEN; User ID = sa;Password=123";
        public BaoCao()
        {
            InitializeComponent();
            conn = new SqlConnection(sql); //gan chuoi ket noi
            ds_SinhVien = new DataSet();
        }

        private void Xemdiemdanh_Load(object sender, EventArgs e)
        {

            adapt = new SqlDataAdapter("SELECT sv.MaSinhVien, sv.HoTen, sv.NgaySinh, lop.MaLop ,ctdd.SoTietVang, ctdd.LyDo,ctdd.NgayDiemDanh FROM SinhVien sv JOIN ChiTietDiemDanh ctdd ON sv.MaSinhVien = ctdd.MaSinhVien JOIN Lop lop on sv.MaLop = lop.MaLop ", conn);
            adapt.Fill(ds_SinhVien, "SINHVIEN");
            dataGridView1.DataSource = ds_SinhVien.Tables["SINHVIEN"];
            dataGridView1.Columns["NgayDiemDanh"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
        }

        private void dtp_xemdiemdanh_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dtp_xemdiemdanh.Value.Date;

            string query = $"SELECT sv.MaSinhVien, sv.HoTen, sv.NgaySinh, lop.MaLop, ctdd.SoTietVang, ctdd.LyDo, ctdd.NgayDiemDanh " +
                           $"FROM SinhVien sv " +
                           $"JOIN ChiTietDiemDanh ctdd ON sv.MaSinhVien = ctdd.MaSinhVien " +
                           $"JOIN Lop lop ON sv.MaLop = lop.MaLop " +
                           $"WHERE ctdd.NgayDiemDanh = '{selectedDate.ToString("yyyy-MM-dd")}'";

            adapt = new SqlDataAdapter(query, conn);
            ds_SinhVien.Tables["SINHVIEN"].Clear(); // Xóa dữ liệu hiện tại trong bảng "SINHVIEN"
            adapt.Fill(ds_SinhVien, "SINHVIEN"); // Đổ dữ liệu mới vào bảng "SINHVIEN"
        }
    }
}
