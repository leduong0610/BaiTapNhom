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
    public partial class FormNhanVien : Form
    {
        Connect_db kn = new Connect_db();
        public FormNhanVien()
        {
            InitializeComponent();
        }
        private void BANG_NHANVIEN()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("SELECT * FROM nhanVien");
            DataGrid_NhanVien1.DataSource = dta;
            HienThiDuLieu();
        }
        private void HienThiDuLieu()
        {
            BANG_NHANVIEN();
            DataGrid_NhanVien1.Columns[0].HeaderText = "Mã Nhân Viên";
            DataGrid_NhanVien1.Columns[1].HeaderText = "Họ Tên Nhân Viên";
            DataGrid_NhanVien1.Columns[2].HeaderText = "Giới tính";
            DataGrid_NhanVien1.Columns[3].HeaderText = "Ngày sinh";
            DataGrid_NhanVien1.Columns[4].HeaderText = "Địa chỉ";
            DataGrid_NhanVien1.Columns[5].HeaderText = "Số điện thoại";
            DataGrid_NhanVien1.Columns[6].HeaderText = "Email";
            DataGrid_NhanVien1.Columns[0].Width = 150;
            DataGrid_NhanVien1.Columns[1].Width = 200;
            DataGrid_NhanVien1.Columns[2].Width = 80;
            DataGrid_NhanVien1.Columns[3].Width = 80;
            DataGrid_NhanVien1.Columns[4].Width = 250;
            DataGrid_NhanVien1.Columns[5].Width = 100;
            DataGrid_NhanVien1.Columns[6].Width = 250;
            DataGrid_NhanVien1.AllowUserToAddRows = false;
            DataGrid_NhanVien1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
            

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sql_them;
            sql_them = " INSERT INTO nhanVien VALUES ('" + txtMaNV.Text + "', '" + txtTenNV.Text + "', '" + txtGioiTinh.Text + "', '" + txtNgaySinh.Text + "','" + txtDiaChi.Text + "', '" + txtSdt.Text + "', '" + txtEmail.Text + "')";
            kn.ThucThi(sql_them);
            BANG_NHANVIEN();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql_Sua;
            sql_Sua = "UPDATE nhanVien SET tennv =  '" + txtTenNV.Text + "', gioitinh = '" + txtGioiTinh.Text + "', ngaysinh =  '" + txtNgaySinh.Text + "', diachi =  '" + txtDiaChi.Text + "', sdt =  '" + txtSdt.Text + "', email =  '" + txtEmail.Text + "' WHERE manv = '" + txtMaNV.Text + "'";
            kn.ThucThi(sql_Sua);
            BANG_NHANVIEN();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql_Xoa;
            sql_Xoa = " DELETE nhanVien WHERE manv = '" + txtMaNV.Text + "' ";
            kn.ThucThi(sql_Xoa);
            BANG_NHANVIEN();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGrid_NhanVien1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            HienThiDuLieu();
        }
        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
        }
    }
}
