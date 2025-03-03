using Microsoft.Extensions.Logging;
using Repository_Layer.Context;
using Repository_Layer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using Repository_Layer.Interface;

namespace Repository_Layer.Service
{
    public class UserRegistrationRL : IUserRegistrationRL
    {
        private readonly UserContext _dbContext;
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public UserRegistrationRL(UserContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void RegisterUser(UserEntity user)
        {
            try
            {
                _dbContext.Users.Add(user);
                _dbContext.SaveChanges();
                logger.Info("User registered successfully: " + user.Email);
            }
            catch (Exception ex)
            {
                logger.Error("Error in RegisterUser: " + ex.Message);
                throw;
            }
        }
    }
}
