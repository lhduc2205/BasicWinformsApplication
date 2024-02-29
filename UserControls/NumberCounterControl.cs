using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WinformsBasic.UserControls
{
    public partial class NumberCounterControl : UserControl
    {
        private List<int> counterNumbers = new List<int>();
        private bool isAscending = true;
        private static NumberCounterControl instance;

        public static NumberCounterControl GetInstance()
        {
            if (instance == null)
            {
                instance = new NumberCounterControl();
            }
            else
            {
                instance.BringToFront();
            }

            return instance;
        }

        public NumberCounterControl()
        {
            InitializeComponent();
        }

        private void PopulateCounterNumbers(decimal endNumber)
        {
            counterNumbers.Clear();

            for (int i = 1; i <= Math.Round(endNumber); i++)
            {
                counterNumbers.Add(i);
            }
        }

        private void UpdateTxtResult()
        {
            txtResult.Text = string.Join(" ", counterNumbers);
        }

        private void BtnStartCount_Click(object sender, EventArgs e)
        {
            PopulateCounterNumbers(endNumberInput.Value);
            SortCounterResult(isAscending);
            UpdateTxtResult();
        }

        private void SortCounterResult(bool ascending = true)
        {
            if (ascending)
            {
                counterNumbers = counterNumbers.OrderBy(n => n).ToList();
            }
            else
            {
                counterNumbers = counterNumbers.OrderByDescending(n => n).ToList();
            }
        }

        private void CbEnableDescending_CheckedChanged(object sender, EventArgs e)
        {
            isAscending = !cbEnableDescending.Checked;
            cbEnableDescending.ForeColor = isAscending ? Color.FromArgb(51, 65, 85) : Color.Black;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = string.Empty;
        }
    }
}
