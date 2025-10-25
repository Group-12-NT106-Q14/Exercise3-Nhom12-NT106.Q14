# Ứng Dụng Quản Lý Người Dùng với TCP Socket

Bài tập Exercise 3 - Môn Lập Trình Mạng Căn Bản - Trường ĐH CNTT - ĐHQG TP.HCM (UIT)

## 📖 Giới Thiệu

Ứng dụng quản lý người dùng với kiến trúc Client-Server sử dụng TCP Socket để giao tiếp. Ứng dụng thực hiện các chức năng đăng ký tài khoản, đăng nhập, hiển thị thông tin người dùng và đăng xuất. Dữ liệu được lưu trữ bằng SQLite (thay thế SQL Server), mật khẩu được mã hóa SHA-256, giao diện được xây dựng trên C# Windows Forms.

### Mục Đích Bài Tập

- Xây dựng ứng dụng Client-Server với kiến trúc TCP Socket.
- Thực hiện giao tiếp giữa TCP Client và TCP Server.
- Quản lý đa kết nối đồng thời trên server sử dụng đa luồng (multiple threads).
- Xác thực người dùng hiệu quả (đăng ký, đăng nhập).
- Mã hóa mật khẩu SHA-256 trước khi gửi qua mạng.
- Lưu trữ và truy xuất thông tin người dùng từ cơ sở dữ liệu.
- Xử lý logic đầu vào, kiểm tra trùng lặp và xử lý ngoại lệ.

## 👥 Thành Viên Nhóm

**Nhóm 12 - Lớp NT106.Q14**

| MSSV     | Họ và Tên         |
|----------|-------------------|
| 24521557 | Phạm Đức Tài      |
| 24520331 | Trần Minh Đức     |
| 24521213 | Trần Thanh Nguyên |
| 24521538 | Trần Sơn          |
| 24521560 | Trần Văn Tài      |

## 🛠️ Công Nghệ Sử Dụng

- Ngôn ngữ lập trình: C#
- .NET Framework 4.7.2 trở lên
- Windows Forms
- Visual Studio 2022
- SQLite (Microsoft.Data.Sqlite)
- TCP Socket
- Multi-threading

## 🏗️ Kiến Trúc Hệ Thống

### TCP Client
- Form đăng nhập (Login)
- Form đăng ký (Register)
- Form hiển thị thông tin (Dashboard)
- Gửi request đến server qua TCP Socket
- Nhận response từ server và hiển thị kết quả

### TCP Server
- Lắng nghe kết nối từ client trên cổng 5000
- Quản lý đa kết nối đồng thời bằng multiple threads
- Xử lý các request: REGISTER, LOGIN, GETINFO
- Kết nối với cơ sở dữ liệu SQLite
- Mã hóa mật khẩu SHA-256 và lưu trữ

### Database (SQLite)
- File: `user_data.db`
- Bảng Users với các cột:
  - UserId (PRIMARY KEY AUTOINCREMENT)
  - Username (TEXT, UNIQUE, NOT NULL)
  - Password (TEXT, NOT NULL) - SHA-256 Hash
  - Email (TEXT)
  - FullName (TEXT)
  - Birthday (TEXT)

## ✨ Tính Năng

### 1. Đăng Ký Tài Khoản (TCP Client + Server)

**Client:**
- Nhập username, email, mật khẩu, xác nhận mật khẩu, họ tên, ngày sinh
- Kiểm tra hợp lệ đầu vào (mật khẩu khớp, email đúng định dạng)
- Mã hóa mật khẩu SHA-256 trước khi gửi
- Gửi request `REGISTER|username|password|fullname|email|birthday` qua TCP Socket

**Server:**
- Nhận request đăng ký từ client
- Kiểm tra username có tồn tại trong database chưa
- Nếu chưa tồn tại, lưu thông tin người dùng vào bảng Users
- Gửi phản hồi `OK|Đăng ký thành công` hoặc `FAIL|Username đã tồn tại`

### 2. Đăng Nhập (TCP Client + Server)

**Client:**
- Nhập username và mật khẩu
- Mã hóa mật khẩu SHA-256
- Gửi request `LOGIN|username|password` qua TCP Socket

**Server:**
- Nhận request đăng nhập
- Truy vấn database để kiểm tra username và password hash
- Nếu đúng, lấy thông tin người dùng và gửi về client
- Gửi phản hồi `OK|fullname|email|birthday` hoặc `FAIL|Sai tên đăng nhập hoặc mật khẩu`

**Client:**
- Hiển thị thông báo lỗi nếu đăng nhập thất bại
- Chuyển đến form Dashboard nếu đăng nhập thành công

### 3. Hiển Thị Thông Tin Người Dùng

