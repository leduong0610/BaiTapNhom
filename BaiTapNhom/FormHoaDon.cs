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
    public partial class FormHoaDon : Form
    {
        Connect_db kn = new Connect_db();
        public FormHoaDon()
        {
            InitializeComponent();
        }
        private void BangHoaDon()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("select * from hoaDon");
            GridViewHoaDon.DataSource = dta;
            cboKhachHang.DataSource = dta;
            cboKhachHang.DisplayMember = "makh";
            cboKhachHang.ValueMember = "makh";

            cboNhanVien.DataSource = dta;
            cboNhanVien.DisplayMember = "manv";
            cboNhanVien.ValueMember = "manv";
            Hienthi_Dulieu();
        }

        private void Hienthi_Dulieu()
        {

            txtMaHD.DataBindings.Clear();
            txtMaHD.DataBindings.Add("Text", GridViewHoaDon.DataSource, "mahd");

            cboKhachHang.DataBindings.Clear();
            cboKhachHang.DataBindings.Add("Text", GridViewHoaDon.DataSource, "makh");

            cboNhanVien.DataBindings.Clear();
            cboNhanVien.DataBindings.Add("Text", GridViewHoaDon.DataSource, "manv");

            txtNgay.DataBindings.Clear();
            txtNgay.DataBindings.Add("Text", GridViewHoaDon.DataSource, "ngaytao");


        }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            BangHoaDon();
            Hienthi_Dulieu();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            txtMaHD.Text = "";
            txtNgay.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql1;
            sql1 = "insert into hoaDon values ('" + txtMaHD.Text + "','" + cboKhachHang.Text + "',";
            sql1 = sql1 + "' ,'" + cboNhanVien.Text + "','" + txtNgay.Text + "' )  ";
            kn.ThucThi(sql1);
            BangHoaDon();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn xóa dữ liệu này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (thongbao == DialogResult.Yes)
            {
                string sql3 = "Delete hoaDon where mahd = '" + txtMaHD.Text + "'";
                kn.ThucThi(sql3);
                BangHoaDon();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql2;
            sql2 = "Update hoaDon Set ngaytao = '" + txtNgay.Text + "' where mahd = '" + txtMaHD.Text + "'";
            kn.ThucThi(sql2);
            BangHoaDon();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GridViewHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Hienthi_Dulieu();
        }
    }
}
