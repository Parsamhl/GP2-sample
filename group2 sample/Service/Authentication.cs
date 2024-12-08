using group2_sample.Contract;
using group2_sample.Contract.Repository;
using group2_sample.Entity;
using group2_sample.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group2_sample.Service
{
    public class Authentication : IAuthentication
    {

        private readonly IUserRepository _userRepository;

        public Authentication()
        {
            _userRepository = new UserRepository();
        }

        public bool Login(string userName, string password)
        {
            var u = _userRepository.GetUserById(userName);
            if (userName == u.UserName && password == u.Password)
            {
                return true;
            }
            return false;

        }

        public void Register(User User)
        {
            User = new User { UserName = User.UserName, Password = User.Password , 
                Age = User.Age , LastName = User.LastName , Name = User.Name};

            _userRepository.Add(User);


        }
    }
}
