using System;
using System.Windows.Forms;

namespace ServiceChargeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Hàm này giữ lại để Form không bị báo lỗi thiếu sự kiện TextChanged
        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            // Để trống
        }

        // Xử lý sự kiện bấm nút Tính Tiền
        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            // 1. Validate Đơn giá
            if (!decimal.TryParse(txtDonGia.Text, out decimal donGia) || donGia <= 0)
            {
                MessageBox.Show("Vui lòng nhập Đơn giá là một số hợp lệ lớn hơn 0.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.Focus();
                return;
            }

            // 2. Validate Số lượng khách
            if (!int.TryParse(txtSoLuong.Text, out int soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Vui lòng nhập Số lượng khách là số nguyên lớn hơn 0.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuong.Focus();
                return;
            }

            // 3. Validate Giảm giá (Nếu để trống thì mặc định tính là 0%)
            decimal giamGia = 0;
            if (!string.IsNullOrWhiteSpace(txtGiamGia.Text))
            {
                if (!decimal.TryParse(txtGiamGia.Text, out giamGia) || giamGia < 0 || giamGia > 100)
                {
                    MessageBox.Show("Phần trăm giảm giá phải nằm trong khoảng từ 0 đến 100.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtGiamGia.Focus();
                    return;
                }
            }

            // 4. Xử lý logic tính toán
            decimal tongTien = (donGia * soLuong) * ((100 - giamGia) / 100m);

            // 5. Hiển thị kết quả
            lblTongTien.Text = $"Tổng tiền thanh toán: {tongTien:N0} VNĐ";
        }

        // Xử lý sự kiện bấm nút Làm Mới
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtDonGia.Clear();
            txtSoLuong.Clear();
            txtGiamGia.Clear();
            lblTongTien.Text = "Tổng tiền thanh toán: 0 VNĐ";

            txtDonGia.Focus();
        }

        private void txtGiamGia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}