
namespace BaiTapNhom
{
    partial class FormHoaDon
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBoxThongtinchung = new System.Windows.Forms.GroupBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.lblNgay = new System.Windows.Forms.Label();
            this.lblMaHD = new System.Windows.Forms.Label();
            this.lblHD = new System.Windows.Forms.Label();
            this.grBoxCTNH = new System.Windows.Forms.GroupBox();
            this.GridViewHoaDon = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnTao = new System.Windows.Forms.Button();
            this.txtNgay = new System.Windows.Forms.TextBox();
            this.cboKhachHang = new System.Windows.Forms.ComboBox();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxThongtinchung.SuspendLayout();
            this.grBoxCTNH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxThongtinchung);
            this.splitContainer1.Panel1.Controls.Add(this.lblHD);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grBoxCTNH);
            this.splitContainer1.Size = new System.Drawing.Size(1018, 581);
            this.splitContainer1.SplitterDistance = 229;
            this.splitContainer1.TabIndex = 3;
            // 
            // groupBoxThongtinchung
            // 
            this.groupBoxThongtinchung.Controls.Add(this.cboNhanVien);
            this.groupBoxThongtinchung.Controls.Add(this.cboKhachHang);
            this.groupBoxThongtinchung.Controls.Add(this.txtNgay);
            this.groupBoxThongtinchung.Controls.Add(this.lblMaNV);
            this.groupBoxThongtinchung.Controls.Add(this.txtMaHD);
            this.groupBoxThongtinchung.Controls.Add(this.lblMaKH);
            this.groupBoxThongtinchung.Controls.Add(this.lblNgay);
            this.groupBoxThongtinchung.Controls.Add(this.lblMaHD);
            this.groupBoxThongtinchung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBoxThongtinchung.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBoxThongtinchung.Location = new System.Drawing.Point(6, 60);
            this.groupBoxThongtinchung.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxThongtinchung.Name = "groupBoxThongtinchung";
            this.groupBoxThongtinchung.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxThongtinchung.Size = new System.Drawing.Size(1008, 158);
            this.groupBoxThongtinchung.TabIndex = 1;
            this.groupBoxThongtinchung.TabStop = false;
            this.groupBoxThongtinchung.Text = "Thông tin chung";
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(544, 106);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(95, 18);
            this.lblMaNV.TabIndex = 3;
            this.lblMaNV.Text = "Mã nhân viên";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(114, 35);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(271, 24);
            this.txtMaHD.TabIndex = 7;
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Location = new System.Drawing.Point(544, 40);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(109, 18);
            this.lblMaKH.TabIndex = 3;
            this.lblMaKH.Text = "Mã khách hàng";
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.Location = new System.Drawing.Point(8, 109);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(46, 18);
            this.lblNgay.TabIndex = 1;
            this.lblNgay.Text = "Ngày ";
            // 
            // lblMaHD
            // 
            this.lblMaHD.AutoSize = true;
            this.lblMaHD.Location = new System.Drawing.Point(8, 38);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(87, 18);
            this.lblMaHD.TabIndex = 0;
            this.lblMaHD.Text = "Mã hóa đơn";
            // 
            // lblHD
            // 
            this.lblHD.AutoSize = true;
            this.lblHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHD.Location = new System.Drawing.Point(333, 10);
            this.lblHD.Name = "lblHD";
            this.lblHD.Size = new System.Drawing.Size(273, 29);
            this.lblHD.TabIndex = 0;
            this.lblHD.Text = "DANH MỤC HÓA ĐƠN";
            // 
            // grBoxCTNH
            // 
            this.grBoxCTNH.Controls.Add(this.GridViewHoaDon);
            this.grBoxCTNH.Controls.Add(this.btnThoat);
            this.grBoxCTNH.Controls.Add(this.btnSua);
            this.grBoxCTNH.Controls.Add(this.btnHuy);
            this.grBoxCTNH.Controls.Add(this.btnLuu);
            this.grBoxCTNH.Controls.Add(this.btnTao);
            this.grBoxCTNH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grBoxCTNH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grBoxCTNH.Location = new System.Drawing.Point(1, 2);
            this.grBoxCTNH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grBoxCTNH.Name = "grBoxCTNH";
            this.grBoxCTNH.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grBoxCTNH.Size = new System.Drawing.Size(1020, 318);
            this.grBoxCTNH.TabIndex = 0;
            this.grBoxCTNH.TabStop = false;
            // 
            // GridViewHoaDon
            // 
            this.GridViewHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewHoaDon.Location = new System.Drawing.Point(9, 12);
            this.GridViewHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GridViewHoaDon.Name = "GridViewHoaDon";
            this.GridViewHoaDon.RowHeadersWidth = 51;
            this.GridViewHoaDon.RowTemplate.Height = 24;
            this.GridViewHoaDon.Size = new System.Drawing.Size(998, 254);
            this.GridViewHoaDon.TabIndex = 22;
            this.GridViewHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewHoaDon_CellContentClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(874, 274);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(132, 35);
            this.btnThoat.TabIndex = 21;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(684, 274);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(163, 35);
            this.btnSua.TabIndex = 20;
            this.btnSua.Text = "Sửa hóa đơn";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(459, 274);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(190, 35);
            this.btnHuy.TabIndex = 19;
            this.btnHuy.Text = "Hủy hóa đơn";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(240, 274);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(189, 35);
            this.btnLuu.TabIndex = 18;
            this.btnLuu.Text = "Lưu hóa đơn";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnTao
            // 
            this.btnTao.Location = new System.Drawing.Point(11, 274);
            this.btnTao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(193, 35);
            this.btnTao.TabIndex = 17;
            this.btnTao.Text = "Tạo hóa đơn mới";
            this.btnTao.UseVisualStyleBackColor = true;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // txtNgay
            // 
            this.txtNgay.Location = new System.Drawing.Point(114, 106);
            this.txtNgay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Size = new System.Drawing.Size(271, 24);
            this.txtNgay.TabIndex = 8;
            // 
            // cboKhachHang
            // 
            this.cboKhachHang.FormattingEnabled = true;
            this.cboKhachHang.Location = new System.Drawing.Point(710, 40);
            this.cboKhachHang.Name = "cboKhachHang";
            this.cboKhachHang.Size = new System.Drawing.Size(271, 26);
            this.cboKhachHang.TabIndex = 9;
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(710, 98);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(271, 26);
            this.cboNhanVien.TabIndex = 10;
            // 
            // FormHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 581);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormHoaDon";
            this.Text = "FormGiaoHang";
            this.Load += new System.EventHandler(this.FormHoaDon_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxThongtinchung.ResumeLayout(false);
            this.groupBoxThongtinchung.PerformLayout();
            this.grBoxCTNH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBoxThongtinchung;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.Label lblMaHD;
        private System.Windows.Forms.Label lblHD;
        private System.Windows.Forms.GroupBox grBoxCTNH;
        private System.Windows.Forms.DataGridView GridViewHoaDon;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.TextBox txtNgay;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.ComboBox cboKhachHang;
    }
}