using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Net.Sockets;

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

        private string SendRequest(string message)
        {
            try
            {
                using (TcpClient client = new TcpClient("127.0.0.1", 5000))
                using (NetworkStream stream = client.GetStream())
                {
                    byte[] data = Encoding.UTF8.GetBytes(message);
                    stream.Write(data, 0, data.Length);

                    byte[] buffer = new byte[1024];
                    int byteCount = stream.Read(buffer, 0, buffer.Length);
                    return Encoding.UTF8.GetString(buffer, 0, byteCount);
                }
            }
            catch (Exception ex)
            {
                return "FAIL|" + ex.Message;
            }
        }

        private void btnĐK_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(txtTK.Text))
                errorProvider1.SetError(txtTK, "Vui lòng nhập tài khoản");
            if (string.IsNullOrWhiteSpace(textBox1.Text))
                errorProvider1.SetError(textBox1, "Vui lòng nhập họ và tên");
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
                errorProvider1.SetError(txtEmail, "Vui lòng nhập email");
            if (!IsValidEmail(txtEmail.Text))
                errorProvider1.SetError(txtEmail, "Email không hợp lệ");
            if (string.IsNullOrWhiteSpace(txtMK.Text))
                errorProvider1.SetError(txtMK, "Vui lòng nhập mật khẩu");
            if (string.IsNullOrWhiteSpace(txtNLMK.Text))
                errorProvider1.SetError(txtNLMK, "Vui lòng nhập lại mật khẩu");
            if (txtMK.TextLength < 8)
                errorProvider1.SetError(txtMK, "Mật khẩu phải lớn hơn 8 ký tự");
            if (txtMK.Text != txtNLMK.Text)
                errorProvider1.SetError(txtNLMK, "Mật khẩu không khớp");

            bool ok = !string.IsNullOrWhiteSpace(txtTK.Text)
                && !string.IsNullOrWhiteSpace(textBox1.Text)
                && !string.IsNullOrWhiteSpace(txtMK.Text)
                && !string.IsNullOrWhiteSpace(txtNLMK.Text)
                && txtMK.TextLength >= 8
                && txtMK.Text == txtNLMK.Text
                && IsValidEmail(txtEmail.Text);

            if (!ok)
            {
                MessageBox.Show("Đăng ký thất bại. Vui lòng kiểm tra lại thông tin.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string username = txtTK.Text.Trim();
            string password = txtMK.Text.Trim();
            string fullname = textBox1.Text.Trim();
            string email = txtEmail.Text.Trim();
            string birthday = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            try
            {
                string response = SendRequest($"REGISTER|{username}|{password}|{fullname}|{email}|{birthday}");
                string[] parts = response.Split('|');

                if (parts[0] == "OK")
                {
                    MessageBox.Show(parts[1], "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    var frm = new Login();
                    frm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(parts.Length > 1 ? parts[1] : "Lỗi kết nối đến server!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đăng ký: " + ex.Message);
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

        private void txtMK_TextChanged(object sender, EventArgs e)
        {
            txtMK.PasswordChar = '*';
        }

        private void txtNLMK_TextChanged(object sender, EventArgs e)
        {
            txtNLMK.PasswordChar = '*';
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}
