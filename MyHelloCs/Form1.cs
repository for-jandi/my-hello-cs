﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHelloCs
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void BtnGreeting_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "환영합니다.",
                "몬베베",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information
            );
        }
    }
}
