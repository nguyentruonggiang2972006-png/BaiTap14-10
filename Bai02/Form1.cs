using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Bai02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 1. Xử lý nút TẢI ẢNH LỖI
        private void btnTaiAnh_Click(object sender, EventArgs e)
        {
            // Mở hộp thoại chọn file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn ảnh lỗi";
            openFileDialog.Filter = "Image Files (*.jpg, *.png)|*.jpg;*.png"; // Chỉ cho chọn ảnh jpg, png

            // Nếu người dùng chọn ảnh và bấm OK
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Hiển thị ảnh lên PictureBox
                picAnhLoi.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        // 2. Xử lý nút GỬI YÊU CẦU
        private void btnGuiYeuCau_Click(object sender, EventArgs e)
        {
            // Validate sơ bộ
            if (string.IsNullOrWhiteSpace(txtMaPhieu.Text) || string.IsNullOrWhiteSpace(txtNguoiYeuCau.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã phiếu và Người yêu cầu!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbLoaiSuCo.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn Loại sự cố!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Thu thập Mức độ ưu tiên
            string mucDo = "";
            if (radThap.Checked) mucDo = "Thấp";
            else if (radTrungBinh.Checked) mucDo = "Trung bình";
            else if (radKhanCap.Checked) mucDo = "Khẩn cấp";

            // Thu thập Thiết bị ảnh hưởng (có thể chọn nhiều)
            List<string> thietBi = new List<string>();
            if (chkMayTinhBan.Checked) thietBi.Add("Máy tính bàn");
            if (chkLaptop.Checked) thietBi.Add("Laptop");
            if (chkMayIn.Checked) thietBi.Add("Máy in");
            if (chkDienThoai.Checked) thietBi.Add("Điện thoại");

            string danhSachThietBi = thietBi.Count > 0 ? string.Join(", ", thietBi) : "Không có";

            // Tạo chuỗi tóm tắt thông tin
            string tomTat = "THÔNG TIN PHIẾU HỖ TRỢ IT\n";
            tomTat += "--------------------------------------\n";
            tomTat += $"- Mã phiếu: {txtMaPhieu.Text}\n";
            tomTat += $"- Người yêu cầu: {txtNguoiYeuCau.Text}\n";
            tomTat += $"- Ngày ghi nhận: {dtpNgayGhiNhan.Value.ToString("dd/MM/yyyy")}\n";
            tomTat += $"- Mức độ ưu tiên: {mucDo}\n";
            tomTat += $"- Loại sự cố: {cmbLoaiSuCo.SelectedItem.ToString()}\n";
            tomTat += $"- Thiết bị ảnh hưởng: {danhSachThietBi}\n";

            string coAnh = (picAnhLoi.Image != null) ? "Đã đính kèm ảnh lỗi" : "Không có ảnh đính kèm";
            tomTat += $"- Hình ảnh: {coAnh}";

            // Hiển thị kết quả
            MessageBox.Show(tomTat, "Tóm tắt yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // 3. Xử lý nút NHẬP LẠI (Xóa trắng toàn bộ form)
        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtMaPhieu.Clear();
            txtNguoiYeuCau.Clear();
            dtpNgayGhiNhan.Value = DateTime.Now; // Đưa ngày về hiện tại

            radThap.Checked = true; // Chọn lại mức ưu tiên mặc định
            cmbLoaiSuCo.SelectedIndex = -1; // Bỏ chọn ComboBox

            // Bỏ chọn tất cả Checkbox
            chkMayTinhBan.Checked = false;
            chkLaptop.Checked = false;
            chkMayIn.Checked = false;
            chkDienThoai.Checked = false;

            // Xóa ảnh
            picAnhLoi.Image = null;

            txtMaPhieu.Focus();
        }
    }
}