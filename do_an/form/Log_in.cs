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
    public partial class Log_in : Form
    {
        public Log_in()
        {
            InitializeComponent();
        }

        private void btn_dangKy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vui lòng đăng nhập dưới quyền admin hoặc quản lý để đăng ký nhân viên","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btn_dangNhap_Click(object sender, EventArgs e)
        {
            check_radiu();
            if (cv==null)
            {
                MessageBox.Show("Vui lòng chọn phân quyền", "Thông báo");
            }
            else
            {
                Check_Acccount();
            }
        }
        private string cv = null;
        void check_radiu()
        {
            if (radiBtn_nhanVien.Checked == true)
            {
                cv = "CV01";
                Form1.radiu = 1;
            }
            if (radiBtn_quanLy.Checked == true)
            {
                cv = "CV02";
                Form1.radiu = 2;
            }
            if (radiBtn_admin.Checked == true)
            {
                cv = "CV03";
                Form1.radiu = 3;
            }
        }
        private void lb_quenMK_Click(object sender, EventArgs e)
        {
            Form1.mk = 1;
            form.QuenMK f1 = new QuenMK();
            Form1.homee.load_form(f1);
        }


        void Check_Acccount()
        {
            DatabaseAccess databaseAccess = new DatabaseAccess();
            databaseAccess.openConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "NV_AuthoLogin";
            cmd.Parameters.AddWithValue("@Username",txt_username.Text.Trim());
            cmd.Parameters.AddWithValue("@Password",txt_password.Text.Trim());
            cmd.Parameters.AddWithValue("@Quyen",cv);
            cmd.Connection = databaseAccess.openConnection();
            object kq = cmd.ExecuteScalar();
            int code = Convert.ToInt32(kq);
            if (code == 1)
            {
                Form1.maNhanVien = txt_username.Text.Trim();
                if (cv=="CV01")
                {
                    
                    form.Home_nhanVien f1 = new Home_nhanVien();
                    Form1.homee.load_form(f1);
                }   
                else if (cv=="CV02")
                {
                    form.Home_quanLy f1 = new Home_quanLy();
                    Form1.homee.load_form(f1);
                }
                else
                {
                    form.Home_admin f1 = new Home_admin();
                    Form1.homee.load_form(f1);
                }
            }
            else
                MessageBox.Show("Lỗi khi đăng nhập\nVui lòng kiểm tra lại thông tin đăng nhập!","Errol");
            


        }



    }
}
