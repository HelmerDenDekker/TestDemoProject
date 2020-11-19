using Model.DalRepositories;

namespace TestDemoProject
{
    public class UserLogic : IUserLogic
    {
        private readonly IUserRepository _userRepository;

        public UserLogic(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        /// <summary>
        /// Query style
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public UserInfoDto GetUserInfo(int userId)
        {
            var user= _userRepository.FindById(userId);
            var userInfoDto = new UserInfoDto
            {
                UserId = user.Id,
                UserName = user.UserName
            };
            return userInfoDto;
        }

        /// <summary>
        /// Command style
        /// </summary>
        /// <param name="newUser"></param>
        public void AddNewUser(NewUserDto newUser)
        {
            var user = new User { UserName = newUser.UserName };
            _userRepository.AddUser(user);
        }

        /// <summary>
        /// Mixing command style and query style, since we want to return the new data to the FE
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        public UserInfoDto UpdateUserInfo(UserInfoDto userInfo)
        {
            var user = new User {Id = userInfo.UserId, UserName = userInfo.UserName};
            _userRepository.UpdateUser(user);
            return GetUserInfo(userInfo.UserId);
        }

    }


}
