namespace QuanLiDiemDanhSinhVien
{
    partial class FormMain
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
            panel1 = new Panel();
            btn_baocao = new Button();
            panel3 = new Panel();
            panelSlide = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panelBack = new Panel();
            pictureBox2 = new PictureBox();
            panelTop = new Panel();
            lbl_NameRole = new Label();
            label2 = new Label();
            btn_dieukien = new Button();
            btn_Ddpanel = new Button();
            panelBack2 = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SkyBlue;
            panel1.Controls.Add(btn_baocao);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(258, 720);
            panel1.TabIndex = 0;
            // 
            // btn_baocao
            // 
            btn_baocao.BackColor = Color.SkyBlue;
            btn_baocao.Cursor = Cursors.Hand;
            btn_baocao.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_baocao.Location = new Point(8, 273);
            btn_baocao.Name = "btn_baocao";
            btn_baocao.Size = new Size(250, 48);
            btn_baocao.TabIndex = 3;
            btn_baocao.Text = "Báo cáo";
            btn_baocao.UseVisualStyleBackColor = false;
            btn_baocao.Click += btn_baocao_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(panelSlide);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 180);
            panel3.Name = "panel3";
            panel3.Size = new Size(8, 540);
            panel3.TabIndex = 0;
            // 
            // panelSlide
            // 
            panelSlide.BackColor = Color.White;
            panelSlide.Location = new Point(0, 0);
            panelSlide.Name = "panelSlide";
            panelSlide.Size = new Size(8, 47);
            panelSlide.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(258, 180);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(60, 94);
            label1.Name = "label1";
            label1.Size = new Size(138, 21);
            label1.TabIndex = 1;
            label1.Text = "Quản lí sinh viên";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.student;
            pictureBox1.Location = new Point(81, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panelBack
            // 
            panelBack.Controls.Add(pictureBox2);
            panelBack.Controls.Add(panelTop);
            panelBack.Dock = DockStyle.Top;
            panelBack.Location = new Point(258, 0);
            panelBack.Name = "panelBack";
            panelBack.Size = new Size(942, 165);
            panelBack.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.close;
            pictureBox2.Location = new Point(908, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.SkyBlue;
            panelTop.Controls.Add(lbl_NameRole);
            panelTop.Controls.Add(label2);
            panelTop.Dock = DockStyle.Bottom;
            panelTop.Location = new Point(0, 65);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(942, 100);
            panelTop.TabIndex = 0;
            // 
            // lbl_NameRole
            // 
            lbl_NameRole.AutoSize = true;
            lbl_NameRole.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_NameRole.ForeColor = SystemColors.ButtonHighlight;
            lbl_NameRole.Location = new Point(126, 19);
            lbl_NameRole.Name = "lbl_NameRole";
            lbl_NameRole.Size = new Size(17, 21);
            lbl_NameRole.TabIndex = 2;
            lbl_NameRole.Text = "?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(40, 19);
            label2.Name = "label2";
            label2.Size = new Size(80, 21);
            label2.TabIndex = 1;
            label2.Text = "Xin chào:";
            // 
            // btn_dieukien
            // 
            btn_dieukien.BackColor = Color.SkyBlue;
            btn_dieukien.Cursor = Cursors.Hand;
            btn_dieukien.FlatAppearance.BorderSize = 0;
            btn_dieukien.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_dieukien.ForeColor = SystemColors.ActiveCaptionText;
            btn_dieukien.Location = new Point(7, 180);
            btn_dieukien.Name = "btn_dieukien";
            btn_dieukien.Size = new Size(250, 48);
            btn_dieukien.TabIndex = 0;
            btn_dieukien.Text = "Điều khiển";
            btn_dieukien.UseVisualStyleBackColor = false;
            btn_dieukien.Click += btn_dieukien_Click;
            // 
            // btn_Ddpanel
            // 
            btn_Ddpanel.BackColor = Color.SkyBlue;
            btn_Ddpanel.Cursor = Cursors.Hand;
            btn_Ddpanel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Ddpanel.Location = new Point(8, 229);
            btn_Ddpanel.Name = "btn_Ddpanel";
            btn_Ddpanel.Size = new Size(250, 48);
            btn_Ddpanel.TabIndex = 2;
            btn_Ddpanel.Text = "Điểm danh";
            btn_Ddpanel.UseVisualStyleBackColor = false;
            btn_Ddpanel.Click += btn_Ddpanel_Click;
            // 
            // panelBack2
            // 
            panelBack2.Location = new Point(258, 171);
            panelBack2.Name = "panelBack2";
            panelBack2.Size = new Size(939, 549);
            panelBack2.TabIndex = 3;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 720);
            Controls.Add(panelBack2);
            Controls.Add(btn_Ddpanel);
            Controls.Add(btn_dieukien);
            Controls.Add(panelBack);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lí điểm danh";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panelBack;
        private Panel panelTop;
        private Label label2;
        private Label lbl_NameRole;
        private Panel panelSlide;
        private Panel panel3;
        private Button btn_dieukien;
        private Button btn_Ddpanel;
        private PictureBox pictureBox2;
        private Panel panelBack2;
        private Button btn_baocao;
    }
}