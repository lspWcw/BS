using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BSDal
{
    //用户访问类
    public class UsersDal
    {
        //添加用户
        public static bool Add(BSModel.Users user)
        {
            bool result = false;
            string strsql = "insert into t_users (username,password,name,address,sex,mobile,state,addtime)values('" + user.username + "','" + user.password + "','" + user.name + "','" + user.address + "','" + user.sex + "','" + user.mobile + "','" + user.state + "','" + user.addtime + "')";
            int i = BSUtility.MsSqlHelper.ExecuteSql(strsql);
            if (i > 0)
            {
                return true;
            }
            return result;
        }
        //判断用户存不存在
        public static bool Search(string username)
        {
            bool result = false;
            string strsql = "select * from t_users where username = '" + username + "'";
            DataTable dataTable = BSUtility.MsSqlHelper.Query(strsql).Tables[0];
            if (dataTable.Rows.Count == 0)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
        //登录
        public static bool Login(string username, string password)
        {
            bool result = false;
            string strsql = "select * from t_users where username = '" + username + "'and password = '" + password + "'";
            DataTable dataTable = BSUtility.MsSqlHelper.Query(strsql).Tables[0];
            if (dataTable.Rows.Count != 0)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
        //用户管理
        public static List<BSModel.Users> DtToList(DataTable dataTable)
        {
            List<BSModel.Users> list = new List<BSModel.Users>();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                BSModel.Users user = new BSModel.Users();
                user.id = Convert.ToInt32(dataTable.Rows[i]["id"].ToString());
                user.username = dataTable.Rows[i]["username"].ToString();
                user.password = dataTable.Rows[i]["password"].ToString();
                user.name = dataTable.Rows[i]["name"].ToString();
                user.address = dataTable.Rows[i]["address"].ToString();
                user.sex = Convert.ToInt32(dataTable.Rows[i]["sex"]);
                user.mobile = dataTable.Rows[i]["mobile"].ToString();
                user.state = Convert.ToInt32(dataTable.Rows[i]["state"]);
                user.addtime = DateTime.Parse(dataTable.Rows[i]["addtime"].ToString());
                list.Add(user);
            }
            return list;
        }
        public static List<BSModel.Users> UsersList()
        {
            string strsql = "select * from t_users order by id";
            DataTable dataTable = BSUtility.MsSqlHelper.Query(strsql).Tables[0];
            return DtToList(dataTable);
        }
        public static BSModel.Users GetUser(int id)
        {
            string strsql = "select * from t_users where id = '" + id + "' order by id";
            DataTable dataTable = BSUtility.MsSqlHelper.Query(strsql).Tables[0];
            BSModel.Users user = new BSModel.Users();
            user.id = Convert.ToInt32(dataTable.Rows[0]["id"].ToString());
            user.username = dataTable.Rows[0]["username"].ToString();
            user.password = dataTable.Rows[0]["password"].ToString();
            user.name = dataTable.Rows[0]["name"].ToString();
            user.address = dataTable.Rows[0]["address"].ToString();
            user.sex = Convert.ToInt32(dataTable.Rows[0]["sex"].ToString());
            user.mobile = dataTable.Rows[0]["mobile"].ToString();
            user.state = Convert.ToInt32(dataTable.Rows[0]["state"]);
            user.addtime = DateTime.Parse(dataTable.Rows[0]["addtime"].ToString());
            return user;
        }
        public static BSModel.Users GetUser(string username)
        {
            string strsql = "select * from t_users where username = '" + username + "' order by id";
            DataTable dataTable = BSUtility.MsSqlHelper.Query(strsql).Tables[0];
            BSModel.Users user = new BSModel.Users();
            user.id = Convert.ToInt32(dataTable.Rows[0]["id"].ToString());
            user.username = dataTable.Rows[0]["username"].ToString();
            user.password = dataTable.Rows[0]["password"].ToString();
            user.name = dataTable.Rows[0]["name"].ToString();
            user.address = dataTable.Rows[0]["address"].ToString();
            user.sex = Convert.ToInt32(dataTable.Rows[0]["sex"].ToString());
            user.mobile = dataTable.Rows[0]["mobile"].ToString();
            user.state = Convert.ToInt32(dataTable.Rows[0]["state"]);
            user.addtime = DateTime.Parse(dataTable.Rows[0]["addtime"].ToString());
            return user;
        }
        public static bool DelUser(int id)
        {
            bool result = false;
            string strsql = "delete from t_users where id = " + id + "";
            int i = BSUtility.MsSqlHelper.ExecuteSql(strsql);
            if (i > 0)
            {
                return true;
            }
            return result;
        }
        public static bool UpUser(BSModel.Users user)
        {
            bool result = false;
            string strsql = "update t_users set password='" + user.password + "',name='" + user.name +
                "',address='" + user.address + "',sex='" + user.sex + "',mobile='" + user.mobile + "',state='"
                + user.state + "' where id = '" + user.id + "'";
            int i = BSUtility.MsSqlHelper.ExecuteSql(strsql);
            if (i > 0)
            {
                return true;
            }
            return result;
        }
    }
}
