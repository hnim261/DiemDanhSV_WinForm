namespace QuanLiDiemDanhSinhVien
{
    partial class Diemdanh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_masv = new TextBox();
            txt_tensv = new TextBox();
            cbo_lop = new ComboBox();
            btn_them = new Button();
            btn_xoa = new Button();
            btn_sua = new Button();
            btn_thoat = new Button();
            dgv_sinhvien = new DataGridView();
            msk_ngaysinh = new MaskedTextBox();
            btn_show = new Button();
            errorProvider1 = new ErrorProvider(components);
            btn_luu = new Button();
            lbl_sisolop = new Label();
            dtp_Ngaydiemdanh = new DateTimePicker();
            label5 = new Label();
            chk_diemdanh = new DataGridViewCheckBoxColumn();
            ghichu = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv_sinhvien).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(151, 33);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã sinh viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 82);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 0;
            label2.Text = "Tên sinh viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(657, 42);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 0;
            label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(657, 82);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 0;
            label4.Text = "Lớp";
            // 
            // txt_masv
            // 
            txt_masv.Location = new Point(236, 27);
            txt_masv.Margin = new Padding(4, 3, 4, 3);
            txt_masv.Name = "txt_masv";
            txt_masv.Size = new Size(227, 23);
            txt_masv.TabIndex = 1;
            // 
            // txt_tensv
            // 
            txt_tensv.Location = new Point(236, 78);
            txt_tensv.Margin = new Padding(4, 3, 4, 3);
            txt_tensv.Name = "txt_tensv";
            txt_tensv.Size = new Size(227, 23);
            txt_tensv.TabIndex = 1;
            // 
            // cbo_lop
            // 
            cbo_lop.FormattingEnabled = true;
            cbo_lop.Location = new Point(703, 82);
            cbo_lop.Margin = new Padding(4, 3, 4, 3);
            cbo_lop.Name = "cbo_lop";
            cbo_lop.Size = new Size(168, 23);
            cbo_lop.TabIndex = 2;
            cbo_lop.SelectedIndexChanged += cbo_lop_SelectedIndexChanged;
            // 
            // btn_them
            // 
            btn_them.Location = new Point(469, 194);
            btn_them.Margin = new Padding(4, 3, 4, 3);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(88, 27);
            btn_them.TabIndex = 3;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.Location = new Point(584, 194);
            btn_xoa.Margin = new Padding(4, 3, 4, 3);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(88, 27);
            btn_xoa.TabIndex = 3;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // btn_sua
            // 
            btn_sua.Location = new Point(703, 194);
            btn_sua.Margin = new Padding(4, 3, 4, 3);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(88, 27);
            btn_sua.TabIndex = 3;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = true;
            btn_sua.Click += btn_sua_Click;
            // 
            // btn_thoat
            // 
            btn_thoat.Location = new Point(821, 194);
            btn_thoat.Margin = new Padding(4, 3, 4, 3);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(88, 27);
            btn_thoat.TabIndex = 3;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = true;
            btn_thoat.Click += btn_thoat_Click;
            // 
            // dgv_sinhvien
            // 
            dgv_sinhvien.BackgroundColor = SystemColors.InactiveBorder;
            dgv_sinhvien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_sinhvien.Columns.AddRange(new DataGridViewColumn[] { chk_diemdanh, ghichu });
            dgv_sinhvien.Location = new Point(127, 241);
            dgv_sinhvien.Margin = new Padding(4, 3, 4, 3);
            dgv_sinhvien.Name = "dgv_sinhvien";
            dgv_sinhvien.Size = new Size(784, 246);
            dgv_sinhvien.TabIndex = 4;
            // 
            // msk_ngaysinh
            // 
            msk_ngaysinh.Location = new Point(731, 33);
            msk_ngaysinh.Margin = new Padding(4, 3, 4, 3);
            msk_ngaysinh.Mask = "00/00/0000";
            msk_ngaysinh.Name = "msk_ngaysinh";
            msk_ngaysinh.Size = new Size(140, 23);
            msk_ngaysinh.TabIndex = 5;
            msk_ngaysinh.ValidatingType = typeof(DateTime);
            msk_ngaysinh.Validating += msk_ngaysinh_Validating;
            // 
            // btn_show
            // 
            btn_show.Location = new Point(670, 503);
            btn_show.Margin = new Padding(4, 3, 4, 3);
            btn_show.Name = "btn_show";
            btn_show.Size = new Size(88, 27);
            btn_show.TabIndex = 6;
            btn_show.Text = "Xuất file";
            btn_show.UseVisualStyleBackColor = true;
            btn_show.Click += btn_show_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btn_luu
            // 
            btn_luu.Location = new Point(766, 502);
            btn_luu.Margin = new Padding(4, 3, 4, 3);
            btn_luu.Name = "btn_luu";
            btn_luu.Size = new Size(145, 27);
            btn_luu.TabIndex = 7;
            btn_luu.Text = "Lưu danh sách";
            btn_luu.UseVisualStyleBackColor = true;
            btn_luu.Click += btn_luu_Click;
            // 
            // lbl_sisolop
            // 
            lbl_sisolop.AutoSize = true;
            lbl_sisolop.Location = new Point(14, 167);
            lbl_sisolop.Margin = new Padding(4, 0, 4, 0);
            lbl_sisolop.Name = "lbl_sisolop";
            lbl_sisolop.Size = new Size(0, 15);
            lbl_sisolop.TabIndex = 8;
            // 
            // dtp_Ngaydiemdanh
            // 
            dtp_Ngaydiemdanh.Location = new Point(287, 129);
            dtp_Ngaydiemdanh.Margin = new Padding(4, 3, 4, 3);
            dtp_Ngaydiemdanh.Name = "dtp_Ngaydiemdanh";
            dtp_Ngaydiemdanh.Size = new Size(176, 23);
            dtp_Ngaydiemdanh.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(151, 136);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(125, 15);
            label5.TabIndex = 10;
            label5.Text = "Chọn ngày điểm danh";
            // 
            // chk_diemdanh
            // 
            chk_diemdanh.HeaderText = "Điểm danh";
            chk_diemdanh.Name = "chk_diemdanh";
            // 
            // ghichu
            // 
            ghichu.HeaderText = "Ghi chú";
            ghichu.Name = "ghichu";
            ghichu.Width = 120;
            // 
            // Diemdanh
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1046, 542);
            Controls.Add(label5);
            Controls.Add(dtp_Ngaydiemdanh);
            Controls.Add(lbl_sisolop);
            Controls.Add(btn_luu);
            Controls.Add(btn_show);
            Controls.Add(msk_ngaysinh);
            Controls.Add(dgv_sinhvien);
            Controls.Add(btn_thoat);
            Controls.Add(btn_sua);
            Controls.Add(btn_xoa);
            Controls.Add(btn_them);
            Controls.Add(cbo_lop);
            Controls.Add(txt_tensv);
            Controls.Add(txt_masv);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Diemdanh";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Điểm danh";
            Load += DanhMucSinhVien_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_sinhvien).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_masv;
        private TextBox txt_tensv;
        private ComboBox cbo_lop;
        private Button btn_them;
        private Button btn_xoa;
        private Button btn_sua;
        private Button btn_thoat;
        private DataGridView dgv_sinhvien;
        private MaskedTextBox msk_ngaysinh;
        private Button btn_show;
        private ErrorProvider errorProvider1;
        private Button btn_luu;
        private Label lbl_sisolop;
        private DateTimePicker dtp_Ngaydiemdanh;
        private Label label5;
        private DataGridViewCheckBoxColumn diemdanh;
        private DataGridViewCheckBoxColumn chk_diemdanh;
        private DataGridViewTextBoxColumn ghichu;
    }
}