using System;
using System.Linq;
using System.Windows.Forms;

namespace Cau1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Thiết lập thuộc tính cho mật khẩu và nút Hủy ngay khi khởi tạo
            txtMatKhau.PasswordChar = '*';
            txtXacNhanMK.PasswordChar = '*';
            btnHuy.CausesValidation = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Hàm kiểm tra tính hợp lệ của dữ liệu nhập vào
        private bool KiemTraHopLe()
        {
            bool hopLe = true;

            // (1) txtHoTen không để trống và tối thiểu 3 ký tự
            if (string.IsNullOrWhiteSpace(txtHoTen.Text) || txtHoTen.Text.Trim().Length < 3)
            {
                errorProvider1.SetError(txtHoTen, "Họ tên không được để trống và tối thiểu 3 ký tự.");
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtHoTen, "");
            }

            // (2) txtSDT đúng 10 chữ số, bắt đầu bằng "0"
            string sdt = txtSDT.Text.Trim();
            if (sdt.Length != 10 || !sdt.StartsWith("0") || !sdt.All(char.IsDigit))
            {
                errorProvider1.SetError(txtSDT, "Số điện thoại phải đúng 10 chữ số và bắt đầu bằng 0.");
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtSDT, "");
            }

            // (3) txtEmail chứa "@" và "." phía sau "@"
            string email = txtEmail.Text.Trim();
            int viTriAt = email.IndexOf('@');
            int viTriCham = viTriAt >= 0 ? email.IndexOf('.', viTriAt) : -1;

            if (viTriAt <= 0 || viTriCham <= viTriAt + 1 || viTriCham == email.Length - 1)
            {
                errorProvider1.SetError(txtEmail, "Email không đúng định dạng.");
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtEmail, "");
            }

            // (4) txtMatKhau tối thiểu 6 ký tự
            if (txtMatKhau.Text.Length < 6)
            {
                errorProvider1.SetError(txtMatKhau, "Mật khẩu phải có tối thiểu 6 ký tự.");
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtMatKhau, "");
            }

            // (5) txtXacNhanMK phải khớp với txtMatKhau
            if (string.IsNullOrEmpty(txtXacNhanMK.Text) || txtXacNhanMK.Text != txtMatKhau.Text)
            {
                errorProvider1.SetError(txtXacNhanMK, "Mật khẩu xác nhận không khớp.");
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtXacNhanMK, "");
            }

            return hopLe;
        }

        // Sự kiện Click của nút Đăng ký
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (!KiemTraHopLe())
            {
                return;
            }

            MessageBox.Show("Đăng ký thành công! Chào mừng " + txtHoTen.Text,
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        // Sự kiện Click của nút Hủy
        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnHuy.CausesValidation = false;
            errorProvider1.Clear();
            this.Close();
        }
    }
}