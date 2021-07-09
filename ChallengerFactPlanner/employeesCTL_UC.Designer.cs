
namespace ChallengerFactPlanner
{
    partial class employeesCTL_UC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSp = new System.Windows.Forms.TextBox();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.challengerDBDataSet = new ChallengerFactPlanner.ChallengerDBDataSet();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.ndLeave = new System.Windows.Forms.DateTimePicker();
            this.dtApplyAt = new System.Windows.Forms.DateTimePicker();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.cboWSch = new System.Windows.Forms.ComboBox();
            this.chkPL = new System.Windows.Forms.CheckedListBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.stLeave = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stLeaveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ndLeaveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.workSchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSchCTL = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.employeesTableAdapter = new ChallengerFactPlanner.ChallengerDBDataSetTableAdapters.EmployeesTableAdapter();
            this.panelCTL = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.challengerDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelCTL.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Spetialty :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Leave Period :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Assigned Post(s) :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Work Schedule :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Status :";
            // 
            // txtSp
            // 
            this.txtSp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "Specialty", true));
            this.txtSp.Location = new System.Drawing.Point(26, 100);
            this.txtSp.Name = "txtSp";
            this.txtSp.Size = new System.Drawing.Size(261, 25);
            this.txtSp.TabIndex = 7;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.challengerDBDataSet;
            // 
            // challengerDBDataSet
            // 
            this.challengerDBDataSet.DataSetName = "ChallengerDBDataSet";
            this.challengerDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtFullname
            // 
            this.txtFullname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "FullName", true));
            this.txtFullname.Location = new System.Drawing.Point(26, 49);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(261, 25);
            this.txtFullname.TabIndex = 8;
            this.txtFullname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ndLeave
            // 
            this.ndLeave.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employeesBindingSource, "NdLeave", true));
            this.ndLeave.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ndLeave.Location = new System.Drawing.Point(174, 151);
            this.ndLeave.Name = "ndLeave";
            this.ndLeave.Size = new System.Drawing.Size(113, 25);
            this.ndLeave.TabIndex = 9;
            // 
            // dtApplyAt
            // 
            this.dtApplyAt.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employeesBindingSource, "ApplyAt", true));
            this.dtApplyAt.Enabled = false;
            this.dtApplyAt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtApplyAt.Location = new System.Drawing.Point(26, 428);
            this.dtApplyAt.Name = "dtApplyAt";
            this.dtApplyAt.Size = new System.Drawing.Size(92, 25);
            this.dtApplyAt.TabIndex = 10;
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.employeesBindingSource, "Status", true));
            this.chkStatus.Location = new System.Drawing.Point(26, 205);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(49, 23);
            this.chkStatus.TabIndex = 11;
            this.chkStatus.Text = "???";
            this.chkStatus.UseVisualStyleBackColor = true;
            this.chkStatus.CheckedChanged += new System.EventHandler(this.chkStatus_CheckedChanged);
            // 
            // cboWSch
            // 
            this.cboWSch.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.employeesBindingSource, "WorkSch", true));
            this.cboWSch.FormattingEnabled = true;
            this.cboWSch.Location = new System.Drawing.Point(134, 231);
            this.cboWSch.Name = "cboWSch";
            this.cboWSch.Size = new System.Drawing.Size(153, 25);
            this.cboWSch.TabIndex = 12;
            // 
            // chkPL
            // 
            this.chkPL.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.employeesBindingSource, "AssignedPost", true));
            this.chkPL.FormattingEnabled = true;
            this.chkPL.Location = new System.Drawing.Point(26, 304);
            this.chkPL.Name = "chkPL";
            this.chkPL.Size = new System.Drawing.Size(261, 84);
            this.chkPL.TabIndex = 13;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(26, 399);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(264, 23);
            this.checkBox2.TabIndex = 14;
            this.checkBox2.Text = "Check apply changes at a specific date";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // stLeave
            // 
            this.stLeave.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employeesBindingSource, "StLeave", true));
            this.stLeave.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.stLeave.Location = new System.Drawing.Point(26, 151);
            this.stLeave.Name = "stLeave";
            this.stLeave.Size = new System.Drawing.Size(111, 25);
            this.stLeave.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(143, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 23);
            this.label8.TabIndex = 16;
            this.label8.Text = "→";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullNameDataGridViewTextBoxColumn,
            this.specialtyDataGridViewTextBoxColumn,
            this.stLeaveDataGridViewTextBoxColumn,
            this.ndLeaveDataGridViewTextBoxColumn,
            this.statusDataGridViewCheckBoxColumn,
            this.workSchDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(323, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(721, 339);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView1_KeyPress);
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // specialtyDataGridViewTextBoxColumn
            // 
            this.specialtyDataGridViewTextBoxColumn.DataPropertyName = "Specialty";
            this.specialtyDataGridViewTextBoxColumn.HeaderText = "Specialty";
            this.specialtyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.specialtyDataGridViewTextBoxColumn.Name = "specialtyDataGridViewTextBoxColumn";
            this.specialtyDataGridViewTextBoxColumn.Width = 125;
            // 
            // stLeaveDataGridViewTextBoxColumn
            // 
            this.stLeaveDataGridViewTextBoxColumn.DataPropertyName = "StLeave";
            this.stLeaveDataGridViewTextBoxColumn.HeaderText = "Start Leave";
            this.stLeaveDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stLeaveDataGridViewTextBoxColumn.Name = "stLeaveDataGridViewTextBoxColumn";
            this.stLeaveDataGridViewTextBoxColumn.Width = 110;
            // 
            // ndLeaveDataGridViewTextBoxColumn
            // 
            this.ndLeaveDataGridViewTextBoxColumn.DataPropertyName = "NdLeave";
            this.ndLeaveDataGridViewTextBoxColumn.HeaderText = "End Leave";
            this.ndLeaveDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ndLeaveDataGridViewTextBoxColumn.Name = "ndLeaveDataGridViewTextBoxColumn";
            this.ndLeaveDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewCheckBoxColumn
            // 
            this.statusDataGridViewCheckBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewCheckBoxColumn.HeaderText = "Status";
            this.statusDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewCheckBoxColumn.Name = "statusDataGridViewCheckBoxColumn";
            this.statusDataGridViewCheckBoxColumn.Width = 60;
            // 
            // workSchDataGridViewTextBoxColumn
            // 
            this.workSchDataGridViewTextBoxColumn.DataPropertyName = "WorkSch";
            this.workSchDataGridViewTextBoxColumn.HeaderText = "Work Schedule";
            this.workSchDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.workSchDataGridViewTextBoxColumn.Name = "workSchDataGridViewTextBoxColumn";
            this.workSchDataGridViewTextBoxColumn.Width = 150;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Location = new System.Drawing.Point(877, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 53);
            this.button1.TabIndex = 22;
            this.button1.Text = "&Porcess Employees Post Distribution";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSchCTL
            // 
            this.btnSchCTL.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSchCTL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSchCTL.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchCTL.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSchCTL.Location = new System.Drawing.Point(701, 394);
            this.btnSchCTL.Name = "btnSchCTL";
            this.btnSchCTL.Size = new System.Drawing.Size(170, 53);
            this.btnSchCTL.TabIndex = 21;
            this.btnSchCTL.Text = "&Import Employee List From Excel File";
            this.btnSchCTL.UseVisualStyleBackColor = true;
            this.btnSchCTL.Click += new System.EventHandler(this.btnSchCTL_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(323, 394);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 53);
            this.btnNew.TabIndex = 29;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(404, 394);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 53);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(494, 394);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 53);
            this.btnEdit.TabIndex = 27;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(575, 394);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 53);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // panelCTL
            // 
            this.panelCTL.Controls.Add(this.label8);
            this.panelCTL.Controls.Add(this.stLeave);
            this.panelCTL.Controls.Add(this.checkBox2);
            this.panelCTL.Controls.Add(this.chkPL);
            this.panelCTL.Controls.Add(this.cboWSch);
            this.panelCTL.Controls.Add(this.chkStatus);
            this.panelCTL.Controls.Add(this.dtApplyAt);
            this.panelCTL.Controls.Add(this.ndLeave);
            this.panelCTL.Controls.Add(this.txtFullname);
            this.panelCTL.Controls.Add(this.txtSp);
            this.panelCTL.Controls.Add(this.label6);
            this.panelCTL.Controls.Add(this.label5);
            this.panelCTL.Controls.Add(this.label4);
            this.panelCTL.Controls.Add(this.label3);
            this.panelCTL.Controls.Add(this.label2);
            this.panelCTL.Controls.Add(this.label1);
            this.panelCTL.Location = new System.Drawing.Point(0, 0);
            this.panelCTL.Name = "panelCTL";
            this.panelCTL.Size = new System.Drawing.Size(308, 479);
            this.panelCTL.TabIndex = 30;
            // 
            // employeesCTL_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelCTL);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSchCTL);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "employeesCTL_UC";
            this.Size = new System.Drawing.Size(1062, 480);
            this.Load += new System.EventHandler(this.employeesCTL_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.challengerDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelCTL.ResumeLayout(false);
            this.panelCTL.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSp;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.DateTimePicker ndLeave;
        private System.Windows.Forms.DateTimePicker dtApplyAt;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.ComboBox cboWSch;
        private System.Windows.Forms.CheckedListBox chkPL;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.DateTimePicker stLeave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSchCTL;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private ChallengerDBDataSet challengerDBDataSet;
        private ChallengerDBDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stLeaveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ndLeaveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workSchDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panelCTL;
    }
}
