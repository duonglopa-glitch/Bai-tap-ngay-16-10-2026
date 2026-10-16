using ClinicManagerApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormClinicAppointment
{
    public partial class FormClinicAppointment : Form
    {
        private BindingList<Appointment> _allAppointments;
        private BindingSource _bindingSource;
        public FormClinicAppointment()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }
        private void ClearInputFields()
        {
            txtAppointmentId.Clear();
            txtPatientName.Clear();
            txtPhoneNumber.Clear();
            dtpAppointmentDate.Value = DateTime.Now.AddHours(1);
            cboDoctor.SelectedIndex = 0;
            txtReason.Clear();
            cboStatus.SelectedIndex = 0;

            txtAppointmentId.ReadOnly = false;
            epClinic.Clear();
            dgvAppointments.ClearSelection();
            txtAppointmentId.Focus();
        }

        private void FormClinicAppointment_Load(object sender, EventArgs e)
        {
            InitDropdownData();
            InitMockData();
            ConfigureDataGridView();
            BindControlsToBindingSource();
            ApplyFilterAndSearch();
        }
        private void InitDropdownData()
        {
            // Danh sách Bác sĩ
            cboDoctor.Items.Clear();
            cboDoctor.Items.AddRange(new object[] {
                "BS. Nguyễn Văn A (Nội khoa)",
                "BS. Trần Thị B (Nhi khoa)",
                "BS. Lê Hoàng C (Tim mạch)",
                "BS. Phạm Minh D (Răng Hàm Mặt)"
            });
            cboDoctor.SelectedIndex = 0;

            // Danh sách Trạng thái nhập liệu
            cboStatus.Items.Clear();
            cboStatus.Items.AddRange(new object[] { "Chờ khám", "Đang khám", "Hoàn tất", "Đã hủy" });
            cboStatus.SelectedIndex = 0;

            // Danh sách Trạng thái lọc
            cboFilterStatus.Items.Clear();
            cboFilterStatus.Items.Add("Tất cả");
            cboFilterStatus.Items.AddRange(new object[] { "Chờ khám", "Đang khám", "Hoàn tất", "Đã hủy" });
            cboFilterStatus.SelectedIndex = 0;

            dtpAppointmentDate.Value = DateTime.Now.AddHours(1);
            dtpFilterDate.Value = DateTime.Today;
        }

        private void InitMockData()
        {
            _allAppointments = new BindingList<Appointment>
            {
                new Appointment("LH001", "Nguyễn Văn Hùng", "0912345678", DateTime.Now.AddDays(1), "BS. Nguyễn Văn A (Nội khoa)", "Tái khám định kỳ", "Chờ khám"),
                new Appointment("LH002", "Trần Thị Mai", "0987654321", DateTime.Now.AddDays(2), "BS. Trần Thị B (Nhi khoa)", "Sốt cao kéo dài", "Chờ khám"),
                new Appointment("LH003", "Lê Minh Tuấn", "0905112233", DateTime.Now.AddHours(2), "BS. Lê Hoàng C (Tim mạch)", "Đau tức ngực", "Đang khám")
            };

            _bindingSource = new BindingSource
            {
                DataSource = _allAppointments
            };

            dgvAppointments.DataSource = _bindingSource;
        }

        private void ConfigureDataGridView()
        {
            dgvAppointments.AutoGenerateColumns = false;
            dgvAppointments.Columns.Clear();

            dgvAppointments.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "AppointmentId", HeaderText = "Mã Lịch Hẹn", Width = 110 });
            dgvAppointments.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "PatientName", HeaderText = "Họ Tên Bệnh Nhân", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvAppointments.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "PhoneNumber", HeaderText = "Số Điện Thoại", Width = 120 });
            dgvAppointments.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "AppointmentDate", HeaderText = "Ngày Giờ Hẹn", Width = 140, DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy HH:mm" } });
            dgvAppointments.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Doctor", HeaderText = "Bác Sĩ Trực", Width = 180 });
            dgvAppointments.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Reason", HeaderText = "Lý Do Khám", Width = 150 });
            dgvAppointments.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Status", HeaderText = "Trạng Thái", Width = 110 });
        }

        private void BindControlsToBindingSource()
        {
            txtAppointmentId.DataBindings.Add("Text", _bindingSource, "AppointmentId", true, DataSourceUpdateMode.Never);
            txtPatientName.DataBindings.Add("Text", _bindingSource, "PhoneNumber", true, DataSourceUpdateMode.Never);

            // Xử lý sự kiện chọn dòng trên DataGridView để nạp chính xác dữ liệu lên Controls
            _bindingSource.CurrentChanged += (s, e) => LoadCurrentItemToInputFields();
        }

        private void LoadCurrentItemToInputFields()
        {
            if (_bindingSource.Current is Appointment app)
            {
                txtAppointmentId.Text = app.AppointmentId;
                txtPatientName.Text = app.PatientName;
                txtPhoneNumber.Text = app.PhoneNumber;
                dtpAppointmentDate.Value = app.AppointmentDate < dtpAppointmentDate.MinDate ? DateTime.Now : app.AppointmentDate;
                cboDoctor.SelectedItem = app.Doctor;
                txtReason.Text = app.Reason;
                cboStatus.SelectedItem = app.Status;

                txtAppointmentId.ReadOnly = true; // Khóa Mã khi đang chọn từ danh sách
            }
        }
        private bool ValidateInput(bool isNew)
        {
            epClinic.Clear();
            bool isValid = true;

            // 1. Kiểm tra Mã lịch hẹn
            if (string.IsNullOrWhiteSpace(txtAppointmentId.Text))
            {
                epClinic.SetError(txtAppointmentId, "Mã lịch hẹn không được để trống!");
                isValid = false;
            }
            else if (isNew && _allAppointments.Any(a => a.AppointmentId.Equals(txtAppointmentId.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                epClinic.SetError(txtAppointmentId, "Mã lịch hẹn đã tồn tại trên hệ thống!");
                isValid = false;
            }

            // 2. Kiểm tra Họ tên bệnh nhân
            if (string.IsNullOrWhiteSpace(txtPatientName.Text))
            {
                epClinic.SetError(txtPatientName, "Họ tên bệnh nhân không được để trống!");
                isValid = false;
            }

            // 3. Kiểm tra Số điện thoại (Định dạng 10-11 chữ số Việt Nam)
            string phonePattern = @"^(0[3|5|7|8|9])+([0-9]{8})$";
            if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text) || !Regex.IsMatch(txtPhoneNumber.Text.Trim(), phonePattern))
            {
                epClinic.SetError(txtPhoneNumber, "Số điện thoại không hợp lệ (Phải là 10 số bắt đầu bằng 03, 05, 07, 08, 09)!");
                isValid = false;
            }

            // 4. Kiểm tra Ngày hẹn không được nằm trong quá khứ
            if (isNew && dtpAppointmentDate.Value < DateTime.Now.AddMinutes(-5))
            {
                epClinic.SetError(dtpAppointmentDate, "Thời gian hẹn không được nằm trong quá khứ!");
                isValid = false;
            }

            // 5. Kiểm tra Lý do khám
            if (string.IsNullOrWhiteSpace(txtReason.Text))
            {
                epClinic.SetError(txtReason, "Lý do khám không được để trống!");
                isValid = false;
            }

            return isValid;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(isNew: true)) return;

            Appointment newApp = new Appointment(
                txtAppointmentId.Text.Trim(),
                txtPatientName.Text.Trim(),
                txtPhoneNumber.Text.Trim(),
                dtpAppointmentDate.Value,
                cboDoctor.SelectedItem.ToString(),
                txtReason.Text.Trim(),
                cboStatus.SelectedItem.ToString()
            );

            _allAppointments.Add(newApp);
            ApplyFilterAndSearch();
            MessageBox.Show("Thêm lịch hẹn mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearInputFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_bindingSource.Current == null)
            {
                MessageBox.Show("Vui lòng chọn một lịch hẹn từ danh sách để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInput(isNew: false)) return;

            Appointment selectedApp = _allAppointments.FirstOrDefault(a => a.AppointmentId == txtAppointmentId.Text.Trim());
            if (selectedApp != null)
            {
                selectedApp.PatientName = txtPatientName.Text.Trim();
                selectedApp.PhoneNumber = txtPhoneNumber.Text.Trim();
                selectedApp.AppointmentDate = dtpAppointmentDate.Value;
                selectedApp.Doctor = cboDoctor.SelectedItem.ToString();
                selectedApp.Reason = txtReason.Text.Trim();
                selectedApp.Status = cboStatus.SelectedItem.ToString();

                _bindingSource.ResetCurrentItem();
                ApplyFilterAndSearch();
                MessageBox.Show("Cập nhật thông tin lịch hẹn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_bindingSource.Current is Appointment selectedApp)
            {
                DialogResult dr = MessageBox.Show(
                    string.Format("Bạn có chắc chắn muốn xóa lịch hẹn [{0}] của bệnh nhân [{1}]?", selectedApp.AppointmentId, selectedApp.PatientName),
                    "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    _allAppointments.Remove(selectedApp);
                    ApplyFilterAndSearch();
                    ClearInputFields();
                    MessageBox.Show("Xóa lịch hẹn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) => ApplyFilterAndSearch();

        private void cboFilterStatus_SelectedIndexChanged(object sender, EventArgs e) => ApplyFilterAndSearch();

        private void chkFilterDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpFilterDate.Enabled = chkFilterDate.Checked;
            ApplyFilterAndSearch();
        }

        private void dtpFilterDate_ValueChanged(object sender, EventArgs e)
        {
            if (chkFilterDate.Checked) ApplyFilterAndSearch();
        }
        private void ApplyFilterAndSearch()
        {
            if (_allAppointments == null) return;
            string keyword = txtSearch.Text.Trim().ToLower();
            string selectedStatus = cboFilterStatus.SelectedItem != null ? cboFilterStatus.SelectedItem.ToString() : "Tất cả";
            bool filterByDate = chkFilterDate.Checked;
            DateTime targetDate = dtpFilterDate.Value.Date;

            var filteredList = _allAppointments.Where(app =>
            {
                // Tìm theo Tên hoặc Số điện thoại
                bool matchKeyword = string.IsNullOrEmpty(keyword) ||
                                   app.PatientName.ToLower().Contains(keyword) ||
                                   app.PhoneNumber.Contains(keyword);

                // Lọc theo Trạng thái
                bool matchStatus = selectedStatus == "Tất cả" || app.Status == selectedStatus;

                // Lọc theo Ngày hẹn
                bool matchDate = !filterByDate || app.AppointmentDate.Date == targetDate;

                return matchKeyword && matchStatus && matchDate;
            }).ToList();

            _bindingSource.DataSource = new BindingList<Appointment>(filteredList);

            // Cập nhật đếm số lượng bản ghi hiển thị trên StatusStrip
            lblStatusCount.Text = string.Format("Tổng số lịch hẹn đang hiển thị: {0} / {1}", filteredList.Count, _allAppointments.Count);
        }

        private void mnuExportCsv_Click(object sender, EventArgs e)
        {
            var visibleList = (_bindingSource.DataSource as BindingList<Appointment>)?.ToList();

            if (visibleList == null || visibleList.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu lịch hẹn nào để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "Xuất danh sách lịch hẹn ra CSV";
                sfd.Filter = "File CSV (*.csv)|*.csv";
                sfd.FileName = string.Format("LichHen_Clinic_{0:yyyyMMdd_HHmmss}.csv", DateTime.Now);

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine("MaLichHen,HoTenBenhNhan,SoDienThoai,NgayGioHen,BacSi,LyDoKham,TrangThai");

                        foreach (var item in visibleList)
                        {
                            sb.AppendLine(string.Format("\"{0}\",\"{1}\",\"{2}\",\"{3:dd/MM/yyyy HH:mm}\",\"{4}\",\"{5}\",\"{6}\"",
                                item.AppointmentId,
                                item.PatientName,
                                item.PhoneNumber,
                                item.AppointmentDate,
                                item.Doctor,
                                item.Reason,
                                item.Status));
                        }

                        System.IO.File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                        MessageBox.Show("Xuất file CSV thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi trong quá trình ghi file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
