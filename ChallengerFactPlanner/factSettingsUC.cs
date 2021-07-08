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
                chkStatus.CheckState = CheckState.Indeterminate;
            }

        }
    }
}
