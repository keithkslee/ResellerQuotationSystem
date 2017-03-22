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
    public class customer_purchase_input
    {
        public static void createTable()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable queryParams = new Hashtable();
            AxtCRUD.createTable("ResellerQuotationSystem.customer_purchase_input.createcustomer_purchase_input", queryParams);
            AxtCRUD.createTable("ResellerQuotationSystem.customer_purchase_input.createcustomer_purchase_inputHistory", queryParams);
        }

        public static string getcustomer_purchase_input(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable totalCount = (Hashtable)Mapper.Instance().QueryForObject("ResellerQuotationSystem.customer_purchase_inputgetcustomer_purchase_inputTotalCount", queryParams);
            return AxtCRUD.readJson("ResellerQuotationSystem.customer_purchase_input.getcustomer_purchase_input", queryParams, "customer_purchase_input", totalCount["NUM"].ToString());
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
                    AxtCRUD.insert("ResellerQuotationSystem.customer_purchase_input.addData", data);

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

            AxtCRUD.update("ResellerQuotationSystem.customer_purchase_input.updateData", data);
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
            AxtCRUD.delete("ResellerQuotationSystem.customer_purchase_input.deleteAll", queryParams);
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
                    AxtCRUD.delete("ResellerQuotationSystem.customer_purchase_input.deleteData", data);
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

        public static string getcustomer_purchase_inputBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            if (null != queryParams["NO_ORDER_V"] && "" != queryParams["NO_ORDER_V"].ToString().Trim())
            {
                queryParams["NO_ORDER_V"] = "%" + queryParams["NO_ORDER_V"] + "%";
            }
            if (null != queryParams["QUOTATIONNO_V"] && "" != queryParams["QUOTATIONNO_V"].ToString().Trim())
            {
                queryParams["QUOTATIONNO_V"] = "%" + queryParams["QUOTATIONNO_V"] + "%";
            }
            if (null != queryParams["ORDERTYPE_V"] && "" != queryParams["ORDERTYPE_V"].ToString().Trim())
            {
                queryParams["ORDERTYPE_V"] = "%" + queryParams["ORDERTYPE_V"] + "%";
            }
            if (null != queryParams["DEALER_V"] && "" != queryParams["DEALER_V"].ToString().Trim())
            {
                queryParams["DEALER_V"] = "%" + queryParams["DEALER_V"] + "%";
            }
            if (null != queryParams["CUSTOMERID_V"] && "" != queryParams["CUSTOMERID_V"].ToString().Trim())
            {
                queryParams["CUSTOMERID_V"] = "%" + queryParams["CUSTOMERID_V"] + "%";
            }
            if (null != queryParams["CUSTOMERNAME_V"] && "" != queryParams["CUSTOMERNAME_V"].ToString().Trim())
            {
                queryParams["CUSTOMERNAME_V"] = "%" + queryParams["CUSTOMERNAME_V"] + "%";
            }
            if (null != queryParams["COMPETITIVEBRANDS_V"] && "" != queryParams["COMPETITIVEBRANDS_V"].ToString().Trim())
            {
                queryParams["COMPETITIVEBRANDS_V"] = "%" + queryParams["COMPETITIVEBRANDS_V"] + "%";
            }
            if (null != queryParams["ORDERPRODUCT1_V"] && "" != queryParams["ORDERPRODUCT1_V"].ToString().Trim())
            {
                queryParams["ORDERPRODUCT1_V"] = "%" + queryParams["ORDERPRODUCT1_V"] + "%";
            }
            if (null != queryParams["ORDERPRODUCT2_V"] && "" != queryParams["ORDERPRODUCT2_V"].ToString().Trim())
            {
                queryParams["ORDERPRODUCT2_V"] = "%" + queryParams["ORDERPRODUCT2_V"] + "%";
            }
            if (null != queryParams["EXCHANGE_RATE_V"] && "" != queryParams["EXCHANGE_RATE_V"].ToString().Trim())
            {
                queryParams["EXCHANGE_RATE_V"] = "%" + queryParams["EXCHANGE_RATE_V"] + "%";
            }

            Hashtable totalCount = (Hashtable)Mapper.Instance().QueryForObject("ResellerQuotationSystem.customer_purchase_input.getcustomer_purchase_inputByTotalCount", queryParams);
            return  AxtCRUD.readJson("ResellerQuotationSystem.customer_purchase_input.getcustomer_purchase_inputBy", queryParams, "customer_purchase_input", totalCount["NUM"].ToString());
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
            
            Hashtable totalCount = (Hashtable) Mapper.Instance().QueryForObject("ResellerQuotationSystem.customer_purchase_input.getWork_event",queryParams);
                if (totalCount == null )
                {
                    data["SID"] = AxtLibrary.GetUniqueKey(18);
                    AxtCRUD.insert("ResellerQuotationSystem.customer_purchase_input.addStatus",data);
                }
                else
                {
                    data["SID"] = AxtLibrary.GetUniqueKey(18);
                    AxtCRUD.update("ResellerQuotationSystem.customer_purchase_input.updateStatus",data);
                }
            return "ANS_00003";
        }
        /*user code start*/
        /*user code end*/
    }

}