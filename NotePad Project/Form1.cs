using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePad_Project
{
    public partial class Form1 : Form
    {
        string pathFileOpen = "";
        int position = 0;
        string FileName = "";
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        private FormGoTo fGoTo  = new FormGoTo();

        public Form1()
        {
            InitializeComponent();
            TextBox.EnableContextMenu();
            sttZoom.Text = (TextBox.ZoomFactor * 100).ToString() +"%" ;
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
            string search = "https://www.google.com/search?q=" + TextBox.SelectedText;
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

        private void statusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(statusBarToolStripMenuItem.Checked==false)
            {
                statusBarToolStripMenuItem.Checked = false;
                statusbar.Hide();
            }
            else
            {
                statusBarToolStripMenuItem.Checked = true;
                statusbar.Visible = true;
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ss = this.Text;
            DialogResult rs;
            if (ss[0] =='*')
            {
                if(!pathFileOpen.Equals(""))
                {
                    
                    rs =  MessageBox.Show("Do you want to save changes to \n" + pathFileOpen, "Notification",MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                }
                else
                {
                    rs = MessageBox.Show("Do you want to save changes to \n" + FileName, "Notification", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                }

                if(rs == DialogResult.Yes && pathFileOpen.Equals(""))
                {
                    saveAsToolStripMenuItem_Click(sender, e);
                }
                else if(rs == DialogResult.Yes && !pathFileOpen.Equals(""))
                {
                    StreamWriter sw = new StreamWriter(pathFileOpen);
                    sw.WriteLine(TextBox.Text);
                    sw.Close();
                    FileName = "UnTile.txt";
                    pathFileOpen = "";
                    this.Text = FileName + "- NotePad Fake";
                    TextBox.Text = "";
                }
                else if(rs == DialogResult.No)
                {
                    FileName = "UnTile.txt";
                    pathFileOpen = "";
                    this.Text = FileName + "- NotePad Fake";
                    TextBox.Text = "";
                }
                
            }
            else
            {
                FileName = "UnTile.txt";
                pathFileOpen = "";
                this.Text = FileName + "- NotePad Fake";
                TextBox.Text = "";
            }
        }

        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 newform = new Form1();
            newform.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DialogResult rs;
            //string ss = this.Text;
            //if (ss[0] == '*')
            //{
            //    if (!pathFileOpen.Equals(""))
            //    {

            //        rs = MessageBox.Show("Do you want to save changes to \n" + pathFileOpen, "Notification", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            //    }
            //    else
            //    {
            //        rs = MessageBox.Show("Do you want to save changes to \n" + FileName, "Notification", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            //    }

            //    if (rs == DialogResult.Yes && pathFileOpen.Equals(""))
            //    {
            //        saveAsToolStripMenuItem_Click(sender, e);
            //    }
            //    else if (rs == DialogResult.Yes && !pathFileOpen.Equals(""))
            //    {
            //        StreamWriter sw = new StreamWriter(pathFileOpen);
            //        sw.WriteLine(TextBox.Text);
            //        sw.Close();
            //        this.Close();
            //    }
            //    else if (rs == DialogResult.Cancel)
            //    {

            //    }
            //    else
            //    {
            //        this.Close();
            //    }    
            //}
            //else
            //{
            //    this.Close();
            //}
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.ShowDialog();
            openfile.DefaultExt = "txt";
            openfile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openfile.FilterIndex = 1;
            openfile.RestoreDirectory = true;
            string fullpath = openfile.FileName;
            pathFileOpen = fullpath;
            //MessageBox.Show(fullpath);
            if(!fullpath.Equals(""))
            {
                string formatfile = fullpath.Substring(fullpath.Length - 4);
                if(String.Compare(formatfile,".txt",true) ==0)
                {
                    // readfile
                    FileInfo fi = new FileInfo(fullpath);
                    StreamReader sr = fi.OpenText();
                    TextBox.Text = sr.ReadToEnd();
                    sr.Close();
                    int index = fullpath.LastIndexOf(@"\");
                    string filename = fullpath.Substring(index+1);
                    FileName = filename;
                    //MessageBox.Show(filename);
                    this.Text = filename + "- NotePad Fake";
                }    
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if(pathFileOpen != "")
            {
                StreamWriter sw = new StreamWriter(pathFileOpen);
                sw.WriteLine(TextBox.Text);
                sw.Close();
                this.Text = FileName + "- NotePad Fake";
            }
            else
            {
                saveAsToolStripMenuItem_Click(sender, e);
            }

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveFile = new SaveFileDialog();
            SaveFile.ShowDialog();
            SaveFile.DefaultExt = "txt";
            SaveFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            SaveFile.FilterIndex = 2;
            SaveFile.RestoreDirectory = true;
            string fullpath = SaveFile.FileName;
            if (!fullpath.Equals(""))
            {
                string formatfile = fullpath.Substring(fullpath.Length - 4);
                if (String.Compare(formatfile, ".txt", true) == 0)
                {
                    // readfile
                    StreamWriter sw = new StreamWriter(fullpath);
                    sw.WriteLine(TextBox.Text);
                    sw.Close();
                }
                else
                {
                    fullpath += ".txt";
                    StreamWriter sw = new StreamWriter(fullpath);
                    sw.WriteLine(TextBox.Text);
                    sw.Close();
                    MessageBox.Show("Save Success !", "Notification");
                }
                int index = fullpath.LastIndexOf(@"\");
                string filename = fullpath.Substring(index + 1);
                FileName = filename;
                this.Text = FileName + "- NotePad Fake";
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (!FileName.Equals(""))
            {
                this.Text = "*" + FileName + "- NotePad Fake";
            }
            else
            {
                FileName = "UnTile.txt";
                this.Text = "*" + FileName + "- NotePad Fake";
            }
            
        }

        private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PageSetupDialog pgsetup = new PageSetupDialog();
            pgsetup.PageSettings = new System.Drawing.Printing.PageSettings();
            pgsetup.PrinterSettings = new System.Drawing.Printing.PrinterSettings();
            pgsetup.ShowNetwork = false;
            pgsetup.AllowMargins = true;
            pgsetup.AllowOrientation = true;
            pgsetup.ShowDialog();
            
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog a = new PrintDialog();
            a.ShowDialog();
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void goToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fGoTo.MaximizeBox = false;
            fGoTo.MinimizeBox = false;
            fGoTo.ShowDialog();
            position = 0;
            for (int i = 1; i  <= fGoTo.returnline(); i++)
            GoToLine("\n");
        }
        public void GoToLine(string FindValue)      // Find word...
        {
            int start = this.TextBox.Text.IndexOf(FindValue, position);
            int length = FindValue.Length;

            this.TextBox.Select(start-1, 0);

            position = start + length;
        }

        private void timeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime now = System.DateTime.Now;
            TextBox.AppendText(" "+ now.ToString());
        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float zoom = TextBox.ZoomFactor;
            float i = 0.1f;
            if (zoom  < 5) { 
                TextBox.ZoomFactor = zoom + i;
            }
            sttZoom.Text = (TextBox.ZoomFactor *100).ToString()+"%";
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float zoom = TextBox.ZoomFactor;
            float i = 0.1f;
            if (zoom > 0.2)
            {
                TextBox.ZoomFactor = zoom - i;
            }
            sttZoom.Text = (TextBox.ZoomFactor * 100).ToString() + "%";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs;
            string ss = this.Text;
            if (ss[0] == '*')
            {
                if (!pathFileOpen.Equals(""))
                {

                    rs = MessageBox.Show("Do you want to save changes to \n" + pathFileOpen, "Notification", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                }
                else
                {
                    rs = MessageBox.Show("Do you want to save changes to \n" + FileName, "Notification", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                }

                if (rs == DialogResult.Yes && pathFileOpen.Equals(""))
                {
                    saveAsToolStripMenuItem_Click(sender, e);
                }
                else if (rs == DialogResult.Yes && !pathFileOpen.Equals(""))
                {
                    StreamWriter sw = new StreamWriter(pathFileOpen);
                    sw.WriteLine(TextBox.Text);
                    sw.Close();
                    this.Close();
                }
                else if (rs == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }    
            }
            else
            {
                this.Close();
            }
        }
    }
}
