using System;
using System.Linq;

namespace DAL
{
    public class UserRepository : IUserRepository
    {
        private readonly DbContext _context;

        public User FindById(int id)
        {
           return _context.Users.SingleOrDefault(ctx => ctx.Id.Equals(id));
        }

        public void AddUser(User user)
        {
            _context.Users.Add(user);
        }

        public void UpdateUser(User user)
        {
            _context.Users.Update(user);
        }
    }
}
