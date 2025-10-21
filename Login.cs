using System;
using System.Windows.Forms;

namespace Exercise3_Nhom12_NT106.Q14
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void lblMoiDen_Click(object sender, EventArgs e)
        {
            // Placeholder - có thể thêm logic nếu cần
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (btnShow.Visible == true)
            {
                btnShow.Visible = false;
                btnHide.Visible = true;
                txtMK.PasswordChar = '\0';
            }
            if (btnHide.Visible == true)
            {
                btnHide.Visible = false;
                btnShow.Visible = true;
                txtMK.PasswordChar = '*';
            }
        }

        private void btnĐăngNhập_Click(object sender, EventArgs e)
        {
            if (txtTK.Text == "admin" && txtMK.Text == "admin")
            {
                MessageBox.Show("Đăng nhập thành công");
                this.Hide();
                Dashboard frm = new Dashboard();
                frm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu");
            }
        }

        private void btnĐK_Click(object sender, EventArgs e)
        {
            Register frm = new Register();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void txtMK_TextChanged(object sender, EventArgs e)
        {
            txtMK.PasswordChar = '*';
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.btnHide.Visible = false;
            this.btnShow.Visible = true;
            this.txtMK.PasswordChar = '\0';
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            this.btnShow.Visible = false;
            this.btnHide.Visible = true;
            this.txtMK.PasswordChar = '*';
        }

        private void lblLuu_Click(object sender, EventArgs e)
        {
            // Placeholder - có thể thêm logic nếu cần
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Nếu cần khởi tạo thêm, thêm ở đây
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Placeholder - có thể thêm logic nếu cần
        }
    }
}
