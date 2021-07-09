using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChallengerFactPlanner
{
    public partial class employeesCTL_UC : UserControl
    {
        public employeesCTL_UC()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSchCTL_Click(object sender, EventArgs e)
        {
            importEmployees window = new importEmployees();
            window.ShowDialog();
        }

        private void employeesCTL_UC_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'challengerDBDataSet.Schedule' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.challengerDBDataSet.Employees);
            panelCTL.Enabled = false;
            chkStatus.CheckState = CheckState.Unchecked;
            chkStatus.Text = "Not Available";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                panelCTL.Enabled = false;
                employeesBindingSource.EndEdit();
                employeesTableAdapter.Update(challengerDBDataSet.Employees);
                dataGridView1.Refresh();
                txtFullname.Focus();
                MessageBox.Show("Your data has been saved :)", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                challengerDBDataSet.Employees.RejectChanges();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            panelCTL.Enabled = true;
            txtFullname.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelCTL.Enabled = false;
            employeesBindingSource.ResetBindings(false);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                panelCTL.Enabled = true;
                challengerDBDataSet.Employees.AddEmployeesRow(challengerDBDataSet.Employees.NewEmployeesRow());
                employeesBindingSource.MoveLast();
                txtFullname.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                challengerDBDataSet.Employees.RejectChanges();
            }
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    employeesBindingSource.RemoveCurrent();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            processEmployee window = new processEmployee();
            window.ShowDialog();
        }

        private void chkStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStatus.CheckState == CheckState.Checked)
                chkStatus.Text = "Available";
            else
                chkStatus.Text = "Not Available";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.CheckState == CheckState.Checked)
                dtApplyAt.Enabled = true;
            else
                dtApplyAt.Enabled = false;
        }
    }
}
