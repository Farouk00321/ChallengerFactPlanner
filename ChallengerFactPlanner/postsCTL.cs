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
    public partial class postsCTL : Form
    {
        public postsCTL()
        {
            InitializeComponent();
        }

        private void postsCTL_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'challengerDBDataSet.Posts' table. You can move, or remove it, as needed.
            this.postsTableAdapter.Fill(this.challengerDBDataSet.Posts);

        }

        private void btnPostSave_Click(object sender, EventArgs e)
        {
            try
            {
                pnlPostCTL.Enabled = false;
                postsBindingSource.EndEdit();
                postsTableAdapter.Update(challengerDBDataSet.Posts);
                dataGridView2.Refresh();
                txtPostRef.Focus();
                MessageBox.Show("Your data has been saved :)", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                challengerDBDataSet.Posts.RejectChanges();
            }
        }

        private void btnPostEdit_Click(object sender, EventArgs e)
        {
            pnlPostCTL.Enabled = true;
            txtPostRef.Focus();
        }

        private void btnPostCancel_Click(object sender, EventArgs e)
        {
            pnlPostCTL.Enabled = false;
            postsBindingSource.ResetBindings(false);
        }

        private void btnPostNew_Click(object sender, EventArgs e)
        {
            try
            {
                pnlPostCTL.Enabled = true;
                challengerDBDataSet.Posts.AddPostsRow(challengerDBDataSet.Posts.NewPostsRow());
                postsBindingSource.MoveLast();
                txtPostRef.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                challengerDBDataSet.Posts.RejectChanges();
            }
        }

        private void dataGridView2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    postsBindingSource.RemoveCurrent();
            }
        }

        private void chkPostStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPostStatus.CheckState == CheckState.Checked)
                chkPostStatus.Text = "Machine Enabled";
            else if (chkPostStatus.CheckState == CheckState.Unchecked)
                chkPostStatus.Text = "Machine Disabled";
            else
                chkPostStatus.Text = "???";
        }
    }
}
