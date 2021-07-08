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
    public partial class factSettingsUC : UserControl
    {
        public factSettingsUC()
        {
            InitializeComponent();
        }

        private void factSettingsUC_Load(object sender, EventArgs e)
        {
           // this.machinesTableAdapter.Fill(this.challengerDBDataSet.Machines);
            
            pnlMCTL.Enabled = false;
        }

        private void btnSchCTL_Click(object sender, EventArgs e)
        {
            schCTL window = new schCTL();
            window.ShowDialog();
        }

        private void chkCNC_CheckedChanged(object sender, EventArgs e)
        {
            if(chkCNC.CheckState == CheckState.Checked)
            {
                numHeadstock.Enabled = true;
                chkCNC.Text = "Set Your Machine Headstock number !";
                lblCNC.ForeColor = Color.Black;
            }
            else
            {
                numHeadstock.Enabled = false;
                chkCNC.Text = "Check if machine is a CNC machine";
                lblCNC.ForeColor = Color.Gray;
            }
        }

        private void chkStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStatus.CheckState == CheckState.Checked)
                chkStatus.Text = "Machine Enabled";
            else if (chkStatus.CheckState == CheckState.Unchecked)
                chkStatus.Text = "Machine Disabled";
            else
            {
                chkStatus.Text = "???";
            }

        }
        //--------------------------------------------Machines CTL-------------------------------------
        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                pnlMCTL.Enabled = true;
                challengerDBDataSet.Machines.AddMachinesRow(challengerDBDataSet.Machines.NewMachinesRow());
                machinesBindingSource.MoveLast();
                txtRef.Focus();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                challengerDBDataSet.Machines.RejectChanges();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            pnlMCTL.Enabled = true;
            txtRef.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlMCTL.Enabled = false;
            machinesBindingSource.ResetBindings(false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                pnlMCTL.Enabled = false;
                machinesBindingSource.EndEdit();
                machinesTableAdapter.Update(challengerDBDataSet.Machines);
                dataGridView1.Refresh();
                txtRef.Focus();
                MessageBox.Show("Your data has been saved :)", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                challengerDBDataSet.Machines.RejectChanges();
            }
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    machinesBindingSource.RemoveCurrent();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            postsCTL window = new postsCTL();
            window.ShowDialog();
        }
    }
}
