using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformsBasic.Views.Login
{
    public interface ILoginView
    {
        string Username { get; set; }
        string Password { get; set; }

        event EventHandler LoginEvent;

        void Hide();
    }
}
