
namespace ChallengerFactPlanner
{
    partial class schCTL
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
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.stRange = new System.Windows.Forms.NumericUpDown();
            this.ndRange = new System.Windows.Forms.NumericUpDown();
            this.cboTime = new System.Windows.Forms.ComboBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.panelCTL = new System.Windows.Forms.Panel();
            this.scheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.challengerDBDataSet = new ChallengerFactPlanner.ChallengerDBDataSet();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stRangeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ndRangeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheduleTableAdapter = new ChallengerFactPlanner.ChallengerDBDataSetTableAdapters.ScheduleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndRange)).BeginInit();
            this.panelCTL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.challengerDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.label5.Location = new System.Drawing.Point(40, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Start";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.label6.Location = new System.Drawing.Point(116, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "End";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(94, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "→";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.timeDataGridViewTextBoxColumn,
            this.stRangeDataGridViewTextBoxColumn,
            this.ndRangeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.scheduleBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(225, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(304, 136);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView1_KeyPress);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(471, 174);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(48, 31);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(417, 174);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(48, 31);
            this.btnEdit.TabIndex = 20;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(354, 174);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(57, 31);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // stRange
            // 
            this.stRange.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.scheduleBindingSource, "stRange", true));
            this.stRange.Location = new System.Drawing.Point(43, 88);
            this.stRange.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.stRange.Name = "stRange";
            this.stRange.Size = new System.Drawing.Size(45, 25);
            this.stRange.TabIndex = 22;
            // 
            // ndRange
            // 
            this.ndRange.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.scheduleBindingSource, "ndRange", true));
            this.ndRange.Location = new System.Drawing.Point(119, 88);
            this.ndRange.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.ndRange.Name = "ndRange";
            this.ndRange.Size = new System.Drawing.Size(45, 25);
            this.ndRange.TabIndex = 23;
            // 
            // cboTime
            // 
            this.cboTime.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.scheduleBindingSource, "Time", true));
            this.cboTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTime.FormattingEnabled = true;
            this.cboTime.Items.AddRange(new object[] {
            "DAY",
            "MORNING",
            "EVENING",
            "NIGHT"});
            this.cboTime.Location = new System.Drawing.Point(56, 21);
            this.cboTime.Name = "cboTime";
            this.cboTime.Size = new System.Drawing.Size(121, 25);
            this.cboTime.TabIndex = 24;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(300, 174);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(48, 31);
            this.btnNew.TabIndex = 25;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // panelCTL
            // 
            this.panelCTL.Controls.Add(this.cboTime);
            this.panelCTL.Controls.Add(this.ndRange);
            this.panelCTL.Controls.Add(this.stRange);
            this.panelCTL.Controls.Add(this.label7);
            this.panelCTL.Controls.Add(this.label6);
            this.panelCTL.Controls.Add(this.label5);
            this.panelCTL.Controls.Add(this.label1);
            this.panelCTL.Location = new System.Drawing.Point(26, 32);
            this.panelCTL.Name = "panelCTL";
            this.panelCTL.Size = new System.Drawing.Size(187, 136);
            this.panelCTL.TabIndex = 26;
            // 
            // scheduleBindingSource
            // 
            this.scheduleBindingSource.DataMember = "Schedule";
            this.scheduleBindingSource.DataSource = this.challengerDBDataSet;
            // 
            // challengerDBDataSet
            // 
            this.challengerDBDataSet.DataSetName = "ChallengerDBDataSet";
            this.challengerDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.Width = 125;
            // 
            // stRangeDataGridViewTextBoxColumn
            // 
            this.stRangeDataGridViewTextBoxColumn.DataPropertyName = "stRange";
            this.stRangeDataGridViewTextBoxColumn.HeaderText = "Start";
            this.stRangeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stRangeDataGridViewTextBoxColumn.Name = "stRangeDataGridViewTextBoxColumn";
            this.stRangeDataGridViewTextBoxColumn.Width = 60;
            // 
            // ndRangeDataGridViewTextBoxColumn
            // 
            this.ndRangeDataGridViewTextBoxColumn.DataPropertyName = "ndRange";
            this.ndRangeDataGridViewTextBoxColumn.HeaderText = "End";
            this.ndRangeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ndRangeDataGridViewTextBoxColumn.Name = "ndRangeDataGridViewTextBoxColumn";
            this.ndRangeDataGridViewTextBoxColumn.Width = 60;
            // 
            // scheduleTableAdapter
            // 
            this.scheduleTableAdapter.ClearBeforeFill = true;
            // 
            // schCTL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(541, 233);
            this.Controls.Add(this.panelCTL);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "schCTL";
            this.Text = "Schedule Controle";
            this.Load += new System.EventHandler(this.schCTL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndRange)).EndInit();
            this.panelCTL.ResumeLayout(false);
            this.panelCTL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.challengerDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown stRange;
        private System.Windows.Forms.NumericUpDown ndRange;
        private System.Windows.Forms.ComboBox cboTime;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Panel panelCTL;
        private ChallengerDBDataSet challengerDBDataSet;
        private System.Windows.Forms.BindingSource scheduleBindingSource;
        private ChallengerDBDataSetTableAdapters.ScheduleTableAdapter scheduleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stRangeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ndRangeDataGridViewTextBoxColumn;
    }
}