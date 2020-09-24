using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePad_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TextBox.EnableContextMenu();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            
            fd.ShowEffects = true;
            fd.ShowDialog();
            TextBox.Font = fd.Font;
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            int pos = TextBox.SelectionStart;
            int col = pos - TextBox.GetFirstCharIndexOfCurrentLine() + 1;
            int line = TextBox.GetLineFromCharIndex(pos) + 1;
            this.LnCol.Text = "Ln " + line + ", Col " + col;
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox.Undo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox.SelectedText = "";
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox.SelectAll();
        }

        private void searchWithChromeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string search = "https://www.bing.com/search?q=" + TextBox.SelectedText;
           Process.Start("chrome.exe",search);
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void WWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(WWToolStripMenuItem.Checked == false)
            {
                TextBox.WordWrap = false;
                WWToolStripMenuItem.Checked = false;
            }
            else
            {
                TextBox.WordWrap = true;
                WWToolStripMenuItem.Checked =  true;
            }
        }
    }
}
