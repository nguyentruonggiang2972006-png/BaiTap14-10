using System;
using System.Windows.Forms;

namespace Bai03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Hàm hỗ trợ: Làm sạch các ô nhập liệu
        private void ClearInputs()
        {
            txtMaVT.Clear();
            txtTenVT.Clear();
            cmbDonVi.SelectedIndex = -1;
            txtDonGia.Clear();
            txtMaVT.Focus();
        }

        // Hàm hỗ trợ: Kiểm tra dữ liệu hợp lệ không
        private bool ValidateData()
        {
            if (string.IsNullOrWhiteSpace(txtMaVT.Text) || string.IsNullOrWhiteSpace(txtTenVT.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ Mã vật tư và Tên vật tư!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbDonVi.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn Đơn vị tính!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtDonGia.Text, out decimal donGia) || donGia < 0)
            {
                MessageBox.Show("Đơn giá phải là một số lớn hơn hoặc bằng 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.Focus();
                return false;
            }
            return true;
        }

        // 1. Chức năng THÊM MỚI
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (!ValidateData()) return;

            // Kiểm tra trùng Mã Vật Tư
            foreach (ListViewItem item in lsvVatTu.Items)
            {
                if (item.Text.Trim().ToUpper() == txtMaVT.Text.Trim().ToUpper())
                {
                    MessageBox.Show("Mã vật tư này đã tồn tại trong danh sách. Vui lòng nhập mã khác!", "Lỗi trùng lặp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaVT.Focus();
                    return;
                }
            }

            // Tạo một dòng mới (ListViewItem)
            ListViewItem lvi = new ListViewItem(txtMaVT.Text.Trim()); // Cột 0: Mã VT
            lvi.SubItems.Add(txtTenVT.Text.Trim());                   // Cột 1: Tên VT
            lvi.SubItems.Add(cmbDonVi.SelectedItem.ToString());       // Cột 2: Đơn vị

            decimal donGia = Convert.ToDecimal(txtDonGia.Text);
            lvi.SubItems.Add(donGia.ToString("N0"));                  // Cột 3: Đơn giá (Format tiền tệ)

            // Đưa dòng mới vào danh sách
            lsvVatTu.Items.Add(lvi);
            ClearInputs();
        }

        // 2. Chức năng ĐẨY DỮ LIỆU LÊN ĐỂ SỬA KHI CLICK VÀO BẢNG
        private void lsvVatTu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvVatTu.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lsvVatTu.SelectedItems[0];
                txtMaVT.Text = lvi.SubItems[0].Text;
                txtTenVT.Text = lvi.SubItems[1].Text;
                cmbDonVi.SelectedItem = lvi.SubItems[2].Text;
                // Bỏ các dấu phẩy phân cách hàng nghìn khi đưa ngược lại ô TextBox
                txtDonGia.Text = lvi.SubItems[3].Text.Replace(",", "").Replace(".", "");
            }
        }

        // 3. Chức năng CẬP NHẬT
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (lsvVatTu.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng dưới danh sách để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!ValidateData()) return;

            // Lấy ra dòng đang được chọn
            ListViewItem lvi = lsvVatTu.SelectedItems[0];

            // Cập nhật giá trị các cột
            lvi.SubItems[0].Text = txtMaVT.Text.Trim();
            lvi.SubItems[1].Text = txtTenVT.Text.Trim();
            lvi.SubItems[2].Text = cmbDonVi.SelectedItem.ToString();

            decimal donGia = Convert.ToDecimal(txtDonGia.Text);
            lvi.SubItems[3].Text = donGia.ToString("N0");

            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearInputs();
        }

        // 4. Chức năng XÓA DÒNG
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lsvVatTu.SelectedItems.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa vật tư này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    lsvVatTu.Items.Remove(lsvVatTu.SelectedItems[0]);
                    ClearInputs();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // 5. Chức năng XÓA TOÀN BỘ
        private void btnXoaAll_Click(object sender, EventArgs e)
        {
            if (lsvVatTu.Items.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có CHẮC CHẮN muốn xóa TOÀN BỘ danh sách không?", "Cảnh báo nguy hiểm", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (dr == DialogResult.Yes)
                {
                    lsvVatTu.Items.Clear();
                    ClearInputs();
                }
            }
        }
    }
}