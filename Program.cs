using WinformsBasic.Presenters;
using WinformsBasic.Repositories.Impl;
using WinformsBasic.Repositories;
using WinformsBasic.Views;
using WinformsBasic.Views.Login;

namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            ILoginView loginView = new LoginView();
            IUserRepository userRepository = new UserRepository();
            _ = new LoginPresenter(loginView, userRepository);
            Application.Run((Form)loginView);
        }
    }
}