using System;
using System.Windows.Forms;

namespace Exercise3_Nhom12_NT106.Q14
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnDX_Click(object sender, EventArgs e)
        {
            // Đăng xuất: đóng Dashboard và mở lại form đăng nhập
            this.Close();
            var dangnhap = new Login();
            dangnhap.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // TODO: nếu trước đây HienThi_Load gán dữ liệu vào textBox*, chuyển phần đó vào đây
            // Ví dụ:
            // textBox1.Text = currentUser.Username;
            // textBox2.Text = currentUser.FullName;
            // textBox3.Text = currentUser.Email;
            // textBox4.Text = currentUser.BirthDate.ToString("dd/MM/yyyy");
        }
    }
}
