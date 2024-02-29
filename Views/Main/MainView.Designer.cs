namespace WinformsBasic.Views.Main
{
    partial class MainView
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
            btnCountNumber = new Button();
            sumCalculator = new Button();
            panel1 = new Panel();
            panelContainer = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            panelContainer.SuspendLayout();
            SuspendLayout();
            // 
            // btnCountNumber
            // 
            btnCountNumber.BackColor = Color.FromArgb(29, 78, 216);
            btnCountNumber.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCountNumber.ForeColor = Color.White;
            btnCountNumber.Location = new Point(11, 65);
            btnCountNumber.Margin = new Padding(3, 4, 3, 4);
            btnCountNumber.Name = "btnCountNumber";
            btnCountNumber.Size = new Size(194, 56);
            btnCountNumber.TabIndex = 2;
            btnCountNumber.Text = "Number Counter";
            btnCountNumber.UseVisualStyleBackColor = false;
            btnCountNumber.Click += BtnNumberCounter_Click;
            // 
            // sumCalculator
            // 
            sumCalculator.BackColor = Color.FromArgb(29, 78, 216);
            sumCalculator.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sumCalculator.ForeColor = Color.White;
            sumCalculator.Location = new Point(11, 144);
            sumCalculator.Margin = new Padding(3, 4, 3, 4);
            sumCalculator.Name = "sumCalculator";
            sumCalculator.Size = new Size(194, 56);
            sumCalculator.TabIndex = 3;
            sumCalculator.Text = "Sum Calculator";
            sumCalculator.UseVisualStyleBackColor = false;
            sumCalculator.Click += SumCalculator_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(sumCalculator);
            panel1.Controls.Add(btnCountNumber);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 666);
            panel1.TabIndex = 0;
            // 
            // panelContainer
            // 
            panelContainer.Controls.Add(label1);
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(220, 0);
            panelContainer.Margin = new Padding(3, 4, 3, 4);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(751, 666);
            panelContainer.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(157, 86);
            label1.Name = "label1";
            label1.Size = new Size(436, 29);
            label1.TabIndex = 0;
            label1.Text = "Choose program on the left side to go";
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(971, 666);
            Controls.Add(panelContainer);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main View";
            FormClosing += MainView_FormClosing;
            panel1.ResumeLayout(false);
            panelContainer.ResumeLayout(false);
            panelContainer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnCountNumber;
        private System.Windows.Forms.Button sumCalculator;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Label label1;
    }
}