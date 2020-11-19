using DAL;

namespace UnitTestProject
{
    internal class UserRepositoryStub : IUserRepository
    {
        /// <summary>
        /// I added this extra boolean for an unhappy scenario, to show you can extend the sub.
        /// </summary>
        public bool IsHappy { get; set; }

        public User FindById(int id)
        {
            if (!IsHappy)
                return null;
            var user = new User { Id = 1, UserName = "Helmer" };
            return user;
        }

        public void AddUser(User user)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateUser(User user)
        {
            throw new System.NotImplementedException();
        }
    }
}