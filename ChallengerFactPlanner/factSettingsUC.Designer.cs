
namespace ChallengerFactPlanner
{
    partial class factSettingsUC
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
            this.lblCNC = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRef = new System.Windows.Forms.TextBox();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.dtApplyAt = new System.Windows.Forms.DateTimePicker();
            this.chkCNC = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numHeadstock = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlMCTL = new System.Windows.Forms.Panel();
            this.btnSchCTL = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.machinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.challengerDBDataSet = new ChallengerFactPlanner.ChallengerDBDataSet();
            this.machineIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headstockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.apllyAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.challengerDBDataSet1 = new ChallengerFactPlanner.ChallengerDBDataSet();
            this.machinesTableAdapter = new ChallengerFactPlanner.ChallengerDBDataSetTableAdapters.MachinesTableAdapter();
            this.postsTableAdapter = new ChallengerFactPlanner.ChallengerDBDataSetTableAdapters.PostsTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numHeadstock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pnlMCTL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.machinesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.challengerDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.challengerDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Referance :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Location Zone :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Status :";
            // 
            // lblCNC
            // 
            this.lblCNC.AutoSize = true;
            this.lblCNC.ForeColor = System.Drawing.Color.Gray;
            this.lblCNC.Location = new System.Drawing.Point(244, 54);
            this.lblCNC.Name = "lblCNC";
            this.lblCNC.Size = new System.Drawing.Size(112, 19);
            this.lblCNC.TabIndex = 3;
            this.lblCNC.Text = "CNC Headstock :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date To Apply Changes :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(244, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Machine Type :";
            // 
            // txtRef
            // 
            this.txtRef.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.machinesBindingSource, "Referance", true));
            this.txtRef.Location = new System.Drawing.Point(88, 12);
            this.txtRef.Name = "txtRef";
            this.txtRef.Size = new System.Drawing.Size(150, 25);
            this.txtRef.TabIndex = 0;
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.machinesBindingSource, "Status", true));
            this.chkStatus.Location = new System.Drawing.Point(67, 92);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(49, 23);
            this.chkStatus.TabIndex = 2;
            this.chkStatus.Text = "???";
            this.chkStatus.UseVisualStyleBackColor = true;
            this.chkStatus.CheckedChanged += new System.EventHandler(this.chkStatus_CheckedChanged);
            // 
            // dtApplyAt
            // 
            this.dtApplyAt.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.machinesBindingSource, "ApllyAt", true));
            this.dtApplyAt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtApplyAt.Location = new System.Drawing.Point(409, 91);
            this.dtApplyAt.Name = "dtApplyAt";
            this.dtApplyAt.Size = new System.Drawing.Size(124, 25);
            this.dtApplyAt.TabIndex = 5;
            // 
            // chkCNC
            // 
            this.chkCNC.AutoSize = true;
            this.chkCNC.Location = new System.Drawing.Point(362, 13);
            this.chkCNC.Name = "chkCNC";
            this.chkCNC.Size = new System.Drawing.Size(179, 23);
            this.chkCNC.TabIndex = 3;
            this.chkCNC.Text = "Check if machine is CNC";
            this.chkCNC.UseVisualStyleBackColor = true;
            this.chkCNC.CheckedChanged += new System.EventHandler(this.chkCNC_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.machinesBindingSource, "Zone", true));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "S-A",
            "S-B"});
            this.comboBox1.Location = new System.Drawing.Point(116, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 25);
            this.comboBox1.TabIndex = 1;
            // 
            // numHeadstock
            // 
            this.numHeadstock.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.machinesBindingSource, "Headstock", true));
            this.numHeadstock.Enabled = false;
            this.numHeadstock.Location = new System.Drawing.Point(362, 51);
            this.numHeadstock.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numHeadstock.Name = "numHeadstock";
            this.numHeadstock.Size = new System.Drawing.Size(45, 25);
            this.numHeadstock.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(590, 404);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 30);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.machineIDDataGridViewTextBoxColumn,
            this.referanceDataGridViewTextBoxColumn,
            this.zoneDataGridViewTextBoxColumn,
            this.headstockDataGridViewTextBoxColumn,
            this.statusDataGridViewCheckBoxColumn,
            this.apllyAtDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.machinesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(641, 223);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView1_KeyPress);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(509, 404);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 30);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(428, 404);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(347, 404);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 30);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pnlMCTL);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Location = new System.Drawing.Point(21, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(675, 445);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Machines Controle Unit";
            // 
            // pnlMCTL
            // 
            this.pnlMCTL.Controls.Add(this.numHeadstock);
            this.pnlMCTL.Controls.Add(this.comboBox1);
            this.pnlMCTL.Controls.Add(this.chkCNC);
            this.pnlMCTL.Controls.Add(this.dtApplyAt);
            this.pnlMCTL.Controls.Add(this.chkStatus);
            this.pnlMCTL.Controls.Add(this.txtRef);
            this.pnlMCTL.Controls.Add(this.label6);
            this.pnlMCTL.Controls.Add(this.label5);
            this.pnlMCTL.Controls.Add(this.lblCNC);
            this.pnlMCTL.Controls.Add(this.label3);
            this.pnlMCTL.Controls.Add(this.label2);
            this.pnlMCTL.Controls.Add(this.label1);
            this.pnlMCTL.Location = new System.Drawing.Point(24, 22);
            this.pnlMCTL.Name = "pnlMCTL";
            this.pnlMCTL.Size = new System.Drawing.Size(641, 137);
            this.pnlMCTL.TabIndex = 17;
            // 
            // btnSchCTL
            // 
            this.btnSchCTL.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSchCTL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSchCTL.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchCTL.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSchCTL.Location = new System.Drawing.Point(730, 162);
            this.btnSchCTL.Name = "btnSchCTL";
            this.btnSchCTL.Size = new System.Drawing.Size(294, 41);
            this.btnSchCTL.TabIndex = 19;
            this.btnSchCTL.Text = "Open Work Schedule Controle Interface";
            this.btnSchCTL.UseVisualStyleBackColor = true;
            this.btnSchCTL.Click += new System.EventHandler(this.btnSchCTL_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Location = new System.Drawing.Point(730, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(294, 41);
            this.button1.TabIndex = 20;
            this.button1.Text = "Open Posts Controle Interface";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // machinesBindingSource
            // 
            this.machinesBindingSource.DataMember = "Machines";
            this.machinesBindingSource.DataSource = this.challengerDBDataSet;
            // 
            // challengerDBDataSet
            // 
            this.challengerDBDataSet.DataSetName = "ChallengerDBDataSet";
            this.challengerDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // machineIDDataGridViewTextBoxColumn
            // 
            this.machineIDDataGridViewTextBoxColumn.DataPropertyName = "MachineID";
            this.machineIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.machineIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.machineIDDataGridViewTextBoxColumn.Name = "machineIDDataGridViewTextBoxColumn";
            this.machineIDDataGridViewTextBoxColumn.Width = 70;
            // 
            // referanceDataGridViewTextBoxColumn
            // 
            this.referanceDataGridViewTextBoxColumn.DataPropertyName = "Referance";
            this.referanceDataGridViewTextBoxColumn.HeaderText = "Referance";
            this.referanceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.referanceDataGridViewTextBoxColumn.Name = "referanceDataGridViewTextBoxColumn";
            this.referanceDataGridViewTextBoxColumn.Width = 125;
            // 
            // zoneDataGridViewTextBoxColumn
            // 
            this.zoneDataGridViewTextBoxColumn.DataPropertyName = "Zone";
            this.zoneDataGridViewTextBoxColumn.HeaderText = "Zone";
            this.zoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.zoneDataGridViewTextBoxColumn.Name = "zoneDataGridViewTextBoxColumn";
            this.zoneDataGridViewTextBoxColumn.Width = 70;
            // 
            // headstockDataGridViewTextBoxColumn
            // 
            this.headstockDataGridViewTextBoxColumn.DataPropertyName = "Headstock";
            this.headstockDataGridViewTextBoxColumn.HeaderText = "Headstock";
            this.headstockDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.headstockDataGridViewTextBoxColumn.Name = "headstockDataGridViewTextBoxColumn";
            this.headstockDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewCheckBoxColumn
            // 
            this.statusDataGridViewCheckBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewCheckBoxColumn.HeaderText = "Status";
            this.statusDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewCheckBoxColumn.Name = "statusDataGridViewCheckBoxColumn";
            this.statusDataGridViewCheckBoxColumn.Width = 70;
            // 
            // apllyAtDataGridViewTextBoxColumn
            // 
            this.apllyAtDataGridViewTextBoxColumn.DataPropertyName = "ApllyAt";
            this.apllyAtDataGridViewTextBoxColumn.HeaderText = "Aplly At";
            this.apllyAtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.apllyAtDataGridViewTextBoxColumn.Name = "apllyAtDataGridViewTextBoxColumn";
            this.apllyAtDataGridViewTextBoxColumn.Width = 125;
            // 
            // postsBindingSource
            // 
            this.postsBindingSource.DataMember = "Posts";
            this.postsBindingSource.DataSource = this.challengerDBDataSet1;
            // 
            // challengerDBDataSet1
            // 
            this.challengerDBDataSet1.DataSetName = "ChallengerDBDataSet";
            this.challengerDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // machinesTableAdapter
            // 
            this.machinesTableAdapter.ClearBeforeFill = true;
            // 
            // postsTableAdapter
            // 
            this.postsTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 391);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "💡 To Delete a record :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 411);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(305, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "Select the record on the table and press \"ENTER\"";
            // 
            // factSettingsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSchCTL);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "factSettingsUC";
            this.Size = new System.Drawing.Size(1062, 480);
            this.Load += new System.EventHandler(this.factSettingsUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numHeadstock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlMCTL.ResumeLayout(false);
            this.pnlMCTL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.machinesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.challengerDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.challengerDBDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCNC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRef;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.DateTimePicker dtApplyAt;
        private System.Windows.Forms.CheckBox chkCNC;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numHeadstock;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSchCTL;
        private System.Windows.Forms.Panel pnlMCTL;
        private System.Windows.Forms.BindingSource machinesBindingSource;
        private ChallengerDBDataSet challengerDBDataSet;
        private ChallengerDBDataSetTableAdapters.MachinesTableAdapter machinesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn machineIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn referanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn headstockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apllyAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource postsBindingSource;
        private ChallengerDBDataSet challengerDBDataSet1;
        private ChallengerDBDataSetTableAdapters.PostsTableAdapter postsTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
    }
}
