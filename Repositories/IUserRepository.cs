using HandOnModelValidations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandOnModelValidations.Repositories
{
    internal interface IUserRepository
    {
        //declare functionalities of User Model
        void Register(User user);
        User Validate(Login login);
        List<User> GetAll();
        void Update(User user);
        void Delete(int userId);
    }
}
