using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Button bt=(Button)sender;
            txtscreen.Text = txtscreen.Text + bt.Text;

        }

        private void btnac_Click(object sender, EventArgs e)
        {
            lblscreen.Text = "";
            txtscreen.Text = "";
        }

        private void btnresult_Click(object sender, EventArgs e)
        {
            lblscreen.Text = txtscreen.Text;
            DataTable dt = new DataTable();
            txtscreen.Text = dt.Compute(txtscreen.Text,null).ToString();

        }
    }
}
