using Model;

namespace TestDemoProject
{
    public interface IUserLogic
    {

        public UserInfoDto GetUserInfo(int userId);

        public void AddNewUser(NewUserDto newUser);

        public UserInfoDto UpdateUserInfo(UserInfoDto userInfo);

    }
}