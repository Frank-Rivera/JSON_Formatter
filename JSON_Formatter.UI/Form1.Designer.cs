namespace JSON_Formatter.UI
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CtxBxTextArea = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cBtnFormat = new System.Windows.Forms.Button();
            this.CbtnClear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CtxBxTextArea);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 387);
            this.panel1.TabIndex = 0;
            // 
            // CtxBxTextArea
            // 
            this.CtxBxTextArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CtxBxTextArea.Location = new System.Drawing.Point(0, 0);
            this.CtxBxTextArea.Multiline = true;
            this.CtxBxTextArea.Name = "CtxBxTextArea";
            this.CtxBxTextArea.Size = new System.Drawing.Size(898, 387);
            this.CtxBxTextArea.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CbtnClear);
            this.panel2.Controls.Add(this.cBtnFormat);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 387);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(898, 164);
            this.panel2.TabIndex = 1;
            // 
            // cBtnFormat
            // 
            this.cBtnFormat.Location = new System.Drawing.Point(43, 71);
            this.cBtnFormat.Name = "cBtnFormat";
            this.cBtnFormat.Size = new System.Drawing.Size(75, 23);
            this.cBtnFormat.TabIndex = 0;
            this.cBtnFormat.Text = "Format";
            this.cBtnFormat.UseVisualStyleBackColor = true;
            this.cBtnFormat.Click += new System.EventHandler(this.CBtnFormat_Click);
            // 
            // CbtnClear
            // 
            this.CbtnClear.Location = new System.Drawing.Point(211, 71);
            this.CbtnClear.Name = "CbtnClear";
            this.CbtnClear.Size = new System.Drawing.Size(75, 23);
            this.CbtnClear.TabIndex = 1;
            this.CbtnClear.Text = "Clear";
            this.CbtnClear.UseVisualStyleBackColor = true;
            this.CbtnClear.Click += new System.EventHandler(this.CbtnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 551);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox CtxBxTextArea;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cBtnFormat;
        private System.Windows.Forms.Button CbtnClear;
    }
}

