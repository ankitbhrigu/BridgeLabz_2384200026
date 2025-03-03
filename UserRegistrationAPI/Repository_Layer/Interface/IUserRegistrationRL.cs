using Repository_Layer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Layer.Interface
{
    public interface IUserRegistrationRL
    {
        void RegisterUser(UserEntity user);
    }
}