- Sau khi đăng nhập thành công, hiển thị thông tin:
  - Username
  - Họ và tên (FullName)
  - Email
  - Ngày sinh (Birthday)

### 4. Đăng Xuất

- Người dùng có thể đăng xuất khỏi ứng dụng
- Quay lại màn hình đăng nhập

### 5. Quản Lý Đa Kết Nối (TCP Server)

- Server sử dụng multiple threads để xử lý nhiều client đồng thời
- Mỗi kết nối client mới được xử lý trên một thread riêng biệt
- Server lắng nghe liên tục và chấp nhận kết nối mới

## 💻 Yêu Cầu Hệ Thống

- Windows 7/8/10/11
- .NET Framework 4.7.2 trở lên
- Visual Studio 2022 (để build từ source code)
- SQLite (Microsoft.Data.Sqlite NuGet package)

## 📥 Hướng Dẫn Cài Đặt

### Bước 1: Clone Repository

```bash
git clone https://github.com/thnguyen290106/Exercise2.2-Nhom12-NT106.Q14.git
cd Exercise3-3-Nhom12-NT106.Q14
```

### Bước 2: Cài Đặt Dependencies

1. Mở Visual Studio 2022
2. Mở file `.sln` trong thư mục đã clone
3. Cài đặt NuGet Package:
   - Right-click vào Solution → Manage NuGet Packages
   - Tìm và cài `Microsoft.Data.Sqlite`

### Bước 3: Build Project

- Build Server: `Ctrl + Shift + B` trên project Server
- Build Client: `Ctrl + Shift + B` trên project Client

### Bước 4: Khởi Động Server

1. Mở thư mục Server
2. Chạy `TCPServer.cs` hoặc file executable đã build
3. Server sẽ lắng nghe tại **cổng 5000**
4. Database `user_data.db` sẽ được tạo tự động

### Bước 5: Chạy Client

1. Mở thư mục Client
2. Chạy ứng dụng Client (Login form)
3. Đảm bảo Server đang chạy trước khi sử dụng Client

## 📚 Hướng Dẫn Sử Dụng

### Khởi Động Server

1. Chạy chương trình TCP Server
2. Console sẽ hiển thị: `✅ Server đang lắng nghe tại cổng 5000...`
3. Server sẵn sàng nhận kết nối từ client

### Đăng Ký Tài Khoản Mới

1. Mở ứng dụng Client
2. Nhấn nút "Đăng ký"
3. Điền đầy đủ thông tin:
   - Username (bắt buộc, duy nhất)
   - Email (bắt buộc, đúng định dạng)
   - Password (bắt buộc)
   - Confirm Password (phải khớp với password)
   - Full Name (họ và tên)
   - Birthday (ngày sinh)
4. Nhấn "Đăng kí"
5. Hệ thống sẽ thông báo kết quả

### Đăng Nhập Hệ Thống

1. Nhập Username và Password
2. Nhấn "Đăng nhập"
3. Nếu thành công, chuyển đến Dashboard
4. Nếu thất bại, hiển thị thông báo lỗi

### Xem Thông Tin Tài Khoản

- Sau khi đăng nhập, Dashboard sẽ hiển thị:
  - Username
  - Họ và tên
  - Email
  - Ngày sinh

### Đăng Xuất

- Nhấn nút "Đăng xuất" trong Dashboard
- Quay lại màn hình đăng nhập

## 🖼️ Giao Diện Ứng Dụng

### Màn Hình Đăng Nhập (Login)

