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
    public partial class FormReplace : Form
    {
        public delegate void TextReplace(string TextFind,string TextRePlace, bool matchcase, bool wraparound);
        public event TextReplace letReplaceText;
        public event TextReplace letFindTexttoReplace;
        public event TextReplace letReplaceAll;
        public FormReplace()
        {

           
            InitializeComponent();
            btnFindtoReplace.Click += BtnFindtoReplace_Click;
            btnReplace.Click += BtnReplace_Click;
            btnReplaceAll.Click += BtnReplaceAll_Click;
        }

        private void BtnReplaceAll_Click(object sender, EventArgs e)
        {
            bool matchCase = cbMatchCaseRP.Checked;
            bool wrapAround = cbWrapArroundRP.Checked;
            string TextFind = txtFind.Text;
            string TextRePlace = txtReplace.Text;
            if(letReplaceAll != null)
                letReplaceAll(TextFind, TextRePlace, matchCase, wrapAround);
        }

        private void BtnReplace_Click(object sender, EventArgs e)
        {
            bool matchCase = cbMatchCaseRP.Checked;
            bool wrapAround = cbWrapArroundRP.Checked;
            string TextFind = txtFind.Text;
            string TextRePlace = txtReplace.Text;
            if (letReplaceText != null)
                letReplaceText(TextFind, TextRePlace, matchCase, wrapAround);
        }

        private void BtnFindtoReplace_Click(object sender, EventArgs e)
        {
            bool matchCase = cbMatchCaseRP.Checked;
            bool wrapAround = cbWrapArroundRP.Checked;
            string TextFind = txtFind.Text;
            string TextRePlace = txtReplace.Text;
            if (letFindTexttoReplace != null)
                letFindTexttoReplace(TextFind, TextRePlace, matchCase, wrapAround);
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
