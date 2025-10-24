using Microsoft.Data.Sqlite;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Security.Cryptography;

namespace ServerApp
{
    internal class TCPServer
    {
        private const string connString = "Data Source=user_data.db;";
        private readonly TcpListener listener;

        public TCPServer(int port)
        {
            listener = new TcpListener(IPAddress.Any, port);
        }

        public void Start()
        {
            listener.Start();
            Console.WriteLine("✅ Server đang lắng nghe tại cổng 5000...");

            while (true)
            {
                var client = listener.AcceptTcpClient();
                Console.WriteLine("📩 Client kết nối: " + client.Client.RemoteEndPoint);
                HandleClient(client);
            }
        }

        private void HandleClient(TcpClient client)
        {
            using (var stream = client.GetStream())
            {
                byte[] buffer = new byte[1024];
                int byteCount = stream.Read(buffer, 0, buffer.Length);
                string request = Encoding.UTF8.GetString(buffer, 0, byteCount);

                string response = HandleRequest(request);
                byte[] responseBytes = Encoding.UTF8.GetBytes(response);
                stream.Write(responseBytes, 0, responseBytes.Length);
            }
            client.Close();
        }

        private string HandleRequest(string request)
        {
            try
            {
                string[] parts = request.Split('|');
                string action = parts[0];

                if (action == "REGISTER")
                    return RegisterUser(parts[1], parts[2], parts[3], parts[4], parts[5]);
                else if (action == "LOGIN")
                    return LoginUser(parts[1], parts[2]);
                else if (action == "GETINFO")
                    return GetUserInfo(parts[1]);
                else
                    return "FAIL|Lệnh không hợp lệ";
            }
            catch
            {
                return "FAIL|Dữ liệu không hợp lệ";
            }
        }

        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);
                return BitConverter.ToString(hash).Replace("-", "").ToLower();
            }
        }

        // Đăng ký - thêm FullName vào INSERT
        private string RegisterUser(string username, string password, string fullname, string email, string birthday)
        {
            try
            {
                string hashedPassword = HashPassword(password);

                using (var conn = new SqliteConnection(connString))
                {
                    conn.Open();

                    string check = "SELECT COUNT(*) FROM Users WHERE Username=@u OR Email=@e";
                    using (var cmd = new SqliteCommand(check, conn))
                    {
                        cmd.Parameters.AddWithValue("@u", username);
                        cmd.Parameters.AddWithValue("@e", email);

                        long count = (long)cmd.ExecuteScalar();
                        if (count > 0)
                            return "FAIL|Tài khoản hoặc email đã tồn tại!";
                    }

                    string insert = "INSERT INTO Users (Username, Password, FullName, Email, Birthday) VALUES (@u,@p,@f,@e,@b)";
                    using (var cmd = new SqliteCommand(insert, conn))
                    {
                        cmd.Parameters.AddWithValue("@u", username);
                        cmd.Parameters.AddWithValue("@p", hashedPassword);
                        cmd.Parameters.AddWithValue("@f", fullname);
                        cmd.Parameters.AddWithValue("@e", email);
                        cmd.Parameters.AddWithValue("@b", birthday);
                        cmd.ExecuteNonQuery();
                    }

                    return "OK|Đăng ký thành công!";
                }
            }
            catch (Exception ex)
            {
                return "FAIL|" + ex.Message;
            }
        }

        private string LoginUser(string username, string password)
        {
            try
            {
                using (var conn = new SqliteConnection(connString))
                {
                    conn.Open();

                    string sql = "SELECT Password FROM Users WHERE Username=@u";
                    using (var cmd = new SqliteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@u", username);
                        var result = cmd.ExecuteScalar();

                        if (result == null)
                            return "FAIL|Tài khoản không tồn tại!";

                        string storedHashedPassword = result.ToString();
                        string hashedInput = HashPassword(password);

                        if (hashedInput == storedHashedPassword)
                            return "OK|Đăng nhập thành công!";
                        else
                            return "FAIL|Sai mật khẩu!";
                    }
                }
            }
            catch (Exception ex)
            {
                return "FAIL|" + ex.Message;
            }
        }

        private string GetUserInfo(string username)
        {
            try
            {
                using (var conn = new SqliteConnection(connString))
                {
                    conn.Open();
                    string sql = "SELECT Username, FullName, Email, Birthday FROM Users WHERE Username=@u";
                    using (var cmd = new SqliteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@u", username);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string user = reader["Username"]?.ToString();
                                string fullname = reader["FullName"]?.ToString();
                                string email = reader["Email"]?.ToString();
                                string birthday = reader["Birthday"]?.ToString();
                                return $"OK|{user}|{fullname}|{email}|{birthday}";
                            }
                            else return "FAIL|Không tìm thấy người dùng!";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return "FAIL|" + ex.Message;
            }
        }
    }
}
