using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RetirementCenter.Forms.Main
{
    public partial class AntiAdminLogincs : Form
    {
        public AntiAdminLogincs()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (txt.Text != string.Empty && txt.Text == "mohnoor12397@123")
            {
                DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
        }
    }
}
