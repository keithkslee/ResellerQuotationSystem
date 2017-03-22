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
    public class customer_trace
    {
        public static void createTable()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable queryParams = new Hashtable();
            AxtCRUD.createTable("ResellerQuotationSystem.customer_trace.createcustomer_trace", queryParams);
            AxtCRUD.createTable("ResellerQuotationSystem.customer_trace.createcustomer_traceHistory", queryParams);
        }

        public static string getcustomer_trace(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable totalCount = (Hashtable)Mapper.Instance().QueryForObject("ResellerQuotationSystem.customer_tracegetcustomer_traceTotalCount", queryParams);
            return AxtCRUD.readJson("ResellerQuotationSystem.customer_trace.getcustomer_trace", queryParams, "customer_trace", totalCount["NUM"].ToString());
        }

        public static string getCBXDEALER_TW_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.customer_trace.getCBXDEALER_TW_V", queryParams, "customer_trace");
        }
        public static string getCBXDUEDATE1_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.customer_trace.getCBXDUEDATE1_V", queryParams, "customer_trace");
        }
        public static string getCBXDUEDATE2_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.customer_trace.getCBXDUEDATE2_V", queryParams, "customer_trace");
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
                    AxtCRUD.insert("ResellerQuotationSystem.customer_trace.addData", data);

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

            AxtCRUD.update("ResellerQuotationSystem.customer_trace.updateData", data);
            AxtCRUD.update("ResellerQuotationSystem.customer_trace.updateData_customer_trace", data);
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
            AxtCRUD.delete("ResellerQuotationSystem.customer_trace.deleteAll", queryParams);
        }

        public static void renewAll()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable queryParams = new Hashtable();
            AxtCRUD.delete("ResellerQuotationSystem.customer_trace.renewAll", queryParams);
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
                    AxtCRUD.delete("ResellerQuotationSystem.customer_trace.deleteData", data);
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
            deleteAll();
            renewAll();
            /*beforeGenConf user code end*/
        }

        public static string getcustomer_traceBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            if (null != queryParams["DEALER_TW_V"] && "" != queryParams["DEALER_TW_V"].ToString().Trim())
            {
                queryParams["DEALER_TW_V"] = "%" + queryParams["DEALER_TW_V"] + "%";
            }
            if (null != queryParams["TRACK_RESULTS_V"] && "" != queryParams["TRACK_RESULTS_V"].ToString().Trim())
            {
                queryParams["TRACK_RESULTS_V"] = "%" + queryParams["TRACK_RESULTS_V"] + "%";
            }
            if (null != queryParams["CUSTOMERNAME_V"] && "" != queryParams["CUSTOMERNAME_V"].ToString().Trim())
            {
                queryParams["CUSTOMERNAME_V"] = "%" + queryParams["CUSTOMERNAME_V"] + "%";
            }
            if (null != queryParams["CUSTOMER_CONTACT_V"] && "" != queryParams["CUSTOMER_CONTACT_V"].ToString().Trim())
            {
                queryParams["CUSTOMER_CONTACT_V"] = "%" + queryParams["CUSTOMER_CONTACT_V"] + "%";
            }
            if (null != queryParams["CONTACTPHONE_V"] && "" != queryParams["CONTACTPHONE_V"].ToString().Trim())
            {
                queryParams["CONTACTPHONE_V"] = "%" + queryParams["CONTACTPHONE_V"] + "%";
            }
            if (null != queryParams["PRIMARY_EMAIL_V"] && "" != queryParams["PRIMARY_EMAIL_V"].ToString().Trim())
            {
                queryParams["PRIMARY_EMAIL_V"] = "%" + queryParams["PRIMARY_EMAIL_V"] + "%";
            }
            if (null != queryParams["DUEDATE1_V"] && "" != queryParams["DUEDATE1_V"].ToString().Trim())
            {
                queryParams["DUEDATE1_V"] = "%" + queryParams["DUEDATE1_V"] + "%";
            }
            if (null != queryParams["DUEDATE2_V"] && "" != queryParams["DUEDATE2_V"].ToString().Trim())
            {
                queryParams["DUEDATE2_V"] = "%" + queryParams["DUEDATE2_V"] + "%";
            }
            if (null != queryParams["TERM1_V"] && "" != queryParams["TERM1_V"].ToString().Trim())
            {
                queryParams["TERM1_V"] = "%" + queryParams["TERM1_V"] + "%";
            }
            if (null != queryParams["TERM2_V"] && "" != queryParams["TERM2_V"].ToString().Trim())
            {
                queryParams["TERM2_V"] = "%" + queryParams["TERM2_V"] + "%";
            }
            if (null != queryParams["QUANTITY_1_V"] && "" != queryParams["QUANTITY_1_V"].ToString().Trim())
            {
                queryParams["QUANTITY_1_V"] = "%" + queryParams["QUANTITY_1_V"] + "%";
            }
            if (null != queryParams["QUANTITY_2_V"] && "" != queryParams["QUANTITY_2_V"].ToString().Trim())
            {
                queryParams["QUANTITY_2_V"] = "%" + queryParams["QUANTITY_2_V"] + "%";
            }
            if (null != queryParams["PRODUCT_1_V"] && "" != queryParams["PRODUCT_1_V"].ToString().Trim())
            {
                queryParams["PRODUCT_1_V"] = "%" + queryParams["PRODUCT_1_V"] + "%";
            }
            if (null != queryParams["PRODUCT_2_V"] && "" != queryParams["PRODUCT_2_V"].ToString().Trim())
            {
                queryParams["PRODUCT_2_V"] = "%" + queryParams["PRODUCT_2_V"] + "%";
            }
            if (null != queryParams["LAST_SEQUENCE_V"] && "" != queryParams["LAST_SEQUENCE_V"].ToString().Trim())
            {
                queryParams["LAST_SEQUENCE_V"] = "%" + queryParams["LAST_SEQUENCE_V"] + "%";
            }
            if (null != queryParams["ENTRY_DATE_V"] && "" != queryParams["ENTRY_DATE_V"].ToString().Trim())
            {
                queryParams["ENTRY_DATE_V"] = "%" + queryParams["ENTRY_DATE_V"] + "%";
            }

            Hashtable totalCount = (Hashtable)Mapper.Instance().QueryForObject("ResellerQuotationSystem.customer_trace.getcustomer_traceByTotalCount", queryParams);
            return  AxtCRUD.readJson("ResellerQuotationSystem.customer_trace.getcustomer_traceBy", queryParams, "customer_trace", totalCount["NUM"].ToString());
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
            
            Hashtable totalCount = (Hashtable) Mapper.Instance().QueryForObject("ResellerQuotationSystem.customer_trace.getWork_event",queryParams);
                if (totalCount == null )
                {
                    data["SID"] = AxtLibrary.GetUniqueKey(18);
                    AxtCRUD.insert("ResellerQuotationSystem.customer_trace.addStatus",data);
                }
                else
                {
                    data["SID"] = AxtLibrary.GetUniqueKey(18);
                    AxtCRUD.update("ResellerQuotationSystem.customer_trace.updateStatus",data);
                }
            return "ANS_00003";
        }
        /*user code start*/
        /*user code end*/
    }

}