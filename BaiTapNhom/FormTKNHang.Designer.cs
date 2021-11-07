
namespace BaiTapNhom
{
    partial class FormTKNHang
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
            this.DataGrid_TimKiemNH = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtNgaynhap = new System.Windows.Forms.TextBox();
            this.cboMaNhap = new System.Windows.Forms.ComboBox();
            this.radioNgaynhap = new System.Windows.Forms.RadioButton();
            this.radioMaNCC = new System.Windows.Forms.RadioButton();
            this.radioMaNhap = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMaNCC = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_TimKiemNH)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrid_TimKiemNH
            // 
            this.DataGrid_TimKiemNH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_TimKiemNH.Location = new System.Drawing.Point(18, 219);
            this.DataGrid_TimKiemNH.Name = "DataGrid_TimKiemNH";
            this.DataGrid_TimKiemNH.RowHeadersWidth = 51;
            this.DataGrid_TimKiemNH.RowTemplate.Height = 24;
            this.DataGrid_TimKiemNH.Size = new System.Drawing.Size(643, 148);
            this.DataGrid_TimKiemNH.TabIndex = 25;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(536, 145);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(119, 35);
            this.btnThoat.TabIndex = 23;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(536, 88);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(119, 35);
            this.btnTimKiem.TabIndex = 24;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtNgaynhap
            // 
            this.txtNgaynhap.Location = new System.Drawing.Point(167, 166);
            this.txtNgaynhap.Name = "txtNgaynhap";
            this.txtNgaynhap.Size = new System.Drawing.Size(323, 22);
            this.txtNgaynhap.TabIndex = 21;
            // 
            // cboMaNhap
            // 
            this.cboMaNhap.FormattingEnabled = true;
            this.cboMaNhap.Location = new System.Drawing.Point(167, 75);
            this.cboMaNhap.Name = "cboMaNhap";
            this.cboMaNhap.Size = new System.Drawing.Size(323, 24);
            this.cboMaNhap.TabIndex = 20;
            // 
            // radioNgaynhap
            // 
            this.radioNgaynhap.AutoSize = true;
            this.radioNgaynhap.Location = new System.Drawing.Point(12, 168);
            this.radioNgaynhap.Name = "radioNgaynhap";
            this.radioNgaynhap.Size = new System.Drawing.Size(100, 21);
            this.radioNgaynhap.TabIndex = 17;
            this.radioNgaynhap.TabStop = true;
            this.radioNgaynhap.Text = "Ngày Nhập";
            this.radioNgaynhap.UseVisualStyleBackColor = true;
            this.radioNgaynhap.CheckedChanged += new System.EventHandler(this.radioNgaynhap_CheckedChanged);
            // 
            // radioMaNCC
            // 
            this.radioMaNCC.AutoSize = true;
            this.radioMaNCC.Location = new System.Drawing.Point(12, 124);
            this.radioMaNCC.Name = "radioMaNCC";
            this.radioMaNCC.Size = new System.Drawing.Size(144, 21);
            this.radioMaNCC.TabIndex = 18;
            this.radioMaNCC.TabStop = true;
            this.radioMaNCC.Text = "Mã Nhà Cung Cấp";
            this.radioMaNCC.UseVisualStyleBackColor = true;
            this.radioMaNCC.CheckedChanged += new System.EventHandler(this.radioMaNCC_CheckedChanged);
            // 
            // radioMaNhap
            // 
            this.radioMaNhap.AutoSize = true;
            this.radioMaNhap.Location = new System.Drawing.Point(12, 79);
            this.radioMaNhap.Name = "radioMaNhap";
            this.radioMaNhap.Size = new System.Drawing.Size(86, 21);
            this.radioMaNhap.TabIndex = 19;
            this.radioMaNhap.TabStop = true;
            this.radioMaNhap.Text = "Mã Nhập";
            this.radioMaNhap.UseVisualStyleBackColor = true;
            this.radioMaNhap.CheckedChanged += new System.EventHandler(this.radioMaNhap_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "TÌM KIẾM HÀNG NHẬP";
            // 
            // cboMaNCC
            // 
            this.cboMaNCC.FormattingEnabled = true;
            this.cboMaNCC.Location = new System.Drawing.Point(167, 121);
            this.cboMaNCC.Name = "cboMaNCC";
            this.cboMaNCC.Size = new System.Drawing.Size(323, 24);
            this.cboMaNCC.TabIndex = 26;
            // 
            // FormTKNHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 386);
            this.Controls.Add(this.cboMaNCC);
            this.Controls.Add(this.DataGrid_TimKiemNH);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtNgaynhap);
            this.Controls.Add(this.cboMaNhap);
            this.Controls.Add(this.radioNgaynhap);
            this.Controls.Add(this.radioMaNCC);
            this.Controls.Add(this.radioMaNhap);
            this.Controls.Add(this.label1);
            this.Name = "FormTKNHang";
            this.Text = "FormTKNHang";
            this.Load += new System.EventHandler(this.FormTKNHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_TimKiemNH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrid_TimKiemNH;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtNgaynhap;
        private System.Windows.Forms.ComboBox cboMaNhap;
        private System.Windows.Forms.RadioButton radioNgaynhap;
        private System.Windows.Forms.RadioButton radioMaNCC;
        private System.Windows.Forms.RadioButton radioMaNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMaNCC;
    }
}