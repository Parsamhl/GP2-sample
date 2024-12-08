using group2_sample.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group2_sample.Contract.Repository
{
    public interface IUserRepository
    {
        User GetUserById (string userName);
        void Add (User user);

    }
}
