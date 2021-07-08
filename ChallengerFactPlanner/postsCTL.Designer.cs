
namespace ChallengerFactPlanner
{
    partial class postsCTL
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnlPostCTL = new System.Windows.Forms.Panel();
            this.cboPostOP = new System.Windows.Forms.ComboBox();
            this.chkPostStatus = new System.Windows.Forms.CheckBox();
            this.txtPostRef = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnPostNew = new System.Windows.Forms.Button();
            this.btnPostCancel = new System.Windows.Forms.Button();
            this.btnPostEdit = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnPostSave = new System.Windows.Forms.Button();
            this.challengerDBDataSet = new ChallengerFactPlanner.ChallengerDBDataSet();
            this.postsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postsTableAdapter = new ChallengerFactPlanner.ChallengerDBDataSetTableAdapters.PostsTableAdapter();
            this.referanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox2.SuspendLayout();
            this.pnlPostCTL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.challengerDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pnlPostCTL);
            this.groupBox2.Controls.Add(this.btnPostNew);
            this.groupBox2.Controls.Add(this.btnPostCancel);
            this.groupBox2.Controls.Add(this.btnPostEdit);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.btnPostSave);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(377, 395);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Posts Controle Unit";
            // 
            // pnlPostCTL
            // 
            this.pnlPostCTL.Controls.Add(this.cboPostOP);
            this.pnlPostCTL.Controls.Add(this.chkPostStatus);
            this.pnlPostCTL.Controls.Add(this.txtPostRef);
            this.pnlPostCTL.Controls.Add(this.label10);
            this.pnlPostCTL.Controls.Add(this.label11);
            this.pnlPostCTL.Controls.Add(this.label12);
            this.pnlPostCTL.Location = new System.Drawing.Point(11, 22);
            this.pnlPostCTL.Name = "pnlPostCTL";
            this.pnlPostCTL.Size = new System.Drawing.Size(314, 120);
            this.pnlPostCTL.TabIndex = 17;
            // 
            // cboPostOP
            // 
            this.cboPostOP.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.postsBindingSource, "Operation", true));
            this.cboPostOP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPostOP.FormattingEnabled = true;
            this.cboPostOP.Items.AddRange(new object[] {
            "ADJUST",
            "CENETIC",
            "CONTROLE"});
            this.cboPostOP.Location = new System.Drawing.Point(93, 54);
            this.cboPostOP.Name = "cboPostOP";
            this.cboPostOP.Size = new System.Drawing.Size(146, 25);
            this.cboPostOP.TabIndex = 10;
            // 
            // chkPostStatus
            // 
            this.chkPostStatus.AutoSize = true;
            this.chkPostStatus.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.postsBindingSource, "Status", true));
            this.chkPostStatus.Location = new System.Drawing.Point(93, 94);
            this.chkPostStatus.Name = "chkPostStatus";
            this.chkPostStatus.Size = new System.Drawing.Size(49, 23);
            this.chkPostStatus.TabIndex = 7;
            this.chkPostStatus.Text = "???";
            this.chkPostStatus.UseVisualStyleBackColor = true;
            this.chkPostStatus.CheckedChanged += new System.EventHandler(this.chkPostStatus_CheckedChanged);
            // 
            // txtPostRef
            // 
            this.txtPostRef.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postsBindingSource, "Referance", true));
            this.txtPostRef.Location = new System.Drawing.Point(90, 14);
            this.txtPostRef.Name = "txtPostRef";
            this.txtPostRef.Size = new System.Drawing.Size(194, 25);
            this.txtPostRef.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 19);
            this.label10.TabIndex = 2;
            this.label10.Text = "Status :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 19);
            this.label11.TabIndex = 1;
            this.label11.Text = "Operation :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 19);
            this.label12.TabIndex = 0;
            this.label12.Text = "Referance :";
            // 
            // btnPostNew
            // 
            this.btnPostNew.Location = new System.Drawing.Point(106, 354);
            this.btnPostNew.Name = "btnPostNew";
            this.btnPostNew.Size = new System.Drawing.Size(58, 30);
            this.btnPostNew.TabIndex = 16;
            this.btnPostNew.Text = "&New";
            this.btnPostNew.UseVisualStyleBackColor = true;
            this.btnPostNew.Click += new System.EventHandler(this.btnPostNew_Click);
            // 
            // btnPostCancel
            // 
            this.btnPostCancel.Location = new System.Drawing.Point(170, 354);
            this.btnPostCancel.Name = "btnPostCancel";
            this.btnPostCancel.Size = new System.Drawing.Size(58, 30);
            this.btnPostCancel.TabIndex = 15;
            this.btnPostCancel.Text = "&Cancel";
            this.btnPostCancel.UseVisualStyleBackColor = true;
            this.btnPostCancel.Click += new System.EventHandler(this.btnPostCancel_Click);
            // 
            // btnPostEdit
            // 
            this.btnPostEdit.Location = new System.Drawing.Point(237, 354);
            this.btnPostEdit.Name = "btnPostEdit";
            this.btnPostEdit.Size = new System.Drawing.Size(58, 30);
            this.btnPostEdit.TabIndex = 14;
            this.btnPostEdit.Text = "&Edit";
            this.btnPostEdit.UseVisualStyleBackColor = true;
            this.btnPostEdit.Click += new System.EventHandler(this.btnPostEdit_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.referanceDataGridViewTextBoxColumn,
            this.operationDataGridViewTextBoxColumn,
            this.statusDataGridViewCheckBoxColumn});
            this.dataGridView2.DataSource = this.postsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(11, 166);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(360, 182);
            this.dataGridView2.TabIndex = 13;
            this.dataGridView2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView2_KeyPress);
            // 
            // btnPostSave
            // 
            this.btnPostSave.Location = new System.Drawing.Point(301, 354);
            this.btnPostSave.Name = "btnPostSave";
            this.btnPostSave.Size = new System.Drawing.Size(58, 30);
            this.btnPostSave.TabIndex = 12;
            this.btnPostSave.Text = "&Save";
            this.btnPostSave.UseVisualStyleBackColor = true;
            this.btnPostSave.Click += new System.EventHandler(this.btnPostSave_Click);
            // 
            // challengerDBDataSet
            // 
            this.challengerDBDataSet.DataSetName = "ChallengerDBDataSet";
            this.challengerDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // postsBindingSource
            // 
            this.postsBindingSource.DataMember = "Posts";
            this.postsBindingSource.DataSource = this.challengerDBDataSet;
            // 
            // postsTableAdapter
            // 
            this.postsTableAdapter.ClearBeforeFill = true;
            // 
            // referanceDataGridViewTextBoxColumn
            // 
            this.referanceDataGridViewTextBoxColumn.DataPropertyName = "Referance";
            this.referanceDataGridViewTextBoxColumn.HeaderText = "Referance";
            this.referanceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.referanceDataGridViewTextBoxColumn.Name = "referanceDataGridViewTextBoxColumn";
            this.referanceDataGridViewTextBoxColumn.Width = 125;
            // 
            // operationDataGridViewTextBoxColumn
            // 
            this.operationDataGridViewTextBoxColumn.DataPropertyName = "Operation";
            this.operationDataGridViewTextBoxColumn.HeaderText = "Operation";
            this.operationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.operationDataGridViewTextBoxColumn.Name = "operationDataGridViewTextBoxColumn";
            this.operationDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewCheckBoxColumn
            // 
            this.statusDataGridViewCheckBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewCheckBoxColumn.HeaderText = "Status";
            this.statusDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewCheckBoxColumn.Name = "statusDataGridViewCheckBoxColumn";
            this.statusDataGridViewCheckBoxColumn.Width = 50;
            // 
            // postsCTL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(414, 421);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "postsCTL";
            this.Text = "Posts Controle Interface";
            this.Load += new System.EventHandler(this.postsCTL_Load);
            this.groupBox2.ResumeLayout(false);
            this.pnlPostCTL.ResumeLayout(false);
            this.pnlPostCTL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.challengerDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel pnlPostCTL;
        private System.Windows.Forms.ComboBox cboPostOP;
        private System.Windows.Forms.CheckBox chkPostStatus;
        private System.Windows.Forms.TextBox txtPostRef;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnPostNew;
        private System.Windows.Forms.Button btnPostCancel;
        private System.Windows.Forms.Button btnPostEdit;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnPostSave;
        private ChallengerDBDataSet challengerDBDataSet;
        private System.Windows.Forms.BindingSource postsBindingSource;
        private ChallengerDBDataSetTableAdapters.PostsTableAdapter postsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn referanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
    }
}