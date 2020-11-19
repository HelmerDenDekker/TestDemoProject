namespace DAL
{
    public interface IUserRepository
    {
        public User FindById(int id);

        public void AddUser(User user);
       public void UpdateUser(User user);
    }
}