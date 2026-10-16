using LabEquipmentApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormEquipmentCheckout
{
    
    public partial class ClearInputFields : Form
    {
        private BindingList<EquipmentCheckout> _allCheckouts;
        private BindingSource _bindingSource;
        public ClearInputFields()
        {
            InitializeComponent();
        }

        private void ClearInputFields_Load(object sender, EventArgs e)
        {
            _allCheckouts = new BindingList<EquipmentCheckout>();
            _bindingSource = new BindingSource();

            InitDropdownData();
            InitMockData();
            ConfigureDataGridView();
            BindControlsToBindingSource();
            ApplyFilterAndSearch();
        }
        private void InitDropdownData()
        {
            // Danh sách thiết bị thực hành mẫu
            cboEquipment.Items.Clear();
            cboEquipment.Items.AddRange(new object[] {
                "Oscilloscope Tektronix 100MHz",
                "Bộ Thực Hành Vi Điều Khiển STM32",
                "Đồng Hồ Đo Vạn Năng Fluke",
                "Máy Phát Hàm Signal Generator",
                "Bộ Kit Lập Trình PLC Siemens S7-1200"
            });
            cboEquipment.SelectedIndex = 0;

            // Danh sách Lọc trạng thái
            cboFilterStatus.Items.Clear();
            cboFilterStatus.Items.AddRange(new object[] { "Tất cả", "Đang mượn", "Quá hạn", "Đã trả" });
            cboFilterStatus.SelectedIndex = 0;

            dtpCheckoutDate.Value = DateTime.Today;
            dtpDueDate.Value = DateTime.Today.AddDays(7);
            dtpActualReturnDate.Value = DateTime.Today;
        }

        private void InitMockData()
        {
            _allCheckouts.Add(new EquipmentCheckout("PM001", "SV2021001", "Nguyễn Văn An", "Oscilloscope Tektronix 100MHz", 1, DateTime.Today.AddDays(-10), DateTime.Today.AddDays(-3))); // Quá hạn
            _allCheckouts.Add(new EquipmentCheckout("PM002", "SV2021002", "Trần Thị Bích", "Bộ Thực Hành Vi Điều Khiển STM32", 2, DateTime.Today.AddDays(-2), DateTime.Today.AddDays(5)));   // Đang mượn
            _allCheckouts.Add(new EquipmentCheckout("PM003", "SV2021003", "Lê Hoàng Cường", "Đồng Hồ Đo Vạn Năng Fluke", 1, DateTime.Today.AddDays(-15), DateTime.Today.AddDays(-8), DateTime.Today.AddDays(-7))); // Đã trả

            _bindingSource.DataSource = _allCheckouts;
            dgvCheckouts.DataSource = _bindingSource;
        }

        private void ConfigureDataGridView()
        {
            dgvCheckouts.AutoGenerateColumns = false;
            dgvCheckouts.Columns.Clear();

            dgvCheckouts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "CheckoutId", HeaderText = "Mã Phiếu", Width = 90 });
            dgvCheckouts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "StudentId", HeaderText = "Mã Sinh Viên", Width = 110 });
            dgvCheckouts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "StudentName", HeaderText = "Họ Tên Sinh Viên", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvCheckouts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "EquipmentName", HeaderText = "Thiết Bị Thực Hành", Width = 220 });
            dgvCheckouts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Quantity", HeaderText = "SL", Width = 50 });
            dgvCheckouts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "CheckoutDate", HeaderText = "Ngày Mượn", Width = 100, DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" } });
            dgvCheckouts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "DueDate", HeaderText = "Hạn Trả", Width = 100, DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" } });

            // Cột hiển thị Ngày trả thực tế (Xử lý chuỗi rỗng nếu chưa trả)
            DataGridViewTextBoxColumn colActualReturn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ActualReturnDate",
                HeaderText = "Ngày Trả TT",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy", NullValue = "---" }
            };
            dgvCheckouts.Columns.Add(colActualReturn);

            dgvCheckouts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Status", HeaderText = "Tình Trạng", Width = 100 });
        }

        private void BindControlsToBindingSource()
        {
            _bindingSource.CurrentChanged += (s, e) => LoadCurrentItemToInputFields();
        }

        private void LoadCurrentItemToInputFields()
        {
            if (_bindingSource.Current is EquipmentCheckout item)
            {
                txtCheckoutId.Text = item.CheckoutId;
                txtStudentId.Text = item.StudentId;
                txtStudentName.Text = item.StudentName;
                cboEquipment.SelectedItem = item.EquipmentName;
                numQuantity.Value = item.Quantity;
                dtpCheckoutDate.Value = item.CheckoutDate;
                dtpDueDate.Value = item.DueDate;

                if (item.ActualReturnDate.HasValue)
                {
                    chkIsReturned.Checked = true;
                    dtpActualReturnDate.Value = item.ActualReturnDate.Value;
                }
                else
                {
                    chkIsReturned.Checked = false;
                    dtpActualReturnDate.Value = DateTime.Today;
                }

                txtCheckoutId.ReadOnly = true; // Khóa Mã phiếu khi chọn từ lưới
            }
        }

        private void chkIsReturned_CheckedChanged(object sender, EventArgs e)
        {
            dtpActualReturnDate.Enabled = chkIsReturned.Checked;
        }
        private bool ValidateInput(bool isNew)
        {
            epCheckout.Clear();
            bool isValid = true;

            // 1. Kiểm tra Mã phiếu mượn
            if (string.IsNullOrWhiteSpace(txtCheckoutId.Text))
            {
                epCheckout.SetError(txtCheckoutId, "Mã phiếu mượn không được để trống!");
                isValid = false;
            }
            else if (isNew && _allCheckouts.Any(x => x.CheckoutId.Equals(txtCheckoutId.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                epCheckout.SetError(txtCheckoutId, "Mã phiếu mượn đã tồn tại trên hệ thống!");
                isValid = false;
            }

            // 2. Kiểm tra Mã sinh viên
            if (string.IsNullOrWhiteSpace(txtStudentId.Text))
            {
                epCheckout.SetError(txtStudentId, "Mã sinh viên không được để trống!");
                isValid = false;
            }

            // 3. Kiểm tra Họ tên sinh viên
            if (string.IsNullOrWhiteSpace(txtStudentName.Text))
            {
                epCheckout.SetError(txtStudentName, "Họ tên sinh viên không được để trống!");
                isValid = false;
            }

            // 4. Kiểm tra Thiết bị
            if (cboEquipment.SelectedItem == null)
            {
                epCheckout.SetError(cboEquipment, "Vui lòng chọn thiết bị thực hành!");
                isValid = false;
            }

            // 5. Kiểm tra Số lượng mượn
            if (numQuantity.Value <= 0)
            {
                epCheckout.SetError(numQuantity, "Số lượng mượn phải lớn hơn 0!");
                isValid = false;
            }

            // 6. Kiểm tra Hạn trả không được trước Ngày mượn
            if (dtpDueDate.Value.Date < dtpCheckoutDate.Value.Date)
            {
                epCheckout.SetError(dtpDueDate, "Hạn trả không được trước ngày mượn thiết bị!");
                isValid = false;
            }

            // 7. Kiểm tra Ngày trả thực tế không được trước Ngày mượn (nếu chọn Đã trả)
            if (chkIsReturned.Checked && dtpActualReturnDate.Value.Date < dtpCheckoutDate.Value.Date)
            {
                epCheckout.SetError(dtpActualReturnDate, "Ngày trả thực tế không được trước ngày mượn!");
                isValid = false;
            }

            return isValid;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(isNew: true)) return;

            DateTime? actualReturn = chkIsReturned.Checked ? dtpActualReturnDate.Value.Date : (DateTime?)null;

            EquipmentCheckout item = new EquipmentCheckout(
                txtCheckoutId.Text.Trim(),
                txtStudentId.Text.Trim(),
                txtStudentName.Text.Trim(),
                cboEquipment.SelectedItem.ToString(),
                (int)numQuantity.Value,
                dtpCheckoutDate.Value.Date,
                dtpDueDate.Value.Date,
                actualReturn
            );

            _allCheckouts.Add(item);
            ApplyFilterAndSearch();
            MessageBox.Show("Thêm phiếu mượn mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearInputField();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_bindingSource.Current == null)
            {
                MessageBox.Show("Vui lòng chọn một phiếu mượn từ danh sách để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInput(isNew: false)) return;

            EquipmentCheckout selected = _allCheckouts.FirstOrDefault(x => x.CheckoutId == txtCheckoutId.Text.Trim());
            if (selected != null)
            {
                selected.StudentId = txtStudentId.Text.Trim();
                selected.StudentName = txtStudentName.Text.Trim();
                selected.EquipmentName = cboEquipment.SelectedItem.ToString();
                selected.Quantity = (int)numQuantity.Value;
                selected.CheckoutDate = dtpCheckoutDate.Value.Date;
                selected.DueDate = dtpDueDate.Value.Date;
                selected.ActualReturnDate = chkIsReturned.Checked ? dtpActualReturnDate.Value.Date : (DateTime?)null;

                _bindingSource.ResetCurrentItem();
                ApplyFilterAndSearch();
                MessageBox.Show("Cập nhật phiếu mượn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_bindingSource.Current is EquipmentCheckout selected)
            {
                DialogResult dr = MessageBox.Show(
                    string.Format("Bạn có chắc chắn muốn xóa phiếu mượn [{0}] của sinh viên [{1}]?", selected.CheckoutId, selected.StudentName),
                    "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    _allCheckouts.Remove(selected);
                    ApplyFilterAndSearch();
                    ClearInputField();
                    MessageBox.Show("Đã xóa phiếu mượn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (_bindingSource.Current is EquipmentCheckout selected)
            {
                if (selected.ActualReturnDate.HasValue)
                {
                    MessageBox.Show("Phiếu mượn này đã được hoàn trả trước đó!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                selected.ActualReturnDate = DateTime.Today; // Gán ngày trả là ngày hiện tại
                chkIsReturned.Checked = true;
                dtpActualReturnDate.Value = DateTime.Today;

                _bindingSource.ResetCurrentItem();
                ApplyFilterAndSearch();
                MessageBox.Show(string.Format("Đã xác nhận trả thiết bị cho phiếu mượn [{0}]!", selected.CheckoutId), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputField();
        }
        private void ClearInputField()
        {
            txtCheckoutId.Clear();
            txtStudentId.Clear();
            txtStudentName.Clear();
            cboEquipment.SelectedIndex = 0;
            numQuantity.Value = 1;
            dtpCheckoutDate.Value = DateTime.Today;
            dtpDueDate.Value = DateTime.Today.AddDays(7);
            chkIsReturned.Checked = false;
            dtpActualReturnDate.Value = DateTime.Today;

            txtCheckoutId.ReadOnly = false;
            epCheckout.Clear();
            dgvCheckouts.ClearSelection();
            txtCheckoutId.Focus();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) => ApplyFilterAndSearch();

        private void cboFilterStatus_SelectedIndexChanged(object sender, EventArgs e) => ApplyFilterAndSearch();
        private void ApplyFilterAndSearch()
        {
            if (_allCheckouts == null) return; // An toàn chống lỗi null reference

            string keyword = txtSearch.Text.Trim().ToLower();
            string selectedStatus = cboFilterStatus.SelectedItem != null ? cboFilterStatus.SelectedItem.ToString() : "Tất cả";

            var filteredList = _allCheckouts.Where(item =>
            {
                // Tìm kiếm theo Mã sinh viên hoặc Tên thiết bị
                bool matchKeyword = string.IsNullOrEmpty(keyword) ||
                                   item.StudentId.ToLower().Contains(keyword) ||
                                   item.EquipmentName.ToLower().Contains(keyword);

                // Lọc theo Tình trạng
                bool matchStatus = selectedStatus == "Tất cả" || item.Status == selectedStatus;

                return matchKeyword && matchStatus;
            }).ToList();

            _bindingSource.DataSource = new BindingList<EquipmentCheckout>(filteredList);

            // Cập nhật thông số thống kê lên StatusStrip
            int totalCount = filteredList.Count;
            int overdueCount = filteredList.Count(x => x.Status == "Quá hạn");

            lblTotalCount.Text = string.Format("Tổng số phiếu đang hiển thị: {0} / {1}", totalCount, _allCheckouts.Count);
            lblOverdueCount.Text = string.Format("Số phiếu quá hạn: {0}", overdueCount);
        }

        private void mnuExportCsv_Click(object sender, EventArgs e)
        {
            var visibleList = (_bindingSource.DataSource as BindingList<EquipmentCheckout>)?.ToList();

            if (visibleList == null || visibleList.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu phiếu mượn nào để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "Xuất danh sách mượn trả thiết bị ra CSV";
                sfd.Filter = "File CSV (*.csv)|*.csv";
                sfd.FileName = string.Format("LabCheckout_{0:yyyyMMdd_HHmmss}.csv", DateTime.Now);

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        StringBuilder sb = new StringBuilder();
                        // Tiêu đề cột chuẩn CSV
                        sb.AppendLine("MaPhieu,MaSinhVien,HoTenSinhVien,ThietBi,SoLuong,NgayMuon,HanTra,NgayTraThucTe,TinhTrang");

                        foreach (var item in visibleList)
                        {
                            string returnDateStr = item.ActualReturnDate.HasValue ? item.ActualReturnDate.Value.ToString("dd/MM/yyyy") : "";

                            sb.AppendLine(string.Format("\"{0}\",\"{1}\",\"{2}\",\"{3}\",{4},\"{5:dd/MM/yyyy}\",\"{6:dd/MM/yyyy}\",\"{7}\",\"{8}\"",
                                item.CheckoutId,
                                item.StudentId,
                                item.StudentName,
                                item.EquipmentName,
                                item.Quantity,
                                item.CheckoutDate,
                                item.DueDate,
                                returnDateStr,
                                item.Status));
                        }

                        // Ghi file với mã hóa UTF-8
                        System.IO.File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                        MessageBox.Show("Xuất file CSV thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi trong quá trình xuất file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
