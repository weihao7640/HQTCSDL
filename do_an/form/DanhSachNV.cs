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
    public partial class DanhSachNV : Form
    {
        private DatabaseAccess databaseAccess;
        private DataTable tableChucVu, tablePhongBan;
        SqlCommand cmd = null;

        public DanhSachNV()
        {
            databaseAccess = new DatabaseAccess();
            InitializeComponent();
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            if(CURD("SuaNhanVien") == 1)
            {
                MessageBox.Show("Cập nhật thông tin nhân viên thành công!");
                DanhSachNV_Load(sender, e);
            }
        }

        void hide_show_btn(int i)
        {
            if (i == 1)
            {
                btn_change.Show();
                btn_delete.Show();
                btn_save.Hide();
                btn_huy.Hide();
                btn_loadAnh.Hide();
            }
            else
            {
                btn_change.Hide();
                btn_delete.Hide();
                btn_huy.Show();
                btn_save.Show();
                btn_loadAnh.Show();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if(CURD("ThemNhanVien") == 1)
            {
                MessageBox.Show("Thêm nhân viên thành công!");
                hide_show_btn(1);
                DanhSachNV_Load(sender, e);
            }
        }
        
        // Hàm create, update nhân viên
        private int CURD(string proc)
        {
            try
            {
                string name = txt_hotenNV.Text.ToString();
                string[] hoTen = name.Split(' ');

                string tenPB = cbb_phongban.Text.ToString();
                string tenCV = cbb_chucVu.Text.ToString();

                string hoNV = "";
                string tenNV = "";
                if (hoTen.Length > 2)
                {
                    hoNV = hoTen[0] + " " + hoTen[1];
                    tenNV = hoTen[2];
                }
                else if (hoTen.Length <= 2)
                {
                    hoNV = hoTen[0];
                    tenNV = hoTen[1];
                }
                string maCV = "";
                foreach (DataRow row in tableChucVu.Rows)
                {
                    if (row["TenCV"].Equals(tenCV))
                    {
                        maCV = row["MaCV"].ToString();
                        break;
                    }
                }
                string maPB = "";
                foreach (DataRow row in tablePhongBan.Rows)
                {
                    if (row["TenPB"].Equals(tenPB))
                    {
                        maPB = row["MaPB"].ToString();
                        break;
                    }
                }

                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = proc;
                cmd.Connection = databaseAccess.openConnection();

                cmd.Parameters.Add("@maNV", SqlDbType.Char).Value = txt_maNV.Text;
                cmd.Parameters.Add("@hoNV", SqlDbType.NVarChar).Value = hoNV;
                cmd.Parameters.Add("@tenNV", SqlDbType.NVarChar).Value = tenNV;
                cmd.Parameters.Add("@cccd_cmnd", SqlDbType.Char).Value = txt_CMND_CCCD.Text;
                cmd.Parameters.Add("@ngSinh", SqlDbType.Date).Value = dateTime_ngSinh.Value;
                cmd.Parameters.Add("@gioiTinh", SqlDbType.NVarChar).Value = cbb_gioiTinh.SelectedItem;
                cmd.Parameters.Add("@diaChi", SqlDbType.NVarChar).Value = txt_diaChi.Text;
                cmd.Parameters.Add("@phone", SqlDbType.Char).Value = txt_phone.Text;
                cmd.Parameters.Add("@email", SqlDbType.NChar).Value = txt_email.Text;
                cmd.Parameters.Add("@maPB", SqlDbType.Char).Value = maPB;
                cmd.Parameters.Add("@maCV", SqlDbType.NChar).Value = maCV;


                int result = cmd.ExecuteNonQuery();
                if (result > 0)                  
                    return 1;

            }
            catch (Exception)
            {
                MessageBox.Show("Thông tin không hợp lệ");
            }
            return 0;
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            hide_show_btn(1);
        }

        private void DanhSachNV_Load(object sender, EventArgs e)
        {
            // Load ds nhan vien
            string query = "SELECT MaNV, HoNV, TenNV, CCCD_CMND, NgSinh, GioiTinh, DiaChi, Phone, Email, TenPB, TenCV FROM NHANVIEN JOIN PHONGBAN ON NHANVIEN.MaPB = PHONGBAN.MaPB JOIN CHUCVU ON NHANVIEN.MaCV = CHUCVU.MaCV";
            dgv_DS_nhanVien.DataSource = databaseAccess.executeQuery(query).Tables[0];

            // Load ten chuc vu
            query = "SELECT TenCV, MaCV FROM CHUCVU";
            tableChucVu = databaseAccess.executeQuery(query).Tables[0];
            cbb_chucVu.DataSource = tableChucVu;
            cbb_chucVu.ValueMember = "MaCV";
            cbb_chucVu.DisplayMember = "TenCV";

            // Load ten phong ban
            query = "SELECT TenPB, MaPB FROM PHONGBAN";
            tablePhongBan = databaseAccess.executeQuery(query).Tables[0];
            cbb_phongban.DataSource = tablePhongBan;
            cbb_phongban.ValueMember = "MaPB";
            cbb_phongban.DisplayMember = "TenPB";
            
            cbb_gioiTinh.SelectedItem = "Nam";
            grB_thongtinNV.Hide();
        }

        private void txt_keysearch_Click(object sender, EventArgs e)
        {
            if (txt_keysearch.Text=="Nhập từ khóa tìm kiếm") {
                txt_keysearch.Text = ""; }
        }

        private void txt_keysearch_Leave(object sender, EventArgs e)
        {
            if (txt_keysearch.Text == "")
            {
                txt_keysearch.Text = "Nhập từ khóa tìm kiếm";
            }
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

        private void btn_Add_Click(object sender, EventArgs e)
        {                           
             grB_thongtinNV.Show();
             hide_show_btn(0);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                string ma = txt_maNV.Text;
                if (!ma.Equals(""))
                {
                    DialogResult dlr = MessageBox.Show("Bạn muốn xóa nhân viên?",
                         "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dlr == DialogResult.Yes)
                    {
                        string query = "DELETE FROM NHANVIEN WHERE MaNV = " + ma + "";
                        int result = databaseAccess.executeNonQuery(query);
                        if (result != 0)
                        {
                            MessageBox.Show("Xóa thành công!");
                            DanhSachNV_Load(sender, e);
                        }
                    }                    
                }                
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }

        private void txt_keysearch_TextChanged(object sender, EventArgs e)
        {
            if (txt_keysearch.Text == "Nhập từ khóa tìm kiếm") return;
            DataTable dt = new DataTable();

            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SearchNV";
            cmd.Connection = databaseAccess.openConnection();

            cmd.Parameters.Add("@maNV", SqlDbType.Char).Value = txt_keysearch.Text;
            cmd.Parameters.Add("@hoNV", SqlDbType.NVarChar).Value = txt_keysearch.Text;
            cmd.Parameters.Add("@tenNV", SqlDbType.NVarChar).Value = txt_keysearch.Text;
            cmd.Parameters.Add("@tenPB", SqlDbType.Char).Value = txt_keysearch.Text;

            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            dt.Load(sqlDataReader);

            dgv_DS_nhanVien.DataSource = dt;

            grB_thongtinNV.Show();
            hide_show_btn(1);
        }

        private void dgv_DS_nhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == (dgv_DS_nhanVien.RowCount - 1)) return;
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dgv_DS_nhanVien.Rows[rowIndex];
            txt_maNV.Text = row.Cells["MaNV"].Value.ToString();
            txt_hotenNV.Text = row.Cells["HoNV"].Value.ToString() + " " + row.Cells["TenNV"].Value.ToString();
            dateTime_ngSinh.Value = (DateTime) row.Cells["NgSinh"].Value;
            cbb_gioiTinh.SelectedItem = row.Cells["GioiTinh"].Value.ToString();
            txt_CMND_CCCD.Text = row.Cells["CCCD_CMND"].Value.ToString();
            txt_diaChi.Text = row.Cells["DiaChi"].Value.ToString();
            txt_phone.Text = row.Cells["Phone"].Value.ToString();
            txt_email.Text = row.Cells["Email"].Value.ToString();
            cbb_phongban.Text = row.Cells["TenPB"].Value.ToString();
            cbb_chucVu.Text = row.Cells["TenCV"].Value.ToString();

            grB_thongtinNV.Show();
            hide_show_btn(1);
            
        }
    }
}
