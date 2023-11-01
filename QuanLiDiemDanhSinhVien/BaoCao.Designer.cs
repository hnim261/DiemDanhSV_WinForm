namespace QuanLiDiemDanhSinhVien
{
    partial class BaoCao
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_phanhoi = new System.Windows.Forms.Button();
            this.dtp_xemdiemdanh = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách đã điểm danh";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(734, 330);
            this.dataGridView1.TabIndex = 2;
            // 
            // btn_phanhoi
            // 
            this.btn_phanhoi.Location = new System.Drawing.Point(75, 40);
            this.btn_phanhoi.Name = "btn_phanhoi";
            this.btn_phanhoi.Size = new System.Drawing.Size(75, 23);
            this.btn_phanhoi.TabIndex = 3;
            this.btn_phanhoi.Text = "Phản hồi";
            this.btn_phanhoi.UseVisualStyleBackColor = true;
            // 
            // dtp_xemdiemdanh
            // 
            this.dtp_xemdiemdanh.Location = new System.Drawing.Point(139, 118);
            this.dtp_xemdiemdanh.Name = "dtp_xemdiemdanh";
            this.dtp_xemdiemdanh.Size = new System.Drawing.Size(210, 20);
            this.dtp_xemdiemdanh.TabIndex = 4;
            this.dtp_xemdiemdanh.Value = new System.DateTime(2023, 10, 26, 10, 13, 38, 0);
            this.dtp_xemdiemdanh.ValueChanged += new System.EventHandler(this.dtp_xemdiemdanh_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Chọn ngày ";
            // 
            // Xemdiemdanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 525);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp_xemdiemdanh);
            this.Controls.Add(this.btn_phanhoi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Xemdiemdanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xemdiemdanh";
            this.Load += new System.EventHandler(this.Xemdiemdanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_phanhoi;
        private System.Windows.Forms.DateTimePicker dtp_xemdiemdanh;
        private System.Windows.Forms.Label label2;
    }
}