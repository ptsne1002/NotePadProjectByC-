namespace NotePad_Project
{
    partial class FormReplace
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbWrapArroundRP = new System.Windows.Forms.CheckBox();
            this.cbMatchCaseRP = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnFindtoReplace = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnReplaceAll = new System.Windows.Forms.Button();
            this.txtReplace = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbWrapArroundRP
            // 
            this.cbWrapArroundRP.Location = new System.Drawing.Point(15, 97);
            this.cbWrapArroundRP.Name = "cbWrapArroundRP";
            this.cbWrapArroundRP.Size = new System.Drawing.Size(91, 17);
            this.cbWrapArroundRP.TabIndex = 13;
            this.cbWrapArroundRP.Text = "Wrap arround";
            this.cbWrapArroundRP.UseVisualStyleBackColor = true;
            // 
            // cbMatchCaseRP
            // 
            this.cbMatchCaseRP.AutoSize = true;
            this.cbMatchCaseRP.Checked = true;
            this.cbMatchCaseRP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMatchCaseRP.Location = new System.Drawing.Point(15, 68);
            this.cbMatchCaseRP.Name = "cbMatchCaseRP";
            this.cbMatchCaseRP.Size = new System.Drawing.Size(82, 17);
            this.cbMatchCaseRP.TabIndex = 12;
            this.cbMatchCaseRP.Text = "Match case";
            this.cbMatchCaseRP.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(297, 91);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnFindtoReplace
            // 
            this.btnFindtoReplace.Location = new System.Drawing.Point(297, 4);
            this.btnFindtoReplace.Name = "btnFindtoReplace";
            this.btnFindtoReplace.Size = new System.Drawing.Size(75, 23);
            this.btnFindtoReplace.TabIndex = 9;
            this.btnFindtoReplace.Text = "Find Next";
            this.btnFindtoReplace.UseVisualStyleBackColor = true;
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(94, 6);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(188, 20);
            this.txtFind.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Find Word :";
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(297, 33);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(75, 23);
            this.btnReplace.TabIndex = 14;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            // 
            // btnReplaceAll
            // 
            this.btnReplaceAll.Location = new System.Drawing.Point(297, 62);
            this.btnReplaceAll.Name = "btnReplaceAll";
            this.btnReplaceAll.Size = new System.Drawing.Size(75, 23);
            this.btnReplaceAll.TabIndex = 15;
            this.btnReplaceAll.Text = "Replace All";
            this.btnReplaceAll.UseVisualStyleBackColor = true;
            // 
            // txtReplace
            // 
            this.txtReplace.Location = new System.Drawing.Point(94, 36);
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.Size = new System.Drawing.Size(188, 20);
            this.txtReplace.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Replace With :";
            // 
            // FormReplace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(379, 139);
            this.Controls.Add(this.txtReplace);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnReplaceAll);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.cbWrapArroundRP);
            this.Controls.Add(this.cbMatchCaseRP);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFindtoReplace);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormReplace";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "FormReplace";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbWrapArroundRP;
        private System.Windows.Forms.CheckBox cbMatchCaseRP;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnFindtoReplace;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnReplaceAll;
        private System.Windows.Forms.TextBox txtReplace;
        private System.Windows.Forms.Label label2;
    }
}