![Giao diện đăng nhập](https://sv2.anhsieuviet.com/2025/10/25/imagea98e0efe8af23a51.png)

*Màn hình đăng nhập với các trường Username và Password*

**Chức năng:**
- Nhập tên đăng nhập và mật khẩu
- Nút "Đăng nhập" để xác thực
- Link chuyển sang form đăng ký

### Màn Hình Đăng Ký (Register)

![Giao diện đăng ký](https://sv2.anhsieuviet.com/2025/10/25/imageabe3acff6a4ed6ff.png)

*Màn hình đăng ký tài khoản mới với form nhập thông tin đầy đủ*

**Chức năng:**
- Nhập Username (duy nhất)
- Nhập Email (đúng định dạng)
- Nhập Password và Confirm Password
- Nhập Full Name
- Chọn Birthday
- Nút "Đăng ký" để gửi thông tin
- Nút "Quay lại" về màn hình đăng nhập

### Màn Hình Dashboard

![Giao diện Dashboard](https://sv2.anhsieuviet.com/2025/10/25/image4bf9ed2f29fe1925.png)


*Giao diện Dashboard hiển thị thông tin người dùng sau khi đăng nhập thành công*

**Chức năng:**
- Hiển thị Username
- Hiển thị Full Name
- Hiển thị Email
- Hiển thị Birthday
- Nút "Đăng xuất"
- Nút "Thoát"

### Console Server

![Console Server](https://sv2.anhsieuviet.com/2025/10/25/image10c448c0ba5889c0.png)

*Console hiển thị log hoạt động của TCP Server*

**Hiển thị:**
- Trạng thái server (đang lắng nghe)
- Thông tin client kết nối
- Request từ client
- Response gửi về client
- Lỗi (nếu có)

## 🔧 Cấu Trúc Dự Án

```
Exercise3/
│
├── Client/
│   ├── Login.cs                  # Form đăng nhập
│   ├── Login.Designer.cs
│   ├── Register.cs               # Form đăng ký
│   ├── Register.Designer.cs
│   ├── Dashboard.cs              # Form hiển thị thông tin
│   ├── Dashboard.Designer.cs
│   └── Program.cs
│
├── Server/
│   ├── TCPServer.cs              # TCP Server xử lý kết nối
│   ├── Database.cs               # Khởi tạo và quản lý database
│   └── Program.cs
│
└── README.md                     # File hướng dẫn này
```

## 📡 Giao Thức Giao Tiếp (Protocol)

### Request Format

Các request từ Client gửi đến Server theo format:

```
COMMAND|param1|param2|param3|...
```

### Response Format

Các response từ Server gửi về Client:

```
OK|data1|data2|...      # Thành công
FAIL|error_message      # Thất bại
```

### Các Lệnh Hỗ Trợ

1. **REGISTER** - Đăng ký tài khoản mới
   ```
   Request:  REGISTER|username|password_hash|fullname|email|birthday
   Response: OK|Đăng ký thành công
             FAIL|Username đã tồn tại
             FAIL|Lỗi khi lưu dữ liệu
   ```

2. **LOGIN** - Đăng nhập
   ```
   Request:  LOGIN|username|password_hash
   Response: OK|fullname|email|birthday
             FAIL|Sai tên đăng nhập hoặc mật khẩu
   ```

3. **GETINFO** - Lấy thông tin người dùng
   ```
   Request:  GETINFO|username
   Response: OK|fullname|email|birthday
             FAIL|Người dùng không tồn tại
   ```

## 🔐 Bảo Mật

### Mã Hóa Mật Khẩu

- Sử dụng thuật toán **SHA-256** để mã hóa mật khẩu
- Mật khẩu được mã hóa ở phía **Client** trước khi gửi qua mạng
- Server lưu trữ mật khẩu dưới dạng **hash**, không lưu plain text
- Khi đăng nhập, so sánh hash của mật khẩu nhập vào với hash trong database

### Kiểm Tra Đầu Vào

- Kiểm tra định dạng email
- Kiểm tra mật khẩu và xác nhận mật khẩu phải khớp
- Kiểm tra username không được trống
- Kiểm tra username không trùng lặp trong database

## ⚠️ Xử Lý Lỗi

### Client Side

- Hiển thị thông báo lỗi rõ ràng khi:
  - Không thể kết nối đến server
  - Đăng ký thất bại (username đã tồn tại)
  - Đăng nhập thất bại (sai username hoặc password)
  - Dữ liệu nhập vào không hợp lệ

### Server Side

- Xử lý exception khi:
  - Lỗi kết nối database
  - Lỗi đọc/ghi dữ liệu
  - Request không đúng format
  - Client ngắt kết nối đột ngột
- Log các lỗi ra console để debug

## 📝 Ghi Chú

- Dữ liệu lưu tại file `user_data.db` (SQLite database)
- Mật khẩu được lưu dưới dạng SHA-256 hash
- Server mặc định lắng nghe tại **cổng 5000**
- Server có thể xử lý nhiều client đồng thời nhờ multi-threading
- Hệ thống kiểm tra đầu vào và thông báo lỗi rõ ràng
- Để reset database, xóa file `user_data.db` và khởi chạy lại server

## 🐛 Troubleshooting

### Lỗi không kết nối được đến Server

- Kiểm tra Server có đang chạy không
- Kiểm tra firewall có chặn cổng 5000 không
- Kiểm tra địa chỉ IP và port trong code Client

### Lỗi database

- Xóa file `user_data.db` và khởi chạy lại Server
- Kiểm tra quyền ghi file trong thư mục Server

### Lỗi đa luồng

- Đảm bảo mỗi kết nối client được xử lý trên thread riêng
- Sử dụng lock khi truy cập database từ nhiều thread

---

**Nhóm 12 - NT106.Q14 - Exercise 3**  
*Trường Đại học Công nghệ Thông tin - ĐHQG TP.HCM*
