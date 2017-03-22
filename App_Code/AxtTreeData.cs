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
    public class AxtTreeData
    {
        public static ArrayList getMainMenu()
        {
            return AxtMenuTree.getMainMenu();
        }

        public static ArrayList getMainMenuByUser()
        {
            return AxtMenuTree.getMainMenuByUser();
        }

        public static ArrayList getSubMenu(Hashtable queryParams)
        {
            return AxtMenuTree.getSubMenu(queryParams);
        }

        public static ArrayList getSubMenuByUser(Hashtable queryParams)
        {
            return AxtMenuTree.getSubMenuByUser(queryParams);
        }

        public static ArrayList getMenuItems(Hashtable queryParams)
        {
            return AxtMenuTree.getMenuItems(queryParams);
        }

        public static ArrayList getMenuItemsByUser(Hashtable queryParams)
        {
            return AxtMenuTree.getMenuItemsByUser(queryParams);
        }

        public static ArrayList getChiLinMenuItems(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return (ArrayList)Mapper.Instance().QueryForList("AxtTreeData.getChiLinMenuItems", queryParams);
        }

        public static ArrayList getChiLinMenuItemsByUser(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            if (HttpContext.Current.Session["SuperAdmin"] == null)
            {
                queryParams.Add("account", HttpContext.Current.Session["CurrentUser"].ToString());
                return (ArrayList)Mapper.Instance().QueryForList("AxtTreeData.getChiLinMenuItemsByUser", queryParams);
            }

            return getChiLinMenuItems(queryParams);
        }
    }
}