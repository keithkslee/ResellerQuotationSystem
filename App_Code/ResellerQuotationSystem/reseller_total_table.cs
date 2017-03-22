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
    public class reseller_total_table
    {
        public static void createTable()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable queryParams = new Hashtable();
            AxtCRUD.createTable("ResellerQuotationSystem.reseller_total_table.createreseller_total_table", queryParams);
            AxtCRUD.createTable("ResellerQuotationSystem.reseller_total_table.createreseller_total_tableHistory", queryParams);
        }

        public static string getreseller_total_table(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable totalCount = (Hashtable)Mapper.Instance().QueryForObject("ResellerQuotationSystem.reseller_total_tablegetreseller_total_tableTotalCount", queryParams);
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_total_table.getreseller_total_table", queryParams, "reseller_total_table", totalCount["NUM"].ToString());
        }

        public static string getCBXDEALER_TW_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_total_table.getCBXDEALER_TW_V", queryParams, "reseller_total_table");
        }
        public static string getCBXQUOTATIONNO_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_total_table.getCBXQUOTATIONNO_V", queryParams, "reseller_total_table");
        }
        public static string getCBXSHIPPER_NUMBER_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_total_table.getCBXSHIPPER_NUMBER_V", queryParams, "reseller_total_table");
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
                    AxtCRUD.insert("ResellerQuotationSystem.reseller_total_table.addData", data);

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

            AxtCRUD.update("ResellerQuotationSystem.reseller_total_table.updateData", data);
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
            AxtCRUD.delete("ResellerQuotationSystem.reseller_total_table.deleteAll", queryParams);
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
                    AxtCRUD.delete("ResellerQuotationSystem.reseller_total_table.deleteData", data);
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

        public static string getreseller_total_tableBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            if (null != queryParams["DEALER_TW_V"] && "" != queryParams["DEALER_TW_V"].ToString().Trim())
            {
                queryParams["DEALER_TW_V"] = "%" + queryParams["DEALER_TW_V"] + "%";
            }
            if (null != queryParams["QUOTATIONNO_V"] && "" != queryParams["QUOTATIONNO_V"].ToString().Trim())
            {
                queryParams["QUOTATIONNO_V"] = "%" + queryParams["QUOTATIONNO_V"] + "%";
            }
            if (null != queryParams["QUOTATION_DATE_V"] && "" != queryParams["QUOTATION_DATE_V"].ToString().Trim())
            {
                queryParams["QUOTATION_DATE_V"] = "%" + queryParams["QUOTATION_DATE_V"] + "%";
            }
            if (null != queryParams["SHIPPER_NUMBER_V"] && "" != queryParams["SHIPPER_NUMBER_V"].ToString().Trim())
            {
                queryParams["SHIPPER_NUMBER_V"] = "%" + queryParams["SHIPPER_NUMBER_V"] + "%";
            }
            if (null != queryParams["SHIP__DATE_V"] && "" != queryParams["SHIP__DATE_V"].ToString().Trim())
            {
                queryParams["SHIP__DATE_V"] = "%" + queryParams["SHIP__DATE_V"] + "%";
            }
            if (null != queryParams["ENTRY_DATE_V"] && "" != queryParams["ENTRY_DATE_V"].ToString().Trim())
            {
                queryParams["ENTRY_DATE_V"] = "%" + queryParams["ENTRY_DATE_V"] + "%";
            }
            if (null != queryParams["LAST_SEQUENCE_V"] && "" != queryParams["LAST_SEQUENCE_V"].ToString().Trim())
            {
                queryParams["LAST_SEQUENCE_V"] = "%" + queryParams["LAST_SEQUENCE_V"] + "%";
            }

            Hashtable totalCount = (Hashtable)Mapper.Instance().QueryForObject("ResellerQuotationSystem.reseller_total_table.getreseller_total_tableByTotalCount", queryParams);
            return  AxtCRUD.readJson("ResellerQuotationSystem.reseller_total_table.getreseller_total_tableBy", queryParams, "reseller_total_table", totalCount["NUM"].ToString());
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
            
            Hashtable totalCount = (Hashtable) Mapper.Instance().QueryForObject("ResellerQuotationSystem.reseller_total_table.getWork_event",queryParams);
                if (totalCount == null )
                {
                    data["SID"] = AxtLibrary.GetUniqueKey(18);
                    AxtCRUD.insert("ResellerQuotationSystem.reseller_total_table.addStatus",data);
                }
                else
                {
                    data["SID"] = AxtLibrary.GetUniqueKey(18);
                    AxtCRUD.update("ResellerQuotationSystem.reseller_total_table.updateStatus",data);
                }
            return "ANS_00003";
        }
        public static ArrayList getreseller_total_tableDealer_tw_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.reseller_total_table.getreseller_total_tableDealer_tw_vBy", queryParams);
        }

        /*user code start*/
        /*user code end*/
    }

}