using HandOnModelValidations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HandOnModelValidations.Repositories
{
    public class UserRepository : IUserRepository
    {
        public static List<User> users = new List<User>()
        {
            new User(){Id=6787,Name="Virat",Age=23,Country="Inida",Gender="Male",Password="12345",
                Email="virat@gmail.com",Mobile="9876756789"}
        };
        public void Delete(int userId)
        {
            var user=users.SingleOrDefault(x=>x.Id==userId);    
            users.Remove(user);
        }

        public List<User> GetAll()
        {
           return users;
        }

        public void Register(User user)
        {
           users.Add(user);
        }

        public void Update(User user)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if(users[i].Id==user.Id)
                {
                    users[i].Email = user.Email;
                    users[i].Mobile = user.Mobile;
                    users[i].Country = user.Country;
                    users[i].Age = user.Age;
                }
            }
        }

        public User Validate(Login login)
        {
            var user=users.SingleOrDefault(x=>x.Email==login.Email && x.Password==login.Password);
            return user;
        }
    }
}