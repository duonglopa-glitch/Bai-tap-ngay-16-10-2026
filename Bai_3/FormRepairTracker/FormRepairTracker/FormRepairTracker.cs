using RepairServiceApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormRepairTracker
{
    public partial class FormRepairTracker : Form
    {
        private BindingList<RepairOrder> _allOrders;
        private BindingSource _bindingSource;
        private string _selectedImagePath = string.Empty;
        public FormRepairTracker()
        {
            InitializeComponent();
        }

        private void FormRepairTracker_Load(object sender, EventArgs e)
        {
            _allOrders = new BindingList<RepairOrder>();
            _bindingSource = new BindingSource();

            InitDropdownData();
            InitMockData();
            ConfigureDataGridView();
            BindControlsToBindingSource();
            ApplyFilterAndSearch();
        }
        private void InitDropdownData()
        {
            // Loại thiết bị
            cboDeviceType.Items.Clear();
            cboDeviceType.Items.AddRange(new object[] {
                "Laptop",
                "Điện thoại di động",
                "Máy tính bảng",
                "PC / Linh kiện máy tính",
                "Thiết bị điện gia dụng"
            });
            cboDeviceType.SelectedIndex = 0;

            // Trạng thái đơn nhập
            cboStatus.Items.Clear();
            cboStatus.Items.AddRange(new object[] {
                "Mới tiếp nhận",
                "Đang sửa",
                "Chờ linh kiện",
                "Hoàn tất",
                "Đã hủy"
            });
            cboStatus.SelectedIndex = 0;

            // Trạng thái lọc
            cboFilterStatus.Items.Clear();
            cboFilterStatus.Items.Add("Tất cả");
            cboFilterStatus.Items.AddRange(new object[] {
                "Mới tiếp nhận",
                "Đang sửa",
                "Chờ linh kiện",
                "Hoàn tất",
                "Đã hủy"
            });
            cboFilterStatus.SelectedIndex = 0;

            dtpReceivedDate.Value = DateTime.Now;
            picDeviceImage.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void InitMockData()
        {
            _allOrders.Add(new RepairOrder("SC001", "Trần Văn Bình", "0912345678", "Laptop", "Bật không lên nguồn, bật có tiếng kêu cạch cạch", DateTime.Now.AddDays(-2), 450000m, "Mới tiếp nhận"));
            _allOrders.Add(new RepairOrder("SC002", "Lê Thị Thu", "0988776655", "Điện thoại di động", "Vỡ màn hình cảm ứng, sạc pin chập chờn", DateTime.Now.AddDays(-1), 1200000m, "Đang sửa"));
            _allOrders.Add(new RepairOrder("SC003", "Nguyễn Hoàng Nam", "0903123456", "PC / Linh kiện máy tính", "Hỏng card đồ họa, treo máy khi chơi game", DateTime.Now.AddDays(-5), 2500000m, "Chờ linh kiện"));
            _allOrders.Add(new RepairOrder("SC004", "Phạm Quốc Anh", "0971122334", "Máy tính bảng", "Thay pin mới và vệ sinh máy", DateTime.Now.AddDays(-4), 350000m, "Hoàn tất"));

            _bindingSource.DataSource = _allOrders;
            dgvRepairOrders.DataSource = _bindingSource;
        }

        private void ConfigureDataGridView()
        {
            dgvRepairOrders.AutoGenerateColumns = false;
            dgvRepairOrders.Columns.Clear();

            dgvRepairOrders.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "OrderId", HeaderText = "Mã Đơn", Width = 90 });
            dgvRepairOrders.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "CustomerName", HeaderText = "Tên Khách Hàng", Width = 160 });
            dgvRepairOrders.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "PhoneNumber", HeaderText = "Số Điện Thoại", Width = 110 });
            dgvRepairOrders.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "DeviceType", HeaderText = "Loại Thiết Bị", Width = 130 });
            dgvRepairOrders.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "IssueDescription", HeaderText = "Mô Tả Lỗi", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvRepairOrders.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ReceivedDate", HeaderText = "Ngày Tiếp Nhận", Width = 130, DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy HH:mm" } });

            // Định dạng cột chi phí theo chuẩn chuỗi "N0"
            dgvRepairOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "EstimatedCost",
                HeaderText = "Chi Phí Dự Kiến",
                Width = 130,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0", Alignment = DataGridViewContentAlignment.MiddleRight }
            });

            dgvRepairOrders.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Status", HeaderText = "Trạng Thái", Width = 120 });
        }

        private void BindControlsToBindingSource()
        {
            _bindingSource.CurrentChanged += (s, e) => LoadCurrentItemToInputFields();
        }

        private void LoadCurrentItemToInputFields()
        {
            if (_bindingSource.Current is RepairOrder item)
            {
                txtOrderId.Text = item.OrderId;
                txtCustomerName.Text = item.CustomerName;
                txtPhoneNumber.Text = item.PhoneNumber;
                cboDeviceType.SelectedItem = item.DeviceType;
                txtIssueDescription.Text = item.IssueDescription;
                dtpReceivedDate.Value = item.ReceivedDate < dtpReceivedDate.MinDate ? DateTime.Now : item.ReceivedDate;
                numEstimatedCost.Value = item.EstimatedCost;
                cboStatus.SelectedItem = item.Status;

                _selectedImagePath = item.ImagePath;
                DisplayImage(_selectedImagePath);

                txtOrderId.ReadOnly = true; // Khóa mã đơn khi chọn từ bảng
            }
        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn ảnh thiết bị sửa chữa";
                ofd.Filter = "Tệp hình ảnh (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp|Tất cả tệp (*.*)|*.*";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _selectedImagePath = ofd.FileName;
                    DisplayImage(_selectedImagePath);
                }
            }
        }

        private void btnClearImage_Click(object sender, EventArgs e)
        {
            _selectedImagePath = string.Empty;
            if (picDeviceImage.Image != null)
            {
                picDeviceImage.Image.Dispose();
                picDeviceImage.Image = null;
            }

        }
        private void DisplayImage(string imagePath)
        {
            if (picDeviceImage.Image != null)
            {
                picDeviceImage.Image.Dispose();
                picDeviceImage.Image = null;
            }

            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
            {
                try
                {
                    // Tải ảnh an toàn không khóa file đĩa
                    using (FileStream stream = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                    {
                        picDeviceImage.Image = Image.FromStream(stream);
                    }
                }
                catch
                {
                    picDeviceImage.Image = null;
                }
            }
        }
        private bool ValidateInput(bool isNew)
        {
            epRepair.Clear();
            bool isValid = true;

            // 1. Kiểm tra Mã đơn duy nhất
            if (string.IsNullOrWhiteSpace(txtOrderId.Text))
            {
                epRepair.SetError(txtOrderId, "Mã đơn không được để trống!");
                isValid = false;
            }
            else if (isNew && _allOrders.Any(o => o.OrderId.Equals(txtOrderId.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                epRepair.SetError(txtOrderId, "Mã đơn đã tồn tại trên hệ thống!");
                isValid = false;
            }

            // 2. Kiểm tra Tên khách hàng
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
            {
                epRepair.SetError(txtCustomerName, "Tên khách hàng không được để trống!");
                isValid = false;
            }

            // 3. Kiểm tra Số điện thoại hợp lệ
            string phonePattern = @"^(0[3|5|7|8|9])+([0-9]{8})$";
            if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text) || !Regex.IsMatch(txtPhoneNumber.Text.Trim(), phonePattern))
            {
                epRepair.SetError(txtPhoneNumber, "Số điện thoại không hợp lệ (Gồm 10 chữ số bắt đầu bằng 03, 05, 07, 08, 09)!");
                isValid = false;
            }

            // 4. Kiểm tra Mô tả lỗi bắt buộc
            if (string.IsNullOrWhiteSpace(txtIssueDescription.Text))
            {
                epRepair.SetError(txtIssueDescription, "Mô tả lỗi thiết bị không được để trống!");
                isValid = false;
            }

            // 5. Kiểm tra Chi phí dự kiến không âm
            if (numEstimatedCost.Value < 0)
            {
                epRepair.SetError(numEstimatedCost, "Chi phí dự kiến không được là số âm!");
                isValid = false;
            }

            return isValid;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(isNew: true)) return;

            RepairOrder newOrder = new RepairOrder(
                txtOrderId.Text.Trim(),
                txtCustomerName.Text.Trim(),
                txtPhoneNumber.Text.Trim(),
                cboDeviceType.SelectedItem.ToString(),
                txtIssueDescription.Text.Trim(),
                dtpReceivedDate.Value,
                numEstimatedCost.Value,
                cboStatus.SelectedItem.ToString(),
                _selectedImagePath
            );

            _allOrders.Add(newOrder);
            ApplyFilterAndSearch();
            MessageBox.Show("Thêm đơn đăng ký sửa chữa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearInputFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_bindingSource.Current == null)
            {
                MessageBox.Show("Vui lòng chọn một đơn sửa chữa từ danh sách để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInput(isNew: false)) return;

            RepairOrder selected = _allOrders.FirstOrDefault(o => o.OrderId == txtOrderId.Text.Trim());
            if (selected != null)
            {
                selected.CustomerName = txtCustomerName.Text.Trim();
                selected.PhoneNumber = txtPhoneNumber.Text.Trim();
                selected.DeviceType = cboDeviceType.SelectedItem.ToString();
                selected.IssueDescription = txtIssueDescription.Text.Trim();
                selected.ReceivedDate = dtpReceivedDate.Value;
                selected.EstimatedCost = numEstimatedCost.Value;
                selected.Status = cboStatus.SelectedItem.ToString();
                selected.ImagePath = _selectedImagePath;

                _bindingSource.ResetCurrentItem();
                ApplyFilterAndSearch();
                MessageBox.Show("Cập nhật đơn sửa chữa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_bindingSource.Current is RepairOrder selected)
            {
                DialogResult dr = MessageBox.Show(
                    string.Format("Bạn có chắc chắn muốn xóa đơn sửa chữa [{0}] của khách hàng [{1}]?", selected.OrderId, selected.CustomerName),
                    "Xác nhận xóa đơn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    _allOrders.Remove(selected);
                    ApplyFilterAndSearch();
                    ClearInputFields();
                    MessageBox.Show("Đã xóa đơn sửa chữa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }
        private void ClearInputFields()
        {
            txtOrderId.Clear();
            txtCustomerName.Clear();
            txtPhoneNumber.Clear();
            cboDeviceType.SelectedIndex = 0;
            txtIssueDescription.Clear();
            dtpReceivedDate.Value = DateTime.Now;
            numEstimatedCost.Value = 0;
            cboStatus.SelectedIndex = 0;
            btnClearImage_Click(null, null);

            txtOrderId.ReadOnly = false;
            epRepair.Clear();
            dgvRepairOrders.ClearSelection();
            txtOrderId.Focus();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) => ApplyFilterAndSearch();

        private void cboFilterStatus_SelectedIndexChanged(object sender, EventArgs e) => ApplyFilterAndSearch();
        private void ApplyFilterAndSearch()
        {
            if (_allOrders == null) return; // Kiểm tra chống lỗi Null Reference Exception

            string keyword = txtSearch.Text.Trim().ToLower();
            string selectedStatus = cboFilterStatus.SelectedItem != null ? cboFilterStatus.SelectedItem.ToString() : "Tất cả";

            var filteredList = _allOrders.Where(order =>
            {
                // Tìm kiếm theo Mã đơn, Tên KH hoặc SĐT
                bool matchKeyword = string.IsNullOrEmpty(keyword) ||
                                   order.OrderId.ToLower().Contains(keyword) ||
                                   order.CustomerName.ToLower().Contains(keyword) ||
                                   order.PhoneNumber.Contains(keyword);

                // Lọc theo Trạng thái đơn
                bool matchStatus = selectedStatus == "Tất cả" || order.Status == selectedStatus;

                return matchKeyword && matchStatus;
            }).ToList();

            _bindingSource.DataSource = new BindingList<RepairOrder>(filteredList);

            // Tính tổng chi phí dự kiến của các đơn CHƯA HOÀN TẤT (Trạng thái khác "Hoàn tất" và "Đã hủy")
            decimal pendingCostSum = _allOrders
                .Where(o => o.Status != "Hoàn tất" && o.Status != "Đã hủy")
                .Sum(o => o.EstimatedCost);

            // Cập nhật thông số lên StatusStrip
            lblStatusCount.Text = string.Format("Số đơn đang hiển thị: {0} / {1}", filteredList.Count, _allOrders.Count);
            lblPendingCostSum.Text = string.Format("Tổng chi phí các đơn chưa hoàn tất: {0:N0} VNĐ", pendingCostSum);
        }

        private void mnuExportCsv_Click(object sender, EventArgs e)
        {
            var visibleList = (_bindingSource.DataSource as BindingList<RepairOrder>)?.ToList();

            if (visibleList == null || visibleList.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu đơn sửa chữa nào để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "Xuất danh sách đơn sửa chữa ra file CSV";
                sfd.Filter = "File CSV (*.csv)|*.csv";
                sfd.FileName = string.Format("RepairOrders_{0:yyyyMMdd_HHmmss}.csv", DateTime.Now);

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        StringBuilder sb = new StringBuilder();
                        // Tiêu đề cột
                        sb.AppendLine("MaDon,TenKhachHang,SoDienThoai,LoaiThietBi,MoTaLoi,NgayTiepNhan,ChiPhiDuKien,TrangThai,DuongDanAnh");

                        foreach (var item in visibleList)
                        {
                            // Thay thế dấu xuống dòng trong mô tả lỗi để tránh hỏng cấu trúc CSV
                            string cleanDescription = item.IssueDescription.Replace("\r\n", " ").Replace("\n", " ");

                            sb.AppendLine(string.Format("\"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\",\"{5:dd/MM/yyyy HH:mm}\",{6},\"{7}\",\"{8}\"",
                                item.OrderId,
                                item.CustomerName,
                                item.PhoneNumber,
                                item.DeviceType,
                                cleanDescription,
                                item.ReceivedDate,
                                item.EstimatedCost,
                                item.Status,
                                item.ImagePath));
                        }

                        File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                        MessageBox.Show("Xuất danh sách đơn sửa chữa ra file CSV thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi trong quá trình xuất file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát ứng dụng?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
