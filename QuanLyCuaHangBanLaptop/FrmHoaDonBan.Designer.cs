﻿namespace QuanLyCuaHangBanLaptop
{
    partial class FrmHoaDonBan
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnXemCT = new System.Windows.Forms.Button();
            this.btnXemCTTheoMHD = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.MaHDBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLapHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLayHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TriGiaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHDBan,
            this.MaKH,
            this.MaNV,
            this.NgayLapHD,
            this.NgayLayHang,
            this.TriGiaHD});
            this.dgv.Location = new System.Drawing.Point(4, 75);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(780, 272);
            this.dgv.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(12, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(97, 37);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnXemCT
            // 
            this.btnXemCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemCT.Location = new System.Drawing.Point(159, 12);
            this.btnXemCT.Name = "btnXemCT";
            this.btnXemCT.Size = new System.Drawing.Size(139, 37);
            this.btnXemCT.TabIndex = 2;
            this.btnXemCT.Text = "Xem Chi Tiết";
            this.btnXemCT.UseVisualStyleBackColor = true;
            this.btnXemCT.Click += new System.EventHandler(this.btnXemCT_Click);
            // 
            // btnXemCTTheoMHD
            // 
            this.btnXemCTTheoMHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemCTTheoMHD.Location = new System.Drawing.Point(341, 12);
            this.btnXemCTTheoMHD.Name = "btnXemCTTheoMHD";
            this.btnXemCTTheoMHD.Size = new System.Drawing.Size(293, 37);
            this.btnXemCTTheoMHD.TabIndex = 3;
            this.btnXemCTTheoMHD.Text = "Xem Chi Tiết Theo Mã Hóa Đơn";
            this.btnXemCTTheoMHD.UseVisualStyleBackColor = true;
            this.btnXemCTTheoMHD.Click += new System.EventHandler(this.btnXemCTTheoMHD_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(680, 12);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(97, 37);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // MaHDBan
            // 
            this.MaHDBan.DataPropertyName = "MaHDB";
            this.MaHDBan.HeaderText = "Mã HĐ Bán";
            this.MaHDBan.Name = "MaHDBan";
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã KH";
            this.MaKH.Name = "MaKH";
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.Name = "MaNV";
            // 
            // NgayLapHD
            // 
            this.NgayLapHD.DataPropertyName = "NgayLapHD";
            this.NgayLapHD.HeaderText = "Ngày lập HD";
            this.NgayLapHD.Name = "NgayLapHD";
            // 
            // NgayLayHang
            // 
            this.NgayLayHang.DataPropertyName = "NgayLayHang";
            this.NgayLayHang.HeaderText = "Ngày Lấy Hàng";
            this.NgayLayHang.Name = "NgayLayHang";
            // 
            // TriGiaHD
            // 
            this.TriGiaHD.DataPropertyName = "TongTien";
            this.TriGiaHD.HeaderText = "Trị Giá HĐ";
            this.TriGiaHD.Name = "TriGiaHD";
            // 
            // FrmHoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 364);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnXemCTTheoMHD);
            this.Controls.Add(this.btnXemCT);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgv);
            this.Name = "FrmHoaDonBan";
            this.Text = "FrmHoaDonBan";
            this.Load += new System.EventHandler(this.FrmHoaDonBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnXemCT;
        private System.Windows.Forms.Button btnXemCTTheoMHD;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHDBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLapHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLayHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TriGiaHD;
    }
}