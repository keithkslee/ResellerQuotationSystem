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
    public class AxtMutiLanguage
    {
        public static ArrayList getLanguage()
        {
            return AxtMutiLang.getLangs();
        }

        public static ArrayList getMainMenuLangs()
        {
            return AxtMutiLang.getMainMenuLangs();
        }

        public static ArrayList getSubMenuLangs()
        {
            return AxtMutiLang.getSubMenuLangs();
        }

        public static ArrayList getMenuItemsLangs()
        {
            return AxtMutiLang.getMenuItemsLangs();
        }

        public static ArrayList getChiLinMenuItemsLangs()
        {
            return (ArrayList)Mapper.Instance().QueryForList("AxtMutiLang.getChiLinMenuItemsLangs", 1);
        }
    }
}