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
    public class reseller_quotation1_input
    {
        public static void createTable()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable queryParams = new Hashtable();
            AxtCRUD.createTable("ResellerQuotationSystem.reseller_quotation1_input.createreseller_quotation1_input", queryParams);
            AxtCRUD.createTable("ResellerQuotationSystem.reseller_quotation1_input.createreseller_quotation1_inputHistory", queryParams);
        }

        public static string getreseller_quotation1_input(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable totalCount = (Hashtable)Mapper.Instance().QueryForObject("ResellerQuotationSystem.reseller_quotation1_inputgetreseller_quotation1_inputTotalCount", queryParams);
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_quotation1_input.getreseller_quotation1_input", queryParams, "reseller_quotation1_input", totalCount["NUM"].ToString());
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
                    AxtCRUD.insert("ResellerQuotationSystem.reseller_quotation1_input.addData", data);

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

            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation1_input.updateData", data);
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
            AxtCRUD.delete("ResellerQuotationSystem.reseller_quotation1_input.deleteAll", queryParams);
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
                    AxtCRUD.delete("ResellerQuotationSystem.reseller_quotation1_input.deleteData", data);
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

        public static string getreseller_quotation1_inputBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            if (null != queryParams["REPORTTITLE_V"] && "" != queryParams["REPORTTITLE_V"].ToString().Trim())
            {
                queryParams["REPORTTITLE_V"] = "%" + queryParams["REPORTTITLE_V"] + "%";
            }
            if (null != queryParams["REPORTNAME_V"] && "" != queryParams["REPORTNAME_V"].ToString().Trim())
            {
                queryParams["REPORTNAME_V"] = "%" + queryParams["REPORTNAME_V"] + "%";
            }
            if (null != queryParams["RESELLERNAME_V"] && "" != queryParams["RESELLERNAME_V"].ToString().Trim())
            {
                queryParams["RESELLERNAME_V"] = "%" + queryParams["RESELLERNAME_V"] + "%";
            }
            if (null != queryParams["QUOTATIONNO_V"] && "" != queryParams["QUOTATIONNO_V"].ToString().Trim())
            {
                queryParams["QUOTATIONNO_V"] = "%" + queryParams["QUOTATIONNO_V"] + "%";
            }
            if (null != queryParams["UNIFIEDNUMBERING_V"] && "" != queryParams["UNIFIEDNUMBERING_V"].ToString().Trim())
            {
                queryParams["UNIFIEDNUMBERING_V"] = "%" + queryParams["UNIFIEDNUMBERING_V"] + "%";
            }
            if (null != queryParams["COMPACT_V"] && "" != queryParams["COMPACT_V"].ToString().Trim())
            {
                queryParams["COMPACT_V"] = "%" + queryParams["COMPACT_V"] + "%";
            }
            if (null != queryParams["PAYMENT_CONDITIONS_V"] && "" != queryParams["PAYMENT_CONDITIONS_V"].ToString().Trim())
            {
                queryParams["PAYMENT_CONDITIONS_V"] = "%" + queryParams["PAYMENT_CONDITIONS_V"] + "%";
            }
            if (null != queryParams["COMPETITIVEBRANDS_V"] && "" != queryParams["COMPETITIVEBRANDS_V"].ToString().Trim())
            {
                queryParams["COMPETITIVEBRANDS_V"] = "%" + queryParams["COMPETITIVEBRANDS_V"] + "%";
            }
            if (null != queryParams["CUSTOMERNAME_V"] && "" != queryParams["CUSTOMERNAME_V"].ToString().Trim())
            {
                queryParams["CUSTOMERNAME_V"] = "%" + queryParams["CUSTOMERNAME_V"] + "%";
            }
            if (null != queryParams["ORDERTYPE_V"] && "" != queryParams["ORDERTYPE_V"].ToString().Trim())
            {
                queryParams["ORDERTYPE_V"] = "%" + queryParams["ORDERTYPE_V"] + "%";
            }
            if (null != queryParams["OFFERORS_V"] && "" != queryParams["OFFERORS_V"].ToString().Trim())
            {
                queryParams["OFFERORS_V"] = "%" + queryParams["OFFERORS_V"] + "%";
            }
            if (null != queryParams["ITEM1_V"] && "" != queryParams["ITEM1_V"].ToString().Trim())
            {
                queryParams["ITEM1_V"] = "%" + queryParams["ITEM1_V"] + "%";
            }
            if (null != queryParams["PRODUCT_NAME1_V"] && "" != queryParams["PRODUCT_NAME1_V"].ToString().Trim())
            {
                queryParams["PRODUCT_NAME1_V"] = "%" + queryParams["PRODUCT_NAME1_V"] + "%";
            }
            if (null != queryParams["SPECIFICATION1_V"] && "" != queryParams["SPECIFICATION1_V"].ToString().Trim())
            {
                queryParams["SPECIFICATION1_V"] = "%" + queryParams["SPECIFICATION1_V"] + "%";
            }
            if (null != queryParams["QUANTITY1_V"] && "" != queryParams["QUANTITY1_V"].ToString().Trim())
            {
                queryParams["QUANTITY1_V"] = "%" + queryParams["QUANTITY1_V"] + "%";
            }
            if (null != queryParams["NOTE_V"] && "" != queryParams["NOTE_V"].ToString().Trim())
            {
                queryParams["NOTE_V"] = "%" + queryParams["NOTE_V"] + "%";
            }
            if (null != queryParams["HEAD_V"] && "" != queryParams["HEAD_V"].ToString().Trim())
            {
                queryParams["HEAD_V"] = "%" + queryParams["HEAD_V"] + "%";
            }
            if (null != queryParams["SALES_MANAGER_V"] && "" != queryParams["SALES_MANAGER_V"].ToString().Trim())
            {
                queryParams["SALES_MANAGER_V"] = "%" + queryParams["SALES_MANAGER_V"] + "%";
            }
            if (null != queryParams["ATTN_V"] && "" != queryParams["ATTN_V"].ToString().Trim())
            {
                queryParams["ATTN_V"] = "%" + queryParams["ATTN_V"] + "%";
            }
            if (null != queryParams["CUSTOMERS_SIGN_V"] && "" != queryParams["CUSTOMERS_SIGN_V"].ToString().Trim())
            {
                queryParams["CUSTOMERS_SIGN_V"] = "%" + queryParams["CUSTOMERS_SIGN_V"] + "%";
            }

            Hashtable totalCount = (Hashtable)Mapper.Instance().QueryForObject("ResellerQuotationSystem.reseller_quotation1_input.getreseller_quotation1_inputByTotalCount", queryParams);
            return  AxtCRUD.readJson("ResellerQuotationSystem.reseller_quotation1_input.getreseller_quotation1_inputBy", queryParams, "reseller_quotation1_input", totalCount["NUM"].ToString());
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
            
            Hashtable totalCount = (Hashtable) Mapper.Instance().QueryForObject("ResellerQuotationSystem.reseller_quotation1_input.getWork_event",queryParams);
                if (totalCount == null )
                {
                    data["SID"] = AxtLibrary.GetUniqueKey(18);
                    AxtCRUD.insert("ResellerQuotationSystem.reseller_quotation1_input.addStatus",data);
                }
                else
                {
                    data["SID"] = AxtLibrary.GetUniqueKey(18);
                    AxtCRUD.update("ResellerQuotationSystem.reseller_quotation1_input.updateStatus",data);
                }
            return "ANS_00003";
        }
        /*user code start*/
        /*user code end*/
    }

}