using NetCore.Data.DataModels;
using NetCore.Data.ViewModels;
using NetCore.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCore.Services.Svcs
{
    public class UserService : IUser
    {
        #region private Methods
        private IEnumerable<Practice1_User> GetUserInfos()
        {
            return new List<Practice1_User>()
            {
                new Practice1_User()
                {
                    UserId = "root123",
                    UserName = "ROOT관리자",
                    UserEmail = "root@gmail.com",
                    Password = "root123"
                }
            };
        }

        private bool checkTheUserInfo(String userId, String passowrd)
        {
            return GetUserInfos().Where(u => u.UserId.Equals(userId) && u.Password.Equals(passowrd)).Any();
        }

        #endregion

        public bool MatchTheUserInfo(LoginInfo login)
        {
            return checkTheUserInfo(login.UserId, login.Password);
        }
    }
}
