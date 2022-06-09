using Microsoft.AspNetCore.Identity;
using Movies.Models;
using System.Threading.Tasks;

namespace Movies.Repositories
{
    public interface IAccountRepository
    {
        Task<IdentityResult> CreateUser(RegisterModel registerModel);
        Task<SignInResult> PasswordSignIn(LoginModel loginModel);
        Task SignOut();
    }
}
