﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            factSettingsUC1.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            factSettingsUC1.Hide();
            employeesCTL_UC1.Hide();
        }

        private void btnFactSet_Click(object sender, EventArgs e)
        {
            factSettingsUC1.Hide();
            employeesCTL_UC1.Show();
        }
    }
}
