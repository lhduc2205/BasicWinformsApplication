using System;
using WinformsBasic.Models;
using WinformsBasic.Models.Entities;

namespace WinformsBasic.Repositories.Impl
{
    public class UserRepository : IUserRepository
    {

        bool IUserRepository.Login(string username, string password)
        {
            return true;
            if (username.Equals("lhduc") && password.Equals("123456"))
            {
                return true;
            }
            return false;
        }


        bool IUserRepository.Register(User user)
        {
            return false;
        }
    }
}
