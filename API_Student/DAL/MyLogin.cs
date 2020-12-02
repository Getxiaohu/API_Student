using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using API_Student.Models;

namespace API_Student.DAL
{
    public class MyLogin
    {
        public LoginInfo GetLogin(string name,string pwd)
        {
            string sql = $"select Count(*) from Login where LUser='{name}' and Lpwd='{pwd}'";
            return DBHelper.GetList<LoginInfo>(sql).FirstOrDefault();           
        }
    }
}