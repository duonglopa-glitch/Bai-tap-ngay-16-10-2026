namespace FormRepairTracker
{
    partial class FormRepairTracker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnsMain = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExportCsv = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.stsMain = new System.Windows.Forms.StatusStrip();
            this.lblStatusCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblPendingCostSum = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grpOrderInfo = new System.Windows.Forms.GroupBox();
            this.btnClearImage = new System.Windows.Forms.Button();
            this.btnBrowseImage = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.picDeviceImage = new System.Windows.Forms.PictureBox();
            this.numEstimatedCost = new System.Windows.Forms.NumericUpDown();
            this.dtpReceivedDate = new System.Windows.Forms.DateTimePicker();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.cboDeviceType = new System.Windows.Forms.ComboBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtIssueDescription = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.dgvRepairOrders = new System.Windows.Forms.DataGridView();
            this.cboFilterStatus = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.epRepair = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1.SuspendLayout();
            this.stsMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpOrderInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDeviceImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEstimatedCost)).BeginInit();
            this.grpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepairOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epRepair)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsMain});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1548, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnsMain
            // 
            this.mnsMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExportCsv,
            this.mnuExit});
            this.mnsMain.Name = "mnsMain";
            this.mnsMain.Size = new System.Drawing.Size(60, 24);
            this.mnsMain.Text = "Menu";
            // 
            // mnuExportCsv
            // 
            this.mnuExportCsv.Name = "mnuExportCsv";
            this.mnuExportCsv.Size = new System.Drawing.Size(224, 26);
            this.mnuExportCsv.Text = "Xuất File CSV";
            this.mnuExportCsv.Click += new System.EventHandler(this.mnuExportCsv_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(224, 26);
            this.mnuExit.Text = "Thoát";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // stsMain
            // 
            this.stsMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusCount,
            this.lblPendingCostSum});
            this.stsMain.Location = new System.Drawing.Point(0, 677);
            this.stsMain.Name = "stsMain";
            this.stsMain.Size = new System.Drawing.Size(1548, 26);
            this.stsMain.TabIndex = 1;
            this.stsMain.Text = "statusStrip1";
            // 
            // lblStatusCount
            // 
            this.lblStatusCount.Name = "lblStatusCount";
            this.lblStatusCount.Size = new System.Drawing.Size(150, 20);
            this.lblStatusCount.Text = "Số đơn đang hiển thị:";
            // 
            // lblPendingCostSum
            // 
            this.lblPendingCostSum.Name = "lblPendingCostSum";
            this.lblPendingCostSum.Size = new System.Drawing.Size(219, 20);
            this.lblPendingCostSum.Text = "Tổng chi phí đơn chưa hoàn tất:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.grpOrderInfo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.grpFilter, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1548, 649);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // grpOrderInfo
            // 
            this.grpOrderInfo.Controls.Add(this.btnClearImage);
            this.grpOrderInfo.Controls.Add(this.btnBrowseImage);
            this.grpOrderInfo.Controls.Add(this.btnClear);
            this.grpOrderInfo.Controls.Add(this.btnDelete);
            this.grpOrderInfo.Controls.Add(this.btnUpdate);
            this.grpOrderInfo.Controls.Add(this.btnAdd);
            this.grpOrderInfo.Controls.Add(this.picDeviceImage);
            this.grpOrderInfo.Controls.Add(this.numEstimatedCost);
            this.grpOrderInfo.Controls.Add(this.dtpReceivedDate);
            this.grpOrderInfo.Controls.Add(this.cboStatus);
            this.grpOrderInfo.Controls.Add(this.cboDeviceType);
            this.grpOrderInfo.Controls.Add(this.txtPhoneNumber);
            this.grpOrderInfo.Controls.Add(this.txtIssueDescription);
            this.grpOrderInfo.Controls.Add(this.txtCustomerName);
            this.grpOrderInfo.Controls.Add(this.txtOrderId);
            this.grpOrderInfo.Controls.Add(this.label9);
            this.grpOrderInfo.Controls.Add(this.label6);
            this.grpOrderInfo.Controls.Add(this.label7);
            this.grpOrderInfo.Controls.Add(this.label8);
            this.grpOrderInfo.Controls.Add(this.label4);
            this.grpOrderInfo.Controls.Add(this.label3);
            this.grpOrderInfo.Controls.Add(this.label2);
            this.grpOrderInfo.Controls.Add(this.label1);
            this.grpOrderInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpOrderInfo.Location = new System.Drawing.Point(3, 3);
            this.grpOrderInfo.Name = "grpOrderInfo";
            this.grpOrderInfo.Size = new System.Drawing.Size(1542, 308);
            this.grpOrderInfo.TabIndex = 0;
            this.grpOrderInfo.TabStop = false;
            this.grpOrderInfo.Text = "Thông tin đơn đăng ký sửa chữa";
            // 
            // btnClearImage
            // 
            this.btnClearImage.Location = new System.Drawing.Point(948, 223);
            this.btnClearImage.Name = "btnClearImage";
            this.btnClearImage.Size = new System.Drawing.Size(114, 35);
            this.btnClearImage.TabIndex = 23;
            this.btnClearImage.Text = "Xóa ảnh";
            this.btnClearImage.UseVisualStyleBackColor = true;
            this.btnClearImage.Click += new System.EventHandler(this.btnClearImage_Click);
            // 
            // btnBrowseImage
            // 
            this.btnBrowseImage.Location = new System.Drawing.Point(948, 170);
            this.btnBrowseImage.Name = "btnBrowseImage";
            this.btnBrowseImage.Size = new System.Drawing.Size(114, 35);
            this.btnBrowseImage.TabIndex = 22;
            this.btnBrowseImage.Text = "Chọn ảnh";
            this.btnBrowseImage.UseVisualStyleBackColor = true;
            this.btnBrowseImage.Click += new System.EventHandler(this.btnBrowseImage_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(515, 251);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(114, 35);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Làm mới";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(366, 251);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(114, 35);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(220, 251);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(114, 35);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(80, 251);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(114, 35);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // picDeviceImage
            // 
            this.picDeviceImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDeviceImage.Location = new System.Drawing.Point(795, 143);
            this.picDeviceImage.Name = "picDeviceImage";
            this.picDeviceImage.Size = new System.Drawing.Size(127, 147);
            this.picDeviceImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDeviceImage.TabIndex = 17;
            this.picDeviceImage.TabStop = false;
            // 
            // numEstimatedCost
            // 
            this.numEstimatedCost.Location = new System.Drawing.Point(843, 68);
            this.numEstimatedCost.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numEstimatedCost.Name = "numEstimatedCost";
            this.numEstimatedCost.Size = new System.Drawing.Size(209, 22);
            this.numEstimatedCost.TabIndex = 16;
            this.numEstimatedCost.ThousandsSeparator = true;
            // 
            // dtpReceivedDate
            // 
            this.dtpReceivedDate.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpReceivedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReceivedDate.Location = new System.Drawing.Point(843, 37);
            this.dtpReceivedDate.Name = "dtpReceivedDate";
            this.dtpReceivedDate.Size = new System.Drawing.Size(209, 22);
            this.dtpReceivedDate.TabIndex = 15;
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(843, 98);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(209, 24);
            this.cboStatus.TabIndex = 14;
            // 
            // cboDeviceType
            // 
            this.cboDeviceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeviceType.FormattingEnabled = true;
            this.cboDeviceType.Location = new System.Drawing.Point(463, 67);
            this.cboDeviceType.Name = "cboDeviceType";
            this.cboDeviceType.Size = new System.Drawing.Size(209, 24);
            this.cboDeviceType.TabIndex = 13;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(463, 37);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(209, 22);
            this.txtPhoneNumber.TabIndex = 12;
            // 
            // txtIssueDescription
            // 
            this.txtIssueDescription.Location = new System.Drawing.Point(140, 140);
            this.txtIssueDescription.Multiline = true;
            this.txtIssueDescription.Name = "txtIssueDescription";
            this.txtIssueDescription.Size = new System.Drawing.Size(311, 84);
            this.txtIssueDescription.TabIndex = 11;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(140, 69);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(209, 22);
            this.txtCustomerName.TabIndex = 10;
            // 
            // txtOrderId
            // 
            this.txtOrderId.Location = new System.Drawing.Point(140, 37);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(209, 22);
            this.txtOrderId.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Mô tả lỗi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(725, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Trạng thái:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(725, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Chi phí dự kiến:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(725, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Ngày tiếp nhận:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(378, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Loại T.Bị:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "SĐT KH:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Khách hàng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đơn:";
            // 
            // grpFilter
            // 
            this.grpFilter.Controls.Add(this.dgvRepairOrders);
            this.grpFilter.Controls.Add(this.cboFilterStatus);
            this.grpFilter.Controls.Add(this.txtSearch);
            this.grpFilter.Controls.Add(this.label10);
            this.grpFilter.Controls.Add(this.label5);
            this.grpFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpFilter.Location = new System.Drawing.Point(3, 317);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(1542, 308);
            this.grpFilter.TabIndex = 1;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "Tìm kiếm & Lọc tiến độ";
            // 
            // dgvRepairOrders
            // 
            this.dgvRepairOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepairOrders.Location = new System.Drawing.Point(6, 59);
            this.dgvRepairOrders.Name = "dgvRepairOrders";
            this.dgvRepairOrders.ReadOnly = true;
            this.dgvRepairOrders.RowHeadersWidth = 51;
            this.dgvRepairOrders.RowTemplate.Height = 24;
            this.dgvRepairOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRepairOrders.Size = new System.Drawing.Size(1527, 270);
            this.dgvRepairOrders.TabIndex = 4;
            // 
            // cboFilterStatus
            // 
            this.cboFilterStatus.FormattingEnabled = true;
            this.cboFilterStatus.Location = new System.Drawing.Point(777, 29);
            this.cboFilterStatus.Name = "cboFilterStatus";
            this.cboFilterStatus.Size = new System.Drawing.Size(232, 24);
            this.cboFilterStatus.TabIndex = 3;
            this.cboFilterStatus.SelectedIndexChanged += new System.EventHandler(this.cboFilterStatus_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(229, 31);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(334, 22);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(644, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Trạng thái đơn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tìm (Mã đơn / Tên KH / SĐT):";
            // 
            // epRepair
            // 
            this.epRepair.ContainerControl = this;
            // 
            // FormRepairTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1548, 703);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.stsMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormRepairTracker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Repair Service Tracker";
            this.Load += new System.EventHandler(this.FormRepairTracker_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.stsMain.ResumeLayout(false);
            this.stsMain.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grpOrderInfo.ResumeLayout(false);
            this.grpOrderInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDeviceImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEstimatedCost)).EndInit();
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepairOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epRepair)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnsMain;
        private System.Windows.Forms.ToolStripMenuItem mnuExportCsv;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.StatusStrip stsMain;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusCount;
        private System.Windows.Forms.ToolStripStatusLabel lblPendingCostSum;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox grpOrderInfo;
        private System.Windows.Forms.ComboBox cboDeviceType;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtIssueDescription;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numEstimatedCost;
        private System.Windows.Forms.DateTimePicker dtpReceivedDate;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.PictureBox picDeviceImage;
        private System.Windows.Forms.Button btnClearImage;
        private System.Windows.Forms.Button btnBrowseImage;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.ComboBox cboFilterStatus;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvRepairOrders;
        private System.Windows.Forms.ErrorProvider epRepair;
    }
}

