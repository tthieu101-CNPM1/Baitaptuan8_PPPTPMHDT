// Thêm các thư viện cần thiết cho Windows Forms và SQL Server
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // Quan trọng: Thêm thư viện này để làm việc với SQL Server

namespace _1150080052_TranTrungHieu_Lab8
{
    public partial class Form1 : Form
    {
         // [cite: 131-132]
        // !!! LƯU Ý QUAN TRỌNG:
        // Bạn PHẢI cập nhật đường dẫn "AttachDbFilename" dưới đây
        // trỏ đến vị trí tệp QuanLySach.mdf trên máy tính của BẠN.
        string strCon = @"Server=LAPTOP-1GJ2FEE2\SQLEXPRESS;Database=QLBanSach;Integrated Security=True";


        // [cite: 134]
        SqlConnection sqlCon = null;

        public Form1()
        {
            InitializeComponent();
            this.lsvDanhSach.SelectedIndexChanged += new System.EventHandler(this.lsvDanhSach_SelectedIndexChanged);
        }

         // Hàm mở kết nối [cite: 136-146]
        private void MoKetNoi()
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
        }

         // Hàm đóng kết nối [cite: 148-154]
        private void DongKetNoi()
        {
             // Đã sửa lỗi "fifi" từ PDF 
            if (sqlCon != null && sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close(); // [cite: 154]
            }
        }

         // Hàm hiển thị danh sách nhà xuất bản [cite: 156, 158-175]
        private void HienThiDanhSachNXB()
        {
            try
            {
                MoKetNoi(); // [cite: 159]
                SqlCommand sqlCmd = new SqlCommand(); // [cite: 160]
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.CommandText = "HienThiNXB"; // [cite: 160]
                sqlCmd.Connection = sqlCon; // [cite: 161]

                SqlDataReader reader = sqlCmd.ExecuteReader(); // [cite: 162]
                lsvDanhSach.Items.Clear(); // [cite: 163]
                 while (reader.Read()) // [cite: 164]
                {
                    string maNXB = reader.GetString(0); // [cite: 166]
                    string tenNXB = reader.GetString(1); // [cite: 167]
                    string diaChi = reader.GetString(2); // [cite: 168]

                    ListViewItem lvi = new ListViewItem(maNXB); // [cite: 169]
                    lvi.SubItems.Add(tenNXB); // [cite: 170]
                    lvi.SubItems.Add(diaChi); // [cite: 171]
                    lsvDanhSach.Items.Add(lvi); // [cite: 172]
                }
                reader.Close(); // [cite: 173]
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách: " + ex.Message);
            }
            finally
            {
                DongKetNoi();
            }
        }
        // Thêm hàm này vào bên trong lớp Form1 của bạn
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn NXB nào để sửa chưa
            // Bằng cách kiểm tra xem ô Mã NXB có rỗng không
            if (string.IsNullOrEmpty(txtMaNXB.Text))
            {
                MessageBox.Show("Bạn phải chọn một nhà xuất bản từ danh sách để cập nhật.", "Thông báo");
                return;
            }

