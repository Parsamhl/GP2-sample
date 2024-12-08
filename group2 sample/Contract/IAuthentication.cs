using group2_sample.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group2_sample.Contract
{
    public interface IAuthentication
    {
        public bool Login(string userName, string password);
        public void Register(User User);

    }
}
