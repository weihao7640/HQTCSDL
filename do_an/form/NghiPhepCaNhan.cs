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
    public partial class NghiPhepCaNhan : Form
    {
        public NghiPhepCaNhan()
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

        void LoadData()
        {
            da = new SqlDataAdapter("select MaNghi,NgayNghi,LyDo,HuongLuong from NghiPhep where MaNV='"+Form1.maNhanVien.Trim()+"'",databaseAccess.openConnection());
            dt = new DataTable();
            da.Fill(dt);
            dgv_NghiPhep.DataSource = dt;
            dgv_NghiPhep.AllowUserToAddRows = false;
        }



        private void lb_mouth_Click(object sender, EventArgs e)
        {

        }

        private void dgv_Luong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Loc_Click(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("Select MaNghi,NgayNghi,LyDo,HuongLuong from NghiPhep where MaNV='" + Form1.maNhanVien.Trim() + "' and MONTH(NgayNghi)="+(cbb_mouth.SelectedIndex+1)+" and YEAR(NgayNghi)="+cbb_year.SelectedValue, 
                databaseAccess.openConnection());
            dt = new DataTable();
            da.Fill(dt);
            dgv_NghiPhep.DataSource = dt;
            dgv_NghiPhep.AllowUserToAddRows = false;
        }

        private void cbb_year_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbb_mouth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lb_year_Click(object sender, EventArgs e)
        {

        }

        private void lb_title_Click(object sender, EventArgs e)
        {

        }

        private void NghiPhepCaNhan_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadcomboboxNam();
        }
        void LoadcomboboxNam()
        {
            da = new SqlDataAdapter("Select distinct YEAR(NgayNghi) as Nam from NghiPhep where MaNV='" + Form1.maNhanVien + "'", databaseAccess.openConnection());
            dt = new DataTable();
            da.Fill(dt);
            cbb_year.DataSource = dt;
            cbb_year.DisplayMember = "Nam";
            cbb_year.ValueMember = "Nam";
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            LoadcomboboxNam();
            LoadData();
        }
    }
}
