using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BSBll
{
    public class UsersBll
    {
        public static List<BSModel.Users> UsersList()
        {
            return BSDal.UsersDal.UsersList();
        }
        public static BSModel.Users GetUser(int id)
        {
            return BSDal.UsersDal.GetUser(id);
        }
        public static bool Add(BSModel.Users user)
        {
            return BSDal.UsersDal.Add(user);
        }
        public static bool Search(string username)
        {
            return BSDal.UsersDal.Search(username);
        }
        public static bool Login(string username, string password)
        {
            return BSDal.UsersDal.Login(username, password);
        }
        public static bool DelUser(int id)
        {
            return BSDal.UsersDal.DelUser(id);
        }
        public static bool UpUser(BSModel.Users user)
        {
            return BSDal.UsersDal.UpUser(user);
        }
        public static BSModel.Users GetUser(string username)
        {
            return BSDal.UsersDal.GetUser(username);
        }
    }
}
