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
using System.Globalization;
using System.IO;

namespace QuanLiDiemDanhSinhVien
{

    public partial class Diemdanh : Form
    {
        SqlConnection conn;
        DataSet ds_SinhVien;
        SqlDataAdapter adapt;
        private string sql = @"Data Source=BIMBIM; Initial Catalog = QLSINHVIEN; User ID = sa;Password=123";

        public Diemdanh()
        {
            InitializeComponent();
            conn = new SqlConnection(sql);
            ds_SinhVien = new DataSet();

        }

        private void DanhMucSinhVien_Load(object sender, EventArgs e)
        {

            adapt = new SqlDataAdapter("Select * from SinhVien", conn);
            adapt.Fill(ds_SinhVien, "SINHVIEN");
            dgv_sinhvien.DataSource = ds_SinhVien.Tables["SINHVIEN"];


            adapt.SelectCommand = new SqlCommand("Select * from Lop", conn);
            adapt.Fill(ds_SinhVien, "Lop");
            cbo_lop.DataSource = ds_SinhVien.Tables["Lop"];
            cbo_lop.DisplayMember = "TenLop";
            cbo_lop.ValueMember = "MaLop";
            dgv_sinhvien.AllowUserToAddRows = false; //bỏ dòng cuối trong dgv

            binding();
        }

        private void binding()
        {
            txt_masv.DataBindings.Clear();
            txt_masv.DataBindings.Add("Text", dgv_sinhvien.DataSource, "MaSinhVien");
            txt_tensv.DataBindings.Clear();
            txt_tensv.DataBindings.Add("Text", dgv_sinhvien.DataSource, "HoTen");
            msk_ngaysinh.DataBindings.Clear();
            msk_ngaysinh.DataBindings.Add("Text", dgv_sinhvien.DataSource, "NgaySinh");
            cbo_lop.DataBindings.Clear();
            cbo_lop.DataBindings.Add("SelectedValue", dgv_sinhvien.DataSource, "MaLop");
        }



        private void btn_them_Click(object sender, EventArgs e)
        {
            bool result = themSV();
            if (result)
                MessageBox.Show("Đã thêm");
            else
                MessageBox.Show("Có lỗi. Hãy thêm lại");
        }
        public bool themSV()
        {
            int kq = 0;
            adapt = new SqlDataAdapter("Select * From SinhVien", conn);
            DataRow newrow = ds_SinhVien.Tables["SINHVIEN"].NewRow();
            newrow["MaSinhVien"] = txt_masv.Text;
            newrow["HoTen"] = txt_tensv.Text;
            newrow["NgaySinh"] = msk_ngaysinh.Text;
            newrow["MaLop"] = cbo_lop.SelectedValue;
            ds_SinhVien.Tables["SINHVIEN"].Rows.Add(newrow);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapt);
            kq = adapt.Update(ds_SinhVien, "SINHVIEN");

            if (kq == 0)
                return false;
            else
                return true;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            bool result = xoa();
            if (result)
                MessageBox.Show("Đã xóa");
            else
                MessageBox.Show("Có lỗi. Hãy xóa lại");
        }
        private bool xoa()
        {
            int kq = 0;
            DataTable dtSV = ds_SinhVien.Tables["SINHVIEN"];
            dtSV.PrimaryKey = new DataColumn[] { dtSV.Columns["MaSinhVien"] };
            adapt = new SqlDataAdapter("Select * From SinhVien", conn);
            DataRow dr = ds_SinhVien.Tables["SINHVIEN"].Rows.Find(txt_masv.Text);
            if (dr != null)
            {
                dr.Delete();
            }
            SqlCommandBuilder builder = new SqlCommandBuilder(adapt);
            kq = adapt.Update(ds_SinhVien, "SINHVIEN");
            if (kq == 0)
                return false;
            else
                return true;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            DataTable dtSV = ds_SinhVien.Tables["SINHVIEN"];
            dtSV.PrimaryKey = new DataColumn[] { dtSV.Columns["MaSinhVien"] };
            adapt = new SqlDataAdapter("Select * From SinhVien", conn);
            DataRow dr = ds_SinhVien.Tables["SINHVIEN"].Rows.Find(txt_masv.Text);
            if (dr != null)
            {
                dr["HoTen"] = txt_tensv.Text;
                dr["NgaySinh"] = msk_ngaysinh.Text;
                dr["MaLop"] = cbo_lop.SelectedValue;
            }
            SqlCommandBuilder builder = new SqlCommandBuilder(adapt);
            adapt.UpdateCommand = builder.GetUpdateCommand();
            adapt.Update(ds_SinhVien, "SINHVIEN");
            MessageBox.Show("Cập nhật thành công!");
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn có muốn thoát hay không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                this.Close();
        }

        private void cbo_lop_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedClass = cbo_lop.SelectedValue.ToString();
            DataView dv = new DataView(ds_SinhVien.Tables["SINHVIEN"]);
            dv.RowFilter = "MaLop = '" + selectedClass + "'";
            dgv_sinhvien.DataSource = dv;

