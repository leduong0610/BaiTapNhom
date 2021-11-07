
namespace BaiTapNhom
{
    partial class FormTKKHang
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
            this.DataGrid_TimKiemKH = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtSoDT = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.cboMaKH = new System.Windows.Forms.ComboBox();
            this.radioSoDT = new System.Windows.Forms.RadioButton();
            this.radioTenKH = new System.Windows.Forms.RadioButton();
            this.radioMaKH = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_TimKiemKH)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrid_TimKiemKH
            // 
            this.DataGrid_TimKiemKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_TimKiemKH.Location = new System.Drawing.Point(13, 226);
            this.DataGrid_TimKiemKH.Name = "DataGrid_TimKiemKH";
            this.DataGrid_TimKiemKH.RowHeadersWidth = 51;
            this.DataGrid_TimKiemKH.RowTemplate.Height = 24;
            this.DataGrid_TimKiemKH.Size = new System.Drawing.Size(643, 133);
            this.DataGrid_TimKiemKH.TabIndex = 15;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(537, 145);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(119, 35);
            this.btnThoat.TabIndex = 13;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(537, 88);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(119, 35);
            this.btnTimKiem.TabIndex = 14;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtSoDT
            // 
            this.txtSoDT.Location = new System.Drawing.Point(168, 166);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(323, 22);
            this.txtSoDT.TabIndex = 11;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(168, 122);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(323, 22);
            this.txtTenKH.TabIndex = 12;
            // 
            // cboMaKH
            // 
            this.cboMaKH.FormattingEnabled = true;
            this.cboMaKH.Location = new System.Drawing.Point(168, 75);
            this.cboMaKH.Name = "cboMaKH";
            this.cboMaKH.Size = new System.Drawing.Size(323, 24);
            this.cboMaKH.TabIndex = 10;
            this.cboMaKH.SelectedIndexChanged += new System.EventHandler(this.cboMaKH_SelectedIndexChanged);
            // 
            // radioSoDT
            // 
            this.radioSoDT.AutoSize = true;
            this.radioSoDT.Location = new System.Drawing.Point(13, 168);
            this.radioSoDT.Name = "radioSoDT";
            this.radioSoDT.Size = new System.Drawing.Size(112, 21);
            this.radioSoDT.TabIndex = 7;
            this.radioSoDT.TabStop = true;
            this.radioSoDT.Text = "Số điện thoại";
            this.radioSoDT.UseVisualStyleBackColor = true;
            this.radioSoDT.CheckedChanged += new System.EventHandler(this.radioSoDT_CheckedChanged);
            // 
            // radioTenKH
            // 
            this.radioTenKH.AutoSize = true;
            this.radioTenKH.Location = new System.Drawing.Point(13, 124);
            this.radioTenKH.Name = "radioTenKH";
            this.radioTenKH.Size = new System.Drawing.Size(136, 21);
            this.radioTenKH.TabIndex = 8;
            this.radioTenKH.TabStop = true;
            this.radioTenKH.Text = "Tên Khách Hàng";
            this.radioTenKH.UseVisualStyleBackColor = true;
            this.radioTenKH.CheckedChanged += new System.EventHandler(this.radioTenKH_CheckedChanged);
            // 
            // radioMaKH
            // 
            this.radioMaKH.AutoSize = true;
            this.radioMaKH.Location = new System.Drawing.Point(13, 79);
            this.radioMaKH.Name = "radioMaKH";
            this.radioMaKH.Size = new System.Drawing.Size(130, 21);
            this.radioMaKH.TabIndex = 9;
            this.radioMaKH.TabStop = true;
            this.radioMaKH.Text = "Mã Khách Hàng";
            this.radioMaKH.UseVisualStyleBackColor = true;
            this.radioMaKH.CheckedChanged += new System.EventHandler(this.radioMaKH_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "TÌM KIẾM KHÁCH HÀNG";
            // 
            // FormTKKHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 384);
            this.Controls.Add(this.DataGrid_TimKiemKH);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtSoDT);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.cboMaKH);
            this.Controls.Add(this.radioSoDT);
            this.Controls.Add(this.radioTenKH);
            this.Controls.Add(this.radioMaKH);
            this.Controls.Add(this.label1);
            this.Name = "FormTKKHang";
            this.Text = "FormTKKHang";
            this.Load += new System.EventHandler(this.FormTKKHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_TimKiemKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrid_TimKiemKH;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.ComboBox cboMaKH;
        private System.Windows.Forms.RadioButton radioSoDT;
        private System.Windows.Forms.RadioButton radioTenKH;
        private System.Windows.Forms.RadioButton radioMaKH;
        private System.Windows.Forms.Label label1;
    }
}