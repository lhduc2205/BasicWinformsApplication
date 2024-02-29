namespace WinformsBasic.UserControls
{
    partial class NumberCounterControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            guna2Panel1 = new Panel();
            panel2 = new Panel();
            txtResult = new TextBox();
            btnClear = new Button();
            label1 = new Label();
            panel1 = new Panel();
            cbEnableDescending = new CheckBox();
            label2 = new Label();
            endNumberInput = new NumericUpDown();
            btnStartCount = new Button();
            guna2Panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)endNumberInput).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = SystemColors.Control;
            guna2Panel1.Controls.Add(panel2);
            guna2Panel1.Controls.Add(btnClear);
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.Dock = DockStyle.Bottom;
            guna2Panel1.Location = new Point(0, 340);
            guna2Panel1.Margin = new Padding(3, 4, 3, 4);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.Size = new Size(749, 326);
            guna2Panel1.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(2, 6, 23);
            panel2.Controls.Add(txtResult);
            panel2.Location = new Point(16, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(719, 254);
            panel2.TabIndex = 14;
            // 
            // txtResult
            // 
            txtResult.BackColor = Color.FromArgb(2, 6, 23);
            txtResult.BorderStyle = BorderStyle.None;
            txtResult.Cursor = Cursors.IBeam;
            txtResult.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtResult.ForeColor = Color.White;
            txtResult.Location = new Point(3, 5);
            txtResult.Margin = new Padding(3, 5, 3, 5);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.ScrollBars = ScrollBars.Vertical;
            txtResult.Size = new Size(713, 244);
            txtResult.TabIndex = 10;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(653, 10);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(82, 32);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += BtnClear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 16);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 0;
            label1.Text = "Result";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(cbEnableDescending);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(endNumberInput);
            panel1.Controls.Add(btnStartCount);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(749, 332);
            panel1.TabIndex = 2;
            // 
            // cbEnableDescending
            // 
            cbEnableDescending.AutoSize = true;
            cbEnableDescending.BackColor = SystemColors.Control;
            cbEnableDescending.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbEnableDescending.ForeColor = Color.FromArgb(51, 65, 85);
            cbEnableDescending.Location = new Point(20, 134);
            cbEnableDescending.Margin = new Padding(3, 4, 3, 4);
            cbEnableDescending.Name = "cbEnableDescending";
            cbEnableDescending.Size = new Size(158, 24);
            cbEnableDescending.TabIndex = 13;
            cbEnableDescending.Text = "Enable Descending";
            cbEnableDescending.UseVisualStyleBackColor = false;
            cbEnableDescending.CheckedChanged += CbEnableDescending_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(16, 42);
            label2.Name = "label2";
            label2.Size = new Size(361, 20);
            label2.TabIndex = 10;
            label2.Text = "Please enter a number (N) to count from 1 to N";
            // 
            // endNumberInput
            // 
            endNumberInput.Cursor = Cursors.IBeam;
            endNumberInput.Font = new Font("Segoe UI", 9F);
            endNumberInput.Location = new Point(20, 89);
            endNumberInput.Margin = new Padding(3, 5, 3, 5);
            endNumberInput.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            endNumberInput.Name = "endNumberInput";
            endNumberInput.Size = new Size(205, 27);
            endNumberInput.TabIndex = 1;
            // 
            // btnStartCount
            // 
            btnStartCount.FlatStyle = FlatStyle.System;
            btnStartCount.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStartCount.Location = new Point(246, 89);
            btnStartCount.Margin = new Padding(3, 4, 3, 4);
            btnStartCount.Name = "btnStartCount";
            btnStartCount.Size = new Size(116, 27);
            btnStartCount.TabIndex = 2;
            btnStartCount.Text = "Count";
            btnStartCount.UseVisualStyleBackColor = true;
            btnStartCount.Click += BtnStartCount_Click;
            // 
            // NumberCounterControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Controls.Add(guna2Panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "NumberCounterControl";
            Size = new Size(749, 666);
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)endNumberInput).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel guna2Panel1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown endNumberInput;
        private System.Windows.Forms.Button btnStartCount;
        private System.Windows.Forms.CheckBox cbEnableDescending;
        private System.Windows.Forms.Button btnClear;
        private Panel panel2;
    }
}
