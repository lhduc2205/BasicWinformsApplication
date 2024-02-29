using System;
using System.Windows.Forms;
using WinformsBasic.Views.Login;
using WinformsBasic.Views.Main;

namespace WinformsBasic.Views
{
    public partial class LoginView : Form, ILoginView
    {
        public string Username { get => txtUsername.Text; set => txtUsername.Text = value; }
        public string Password { get => txtPassword.Text; set => txtPassword.Text = value; }

        public event EventHandler LoginEvent;

        public LoginView()
        {
            InitializeComponent();
            AssociateAndRiseViewEvents();
        }

        private void AssociateAndRiseViewEvents()
        {
            btnLogin.Click += delegate { LoginEvent?.Invoke(this, EventArgs.Empty); };
        }


        private void CbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = cbShowPassword.Checked ? '\0' : '*';
        }
    }
}
