
namespace BaiTapNhom
{
    partial class FormCTNH
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
            this.numSLH = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numSoluong = new System.Windows.Forms.NumericUpDown();
            this.txtMaCTNH = new System.Windows.Forms.TextBox();
            this.lblMaNCC = new System.Windows.Forms.Label();
            this.lblTongtien = new System.Windows.Forms.Label();
            this.lblNgaynhap = new System.Windows.Forms.Label();
            this.lblmanhap1 = new System.Windows.Forms.Label();
            this.lblDM = new System.Windows.Forms.Label();
            this.grBoxCTNH = new System.Windows.Forms.GroupBox();
            this.GridViewCTNH = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnTao = new System.Windows.Forms.Button();
            this.cboManhap = new System.Windows.Forms.ComboBox();
            this.cboMahang = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxThongtinchung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSLH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoluong)).BeginInit();
            this.grBoxCTNH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCTNH)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.AllowDrop = true;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxThongtinchung);
            this.splitContainer1.Panel1.Controls.Add(this.lblDM);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grBoxCTNH);
            this.splitContainer1.Size = new System.Drawing.Size(1070, 577);
            this.splitContainer1.SplitterDistance = 258;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBoxThongtinchung
            // 
            this.groupBoxThongtinchung.Controls.Add(this.cboMahang);
            this.groupBoxThongtinchung.Controls.Add(this.cboManhap);
            this.groupBoxThongtinchung.Controls.Add(this.numSLH);
            this.groupBoxThongtinchung.Controls.Add(this.label1);
            this.groupBoxThongtinchung.Controls.Add(this.numSoluong);
            this.groupBoxThongtinchung.Controls.Add(this.txtMaCTNH);
            this.groupBoxThongtinchung.Controls.Add(this.lblMaNCC);
            this.groupBoxThongtinchung.Controls.Add(this.lblTongtien);
            this.groupBoxThongtinchung.Controls.Add(this.lblNgaynhap);
            this.groupBoxThongtinchung.Controls.Add(this.lblmanhap1);
            this.groupBoxThongtinchung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBoxThongtinchung.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBoxThongtinchung.Location = new System.Drawing.Point(15, 64);
            this.groupBoxThongtinchung.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxThongtinchung.Name = "groupBoxThongtinchung";
            this.groupBoxThongtinchung.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxThongtinchung.Size = new System.Drawing.Size(1037, 183);
            this.groupBoxThongtinchung.TabIndex = 2;
            this.groupBoxThongtinchung.TabStop = false;
            this.groupBoxThongtinchung.Text = "Thông tin chung";
            // 
            // numSLH
            // 
            this.numSLH.Location = new System.Drawing.Point(785, 82);
            this.numSLH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numSLH.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numSLH.Name = "numSLH";
            this.numSLH.Size = new System.Drawing.Size(243, 24);
            this.numSLH.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(623, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Số lượng hỏng";
            // 
            // numSoluong
            // 
            this.numSoluong.Location = new System.Drawing.Point(785, 32);
            this.numSoluong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numSoluong.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numSoluong.Name = "numSoluong";
            this.numSoluong.Size = new System.Drawing.Size(243, 24);
            this.numSoluong.TabIndex = 16;
            // 
            // txtMaCTNH
            // 
            this.txtMaCTNH.Location = new System.Drawing.Point(123, 142);
            this.txtMaCTNH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaCTNH.Name = "txtMaCTNH";
            this.txtMaCTNH.Size = new System.Drawing.Size(241, 24);
            this.txtMaCTNH.TabIndex = 10;
            // 
            // lblMaNCC
            // 
            this.lblMaNCC.AutoSize = true;
            this.lblMaNCC.Location = new System.Drawing.Point(5, 145);
            this.lblMaNCC.Name = "lblMaNCC";
            this.lblMaNCC.Size = new System.Drawing.Size(75, 18);
            this.lblMaNCC.TabIndex = 3;
            this.lblMaNCC.Text = "Mã CTNH";
            // 
            // lblTongtien
            // 
            this.lblTongtien.AutoSize = true;
            this.lblTongtien.Location = new System.Drawing.Point(623, 34);
            this.lblTongtien.Name = "lblTongtien";
            this.lblTongtien.Size = new System.Drawing.Size(71, 18);
            this.lblTongtien.TabIndex = 2;
            this.lblTongtien.Text = "Số lượng ";
            // 
            // lblNgaynhap
            // 
            this.lblNgaynhap.AutoSize = true;
            this.lblNgaynhap.Location = new System.Drawing.Point(5, 90);
            this.lblNgaynhap.Name = "lblNgaynhap";
            this.lblNgaynhap.Size = new System.Drawing.Size(65, 18);
            this.lblNgaynhap.TabIndex = 1;
            this.lblNgaynhap.Text = "Mã hàng";
            // 
            // lblmanhap1
            // 
            this.lblmanhap1.AutoSize = true;
            this.lblmanhap1.Location = new System.Drawing.Point(5, 34);
            this.lblmanhap1.Name = "lblmanhap1";
            this.lblmanhap1.Size = new System.Drawing.Size(65, 18);
            this.lblmanhap1.TabIndex = 0;
            this.lblmanhap1.Text = "Mã nhập";
            // 
            // lblDM
            // 
            this.lblDM.AutoSize = true;
            this.lblDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDM.Location = new System.Drawing.Point(293, 11);
            this.lblDM.Name = "lblDM";
            this.lblDM.Size = new System.Drawing.Size(419, 29);
            this.lblDM.TabIndex = 1;
            this.lblDM.Text = "DANH MỤC CHI TIẾT NHẬP HÀNG";
            // 
            // grBoxCTNH
            // 
            this.grBoxCTNH.Controls.Add(this.GridViewCTNH);
            this.grBoxCTNH.Controls.Add(this.btnThoat);
            this.grBoxCTNH.Controls.Add(this.btnSua);
            this.grBoxCTNH.Controls.Add(this.btnHuy);
            this.grBoxCTNH.Controls.Add(this.btnLuu);
            this.grBoxCTNH.Controls.Add(this.btnTao);
            this.grBoxCTNH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grBoxCTNH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grBoxCTNH.Location = new System.Drawing.Point(15, 7);
            this.grBoxCTNH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grBoxCTNH.Name = "grBoxCTNH";
            this.grBoxCTNH.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grBoxCTNH.Size = new System.Drawing.Size(1037, 283);
            this.grBoxCTNH.TabIndex = 1;
            this.grBoxCTNH.TabStop = false;
            // 
            // GridViewCTNH
            // 
            this.GridViewCTNH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewCTNH.Location = new System.Drawing.Point(0, 12);
            this.GridViewCTNH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GridViewCTNH.Name = "GridViewCTNH";
            this.GridViewCTNH.RowHeadersWidth = 51;
            this.GridViewCTNH.RowTemplate.Height = 24;
            this.GridViewCTNH.Size = new System.Drawing.Size(1037, 226);
            this.GridViewCTNH.TabIndex = 22;
            this.GridViewCTNH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewCTNH_CellContentClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(915, 244);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(117, 31);
            this.btnThoat.TabIndex = 21;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(699, 244);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(145, 31);
            this.btnSua.TabIndex = 20;
            this.btnSua.Text = "Sửa CTHD";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(457, 244);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(169, 31);
            this.btnHuy.TabIndex = 19;
            this.btnHuy.Text = "Hủy CTHD";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(228, 244);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(168, 31);
            this.btnLuu.TabIndex = 18;
            this.btnLuu.Text = "Lưu CTHD";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnTao
            // 
            this.btnTao.Location = new System.Drawing.Point(5, 244);
            this.btnTao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(176, 31);
            this.btnTao.TabIndex = 17;
            this.btnTao.Text = "Tạo CTHD mới";
            this.btnTao.UseVisualStyleBackColor = true;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // cboManhap
            // 
            this.cboManhap.FormattingEnabled = true;
            this.cboManhap.Location = new System.Drawing.Point(123, 32);
            this.cboManhap.Name = "cboManhap";
            this.cboManhap.Size = new System.Drawing.Size(241, 26);
            this.cboManhap.TabIndex = 22;
            // 
            // cboMahang
            // 
            this.cboMahang.FormattingEnabled = true;
            this.cboMahang.Location = new System.Drawing.Point(123, 80);
            this.cboMahang.Name = "cboMahang";
            this.cboMahang.Size = new System.Drawing.Size(241, 26);
            this.cboMahang.TabIndex = 23;
            // 
            // FormCTNH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 577);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormCTNH";
            this.Text = "FormCTNH";
            this.Load += new System.EventHandler(this.FormCTNH_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxThongtinchung.ResumeLayout(false);
            this.groupBoxThongtinchung.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSLH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoluong)).EndInit();
            this.grBoxCTNH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCTNH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBoxThongtinchung;
        private System.Windows.Forms.NumericUpDown numSLH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numSoluong;
        private System.Windows.Forms.TextBox txtMaCTNH;
        private System.Windows.Forms.Label lblMaNCC;
        private System.Windows.Forms.Label lblTongtien;
        private System.Windows.Forms.Label lblNgaynhap;
        private System.Windows.Forms.Label lblmanhap1;
        private System.Windows.Forms.Label lblDM;
        private System.Windows.Forms.GroupBox grBoxCTNH;
        private System.Windows.Forms.DataGridView GridViewCTNH;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.ComboBox cboMahang;
        private System.Windows.Forms.ComboBox cboManhap;
    }
}