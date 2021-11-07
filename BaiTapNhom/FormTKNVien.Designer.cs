
namespace BaiTapNhom
{
    partial class FormTKNVien
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
            this.DataGrid_TimKiemNV = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtSoDT = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.radioSoDT = new System.Windows.Forms.RadioButton();
            this.radioTenNV = new System.Windows.Forms.RadioButton();
            this.radioMaNV = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_TimKiemNV)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrid_TimKiemNV
            // 
            this.DataGrid_TimKiemNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_TimKiemNV.Location = new System.Drawing.Point(12, 218);
            this.DataGrid_TimKiemNV.Name = "DataGrid_TimKiemNV";
            this.DataGrid_TimKiemNV.RowHeadersWidth = 51;
            this.DataGrid_TimKiemNV.RowTemplate.Height = 24;
            this.DataGrid_TimKiemNV.Size = new System.Drawing.Size(643, 133);
            this.DataGrid_TimKiemNV.TabIndex = 25;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(536, 137);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(119, 35);
            this.btnThoat.TabIndex = 23;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(536, 80);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(119, 35);
            this.btnTimKiem.TabIndex = 24;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtSoDT
            // 
            this.txtSoDT.Location = new System.Drawing.Point(167, 158);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(323, 22);
            this.txtSoDT.TabIndex = 21;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(167, 114);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(323, 22);
            this.txtTenNV.TabIndex = 22;
            // 
            // cboMaNV
            // 
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.Location = new System.Drawing.Point(167, 67);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(323, 24);
            this.cboMaNV.TabIndex = 20;
            // 
            // radioSoDT
            // 
            this.radioSoDT.AutoSize = true;
            this.radioSoDT.Location = new System.Drawing.Point(12, 160);
            this.radioSoDT.Name = "radioSoDT";
            this.radioSoDT.Size = new System.Drawing.Size(112, 21);
            this.radioSoDT.TabIndex = 17;
            this.radioSoDT.TabStop = true;
            this.radioSoDT.Text = "Số điện thoại";
            this.radioSoDT.UseVisualStyleBackColor = true;
            this.radioSoDT.CheckedChanged += new System.EventHandler(this.radioSoDT_CheckedChanged);
            // 
            // radioTenNV
            // 
            this.radioTenNV.AutoSize = true;
            this.radioTenNV.Location = new System.Drawing.Point(12, 116);
            this.radioTenNV.Name = "radioTenNV";
            this.radioTenNV.Size = new System.Drawing.Size(124, 21);
            this.radioTenNV.TabIndex = 18;
            this.radioTenNV.TabStop = true;
            this.radioTenNV.Text = "Tên Nhân Viên";
            this.radioTenNV.UseVisualStyleBackColor = true;
            this.radioTenNV.CheckedChanged += new System.EventHandler(this.radioTenNV_CheckedChanged);
            // 
            // radioMaNV
            // 
            this.radioMaNV.AutoSize = true;
            this.radioMaNV.Location = new System.Drawing.Point(12, 71);
            this.radioMaNV.Name = "radioMaNV";
            this.radioMaNV.Size = new System.Drawing.Size(118, 21);
            this.radioMaNV.TabIndex = 19;
            this.radioMaNV.TabStop = true;
            this.radioMaNV.Text = "Mã Nhân Viên";
            this.radioMaNV.UseVisualStyleBackColor = true;
            this.radioMaNV.CheckedChanged += new System.EventHandler(this.radioMaNV_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "TÌM KIẾM NHÂN VIÊN";
            // 
            // FormTKNVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 373);
            this.Controls.Add(this.DataGrid_TimKiemNV);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtSoDT);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.cboMaNV);
            this.Controls.Add(this.radioSoDT);
            this.Controls.Add(this.radioTenNV);
            this.Controls.Add(this.radioMaNV);
            this.Controls.Add(this.label1);
            this.Name = "FormTKNVien";
            this.Text = "FormTKNVien";
            this.Load += new System.EventHandler(this.FormTKNVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_TimKiemNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrid_TimKiemNV;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.ComboBox cboMaNV;
        private System.Windows.Forms.RadioButton radioSoDT;
        private System.Windows.Forms.RadioButton radioTenNV;
        private System.Windows.Forms.RadioButton radioMaNV;
        private System.Windows.Forms.Label label1;
    }
}