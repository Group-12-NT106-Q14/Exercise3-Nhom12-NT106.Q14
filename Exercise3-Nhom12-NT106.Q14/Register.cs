using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Exercise3_Nhom12_NT106.Q14
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private bool IsValidEmail(string email)
        {
            string emailPattern = @"^[^\@\s]+@[^\@\s]+\.[^\@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }

        private void btnĐK_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (txtTK.Text == "")
                errorProvider1.SetError(txtTK, "Vui lòng nhập tài khoản");

            if (txtEmail.Text == "")
                errorProvider1.SetError(txtEmail, "Vui lòng nhập email");

            if (!IsValidEmail(txtEmail.Text))
                errorProvider1.SetError(txtEmail, "Email không hợp lệ");

            if (txtMK.Text == "")
                errorProvider1.SetError(txtMK, "Vui lòng nhập mật khẩu");

            if (txtNLMK.Text == "")
                errorProvider1.SetError(txtNLMK, "Vui lòng nhập lại mật khẩu");

            // Sửa điều kiện: dùng TextLength thay vì MaxLength
            if (txtMK.TextLength < 8)
                errorProvider1.SetError(txtMK, "Mật khẩu phải lớn hơn 8 ký tự");

            if (txtMK.Text != txtNLMK.Text)
                errorProvider1.SetError(txtNLMK, "Mật khẩu không khớp");

            bool ok = txtTK.Text != "" &&
                      txtMK.Text != "" &&
                      txtNLMK.Text != "" &&
                      txtMK.TextLength >= 8 &&
                      txtMK.Text == txtNLMK.Text &&
                      IsValidEmail(txtEmail.Text);

            if (ok)
            {
                MessageBox.Show("Đăng kí thành công");
                this.Hide();
                var frm = new Login();
                frm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng ký thất bại");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.btnShow1.Visible = false;
            this.btnHide1.Visible = true;
            this.txtMK.PasswordChar = '*';
        }

        private void btnHide1_Click(object sender, EventArgs e)
        {
            this.btnHide1.Visible = false;
            this.btnShow1.Visible = true;
            this.txtMK.PasswordChar = '\0';
        }

        private void btnHide2_Click(object sender, EventArgs e)
        {
            this.btnHide2.Visible = false;
            this.btnShow2.Visible = true;
            this.txtNLMK.PasswordChar = '\0';
        }

        private void btnShow2_Click(object sender, EventArgs e)
        {
            this.btnShow2.Visible = false;
            this.btnHide2.Visible = true;
            this.txtNLMK.PasswordChar = '*';
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Nếu cần khởi tạo thêm, thêm ở đây
        }

        private void txtMK_TextChanged(object sender, EventArgs e)
        {
            txtMK.PasswordChar = '*';
        }

        private void txtNLMK_TextChanged(object sender, EventArgs e)
        {
            txtNLMK.PasswordChar = '*';
        }
    }
}
