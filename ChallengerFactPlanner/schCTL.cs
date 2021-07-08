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
    public partial class schCTL : Form
    {
        public schCTL()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void schCTL_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'challengerDBDataSet.Schedule' table. You can move, or remove it, as needed.
            this.scheduleTableAdapter.Fill(this.challengerDBDataSet.Schedule);
            panelCTL.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                panelCTL.Enabled = false;
                scheduleBindingSource.EndEdit();
                scheduleTableAdapter.Update(challengerDBDataSet.Schedule);
                dataGridView1.Refresh();
                cboTime.Focus();
                MessageBox.Show("Your data has been saved :)", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                challengerDBDataSet.Schedule.RejectChanges();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            panelCTL.Enabled = true;
            cboTime.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelCTL.Enabled = false;
           scheduleBindingSource.ResetBindings(false);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                panelCTL.Enabled = true;
                challengerDBDataSet.Schedule.AddScheduleRow(challengerDBDataSet.Schedule.NewScheduleRow());
               scheduleBindingSource.MoveLast();
                cboTime.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                challengerDBDataSet.Schedule.RejectChanges();
            }
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                   scheduleBindingSource.RemoveCurrent();
            }
        }
    }
}
