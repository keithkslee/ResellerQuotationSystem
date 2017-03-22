using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.IO;
using Common.Logging;
using IBatisNet.DataMapper;
using IBatisNet.DataAccess;
using AxtAspNetUtility;
using AxtReport;
using OfficeOpenXml;
using System.Data.OleDb;
using System.Data;
namespace ResellerQuotationSystem.ResellerQuotationSystem
{
    public class email_settings
    {
        public static void createTable()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable queryParams = new Hashtable();
            AxtCRUD.createTable("ResellerQuotationSystem.email_settings.createemail_settings", queryParams);
            AxtCRUD.createTable("ResellerQuotationSystem.email_settings.createemail_settingsHistory", queryParams);
        }

        public static string getemail_settings(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable totalCount = (Hashtable)Mapper.Instance().QueryForObject("ResellerQuotationSystem.email_settingsgetemail_settingsTotalCount", queryParams);
            return AxtCRUD.readJson("ResellerQuotationSystem.email_settings.getemail_settings", queryParams, "email_settings", totalCount["NUM"].ToString());
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
                    AxtCRUD.insert("ResellerQuotationSystem.email_settings.addData", data);

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

            AxtCRUD.update("ResellerQuotationSystem.email_settings.updateData", data);
            /*update user code start*/
            /*update user code end*/
        }

        public static void deleteAll()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable queryParams = new Hashtable();
            AxtCRUD.delete("ResellerQuotationSystem.email_settings.deleteAll", queryParams);
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
                    AxtCRUD.delete("ResellerQuotationSystem.email_settings.deleteData", data);
                    /*deleteData user code start*/
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
            /*beforeGenConf user code end*/
        }

        public static string getemail_settingsBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            if (null != queryParams["SENDERNAME_V"] && "" != queryParams["SENDERNAME_V"].ToString().Trim())
            {
                queryParams["SENDERNAME_V"] = "%" + queryParams["SENDERNAME_V"] + "%";
            }
            if (null != queryParams["SENDEREMAIL_V"] && "" != queryParams["SENDEREMAIL_V"].ToString().Trim())
            {
                queryParams["SENDEREMAIL_V"] = "%" + queryParams["SENDEREMAIL_V"] + "%";
            }
            if (null != queryParams["EMAILSERVER_V"] && "" != queryParams["EMAILSERVER_V"].ToString().Trim())
            {
                queryParams["EMAILSERVER_V"] = "%" + queryParams["EMAILSERVER_V"] + "%";
            }
            if (null != queryParams["SENDERACCOUNT_V"] && "" != queryParams["SENDERACCOUNT_V"].ToString().Trim())
            {
                queryParams["SENDERACCOUNT_V"] = "%" + queryParams["SENDERACCOUNT_V"] + "%";
            }
            if (null != queryParams["SENDERPASSWORD_V"] && "" != queryParams["SENDERPASSWORD_V"].ToString().Trim())
            {
                queryParams["SENDERPASSWORD_V"] = "%" + queryParams["SENDERPASSWORD_V"] + "%";
            }

            Hashtable totalCount = (Hashtable)Mapper.Instance().QueryForObject("ResellerQuotationSystem.email_settings.getemail_settingsByTotalCount", queryParams);
            return  AxtCRUD.readJson("ResellerQuotationSystem.email_settings.getemail_settingsBy", queryParams, "email_settings", totalCount["NUM"].ToString());
            /*appcode btnQuery user code start*/
            /*appcode btnQuery user code end*/
        }

        public static string saveStatus(string work_event,string status)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return "ERR_00004";
            }

            Hashtable data = new Hashtable();
            data["WORK_EVENT_V"] = work_event;
            data["STATUS_V"] = status;
            Hashtable queryParams = new Hashtable();
            queryParams["WORK_EVENT"] = "%" + work_event + "%";
            
            Hashtable totalCount = (Hashtable) Mapper.Instance().QueryForObject("ResellerQuotationSystem.email_settings.getWork_event",queryParams);
                if (totalCount == null )
                {
                    data["SID"] = AxtLibrary.GetUniqueKey(18);
                    AxtCRUD.insert("ResellerQuotationSystem.email_settings.addStatus",data);
                }
                else
                {
                    data["SID"] = AxtLibrary.GetUniqueKey(18);
                    AxtCRUD.update("ResellerQuotationSystem.email_settings.updateStatus",data);
                }
            return "ANS_00003";
        }
        /*user code start*/
        /*user code end*/
    }

}