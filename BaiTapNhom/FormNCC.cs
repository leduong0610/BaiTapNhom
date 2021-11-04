using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BaiTapNhom
{
    public partial class FormNCC : Form
    {
        Connect_db kn = new Connect_db();
        public FormNCC()
        {
            InitializeComponent();
        }

        private void FrmNCC_Load(object sender, EventArgs e)
        {
            BANG_NHACUNGCAP();
            HIENTHI_DULIEU();
        }

        private void BANG_NHACUNGCAP()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * From nhaCungCap");
            DataGrid_NhaCungCap.DataSource = dta;
            HIENTHI_DULIEU();
        }

        private void HIENTHI_DULIEU()
        {
            txtMaNCC.DataBindings.Clear();
            txtMaNCC.DataBindings.Add("Text", DataGrid_NhaCungCap.DataSource, "mancc");
            txtTenNCC.DataBindings.Clear();
            txtTenNCC.DataBindings.Add("Text", DataGrid_NhaCungCap.DataSource, "tenncc");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", DataGrid_NhaCungCap.DataSource, "diachi");
            txtDT.DataBindings.Clear();
            txtDT.DataBindings.Add("Text", DataGrid_NhaCungCap.DataSource, "sdt");

        }
        private void btnTaomoi_Click(object sender, EventArgs e)
        {
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtDT.Text = "";
            txtDiaChi.Text = "";
            txtMaNCC.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql1;
            sql1 = " INSERT INTO nhaCungCap VALUES ('" + txtMaNCC.Text + "', '" + txtTenNCC.Text + "', '" + txtDiaChi.Text + "', '" + txtDT.Text + "')";
            kn.ThucThi(sql1);
            BANG_NHACUNGCAP();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql2;
            sql2 = "UPDATE nhaCungCap SET tenncc =  '" + txtTenNCC.Text + "', diachi = '" + txtDiaChi.Text + "', sdt = '" + txtDT.Text + "' WHERE mancc = '" + txtMaNCC.Text + "'";
            kn.ThucThi(sql2);
            BANG_NHACUNGCAP();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn xóa dữ liệu này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (thongbao == DialogResult.Yes)
            {
                string sql_xoa = "Delete nhaCungCap where mancc = '" + txtMaNCC.Text + "'";
                kn.ThucThi(sql_xoa);
                BANG_NHACUNGCAP();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGrid_NhaCungCap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            HIENTHI_DULIEU();
        }
    }
}