            int SiSo = dgv_sinhvien.Rows.Count;
            lbl_sisolop.Text = "Sĩ số lớp: " + SiSo + " ";
            binding();
        }
        private void XuatThongBao()
        {
            int SiSo = dgv_sinhvien.Rows.Count;
            int tongSoHocSinhVang = 0;
            string lyDoVang = "";

            foreach (DataGridViewRow row in dgv_sinhvien.Rows)
            {
                if (row.Cells["diemdanh"].Value != null && (bool)row.Cells["diemdanh"].Value)
                {
                    tongSoHocSinhVang++;

                    if (row.Cells["ghichu"].Value != null)
                    {
                        lyDoVang += $"{row.Cells["HoTen"].Value}: {row.Cells["ghichu"].Value}\n";
                    }
                }
            }

            string thongBao = $"Sĩ Số: {SiSo}\n" +
                              $"Tổng số học sinh vắng: {tongSoHocSinhVang}\n\n" +
                              $"Ghi chú:\n{lyDoVang}";
            string duongdanFile = "D:/VanMinh/baocao.txt";
            using (StreamWriter sw = new StreamWriter(duongdanFile))
            {
                sw.Write(thongBao);
            }

            MessageBox.Show("Xuất file thành công");
        }
        private void btn_show_Click(object sender, EventArgs e)
        {
            XuatThongBao();
        }




        private void msk_ngaysinh_Validating(object sender, CancelEventArgs e)
        {
            string input = msk_ngaysinh.Text;
            DateTime date;
            bool isValidDate = DateTime.TryParseExact(input, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date);

            if (!isValidDate)
            {
                e.Cancel = true; // Hủy sự kiện Validating
                msk_ngaysinh.Focus(); // Đưa con trỏ về MaskedTextBox
                errorProvider1.SetError(msk_ngaysinh, "Ngày không hợp lệ. Vui lòng nhập lại theo định dạng dd/MM/yyyy.");
            }
            else
            {
                errorProvider1.SetError(msk_ngaysinh, ""); // Xóa thông báo lỗi nếu ngày hợp lệ
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            DateTime ngayDiemDanh = dtp_Ngaydiemdanh.Value.Date; // Lấy ngày điểm danh từ DateTimePicker

            foreach (DataGridViewRow row in dgv_sinhvien.Rows)
            {
                string maSinhVien = string.Empty; // Khởi tạo giá trị mặc định

                if (row.Cells["MaSinhVien"].Value != null)
                {
                    maSinhVien = row.Cells["MaSinhVien"].Value.ToString();
                }

                bool isPresent = Convert.ToBoolean(row.Cells["diemdanh"].Value);
                string ghiChu = string.Empty;

                // Lấy ghi chú từ ô tương ứng trong DataGridView
                if (row.Cells["ghichu"].Value != null)
                {
                    ghiChu = row.Cells["ghichu"].Value.ToString();
                }

                // Cập nhật số tiết vắng và ghi chú trong CSDL
                if (isPresent)
                {
                    CapNhatDiemDanh(maSinhVien, 1, ghiChu, ngayDiemDanh);
                }
                else
                {
                    CapNhatDiemDanh(maSinhVien, 0, ghiChu, ngayDiemDanh);
                }
            }

            MessageBox.Show("Điểm danh thành công.");
        }
        private void CapNhatDiemDanh(string maSinhVien, int soTietVang, string ghiChu, DateTime ngayDiemDanh)
        {
            try
            {
                conn.Open();
                // Kiểm tra xem đã có bản ghi điểm danh cho sinh viên và ngày cụ thể chưa
                string selectQuery = "SELECT SoTietVang FROM ChiTietDiemDanh WHERE MaSinhVien = @MaSinhVien AND NgayDiemDanh = @NgayDiemDanh";
                using (SqlCommand selectCommand = new SqlCommand(selectQuery, conn))
                {
                    selectCommand.Parameters.AddWithValue("@MaSinhVien", maSinhVien);
                    selectCommand.Parameters.AddWithValue("@NgayDiemDanh", ngayDiemDanh);
                    object ketqua = selectCommand.ExecuteScalar();

                    if (ketqua != null)  // Bản ghi tồn tại thì cập nhật số tiết vắng
                    {
                        int existingSoTietVang = Convert.ToInt32(ketqua);
                        soTietVang += existingSoTietVang; // Tăng lên 1
                        string updateQuery = "UPDATE ChiTietDiemDanh SET SoTietVang = @SoTietVang, LyDo = @LyDo WHERE MaSinhVien = @MaSinhVien AND NgayDiemDanh = @NgayDiemDanh";
                        using (SqlCommand updateCommand = new SqlCommand(updateQuery, conn))
                        {
                            updateCommand.Parameters.AddWithValue("@SoTietVang", soTietVang);
                            updateCommand.Parameters.AddWithValue("@LyDo", ghiChu);
                            updateCommand.Parameters.AddWithValue("@MaSinhVien", maSinhVien);
                            updateCommand.Parameters.AddWithValue("@NgayDiemDanh", ngayDiemDanh);
                            updateCommand.ExecuteNonQuery();
                        }
                    }
                    else // ko tồn tại thì thêm mới
                    {
                        string insertQuery = "INSERT INTO ChiTietDiemDanh (MaSinhVien, SoTietVang, LyDo,NgayDiemDanh) VALUES (@MaSinhVien, @SoTietVang, @LyDo,@NgayDiemDanh)";
                        using (SqlCommand insertCommand = new SqlCommand(insertQuery, conn))
                        {
                            insertCommand.Parameters.AddWithValue("@MaSinhVien", maSinhVien);
                            insertCommand.Parameters.AddWithValue("@SoTietVang", soTietVang);
                            insertCommand.Parameters.AddWithValue("@LyDo", ghiChu);
                            insertCommand.Parameters.AddWithValue("@NgayDiemDanh", ngayDiemDanh);
                            insertCommand.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
