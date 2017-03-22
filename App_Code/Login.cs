using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using IBatisNet.DataMapper;
using IBatisNet.DataAccess;
using AxtAspNetUtility;

namespace ResellerQuotationSystem
{
    public class Login
    {
        public static String check(Hashtable user)
        {
            string ret = AxtLoginCheck.check(user);
            if (ret == "ANS_00001")
            {
                HttpContext.Current.Session["CurrentUser"] = user["account"].ToString();
                HttpContext.Current.Session["LoginTime"] = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            }
            return ret;
        }

        public static Boolean isLogin()
        {
            return AxtLoginCheck.isLogin();
        }

        public static string getLoginPassword(Hashtable user)
        {
            return AxtLoginCheck.getLoginPassword(user);
        }

        public static string getLoginIP(string account)
        {
            return AxtLoginCheck.getLoginIP(account);
        }

        public static string Logout()
        {
            return AxtLoginCheck.Logout();
        }
    }
}