using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bai04
{
    public partial class Form1 : Form
    {
        // Khai báo biến toàn cục để đếm số ghế và tính tiền
        private int soGheDangChon = 0;
        private decimal donGia = 100000; // Mặc định giờ Sáng

        public Form1()
        {
            InitializeComponent();
        }

        // Sự kiện Form_Load chạy ngay khi Form vừa mở lên
        private void Form1_Load(object sender, EventArgs e)
        {
            // 1. Cài đặt ComboBox mặc định là dòng đầu tiên (Sáng)
            cmbKhungGio.SelectedIndex = 0;
            cmbKhungGio.SelectedIndexChanged += CmbKhungGio_SelectedIndexChanged;

            // 2. Dùng vòng lặp tạo 20 Button (4 hàng x 5 cột = 20)
            for (int i = 1; i <= 20; i++)
            {
                Button btn = new Button();
                btn.Text = i.ToString();            // In số lên ghế
                btn.Size = new Size(60, 50);        // Kích thước ghế
                btn.BackColor = Color.White;        // Trạng thái ban đầu: Trắng (Trống)
                btn.Cursor = Cursors.Hand;          // Đổi icon chuột thành hình bàn tay

                // Gán CHUNG 1 sự kiện Click cho cả 20 nút này
                btn.Click += Ghe_Click;

                // Thêm nút vừa tạo vào cái khung FlowLayoutPanel
                flpSoDo.Controls.Add(btn);
            }
        }

        // Xử lý cập nhật giá tiền khi đổi khung giờ Sáng/Tối
        private void CmbKhungGio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhungGio.SelectedIndex == 0) // Sáng
                donGia = 100000;
            else                                // Tối
                donGia = 150000;

            CapNhatThanhToan();
        }

        // Sự kiện CHUNG dùng cho toàn bộ 20 cái ghế khi bị click
        private void Ghe_Click(object sender, EventArgs e)
        {
            // Ép kiểu sender (kẻ gửi sự kiện) về lại thành Button để biết chính xác ghế nào đang bị bấm
            Button gheDuocBam = sender as Button;

            if (gheDuocBam != null)
            {
                // Nếu ghế màu Đỏ -> Đã có người mua -> Báo lỗi không cho bấm
                if (gheDuocBam.BackColor == Color.Red)
                {
                    MessageBox.Show("Vị trí này đã có người đặt. Vui lòng chọn vị trí khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Nếu ghế màu Trắng -> Đang trống -> Đổi sang Xanh lá (Đang chọn)
                if (gheDuocBam.BackColor == Color.White)
                {
                    gheDuocBam.BackColor = Color.LightGreen;
                    soGheDangChon++;
                }
                // Nếu ghế màu Xanh lá -> Đang chọn -> Bấm phát nữa để Hủy chọn (Về Trắng)
                else if (gheDuocBam.BackColor == Color.LightGreen)
                {
                    gheDuocBam.BackColor = Color.White;
                    soGheDangChon--;
                }

                // Tính lại tiền
                CapNhatThanhToan();
            }
        }

        // Hàm hỗ trợ tính toán và hiển thị Text
        private void CapNhatThanhToan()
        {
            lblSoViTri.Text = $"Số vị trí đang chọn: {soGheDangChon}";
            decimal tongTien = soGheDangChon * donGia;
            lblTamTinh.Text = $"Tạm tính tiền: {tongTien:N0} VNĐ";
        }

        // Nút Xác nhận đặt
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (soGheDangChon == 0)
            {
                MessageBox.Show("Bạn chưa chọn vị trí nào!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult dr = MessageBox.Show($"Xác nhận đặt {soGheDangChon} vị trí với tổng tiền {soGheDangChon * donGia:N0} VNĐ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                // Quét qua tất cả 20 nút, nút nào màu Xanh Lá thì chuyển thành Đỏ vĩnh viễn
                foreach (Control ctrl in flpSoDo.Controls)
                {
                    if (ctrl is Button && ctrl.BackColor == Color.LightGreen)
                    {
                        ctrl.BackColor = Color.Red;
                    }
                }

                // Reset lại bộ đếm tiền
                soGheDangChon = 0;
                CapNhatThanhToan();
                MessageBox.Show("Đặt vị trí thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Nút Hủy chọn tất cả (Chỉ hủy những ghế Xanh lá, không hủy ghế Đỏ)
        private void btnHuy_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in flpSoDo.Controls)
            {
                if (ctrl is Button && ctrl.BackColor == Color.LightGreen)
                {
                    ctrl.BackColor = Color.White;
                }
            }
            soGheDangChon = 0;
            CapNhatThanhToan();
        }
    }
}