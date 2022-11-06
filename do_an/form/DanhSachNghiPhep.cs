using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace do_an.form
{
    public partial class DanhSachNghiPhep : Form
    {
        private DatabaseAccess databaseAccess;
        SqlCommand cmd = null;

        public DanhSachNghiPhep()
        {
            databaseAccess = new DatabaseAccess();
            InitializeComponent();
            load();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (Form1.radiu == 1)
            { Home_nhanVien f1 = new Home_nhanVien(); Form1.homee.load_form(f1); }
            else if (Form1.radiu == 2)
            { Home_quanLy f1 = new Home_quanLy(); Form1.homee.load_form(f1); }
            else
            { Home_admin f1 = new Home_admin(); Form1.homee.load_form(f1); }
        }

        private void DanhSachNghiPhep_Load(object sender, EventArgs e)
        {
            // Load name of department
            string query = "SELECT TenPB FROM PHONGBAN";
            cbbPhongBan.DataSource = databaseAccess.executeQuery(query).Tables[0];
            cbbPhongBan.ValueMember = "TenPB";
            cbbPhongBan.DisplayMember = "TenPB";
            
        }
        private void load()
        {
            DataTable dt = new DataTable();

            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DSNghiPhep";
            cmd.Connection = databaseAccess.openConnection();

            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            dt.Load(sqlDataReader);
            dgv_Luong.DataSource = dt;


            // Load year of cbbYear
            string query = "SELECT YEAR(NgayNghi) as [Year] FROM NghiPhep GROUP BY NgayNghi";
            cbb_year.DataSource = databaseAccess.executeQuery(query).Tables[0];
            cbb_year.ValueMember = "Year";
            cbb_year.DisplayMember = "Year";

            
        }

        private void cbbPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            string textSearch = cbbPhongBan.SelectedValue.ToString();
            string query = "SELECT TenPB, HoNV, TenNV, NgayNghi, LyDo, HuongLuong, Phone " +
                "FROM NghiPhep JOIN NHANVIEN ON NghiPhep.MaNV = NHANVIEN.MaNV JOIN PHONGBAN ON NHANVIEN.MaPB = PHONGBAN.MaPB " +
                "WHERE TenPB = '"+ textSearch +"'";
            dgv_Luong.DataSource = databaseAccess.executeQuery(query).Tables[0];
        }

        private void btn_Loc_Click(object sender, EventArgs e)
        {
            // Lấy tháng, năm của ngày nghỉ
            string month = cbb_mouth.SelectedItem.ToString();
            string year = cbb_year.SelectedValue.ToString();
            int m = Convert.ToInt32(month);
            int y = Convert.ToInt32(year);
            
            string query = "SELECT TenPB, HoNV, TenNV, NgayNghi, LyDo, HuongLuong, Phone " +
                "FROM NghiPhep JOIN NHANVIEN ON NghiPhep.MaNV = NHANVIEN.MaNV JOIN PHONGBAN ON NHANVIEN.MaPB = PHONGBAN.MaPB " +
                "WHERE MONTH(NgayNghi) = "+ m +" AND YEAR(NgayNghi) = "+ y +"";

            dgv_Luong.DataSource = databaseAccess.executeQuery(query).Tables[0];
        }

        private void txt_keysearch_Leave(object sender, EventArgs e)
        {
            if (txt_keysearch.Text == "")
            {
                txt_keysearch.Text = "Nhập từ khóa tìm kiếm";
            }
        }

        private void txt_keysearch_Click(object sender, EventArgs e)
        {
            if (txt_keysearch.Text == "Nhập từ khóa tìm kiếm")
            {
                txt_keysearch.Text = "";
            }
        }

        private void txt_keysearch_TextChanged(object sender, EventArgs e)
        {
            if (txt_keysearch.Text == "Nhập từ khóa tìm kiếm") return;
            DataTable dt = new DataTable();

            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SearchNghiPhep";
            cmd.Connection = databaseAccess.openConnection();

            cmd.Parameters.Add("@hoNV", SqlDbType.NVarChar).Value = txt_keysearch.Text;
            cmd.Parameters.Add("@tenNV", SqlDbType.NVarChar).Value = txt_keysearch.Text;
            cmd.Parameters.Add("@tenPB", SqlDbType.Char).Value = txt_keysearch.Text;

            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            dt.Load(sqlDataReader);
            dgv_Luong.DataSource = dt;
        }
    }
}
