using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyFastFood.DB_Layer;
using System.Data.Sql;
using System.Data.SqlClient;

namespace QuanLyFastFood
{
    public partial class frmDangNhap : Form
    {
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyFastFoodDataSet.V_DS_PhanManh' table. You can move, or remove it, as needed.
            this.v_DS_PhanManhTableAdapter.Fill(this.quanLyFastFoodDataSet.V_DS_PhanManh);
            cbtenCN.SelectedIndex = 1;
            cbtenCN.SelectedIndex = 0;
            DBMain.bds_dspm.DataSource = DS_PhanManh;
        }

        private void tenCN_Selected(object sender, EventArgs e)
        {
            if (cbtenCN.SelectedValue != null)
                DBMain.servername = cbtenCN.SelectedValue.ToString();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Trim() == "")
            {
                MessageBox.Show("Tên đăng nhập không được để trống", "Lỗi đăng nhập", MessageBoxButtons.OK);
                txtLogin.Focus();
                return;
            }
            DBMain.mlogin = txtLogin.Text;
            DBMain.password = txtPass.Text;

            if (DBMain.KetNoi() == 0) return;
            MessageBox.Show("Đăng nhập thành công!", "Chúc mừng", MessageBoxButtons.OK);

            SqlDataReader myReader;
            DBMain.mChinhanh = cbtenCN.SelectedIndex;
            //DBMain.bds_dspm = ds;

            DBMain.mloginDN = DBMain.mlogin;
            DBMain.passwordDN = DBMain.password;

            string strLenh = "exec sp_KiemTraDangNhap '" + DBMain.mlogin + "'";
            myReader = DBMain.ExecSqlDataReader(strLenh);//
            if (myReader == null) return;
            myReader.Read();//Đọc 1 dòng 


            DBMain.username = myReader.GetString(0);     // Lay user name
            if (Convert.IsDBNull(DBMain.username))
            {
                MessageBox.Show("User không đủ quyền truy cập ! Xin vui lòng xem lại cơ sở dữ liệu.", "", MessageBoxButtons.OK);
                return;
            }
            DBMain.mHoten = myReader.GetString(1);
            DBMain.mGroup = myReader.GetString(2);
            myReader.Close();
            DBMain.conn.Close();

            Program.frmChinh.MaNV.Text = "Mã NV: " + DBMain.username;
            Program.frmChinh.HoTen.Text = "Họ tên: " + DBMain.mHoten;
            Program.frmChinh.Nhom.Text = "Nhóm: " + DBMain.mGroup;

            //Program.frmChinh.HienThiMenu();
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn có muốn thoát ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                this.Close();
            }
            else
                return;
        }
    }
}
