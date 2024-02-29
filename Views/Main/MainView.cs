using System;
using System.Windows.Forms;
using WinformsBasic.UserControls;

namespace WinformsBasic.Views.Main
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
            AssociateAndRiseViewEvents();
        }

        private void AssociateAndRiseViewEvents()
        {
            
        }

        private void MainView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BtnNumberCounter_Click(object sender, EventArgs e)
        {
            NumberCounterControl countNumberControl = NumberCounterControl.GetInstance();
            AddUserControl(countNumberControl);
        }

        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void SumCalculator_Click(object sender, EventArgs e)
        {
            SumCalculatorControl sumCalculatorControl = new SumCalculatorControl();
            AddUserControl(sumCalculatorControl);
        }
    }
}
