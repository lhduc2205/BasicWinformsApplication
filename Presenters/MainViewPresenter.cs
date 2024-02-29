using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformsBasic.Views.Main;

namespace WinformsBasic.Presenters
{
    public class MainViewPresenter
    {
        private readonly IMainView _mainView;

        public MainViewPresenter(IMainView mainView)
        {
            _mainView = mainView;
            _mainView.Show();
        }
    }
}
