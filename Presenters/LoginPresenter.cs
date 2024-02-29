using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformsBasic.Repositories;
using WinformsBasic.Views.Login;
using WinformsBasic.Views.Main;

namespace WinformsBasic.Presenters
{
    public class LoginPresenter
    {
        private readonly ILoginView _loginView;
        private readonly IUserRepository _userRepository;

        public LoginPresenter(ILoginView loginView, IUserRepository userRepository)
        {
            _loginView = loginView;
            _userRepository = userRepository;

            _loginView.LoginEvent += Login;
        }

        private void Login(object sender, EventArgs e)
        {
            bool isCorrect = _userRepository.Login(_loginView.Username, _loginView.Password);

            if (isCorrect)
            {
                ShowMainView();
                _loginView.Hide();
            } else
            {
                MessageBox.Show("Incorrect Username or Password!!!", "Invalid Credential");
            }
        }

        private void ShowMainView()
        {
            IMainView mainView = new MainView();
            new MainViewPresenter(mainView);
            mainView.Show();
        }
    }
}
