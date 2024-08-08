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

namespace Cinema
{
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }
        public (int, int) Check_User(string pUser, string pPass)
        {
            SqlDataAdapter daUser = new SqlDataAdapter(
                "select * from NhanVien where TenDangNhap=@pUser and MatKhau=@pPass",
                Properties.Settings.Default.cnn);

            daUser.SelectCommand.Parameters.AddWithValue("@pUser", pUser);
            daUser.SelectCommand.Parameters.AddWithValue("@pPass", pPass);

            DataTable dt = new DataTable();
            daUser.Fill(dt);

            if (dt.Rows.Count == 0)
                return (100, 0); // User does not exist
            else if (dt.Rows[0][2] == null || dt.Rows[0][2].ToString() == "False")
            {
                return (200, 0); // Account is inactive
            }

            int maNhanVien = Convert.ToInt32(dt.Rows[0]["MaNhanVien"]);
            int maNhomNguoiDung = GetUserGroup(maNhanVien);

            return (300, maNhomNguoiDung); // Successful login
        }

        private int GetUserGroup(int maNhanVien)
        {
            // Assuming you have a method to get the user group from the database
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnn))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "SELECT TOP 1 MaNhomNguoiDung FROM NguoiDungNhomNguoiDung WHERE MaNhanVien = @maNhanVien",
                    conn);
                cmd.Parameters.AddWithValue("@maNhanVien", maNhanVien);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    return Convert.ToInt32(result);
                }
                return 0; // Return 0 or another code if no group is found
            }
        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.nhanVienBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataSetCinema);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Không thể cập nhật!");
            }
      

        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetCinema.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.dataSetCinema.NhanVien);

        }
    }
}
