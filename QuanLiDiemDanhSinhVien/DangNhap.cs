using System.Data;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;

namespace QuanLiDiemDanhSinhVien
{
    public partial class DangNhap : Form
    {
        private string sql = @"Data Source=BIMBIM; Initial Catalog = QLSINHVIEN; User ID = sa;Password=123";
        SqlConnection conn;
        public DangNhap()
        {
            InitializeComponent();
            conn = new SqlConnection(sql);
        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox2, "Minimize");
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox1, "Close");
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_taikhoan.Text))
            {
                MessageBox.Show("Nhập tài khoản");
                txt_taikhoan.Select();
                return;
            }
            if (string.IsNullOrEmpty(txt_matkhau.Text))
            {
                MessageBox.Show("Nhập mật khẩu");
                txt_matkhau.Select();
                return;
            }
            string tk = txt_taikhoan.Text;
            string mk = txt_matkhau.Text;
            if (conn.State == ConnectionState.Closed) { conn.Open(); } //kiem tra ket noi 
            string dnsql = "SELECT * FROM TaiKhoan where username = '" + tk + "' and pword = '" + mk + "'";
            SqlCommand cmd = new SqlCommand(dnsql, conn);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                MessageBox.Show("Đăng nhập thành công");
                if (txt_taikhoan.Text == "giangvien")
                {
                    FormMain formMain = new FormMain();

                    formMain.Show();
                }
                else if (txt_taikhoan.Text == "sinhvien")
                {
                    Diemdanh xemds = new Diemdanh();
                    xemds.Show();

                }
                else { MessageBox.Show("Lỗi đăng nhập"); }
            }
            else { MessageBox.Show("Tên tài khoản hoặc mật khẩu không hợp lệ"); }
            if (conn.State == ConnectionState.Open) { conn.Close(); }
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
           
        }
    }
}