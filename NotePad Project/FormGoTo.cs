using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePad_Project
{
    public partial class FormGoTo : Form
    {
        int LineNumber = 0;
        public FormGoTo()
        {
            InitializeComponent();
        }

        private void btnGoTo_Click(object sender, EventArgs e)
        {
            LineNumber = int.Parse(txtGoToLine.Text);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtGoToLine_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if((e.KeyChar == (char)13))
                {
                btnGoTo_Click(sender, e);
            }
        }
        public int returnline()
        {
            return LineNumber;
            
        }
    }
}
