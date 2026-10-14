using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bai05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Cài đặt Timer chạy đồng hồ
            tmrClock.Interval = 1000;
            tmrClock.Tick += TmrClock_Tick;
            tmrClock.Start();

            // Kết nối các sự kiện của DataGridView
            dgvHangHoa.CellValueChanged += DgvHangHoa_CellValueChanged;
            dgvHangHoa.CellValidating += DgvHangHoa_CellValidating;
            dgvHangHoa.CurrentCellDirtyStateChanged += DgvHangHoa_CurrentCellDirtyStateChanged;

            // Kết nối sự kiện phím tắt cho Form
            this.KeyDown += Form1_KeyDown;
        }

        // 1. Cập nhật đồng hồ thời gian thực trên StatusStrip
        private void TmrClock_Tick(object sender, EventArgs e)
        {
            lblThoiGian.Text = "Thời gian: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        // 2. Ép DataGridView nhận diện sự thay đổi giá trị ngay lập tức (không cần chờ bấm Enter)
        private void DgvHangHoa_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvHangHoa.IsCurrentCellDirty)
            {
                dgvHangHoa.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        // 3. Tự động tính Thành Tiền và Cập nhật StatusStrip khi ô lưới bị thay đổi
        private void DgvHangHoa_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHangHoa.Rows[e.RowIndex];

                // Nếu người dùng vừa sửa Số lượng hoặc Đơn giá -> Tự tính lại Thành Tiền
                if (e.ColumnIndex == dgvHangHoa.Columns["colSoLuong"].Index ||
                    e.ColumnIndex == dgvHangHoa.Columns["colDonGia"].Index)
                {
                    decimal soLuong = 0, donGia = 0;
                    decimal.TryParse(Convert.ToString(row.Cells["colSoLuong"].Value), out soLuong);
                    decimal.TryParse(Convert.ToString(row.Cells["colDonGia"].Value), out donGia);

                    row.Cells["colThanhTien"].Value = (soLuong * donGia).ToString("N0");
                }

                // Sau khi thay đổi bất kỳ ô nào, tính toán lại toàn bộ tổng trên StatusStrip
                CapNhatStatusStrip();
            }
        }

        // 4. Sử dụng ErrorProvider (biểu tượng chấm đỏ) để bắt lỗi trực tiếp trên ô nhập
        private void DgvHangHoa_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.RowIndex >= 0 && !dgvHangHoa.Rows[e.RowIndex].IsNewRow)
            {
                // Kiểm tra cột Số Lượng
                if (e.ColumnIndex == dgvHangHoa.Columns["colSoLuong"].Index)
                {
                    decimal sl;
                    if (!decimal.TryParse(e.FormattedValue.ToString(), out sl) || sl <= 0)
                    {
                        dgvHangHoa.Rows[e.RowIndex].ErrorText = "Lỗi: Số lượng phải lớn hơn 0!";
                        e.Cancel = true; // Chặn không cho thoát khỏi ô nhập
                    }
                    else
                    {
                        dgvHangHoa.Rows[e.RowIndex].ErrorText = string.Empty; // Xóa lỗi
                    }
                }

                // Kiểm tra cột Trọng lượng
                if (e.ColumnIndex == dgvHangHoa.Columns["colTrongLuong"].Index)
                {
                    decimal tl;
                    if (!decimal.TryParse(e.FormattedValue.ToString(), out tl) || tl <= 0)
                    {
                        dgvHangHoa.Rows[e.RowIndex].ErrorText = "Lỗi: Trọng lượng phải lớn hơn 0 kg!";
                        e.Cancel = true;
                    }
                    else
                    {
                        dgvHangHoa.Rows[e.RowIndex].ErrorText = string.Empty;
                    }
                }
            }
        }

        // 5. Hàm quét toàn bộ bảng để tính tổng cho thanh trạng thái dưới cùng
        private void CapNhatStatusStrip()
        {
            decimal tongSoLuong = 0;
            decimal tongTrongLuong = 0;
            decimal tongTien = 0;

            foreach (DataGridViewRow row in dgvHangHoa.Rows)
            {
                if (!row.IsNewRow)
                {
                    decimal sl = 0, tl = 0, tt = 0;
                    decimal.TryParse(Convert.ToString(row.Cells["colSoLuong"].Value), out sl);
                    decimal.TryParse(Convert.ToString(row.Cells["colTrongLuong"].Value), out tl);
                    decimal.TryParse(Convert.ToString(row.Cells["colThanhTien"].Value), out tt);

                    tongSoLuong += sl;
                    tongTrongLuong += tl;
                    tongTien += tt;
                }
            }

            lblTongSoLuong.Text = $"Tổng SL: {tongSoLuong:N0}";
            lblTongTrongLuong.Text = $"Tổng TL: {tongTrongLuong:N2} kg";
            lblTongTien.Text = $"Tổng tiền: {tongTien:N0} VNĐ";
        }

        // 6. Xử lý Phím tắt: F2 để thêm dòng, Delete để xóa dòng
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Nhấn F2 -> Di chuyển con trỏ chuột xuống dòng mới cuối cùng để nhập luôn
            if (e.KeyCode == Keys.F2)
            {
                dgvHangHoa.Focus();
                if (dgvHangHoa.Rows.Count > 0)
                {
                    int lastRowIndex = dgvHangHoa.Rows.Count - 1;
                    dgvHangHoa.CurrentCell = dgvHangHoa.Rows[lastRowIndex].Cells[0];
                    dgvHangHoa.BeginEdit(true);
                }
            }

            // Nhấn Delete -> Xác nhận và xóa dòng đang chọn (nếu không phải dòng trống)
            if (e.KeyCode == Keys.Delete)
            {
                if (dgvHangHoa.SelectedRows.Count > 0 && !dgvHangHoa.SelectedRows[0].IsNewRow)
                {
                    DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa dòng hàng hóa này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        dgvHangHoa.Rows.RemoveAt(dgvHangHoa.SelectedRows[0].Index);
                        CapNhatStatusStrip(); // Xóa xong phải tính lại tổng
                    }
                }
            }
        }
    }
}