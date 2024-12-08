using group2_sample.Contract.Repository;
using group2_sample.Data;
using group2_sample.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group2_sample.Repository
{
    public class UserRepository : IUserRepository
    {

        private readonly AppDbContext _context;

        public UserRepository()
        {
            _context = new AppDbContext();
        }

        public void Add(User user)
        {
            _context.Add(user);
            _context.SaveChanges();
            
            
        }

        public User GetUserById(string userName)
        {
            var u = _context.users.FirstOrDefault(u => u.UserName == userName);
            if(u is not null)
            {
                return u;   
            }
            return null;

        }
    }
}
