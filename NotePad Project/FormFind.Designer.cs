namespace NotePad_Project
{
    partial class FormFind
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoBtnDown = new System.Windows.Forms.RadioButton();
            this.rdoBtnUp = new System.Windows.Forms.RadioButton();
            this.cbMatchCase = new System.Windows.Forms.CheckBox();
            this.cbWrapArround = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find Word :";
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(81, 10);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(202, 20);
            this.txtFind.TabIndex = 1;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(298, 8);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Find Next";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(298, 37);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoBtnDown);
            this.groupBox1.Controls.Add(this.rdoBtnUp);
            this.groupBox1.Location = new System.Drawing.Point(179, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(104, 51);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Direction";
            // 
            // rdoBtnDown
            // 
            this.rdoBtnDown.AutoSize = true;
            this.rdoBtnDown.Checked = true;
            this.rdoBtnDown.Location = new System.Drawing.Point(45, 20);
            this.rdoBtnDown.Name = "rdoBtnDown";
            this.rdoBtnDown.Size = new System.Drawing.Size(53, 17);
            this.rdoBtnDown.TabIndex = 1;
            this.rdoBtnDown.TabStop = true;
            this.rdoBtnDown.Text = "Down";
            this.rdoBtnDown.UseVisualStyleBackColor = true;
            // 
            // rdoBtnUp
            // 
            this.rdoBtnUp.AutoSize = true;
            this.rdoBtnUp.Location = new System.Drawing.Point(7, 20);
            this.rdoBtnUp.Name = "rdoBtnUp";
            this.rdoBtnUp.Size = new System.Drawing.Size(39, 17);
            this.rdoBtnUp.TabIndex = 0;
            this.rdoBtnUp.Text = "Up";
            this.rdoBtnUp.UseVisualStyleBackColor = true;
            // 
            // cbMatchCase
            // 
            this.cbMatchCase.AutoSize = true;
            this.cbMatchCase.Checked = true;
            this.cbMatchCase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMatchCase.Location = new System.Drawing.Point(13, 57);
            this.cbMatchCase.Name = "cbMatchCase";
            this.cbMatchCase.Size = new System.Drawing.Size(82, 17);
            this.cbMatchCase.TabIndex = 5;
            this.cbMatchCase.Text = "Match case";
            this.cbMatchCase.UseVisualStyleBackColor = true;
            // 
            // cbWrapArround
            // 
            this.cbWrapArround.AutoSize = true;
            this.cbWrapArround.Location = new System.Drawing.Point(13, 86);
            this.cbWrapArround.Name = "cbWrapArround";
            this.cbWrapArround.Size = new System.Drawing.Size(91, 17);
            this.cbWrapArround.TabIndex = 6;
            this.cbWrapArround.Text = "Wrap arround";
            this.cbWrapArround.UseVisualStyleBackColor = true;
            // 
            // FormFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(384, 115);
            this.Controls.Add(this.cbWrapArround);
            this.Controls.Add(this.cbMatchCase);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFind";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "FormFind";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoBtnDown;
        private System.Windows.Forms.RadioButton rdoBtnUp;
        private System.Windows.Forms.CheckBox cbMatchCase;
        private System.Windows.Forms.CheckBox cbWrapArround;
    }
}