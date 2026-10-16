namespace FormEquipmentCheckout
{
    partial class ClearInputFields
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
            this.mnsMain = new System.Windows.Forms.MenuStrip();
            this.mnuExportCsv = new System.Windows.Forms.ToolStripMenuItem();
            this.stsMain = new System.Windows.Forms.StatusStrip();
            this.lblTotalCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblOverdueCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.chkIsReturned = new System.Windows.Forms.CheckBox();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.dtpActualReturnDate = new System.Windows.Forms.DateTimePicker();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckoutDate = new System.Windows.Forms.DateTimePicker();
            this.cboEquipment = new System.Windows.Forms.ComboBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.txtCheckoutId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.dgvCheckouts = new System.Windows.Forms.DataGridView();
            this.cboFilterStatus = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.epCheckout = new System.Windows.Forms.ErrorProvider(this.components);
            this.mnsMain.SuspendLayout();
            this.stsMain.SuspendLayout();
            this.tblMain.SuspendLayout();
            this.grpInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.grpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckouts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCheckout)).BeginInit();
            this.SuspendLayout();
            // 
            // mnsMain
            // 
            this.mnsMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExportCsv});
            this.mnsMain.Location = new System.Drawing.Point(0, 0);
            this.mnsMain.Name = "mnsMain";
            this.mnsMain.Size = new System.Drawing.Size(1337, 28);
            this.mnsMain.TabIndex = 0;
            this.mnsMain.Text = "menuStrip1";
            // 
            // mnuExportCsv
            // 
            this.mnuExportCsv.Name = "mnuExportCsv";
            this.mnuExportCsv.Size = new System.Drawing.Size(110, 24);
            this.mnuExportCsv.Text = "Xuất File CSV";
            this.mnuExportCsv.Click += new System.EventHandler(this.mnuExportCsv_Click);
            // 
            // stsMain
            // 
            this.stsMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTotalCount,
            this.lblOverdueCount});
            this.stsMain.Location = new System.Drawing.Point(0, 647);
            this.stsMain.Name = "stsMain";
            this.stsMain.Size = new System.Drawing.Size(1337, 26);
            this.stsMain.TabIndex = 1;
            this.stsMain.Text = "statusStrip1";
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(106, 20);
            this.lblTotalCount.Text = "Tổng số phiếu:";
            // 
            // lblOverdueCount
            // 
            this.lblOverdueCount.Name = "lblOverdueCount";
            this.lblOverdueCount.Size = new System.Drawing.Size(127, 20);
            this.lblOverdueCount.Text = "Số phiếu quá hạn:";
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 1;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.Controls.Add(this.grpInput, 0, 0);
            this.tblMain.Controls.Add(this.grpFilter, 0, 1);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 28);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 3;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.Size = new System.Drawing.Size(1337, 619);
            this.tblMain.TabIndex = 2;
            // 
            // grpInput
            // 
            this.grpInput.Controls.Add(this.btnClear);
            this.grpInput.Controls.Add(this.btnReturn);
            this.grpInput.Controls.Add(this.btnDelete);
            this.grpInput.Controls.Add(this.btnUpdate);
            this.grpInput.Controls.Add(this.btnAdd);
            this.grpInput.Controls.Add(this.chkIsReturned);
            this.grpInput.Controls.Add(this.numQuantity);
            this.grpInput.Controls.Add(this.dtpActualReturnDate);
            this.grpInput.Controls.Add(this.dtpDueDate);
            this.grpInput.Controls.Add(this.dtpCheckoutDate);
            this.grpInput.Controls.Add(this.cboEquipment);
            this.grpInput.Controls.Add(this.txtStudentName);
            this.grpInput.Controls.Add(this.txtStudentId);
            this.grpInput.Controls.Add(this.txtCheckoutId);
            this.grpInput.Controls.Add(this.label7);
            this.grpInput.Controls.Add(this.label9);
            this.grpInput.Controls.Add(this.label4);
            this.grpInput.Controls.Add(this.label5);
            this.grpInput.Controls.Add(this.label6);
            this.grpInput.Controls.Add(this.label3);
            this.grpInput.Controls.Add(this.label2);
            this.grpInput.Controls.Add(this.label1);
            this.grpInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpInput.Location = new System.Drawing.Point(3, 3);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(1331, 293);
            this.grpInput.TabIndex = 0;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Thông tin phiếu mượn thiết bị";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(817, 202);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(149, 40);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "Làm mới ";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(643, 202);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(149, 40);
            this.btnReturn.TabIndex = 21;
            this.btnReturn.Text = "Xác nhận trả ";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(459, 202);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(149, 40);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Xóa ";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(264, 202);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(149, 40);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(84, 202);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(149, 40);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Thêm ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // chkIsReturned
            // 
            this.chkIsReturned.AutoSize = true;
            this.chkIsReturned.Location = new System.Drawing.Point(736, 98);
            this.chkIsReturned.Name = "chkIsReturned";
            this.chkIsReturned.Size = new System.Drawing.Size(64, 20);
            this.chkIsReturned.TabIndex = 17;
            this.chkIsReturned.Text = "Đã trả";
            this.chkIsReturned.UseVisualStyleBackColor = true;
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(828, 58);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(120, 22);
            this.numQuantity.TabIndex = 16;
            // 
            // dtpActualReturnDate
            // 
            this.dtpActualReturnDate.Location = new System.Drawing.Point(828, 136);
            this.dtpActualReturnDate.Name = "dtpActualReturnDate";
            this.dtpActualReturnDate.Size = new System.Drawing.Size(194, 22);
            this.dtpActualReturnDate.TabIndex = 15;
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Location = new System.Drawing.Point(497, 135);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(194, 22);
            this.dtpDueDate.TabIndex = 14;
            // 
            // dtpCheckoutDate
            // 
            this.dtpCheckoutDate.Location = new System.Drawing.Point(153, 136);
            this.dtpCheckoutDate.Name = "dtpCheckoutDate";
            this.dtpCheckoutDate.Size = new System.Drawing.Size(194, 22);
            this.dtpCheckoutDate.TabIndex = 13;
            // 
            // cboEquipment
            // 
            this.cboEquipment.FormattingEnabled = true;
            this.cboEquipment.Location = new System.Drawing.Point(153, 96);
            this.cboEquipment.Name = "cboEquipment";
            this.cboEquipment.Size = new System.Drawing.Size(194, 24);
            this.cboEquipment.TabIndex = 12;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(497, 96);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(194, 22);
            this.txtStudentName.TabIndex = 11;
            // 
            // txtStudentId
            // 
            this.txtStudentId.Location = new System.Drawing.Point(497, 52);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(194, 22);
            this.txtStudentId.TabIndex = 10;
            // 
            // txtCheckoutId
            // 
            this.txtCheckoutId.Location = new System.Drawing.Point(153, 55);
            this.txtCheckoutId.Name = "txtCheckoutId";
            this.txtCheckoutId.Size = new System.Drawing.Size(194, 22);
            this.txtCheckoutId.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(729, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Ngày trả TT:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(729, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "Số lượng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(407, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Hạn trả:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(407, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Họ tên SV:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(407, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Mã SV:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày mượn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thiết bị:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu:";
            // 
            // grpFilter
            // 
            this.grpFilter.Controls.Add(this.dgvCheckouts);
            this.grpFilter.Controls.Add(this.cboFilterStatus);
            this.grpFilter.Controls.Add(this.txtSearch);
            this.grpFilter.Controls.Add(this.label10);
            this.grpFilter.Controls.Add(this.label8);
            this.grpFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpFilter.Location = new System.Drawing.Point(3, 302);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(1331, 293);
            this.grpFilter.TabIndex = 1;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "Tìm kiếm & Lọc phiếu mượn";
            // 
            // dgvCheckouts
            // 
            this.dgvCheckouts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckouts.Location = new System.Drawing.Point(6, 58);
            this.dgvCheckouts.Name = "dgvCheckouts";
            this.dgvCheckouts.ReadOnly = true;
            this.dgvCheckouts.RowHeadersWidth = 51;
            this.dgvCheckouts.RowTemplate.Height = 24;
            this.dgvCheckouts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCheckouts.Size = new System.Drawing.Size(1325, 235);
            this.dgvCheckouts.TabIndex = 4;
            // 
            // cboFilterStatus
            // 
            this.cboFilterStatus.FormattingEnabled = true;
            this.cboFilterStatus.Location = new System.Drawing.Point(723, 28);
            this.cboFilterStatus.Name = "cboFilterStatus";
            this.cboFilterStatus.Size = new System.Drawing.Size(197, 24);
            this.cboFilterStatus.TabIndex = 3;
            this.cboFilterStatus.SelectedIndexChanged += new System.EventHandler(this.cboFilterStatus_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(213, 30);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(277, 22);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(606, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Tình trạng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tìm (Mã SV / Tên thiết bị):";
            // 
            // epCheckout
            // 
            this.epCheckout.ContainerControl = this;
            // 
            // ClearInputFields
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 673);
            this.Controls.Add(this.tblMain);
            this.Controls.Add(this.stsMain);
            this.Controls.Add(this.mnsMain);
            this.MainMenuStrip = this.mnsMain;
            this.Name = "ClearInputFields";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab Equipment Checkout Manager";
            this.Load += new System.EventHandler(this.ClearInputFields_Load);
            this.mnsMain.ResumeLayout(false);
            this.mnsMain.PerformLayout();
            this.stsMain.ResumeLayout(false);
            this.stsMain.PerformLayout();
            this.tblMain.ResumeLayout(false);
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckouts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCheckout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsMain;
        private System.Windows.Forms.ToolStripMenuItem mnuExportCsv;
        private System.Windows.Forms.StatusStrip stsMain;
        private System.Windows.Forms.ToolStripStatusLabel lblTotalCount;
        private System.Windows.Forms.ToolStripStatusLabel lblOverdueCount;
        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckBox chkIsReturned;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.DateTimePicker dtpActualReturnDate;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.DateTimePicker dtpCheckoutDate;
        private System.Windows.Forms.ComboBox cboEquipment;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.TextBox txtCheckoutId;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cboFilterStatus;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvCheckouts;
        private System.Windows.Forms.ErrorProvider epCheckout;
    }
}

