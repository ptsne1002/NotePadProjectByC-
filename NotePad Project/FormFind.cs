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
    public partial class FormFind : Form
    {
        public delegate void TextFind(string Text, bool matchcase, bool wraparound, bool updown);
        public event TextFind letFindText;
        public FormFind()
        {
            InitializeComponent();
            btnFind.Click += BtnFind_Click;
        }

        public void BtnFind_Click(object sender, EventArgs e)
        {
            string Text = txtFind.Text.Trim();
            bool matchcase = cbMatchCase.Checked;
            bool wraparound = cbWrapArround.Checked;
            bool updown = rdoBtnUp.Checked;

            if(letFindText != null)
            {
                letFindText(Text, matchcase, wraparound, updown);
            }    
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
