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
    public partial class LuongNV : Form
    {
        public LuongNV()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        SqlDataAdapter da = null;
        DataTable dt = null;
        SqlCommand cmd = null;
        DatabaseAccess databaseAccess = new DatabaseAccess();
        private void btn_back_Click(object sender, EventArgs e)
        { 
            if (Form1.radiu == 1)
            { Home_nhanVien f1 = new Home_nhanVien(); Form1.homee.load_form(f1); }
            else if (Form1.radiu == 2)
            { Home_quanLy f1 = new Home_quanLy(); Form1.homee.load_form(f1); }
            else
            { Home_admin f1 = new Home_admin(); Form1.homee.load_form(f1); }
        }

        private void LuongNV_Load(object sender, EventArgs e)
        {
            LoadcomboboxNam();
            LoadData();

        }

        void LoadData()
        {
          
            databaseAccess.openConnection();

            

            da = new SqlDataAdapter("Select BangLuong.MaLuong, MONTH(CHAMCONG.Thang_HT) as Thang, YEAR(CHAMCONG.Thang_HT) as Nam , CHAMCONG.SoNgayCong*BangLuong.HSLuong*BangLuong.MucLuong as LuongThang from(BangLuong inner join CHAMCONG on BangLuong.MaNV = CHAMCONG.ManV) where BangLuong.MaNV ='"+Form1.maNhanVien+ "' and YEAR(CHAMCONG.Thang_HT)="+cbb_year.SelectedValue, databaseAccess.openConnection());
            dt = new DataTable();
            da.Fill(dt);
            dgv_Luong.DataSource = dt;
            dgv_Luong.AllowUserToAddRows = false;

        }
        void LoadcomboboxNam()
        {
            da = new SqlDataAdapter("Select distinct YEAR(CHAMCONG.Thang_HT) as Nam from (BangLuong inner join CHAMCONG on BangLuong.MaNV=CHAMCONG.ManV) where BangLuong.MaNV='"+Form1.maNhanVien+"'", databaseAccess.openConnection());
            dt = new DataTable();
            da.Fill(dt);
            cbb_year.DataSource = dt;
            cbb_year.DisplayMember = "Nam";
            cbb_year.ValueMember = "Nam";
        }
        private void dgv_Luong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            LoadcomboboxNam();
            LoadData();
        }

        private void btn_Loc_Click(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("Select BangLuong.MaLuong, MONTH(CHAMCONG.Thang_HT) as Thang, YEAR(CHAMCONG.Thang_HT) as Nam , CHAMCONG.SoNgayCong*BangLuong.HSLuong*BangLuong.MucLuong as LuongThang from(BangLuong inner join CHAMCONG on BangLuong.MaNV = CHAMCONG.ManV) where BangLuong.MaNV ='" + Form1.maNhanVien + "' and MONTH(CHAMCONG.Thang_HT)="+(cbb_month.SelectedIndex+1)+" and YEAR(CHAMCONG.Thang_HT)="+cbb_year.SelectedValue, databaseAccess.openConnection());
            dt = new DataTable();
            da.Fill(dt);
            dgv_Luong.DataSource = dt;
            dgv_Luong.AllowUserToAddRows = false;
        }
    }
}



