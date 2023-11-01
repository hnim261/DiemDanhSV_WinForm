namespace QuanLiDiemDanhSinhVien
{
    partial class DangNhap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            groupBox1 = new GroupBox();
            btn_dangnhap = new Button();
            pictureBox3 = new PictureBox();
            txt_taikhoan = new TextBox();
            txt_matkhau = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            label3 = new Label();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.close;
            pictureBox1.Location = new Point(1141, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.MouseHover += pictureBox1_MouseHover;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.minimize;
            pictureBox2.Location = new Point(1095, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            pictureBox2.MouseHover += pictureBox2_MouseHover;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(btn_dangnhap);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(txt_taikhoan);
            groupBox1.Controls.Add(txt_matkhau);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(107, 190);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(452, 348);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Đăng nhập";
            // 
            // btn_dangnhap
            // 
            btn_dangnhap.Location = new Point(158, 235);
            btn_dangnhap.Name = "btn_dangnhap";
            btn_dangnhap.Size = new Size(111, 43);
            btn_dangnhap.TabIndex = 2;
            btn_dangnhap.Text = "Đăng nhập";
            btn_dangnhap.UseVisualStyleBackColor = true;
            btn_dangnhap.Click += btn_dangnhap_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = Properties.Resources.hide;
            pictureBox3.Location = new Point(366, 174);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 24);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox2_Click;
            // 
            // txt_taikhoan
            // 
            txt_taikhoan.Location = new Point(95, 81);
            txt_taikhoan.Name = "txt_taikhoan";
            txt_taikhoan.Size = new Size(265, 24);
            txt_taikhoan.TabIndex = 1;
            // 
            // txt_matkhau
            // 
            txt_matkhau.Location = new Point(95, 174);
            txt_matkhau.Name = "txt_matkhau";
            txt_matkhau.Size = new Size(265, 24);
            txt_matkhau.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(95, 47);
            label2.Name = "label2";
            label2.Size = new Size(105, 16);
            label2.TabIndex = 0;
            label2.Text = "Tên tài khoản";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(95, 139);
            label1.Name = "label1";
            label1.Size = new Size(76, 16);
            label1.TabIndex = 0;
            label1.Text = "Mật khẩu";
            // 
            // panel1
            // 
            panel1.Location = new Point(696, 163);
            panel1.Name = "panel1";
            panel1.Size = new Size(5, 408);
            panel1.TabIndex = 0;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.student;
            pictureBox4.Location = new Point(840, 185);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(202, 218);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 15.5F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(844, 431);
            label3.Name = "label3";
            label3.Size = new Size(198, 25);
            label3.TabIndex = 2;
            label3.Text = "Quản lí điểm danh";
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 681);
            Controls.Add(label3);
            Controls.Add(pictureBox4);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "DangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            WindowState = FormWindowState.Maximized;
            Load += DangNhap_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private GroupBox groupBox1;
        private Button btn_dangnhap;
        private TextBox txt_matkhau;
        private Label label1;
        private Label label2;
        private TextBox txt_taikhoan;
        private PictureBox pictureBox3;
        private Panel panel1;
        private PictureBox pictureBox4;
        private Label label3;
        private ToolTip toolTip1;
    }
}