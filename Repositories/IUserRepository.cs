using WinformsBasic.Models.Entities;

namespace WinformsBasic.Repositories
{
    public interface IUserRepository
    {
        bool Login(string username, string password);
        bool Register(User user);
    }
}
