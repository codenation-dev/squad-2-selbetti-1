using System;
using System.Collections.Generic;
using System.Text;
using Codenation.ErrorCenter.Models;
using Codenation.ErrorCenter.Models.Models;

namespace Codenation.ErrorCenter.Services
{
    public class UserService : IUserService
    {
        private ErrorCenterContext context;

        public UserService(ErrorCenterContext context)
        {
            this.context = context;
        }

        public bool DeleteUserById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<User> FindAll()
        {
            throw new NotImplementedException();
        }

        public User FindById(int id)
        {
            throw new NotImplementedException();
        }

        public User FindByUser(User user)
        {
            return context.User.Find(user);
        }

        public User Save(User user)
        {
            throw new NotImplementedException();
        }
    }
}
