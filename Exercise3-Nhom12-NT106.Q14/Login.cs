using System;
using System.Net.Sockets;
using System.Text;
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


        private void btnĐăngNhập_Click(object sender, EventArgs e)
        {
            string username = txtTK.Text.Trim();
            string password = txtMK.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tài khoản và mật khẩu!");
                return;
            }

            string response = SendRequest($"LOGIN|{username}|{password}");
            string[] parts = response.Split('|');

            if (parts[0] == "OK")
            {
                MessageBox.Show(parts[1]);
                this.Hide();
                Dashboard frm = new Dashboard();
                frm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show(parts.Length > 1 ? parts[1] : "Lỗi kết nối server!");
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
