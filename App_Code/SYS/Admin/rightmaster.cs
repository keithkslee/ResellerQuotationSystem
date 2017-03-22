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

namespace ResellerQuotationSystem.SYS.Admin
{
    public class RightMaster
    {
        public static void createTable()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable queryParams = new Hashtable();
            AxtCRUD.createTable("SYS.Admin.RightMaster.createRightMaster", queryParams);
        }

        public static string getRightMaster()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("SYS.Admin.RightMaster.getRightMaster", queryParams, "RightMaster");
        }

        public static string saveData(ArrayList newData)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return "ERR_00004";
            }

            ISqlMapper sqlMap = Mapper.Instance();
            for (int i = 0, len = newData.Count; i < len; ++i)
            {
                Hashtable data = (Hashtable)newData[i];
                if (null == data["SID"] || "" == data["SID"])
                {
                    data["SID"] = AxtLibrary.GetUniqueKey(18);
                    AxtCRUD.insert("SYS.Admin.RightMaster.addData", data);

                    /*saveData user code start*/
                    data.Add("USERID", HttpContext.Current.Session["CurrentUser"].ToString());
                    AxtCRUD.insert("SYS.Admin.RightMaster.addMenuTree", data);
                    /*saveData user code end*/
                }
                else
                {
                    update(data);
                }
            }

            return "ANS_00003";
        }

        public static void update(Hashtable data)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            AxtCRUD.update("SYS.Admin.RightMaster.updateData", data);
            /*update user code start*/
            data.Add("USERID", HttpContext.Current.Session["CurrentUser"].ToString());
            AxtCRUD.update("SYS.Admin.RightMaster.updateMenuTree", data);
            /*update user code end*/
        }

        public static void deleteAll()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable queryParams = new Hashtable();
            AxtCRUD.delete("SYS.Admin.RightMaster.deleteAll", queryParams);
        }

        public static string deleteData(ArrayList deleteData)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return "ERR_00004";
            }

            ISqlMapper sqlMap = Mapper.Instance();
            for (int i = 0, len = deleteData.Count; i < len; ++i)
            {
                Hashtable data = (Hashtable)deleteData[i];
                if (null != data["SID"] && "" != data["SID"])
                {
                    AxtCRUD.delete("SYS.Admin.RightMaster.deleteData", data);
                    /*deleteData user code start*/
                    AxtCRUD.delete("SYS.Admin.RightMaster.deleteMenuTree", data);
                    /*deleteData user code end*/
                }
            }

            return "ANS_00004";
        }

        public static void beforeGenConf()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            /*beforeGenConf user code start*/
			deleteAll();
            Hashtable queryParams = new Hashtable();
            AxtCRUD.beforeGenConf("SYS.Admin.RightMaster.beforeGenConf", queryParams);
            /*beforeGenConf user code end*/
        }

        /*user code start*/
        public static string getMainMenu()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("SYS.Admin.RightMaster.getMainMenu", queryParams, "RightMaster");
        }

        public static string getSubMenu()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("SYS.Admin.RightMaster.getSubMenu", queryParams, "RightMaster");
        }

        public static string getRightMasterBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            if ((null == queryParams["SUB_MENU"] || "" == queryParams["SUB_MENU"].ToString().Trim()) &&
                (null != queryParams["MENU_ITEM"] && "" != queryParams["MENU_ITEM"].ToString().Trim()))
            {
                return AxtCRUD.readJson("SYS.Admin.RightMaster.getRightMasterByMenuItem", queryParams, "RightMaster");
            }

            if ((null != queryParams["SUB_MENU"] && "" != queryParams["SUB_MENU"].ToString().Trim()) &&
                (null == queryParams["MENU_ITEM"] || "" == queryParams["MENU_ITEM"].ToString().Trim()))
            {
                return AxtCRUD.readJson("SYS.Admin.RightMaster.getRightMasterBySubMenu", queryParams, "RightMaster");
            }

            if ((null == queryParams["SUB_MENU"] || "" == queryParams["SUB_MENU"].ToString().Trim()) &&
                (null == queryParams["MENU_ITEM"] || "" == queryParams["MENU_ITEM"].ToString().Trim()))
            {
                return getRightMaster();
            }

            return AxtCRUD.readJson("SYS.Admin.RightMaster.getRightMasterByAll", queryParams, "RightMaster");
        }
        /*user code end*/
    }
}