using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Exercise3_Nhom12_NT106.Q14
{
    public partial class Dashboard : Form
    {
        private string currentUser;

        public Dashboard(string username)
        {
            InitializeComponent();
            currentUser = username;
        }

        private void btnDX_Click(object sender, EventArgs e)
        {
            this.Close();
            Login dangnhap = new Login();
            dangnhap.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            try
            {
                using (TcpClient client = new TcpClient("127.0.0.1", 5000))
                using (NetworkStream stream = client.GetStream())
                {
                    string message = "GETINFO|" + currentUser;
                    byte[] data = Encoding.UTF8.GetBytes(message);
                    stream.Write(data, 0, data.Length);

                    byte[] buffer = new byte[1024];
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    string response = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    string[] parts = response.Split('|');

                    if (parts.Length >= 5 && parts[0] == "OK")
                    {
                        textBox1.Text = parts[1];
                        textBox2.Text = parts[2];
                        textBox3.Text = parts[3];
                        textBox4.Text = parts[4];
                    }
                    else
                    {
                        MessageBox.Show("Không thể tải thông tin tài khoản!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải thông tin: " + ex.Message);
            }
        }
    }
}
