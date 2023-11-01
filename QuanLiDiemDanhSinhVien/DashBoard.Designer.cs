namespace QuanLiDiemDanhSinhVien
{
    partial class DashBoard
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
            lbl_tonglophoc = new Label();
            panel2 = new Panel();
            lbl_tongsinhvien = new Label();
            panel3 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(253, 183, 71);
            panel1.Controls.Add(lbl_tonglophoc);
            panel1.Location = new Point(115, 84);
            panel1.Name = "panel1";
            panel1.Size = new Size(259, 128);
            panel1.TabIndex = 0;
            // 
            // lbl_tonglophoc
            // 
            lbl_tonglophoc.AutoSize = true;
            lbl_tonglophoc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_tonglophoc.ForeColor = Color.White;
            lbl_tonglophoc.Location = new Point(86, 52);
            lbl_tonglophoc.Name = "lbl_tonglophoc";
            lbl_tonglophoc.Size = new Size(70, 21);
            lbl_tonglophoc.TabIndex = 0;
            lbl_tonglophoc.Text = "Lớp học";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(lbl_tongsinhvien);
            panel2.Location = new Point(491, 84);
            panel2.Name = "panel2";
            panel2.Size = new Size(259, 128);
            panel2.TabIndex = 1;
            // 
            // lbl_tongsinhvien
            // 
            lbl_tongsinhvien.AutoSize = true;
            lbl_tongsinhvien.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_tongsinhvien.ForeColor = Color.White;
            lbl_tongsinhvien.Location = new Point(86, 52);
            lbl_tongsinhvien.Name = "lbl_tongsinhvien";
            lbl_tongsinhvien.Size = new Size(81, 21);
            lbl_tongsinhvien.TabIndex = 0;
            lbl_tongsinhvien.Text = "Sinh viên";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = Color.FromArgb(253, 183, 71);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(290, 282);
            panel3.Name = "panel3";
            panel3.Size = new Size(259, 128);
            panel3.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(86, 52);
            label2.Name = "label2";
            label2.Size = new Size(70, 21);
            label2.TabIndex = 0;
            label2.Text = "Lớp học";
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashBoard";
            Text = "DashBoard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lbl_tonglophoc;
        private Panel panel2;
        private Label lbl_tongsinhvien;
        private Panel panel3;
        private Label label2;
    }
}