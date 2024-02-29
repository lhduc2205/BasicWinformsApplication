namespace WinformsBasic.UserControls
{
    partial class SumCalculatorControl
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
            panel1 = new Panel();
            RadioButtonFormula = new RadioButton();
            RadioButtonUsingLinq = new RadioButton();
            RadioButtonWhileLoopType = new RadioButton();
            label3 = new Label();
            RadioButtonForLoopType = new RadioButton();
            label2 = new Label();
            endNumberInput = new NumericUpDown();
            btnCalculate = new Button();
            guna2Panel1 = new Panel();
            txtResult = new TextBox();
            btnClear = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)endNumberInput).BeginInit();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(RadioButtonFormula);
            panel1.Controls.Add(RadioButtonUsingLinq);
            panel1.Controls.Add(RadioButtonWhileLoopType);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(RadioButtonForLoopType);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(endNumberInput);
            panel1.Controls.Add(btnCalculate);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(745, 332);
            panel1.TabIndex = 3;
            // 
            // RadioButtonFormula
            // 
            RadioButtonFormula.AutoSize = true;
            RadioButtonFormula.Location = new Point(152, 251);
            RadioButtonFormula.Margin = new Padding(3, 4, 3, 4);
            RadioButtonFormula.Name = "RadioButtonFormula";
            RadioButtonFormula.Size = new Size(79, 24);
            RadioButtonFormula.TabIndex = 6;
            RadioButtonFormula.Text = "Fomula";
            RadioButtonFormula.UseVisualStyleBackColor = true;
            RadioButtonFormula.Click += RadioButtonFormula_Click;
            // 
            // RadioButtonUsingLinq
            // 
            RadioButtonUsingLinq.AutoSize = true;
            RadioButtonUsingLinq.Location = new Point(152, 219);
            RadioButtonUsingLinq.Margin = new Padding(3, 4, 3, 4);
            RadioButtonUsingLinq.Name = "RadioButtonUsingLinq";
            RadioButtonUsingLinq.Size = new Size(63, 24);
            RadioButtonUsingLinq.TabIndex = 4;
            RadioButtonUsingLinq.Text = "LINQ";
            RadioButtonUsingLinq.UseVisualStyleBackColor = true;
            RadioButtonUsingLinq.Click += RadioButtonUsingLinq_Click;
            // 
            // RadioButtonWhileLoopType
            // 
            RadioButtonWhileLoopType.AutoSize = true;
            RadioButtonWhileLoopType.Location = new Point(20, 251);
            RadioButtonWhileLoopType.Margin = new Padding(3, 4, 3, 4);
            RadioButtonWhileLoopType.Name = "RadioButtonWhileLoopType";
            RadioButtonWhileLoopType.Size = new Size(103, 24);
            RadioButtonWhileLoopType.TabIndex = 5;
            RadioButtonWhileLoopType.Text = "While loop";
            RadioButtonWhileLoopType.UseVisualStyleBackColor = true;
            RadioButtonWhileLoopType.Click += RadioButtonWhileLoopType_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(17, 183);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 11;
            label3.Text = "Option:";
            // 
            // RadioButtonForLoopType
            // 
            RadioButtonForLoopType.AutoSize = true;
            RadioButtonForLoopType.Checked = true;
            RadioButtonForLoopType.Location = new Point(20, 219);
            RadioButtonForLoopType.Margin = new Padding(3, 4, 3, 4);
            RadioButtonForLoopType.Name = "RadioButtonForLoopType";
            RadioButtonForLoopType.Size = new Size(86, 24);
            RadioButtonForLoopType.TabIndex = 3;
            RadioButtonForLoopType.TabStop = true;
            RadioButtonForLoopType.Text = "For loop";
            RadioButtonForLoopType.UseVisualStyleBackColor = true;
            RadioButtonForLoopType.Click += RadioButtonForLoopType_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(16, 44);
            label2.Name = "label2";
            label2.Size = new Size(387, 20);
            label2.TabIndex = 10;
            label2.Text = "Please enter a number (N) to calculate from 1 to N";
            // 
            // endNumberInput
            // 
            endNumberInput.Cursor = Cursors.IBeam;
            endNumberInput.Font = new Font("Segoe UI", 9F);
            endNumberInput.Location = new Point(20, 91);
            endNumberInput.Margin = new Padding(3, 5, 3, 5);
            endNumberInput.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            endNumberInput.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            endNumberInput.Name = "endNumberInput";
            endNumberInput.Size = new Size(205, 27);
            endNumberInput.TabIndex = 1;
            endNumberInput.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnCalculate
            // 
            btnCalculate.FlatStyle = FlatStyle.System;
            btnCalculate.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalculate.Location = new Point(248, 86);
            btnCalculate.Margin = new Padding(3, 4, 3, 4);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(116, 35);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += BtnCalculate_Click;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = SystemColors.Control;
            guna2Panel1.Controls.Add(txtResult);
            guna2Panel1.Controls.Add(btnClear);
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.Dock = DockStyle.Bottom;
            guna2Panel1.Location = new Point(0, 340);
            guna2Panel1.Margin = new Padding(3, 4, 3, 4);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.Size = new Size(745, 326);
            guna2Panel1.TabIndex = 14;
            // 
            // txtResult
            // 
            txtResult.BackColor = Color.FromArgb(2, 6, 23);
            txtResult.BorderStyle = BorderStyle.None;
            txtResult.Cursor = Cursors.IBeam;
            txtResult.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtResult.ForeColor = Color.White;
            txtResult.Location = new Point(16, 53);
            txtResult.Margin = new Padding(3, 5, 3, 5);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.ScrollBars = ScrollBars.Vertical;
            txtResult.Size = new Size(719, 244);
            txtResult.TabIndex = 11;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(653, 6);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(82, 32);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += BtnClear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 0;
            label1.Text = "Result";
            // 
            // SumCalculatorControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(guna2Panel1);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SumCalculatorControl";
            Size = new Size(745, 666);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)endNumberInput).EndInit();
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown endNumberInput;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RadioButton RadioButtonForLoopType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton RadioButtonWhileLoopType;
        private System.Windows.Forms.RadioButton RadioButtonFormula;
        private System.Windows.Forms.RadioButton RadioButtonUsingLinq;
        private TextBox txtResult;
    }
}
