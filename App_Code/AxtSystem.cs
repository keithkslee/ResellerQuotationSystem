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
    public class AxtSystem
    {
        public static void setLang(string lang)
        {
            AxtMutiLang.setLang(lang);
        }

        public static string getLang(string lang)
        {
            return AxtMutiLang.getLang(lang);
        }

        public static string getMenuTreeSid(string currentrule)
        {
            return AxtMenuTree.getMenuTreeSid(currentrule);
        }

        public static string getGuiPath(string menu_tree_sid)
        {
            return AxtMenuTree.getGuiPath(menu_tree_sid);
        }
    }
}