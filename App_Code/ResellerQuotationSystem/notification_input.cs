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
    public class notification_input
    {
        public static void createTable()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable queryParams = new Hashtable();
            AxtCRUD.createTable("ResellerQuotationSystem.notification_input.createnotification_input", queryParams);
            AxtCRUD.createTable("ResellerQuotationSystem.notification_input.createnotification_inputHistory", queryParams);
        }

        public static string getnotification_input(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable totalCount = (Hashtable)Mapper.Instance().QueryForObject("ResellerQuotationSystem.notification_inputgetnotification_inputTotalCount", queryParams);
            return AxtCRUD.readJson("ResellerQuotationSystem.notification_input.getnotification_input", queryParams, "notification_input", totalCount["NUM"].ToString());
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
                    AxtCRUD.insert("ResellerQuotationSystem.notification_input.addData", data);

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

            AxtCRUD.update("ResellerQuotationSystem.notification_input.updateData", data);
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
            AxtCRUD.delete("ResellerQuotationSystem.notification_input.deleteAll", queryParams);
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
                    AxtCRUD.delete("ResellerQuotationSystem.notification_input.deleteData", data);
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

        public static string getnotification_inputBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            if (null != queryParams["CUSTOMERNAMECHINESE_V"] && "" != queryParams["CUSTOMERNAMECHINESE_V"].ToString().Trim())
            {
                queryParams["CUSTOMERNAMECHINESE_V"] = "%" + queryParams["CUSTOMERNAMECHINESE_V"] + "%";
            }
            if (null != queryParams["CUSTOMERNAMEEN_V"] && "" != queryParams["CUSTOMERNAMEEN_V"].ToString().Trim())
            {
                queryParams["CUSTOMERNAMEEN_V"] = "%" + queryParams["CUSTOMERNAMEEN_V"] + "%";
            }
            if (null != queryParams["CONTACTCHINESE_V"] && "" != queryParams["CONTACTCHINESE_V"].ToString().Trim())
            {
                queryParams["CONTACTCHINESE_V"] = "%" + queryParams["CONTACTCHINESE_V"] + "%";
            }
            if (null != queryParams["CONTACTENGLISH_V"] && "" != queryParams["CONTACTENGLISH_V"].ToString().Trim())
            {
                queryParams["CONTACTENGLISH_V"] = "%" + queryParams["CONTACTENGLISH_V"] + "%";
            }
            if (null != queryParams["ORDERPRODUCT_V"] && "" != queryParams["ORDERPRODUCT_V"].ToString().Trim())
            {
                queryParams["ORDERPRODUCT_V"] = "%" + queryParams["ORDERPRODUCT_V"] + "%";
            }
            if (null != queryParams["RENEWCUSTOMERNO_V"] && "" != queryParams["RENEWCUSTOMERNO_V"].ToString().Trim())
            {
                queryParams["RENEWCUSTOMERNO_V"] = "%" + queryParams["RENEWCUSTOMERNO_V"] + "%";
            }
            if (null != queryParams["NEWCUSTOMERBRANDS_V"] && "" != queryParams["NEWCUSTOMERBRANDS_V"].ToString().Trim())
            {
                queryParams["NEWCUSTOMERBRANDS_V"] = "%" + queryParams["NEWCUSTOMERBRANDS_V"] + "%";
            }
            if (null != queryParams["COMPETITIVEBRANDS_V"] && "" != queryParams["COMPETITIVEBRANDS_V"].ToString().Trim())
            {
                queryParams["COMPETITIVEBRANDS_V"] = "%" + queryParams["COMPETITIVEBRANDS_V"] + "%";
            }
            if (null != queryParams["DEALER_TW_V"] && "" != queryParams["DEALER_TW_V"].ToString().Trim())
            {
                queryParams["DEALER_TW_V"] = "%" + queryParams["DEALER_TW_V"] + "%";
            }

            Hashtable totalCount = (Hashtable)Mapper.Instance().QueryForObject("ResellerQuotationSystem.notification_input.getnotification_inputByTotalCount", queryParams);
            return  AxtCRUD.readJson("ResellerQuotationSystem.notification_input.getnotification_inputBy", queryParams, "notification_input", totalCount["NUM"].ToString());
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
            
            Hashtable totalCount = (Hashtable) Mapper.Instance().QueryForObject("ResellerQuotationSystem.notification_input.getWork_event",queryParams);
                if (totalCount == null )
                {
                    data["SID"] = AxtLibrary.GetUniqueKey(18);
                    AxtCRUD.insert("ResellerQuotationSystem.notification_input.addStatus",data);
                }
                else
                {
                    data["SID"] = AxtLibrary.GetUniqueKey(18);
                    AxtCRUD.update("ResellerQuotationSystem.notification_input.updateStatus",data);
                }
            return "ANS_00003";
        }
        /*user code start*/
        /*user code end*/
    }

}