            try
            {
                MoKetNoi();
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.CommandText = "CapNhatThongTin"; // Tên Stored Procedure bạn vừa tạo 
                sqlCmd.Connection = sqlCon;

                // Định nghĩa các tham số (giống hệt khi Thêm)
                SqlParameter parMaNXB = new SqlParameter("@maNXB", SqlDbType.Char);
                SqlParameter parTenNXB = new SqlParameter("@tenNXB", SqlDbType.NVarChar);
                SqlParameter parDiaChi = new SqlParameter("@diaChi", SqlDbType.NVarChar);

                // Gán giá trị cho tham số từ TextBox
                // Lấy Mã NXB từ ô txtMaNXB để biết CẬP NHẬT AI
                parMaNXB.Value = txtMaNXB.Text;
                // Lấy Tên NXB và Địa chỉ mới từ ô text để CẬP NHẬT CÁI GÌ
                parTenNXB.Value = txtTenNXB.Text.Trim();
                parDiaChi.Value = txtDiaChi.Text.Trim();

                // Thêm tham số vào Command
                sqlCmd.Parameters.Add(parMaNXB);
                sqlCmd.Parameters.Add(parTenNXB);
                sqlCmd.Parameters.Add(parDiaChi);

                // Thực thi câu lệnh
                int kq = sqlCmd.ExecuteNonQuery();

                if (kq > 0)
                {
                    MessageBox.Show("Cập nhật thông tin thành công!");
                    HienThiDanhSachNXB(); // Tải lại danh sách
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật dữ liệu: " + ex.Message);
            }
            finally
            {
                DongKetNoi();
            }
        }
        private void btnThemDL_Click(object sender, EventArgs e)
        {
            try
            {
                MoKetNoi(); //
                SqlCommand sqlCmd = new SqlCommand(); //
                sqlCmd.CommandType = CommandType.StoredProcedure;  // [cite: 312-313]
                sqlCmd.CommandText = "ThemDuLieu";  // [cite: 314]

                 // Định nghĩa các tham số [cite: 315-319]
                SqlParameter parMaNXB = new SqlParameter("@maNXB", SqlDbType.Char);
                SqlParameter parTenNXB = new SqlParameter("@tenNXB", SqlDbType.NVarChar);
                SqlParameter parDiaChi = new SqlParameter("@diaChi", SqlDbType.NVarChar);

                 // Gán giá trị cho tham số từ TextBox [cite: 320-322]
                parMaNXB.Value = txtMaNXB.Text.Trim();
                parTenNXB.Value = txtTenNXB.Text.Trim();
                parDiaChi.Value = txtDiaChi.Text.Trim();

                 // Thêm tham số vào Command [cite: 323-325]
                sqlCmd.Parameters.Add(parMaNXB);
                sqlCmd.Parameters.Add(parTenNXB);
                sqlCmd.Parameters.Add(parDiaChi);

                sqlCmd.Connection = sqlCon;  // [cite: 326]
                int kq = sqlCmd.ExecuteNonQuery();  // [cite: 327]

                  if (kq > 0) // [cite: 328]
                {
                    MessageBox.Show("Thêm dữ liệu thành công!");  // [cite: 330]
                    HienThiDanhSachNXB();  // Tải lại danh sách [cite: 330]
                     // Xóa trắng các ô nhập liệu [cite: 331]
                    txtMaNXB.Text = txtTenNXB.Text = txtDiaChi.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm dữ liệu: " + ex.Message);
            }
            finally
            {
                DongKetNoi();
            }
        }
        // Hàm xử lý sự kiện khi Form được tải [cite: 176-179]
        private void Form1_Load(object sender, EventArgs e)
        {
            HienThiDanhSachNXB(); // [cite: 178]
        }

         // Hàm xử lý sự kiện khi chọn một mục trong ListView [cite: 180-186]
        private void lsvDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvDanhSach.SelectedItems.Count == 0) return; // [cite: 182]
            ListViewItem lvi = lsvDanhSach.SelectedItems[0]; // [cite: 183]
            string maNXB = lvi.SubItems[0].Text; // [cite: 184]
            HienThiThongTinNXBTheoMa(maNXB); // [cite: 185]
        }

         // Hàm hiển thị thông tin chi tiết NXB theo mã [cite: 187-208]
         // (Đã sửa lỗi cú pháp từ PDF [cite: 198-202])
        private void HienThiThongTinNXBTheoMa(string maNXB)
        {
            try
            {
                MoKetNoi(); // [cite: 189]
                SqlCommand sqlCmd = new SqlCommand(); // [cite: 190]
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.CommandText = "HienThiChiTietNXB"; // [cite: 190]
                sqlCmd.Connection = sqlCon; // [cite: 191]

                SqlParameter parMaNXB = new SqlParameter("@maNXB", SqlDbType.Char); // [cite: 192]
                parMaNXB.Value = maNXB; // [cite: 193]
                sqlCmd.Parameters.Add(parMaNXB); // [cite: 194]

                SqlDataReader reader = sqlCmd.ExecuteReader(); // [cite: 195]
                txtMaNXB.Text = txtTenNXB.Text = txtDiaChi.Text = ""; // [cite: 196]
                 if (reader.Read()) // [cite: 197]
                {
                    // Lấy dữ liệu từ reader
                    string _maNXB = reader.GetString(0); // [cite: 198]
                    string tenNXB = reader.GetString(1); // [cite: 200]
                    string diaChi = reader.GetString(2); // [cite: 202]

                    // Hiển thị lên TextBox
                    txtMaNXB.Text = _maNXB; // [cite: 203]
                    txtTenNXB.Text = tenNXB; // [cite: 204]
                    txtDiaChi.Text = diaChi; // [cite: 205]
                }
                reader.Close(); // [cite: 208]
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xem chi tiết: " + ex.Message);
            }
            finally
            {
                DongKetNoi();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra xem người dùng đã chọn NXB nào từ danh sách chưa
            if (lsvDanhSach.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bạn phải chọn một nhà xuất bản để xóa!", "Thông báo");
                return;
            }

            // 2. Lấy Mã NXB từ item đang được chọn trong ListView
             // Giống hệt như cách bạn làm trong hàm lsvDanhSach_SelectedIndexChanged [cite: 184]
            string maNXB = lsvDanhSach.SelectedItems[0].SubItems[0].Text;

            // 3. Hiển thị hộp thoại xác nhận trước khi xóa (Rất quan trọng!)
            DialogResult dr = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa nhà xuất bản [" + maNXB + "] không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            // 4. Chỉ thực hiện xóa nếu người dùng chọn "Yes"
            if (dr == DialogResult.Yes)
            {
                try
                {
                    MoKetNoi(); // Mở kết nối
                    SqlCommand sqlCmd = new SqlCommand();
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.CommandText = "XoaNXB"; // [cite: 379]
                    sqlCmd.Connection = sqlCon;

                     // Định nghĩa và gán tham số @maNXB cho Stored Procedure [cite: 380]
                    SqlParameter parMaNXB = new SqlParameter("@maNXB", SqlDbType.Char);
                    parMaNXB.Value = maNXB; // Gán mã NXB đã lấy được
                    sqlCmd.Parameters.Add(parMaNXB);

                    // 5. Thực thi câu lệnh xóa
                    int kq = sqlCmd.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Xóa nhà xuất bản thành công!");
                        HienThiDanhSachNXB(); // Tải lại danh sách NXB

                        // Xóa trắng các ô TextBox
                        txtMaNXB.Text = "";
                        txtTenNXB.Text = "";
                        txtDiaChi.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công!");
                    }
                }
                catch (Exception ex)
                {
                    // Bắt lỗi (ví dụ: xóa NXB đang được sử dụng bởi bảng Sach)
                    MessageBox.Show("Lỗi khi xóa dữ liệu: " + ex.Message);
                }
                finally
                {
                    DongKetNoi(); // Luôn đóng kết nối
                }
            }
        }
    }
}