using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiDiemDanhSinhVien
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelBack2.Controls.Add(childForm);
            panelBack2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            OpenChildForm(new DashBoard());
        }
        private void MoveSlide(Control button)
        {
            panelSlide.Location = new Point(button.Location.X - button.Location.X, button.Location.Y - 180);
        }

        private void btn_dieukien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DashBoard());
            MoveSlide(btn_dieukien);
        }

        private void btn_Ddpanel_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Diemdanh());
            MoveSlide(btn_Ddpanel);
        }
        private void btn_baocao_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BaoCao());
            MoveSlide(btn_baocao);
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
