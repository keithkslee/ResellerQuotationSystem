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
    public class UserInfo
    {
        public static String getUserName()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return "God";
            }

            Hashtable queryParams = new Hashtable();
            queryParams.Add("account", HttpContext.Current.Session["CurrentUser"].ToString());
            return AxtUserInfo.getUserName(queryParams);
        }

        public static String getUserIP()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return "";
            }

            return HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"].ToString();
        }

        public static String getUserLoginTime()
        {
            if (HttpContext.Current.Session["LoginTime"] == null)
            {
                return "I don't know";
            }

            return HttpContext.Current.Session["LoginTime"].ToString();
        }

        public static String getUserHomePage()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            queryParams.Add("account", HttpContext.Current.Session["CurrentUser"].ToString());
            return AxtUserInfo.getUserHomePage(queryParams);
        }
    }
}