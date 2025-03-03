using BusinessLayer.Interface;
using Repository_Layer.Entity;
using Repository_Layer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using Microsoft.Extensions.Logging;
using Repository_Layer.Service;


namespace BusinessLayer.Service
{
    public class UserRegistrationBL : IUserRegistrationBL
    {
        private readonly IUserRegistrationRL _userRl;

        private static Logger logger = LogManager.GetCurrentClassLogger();

        public UserRegistrationBL(IUserRegistrationRL _userRl)
        {
            this._userRl = _userRl;
        }

        public void Register(UserEntity user)
        {
            try
            {
                _userRl.RegisterUser(user);
                logger.Info("User registered in Business Layer: " + user.Email);
            }
            catch (Exception ex)
            {
                logger.Error("Error in Register: " + ex.Message);
                throw;
            }
        }
    }
}
