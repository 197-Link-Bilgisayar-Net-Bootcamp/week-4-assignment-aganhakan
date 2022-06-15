using JWT.Auth.WebAPI.Entities;
using JWT.Auth.WebAPI.Models;

namespace JWT.Auth.WebAPI.Services
{
    public interface IUserService
    {
        AuthenticateResponse Authenticate(AuthenticateRequest model);
        IEnumerable<User> GetAll();
        User GetById(int id);
    }

}
