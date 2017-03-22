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
    public class reseller_shipper
    {
        public static void createTable()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable queryParams = new Hashtable();
            AxtCRUD.createTable("ResellerQuotationSystem.reseller_shipper.createreseller_shipper", queryParams);
            AxtCRUD.createTable("ResellerQuotationSystem.reseller_shipper.createreseller_shipperHistory", queryParams);
        }

        public static string getreseller_shipper(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable totalCount = (Hashtable)Mapper.Instance().QueryForObject("ResellerQuotationSystem.reseller_shippergetreseller_shipperTotalCount", queryParams);
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_shipper.getreseller_shipper", queryParams, "reseller_shipper", totalCount["NUM"].ToString());
        }

        public static string getCBXREPORTTITLE_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_shipper.getCBXREPORTTITLE_V", queryParams, "reseller_shipper");
        }
        public static string getCBXREPORTNAME_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_shipper.getCBXREPORTNAME_V", queryParams, "reseller_shipper");
        }
        public static string getCBXCUSTOMERNAME_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_shipper.getCBXCUSTOMERNAME_V", queryParams, "reseller_shipper");
        }
        public static string getCBXUNIFIEDNUMBERING_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_shipper.getCBXUNIFIEDNUMBERING_V", queryParams, "reseller_shipper");
        }
        public static string getCBXSHIPPER_NUMBER_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_shipper.getCBXSHIPPER_NUMBER_V", queryParams, "reseller_shipper");
        }
        public static string getCBXCOMPACT_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_shipper.getCBXCOMPACT_V", queryParams, "reseller_shipper");
        }
        public static string getCBXPURCHASEORDERNUMBER_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_shipper.getCBXPURCHASEORDERNUMBER_V", queryParams, "reseller_shipper");
        }
        public static string getCBXQUOTATIONNO_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_shipper.getCBXQUOTATIONNO_V", queryParams, "reseller_shipper");
        }
        public static string getCBXITEM_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_shipper.getCBXITEM_V", queryParams, "reseller_shipper");
        }
        public static string getCBXPRODUCT_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_shipper.getCBXPRODUCT_V", queryParams, "reseller_shipper");
        }
        public static string getCBXHEAD_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_shipper.getCBXHEAD_V", queryParams, "reseller_shipper");
        }
        public static string getCBXMANAGER_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_shipper.getCBXMANAGER_V", queryParams, "reseller_shipper");
        }
        public static string getCBXATTN_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_shipper.getCBXATTN_V", queryParams, "reseller_shipper");
        }
        public static string getCBXCUSTOMERS_SIGN_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_shipper.getCBXCUSTOMERS_SIGN_V", queryParams, "reseller_shipper");
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
                    AxtCRUD.insert("ResellerQuotationSystem.reseller_shipper.addData", data);

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

            AxtCRUD.update("ResellerQuotationSystem.reseller_shipper.updateData", data);
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
            AxtCRUD.delete("ResellerQuotationSystem.reseller_shipper.deleteAll", queryParams);
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
                    AxtCRUD.delete("ResellerQuotationSystem.reseller_shipper.deleteData", data);
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

        public static string getreseller_shipperBy(Hashtable queryParams)
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
            if (null != queryParams["CUSTOMERNAME_V"] && "" != queryParams["CUSTOMERNAME_V"].ToString().Trim())
            {
                queryParams["CUSTOMERNAME_V"] = "%" + queryParams["CUSTOMERNAME_V"] + "%";
            }
            if (null != queryParams["SHIP_DATE_V"] && "" != queryParams["SHIP_DATE_V"].ToString().Trim())
            {
                queryParams["SHIP_DATE_V"] = "%" + queryParams["SHIP_DATE_V"] + "%";
            }
            if (null != queryParams["UNIFIEDNUMBERING_V"] && "" != queryParams["UNIFIEDNUMBERING_V"].ToString().Trim())
            {
                queryParams["UNIFIEDNUMBERING_V"] = "%" + queryParams["UNIFIEDNUMBERING_V"] + "%";
            }
            if (null != queryParams["SHIPPER_NUMBER_V"] && "" != queryParams["SHIPPER_NUMBER_V"].ToString().Trim())
            {
                queryParams["SHIPPER_NUMBER_V"] = "%" + queryParams["SHIPPER_NUMBER_V"] + "%";
            }
            if (null != queryParams["COMPACT_V"] && "" != queryParams["COMPACT_V"].ToString().Trim())
            {
                queryParams["COMPACT_V"] = "%" + queryParams["COMPACT_V"] + "%";
            }
            if (null != queryParams["PAYMENT_DATE_V"] && "" != queryParams["PAYMENT_DATE_V"].ToString().Trim())
            {
                queryParams["PAYMENT_DATE_V"] = "%" + queryParams["PAYMENT_DATE_V"] + "%";
            }
            if (null != queryParams["EMAIL_V"] && "" != queryParams["EMAIL_V"].ToString().Trim())
            {
                queryParams["EMAIL_V"] = "%" + queryParams["EMAIL_V"] + "%";
            }
            if (null != queryParams["PURCHASEORDERNUMBER_V"] && "" != queryParams["PURCHASEORDERNUMBER_V"].ToString().Trim())
            {
                queryParams["PURCHASEORDERNUMBER_V"] = "%" + queryParams["PURCHASEORDERNUMBER_V"] + "%";
            }
            if (null != queryParams["PHONE_V"] && "" != queryParams["PHONE_V"].ToString().Trim())
            {
                queryParams["PHONE_V"] = "%" + queryParams["PHONE_V"] + "%";
            }
            if (null != queryParams["ORDERDATE_V"] && "" != queryParams["ORDERDATE_V"].ToString().Trim())
            {
                queryParams["ORDERDATE_V"] = "%" + queryParams["ORDERDATE_V"] + "%";
            }
            if (null != queryParams["FAX_V"] && "" != queryParams["FAX_V"].ToString().Trim())
            {
                queryParams["FAX_V"] = "%" + queryParams["FAX_V"] + "%";
            }
            if (null != queryParams["QUOTATIONNO_V"] && "" != queryParams["QUOTATIONNO_V"].ToString().Trim())
            {
                queryParams["QUOTATIONNO_V"] = "%" + queryParams["QUOTATIONNO_V"] + "%";
            }
            if (null != queryParams["ADDRESS_V"] && "" != queryParams["ADDRESS_V"].ToString().Trim())
            {
                queryParams["ADDRESS_V"] = "%" + queryParams["ADDRESS_V"] + "%";
            }
            if (null != queryParams["DELIVERYADDRESS_V"] && "" != queryParams["DELIVERYADDRESS_V"].ToString().Trim())
            {
                queryParams["DELIVERYADDRESS_V"] = "%" + queryParams["DELIVERYADDRESS_V"] + "%";
            }
            if (null != queryParams["ITEM_V"] && "" != queryParams["ITEM_V"].ToString().Trim())
            {
                queryParams["ITEM_V"] = "%" + queryParams["ITEM_V"] + "%";
            }
            if (null != queryParams["PRODUCT_V"] && "" != queryParams["PRODUCT_V"].ToString().Trim())
            {
                queryParams["PRODUCT_V"] = "%" + queryParams["PRODUCT_V"] + "%";
            }
            if (null != queryParams["AUTORIZATION_NUMBER_V"] && "" != queryParams["AUTORIZATION_NUMBER_V"].ToString().Trim())
            {
                queryParams["AUTORIZATION_NUMBER_V"] = "%" + queryParams["AUTORIZATION_NUMBER_V"] + "%";
            }
            if (null != queryParams["QUANTITY_V"] && "" != queryParams["QUANTITY_V"].ToString().Trim())
            {
                queryParams["QUANTITY_V"] = "%" + queryParams["QUANTITY_V"] + "%";
            }
            if (null != queryParams["YEAR_V"] && "" != queryParams["YEAR_V"].ToString().Trim())
            {
                queryParams["YEAR_V"] = "%" + queryParams["YEAR_V"] + "%";
            }
            if (null != queryParams["LICENSE_START_V"] && "" != queryParams["LICENSE_START_V"].ToString().Trim())
            {
                queryParams["LICENSE_START_V"] = "%" + queryParams["LICENSE_START_V"] + "%";
            }
            if (null != queryParams["LICENSE_END_V"] && "" != queryParams["LICENSE_END_V"].ToString().Trim())
            {
                queryParams["LICENSE_END_V"] = "%" + queryParams["LICENSE_END_V"] + "%";
            }
            if (null != queryParams["MONEY_V"] && "" != queryParams["MONEY_V"].ToString().Trim())
            {
                queryParams["MONEY_V"] = "%" + queryParams["MONEY_V"] + "%";
            }
            if (null != queryParams["NO_TAX_AMOUNT_V"] && "" != queryParams["NO_TAX_AMOUNT_V"].ToString().Trim())
            {
                queryParams["NO_TAX_AMOUNT_V"] = "%" + queryParams["NO_TAX_AMOUNT_V"] + "%";
            }
            if (null != queryParams["SALES_TAX_V"] && "" != queryParams["SALES_TAX_V"].ToString().Trim())
            {
                queryParams["SALES_TAX_V"] = "%" + queryParams["SALES_TAX_V"] + "%";
            }
            if (null != queryParams["TOTAL_V"] && "" != queryParams["TOTAL_V"].ToString().Trim())
            {
                queryParams["TOTAL_V"] = "%" + queryParams["TOTAL_V"] + "%";
            }
            if (null != queryParams["NOTE_V"] && "" != queryParams["NOTE_V"].ToString().Trim())
            {
                queryParams["NOTE_V"] = "%" + queryParams["NOTE_V"] + "%";
            }
            if (null != queryParams["HEAD_V"] && "" != queryParams["HEAD_V"].ToString().Trim())
            {
                queryParams["HEAD_V"] = "%" + queryParams["HEAD_V"] + "%";
            }
            if (null != queryParams["MANAGER_V"] && "" != queryParams["MANAGER_V"].ToString().Trim())
            {
                queryParams["MANAGER_V"] = "%" + queryParams["MANAGER_V"] + "%";
            }
            if (null != queryParams["ATTN_V"] && "" != queryParams["ATTN_V"].ToString().Trim())
            {
                queryParams["ATTN_V"] = "%" + queryParams["ATTN_V"] + "%";
            }
            if (null != queryParams["CUSTOMERS_SIGN_V"] && "" != queryParams["CUSTOMERS_SIGN_V"].ToString().Trim())
            {
                queryParams["CUSTOMERS_SIGN_V"] = "%" + queryParams["CUSTOMERS_SIGN_V"] + "%";
            }

            Hashtable totalCount = (Hashtable)Mapper.Instance().QueryForObject("ResellerQuotationSystem.reseller_shipper.getreseller_shipperByTotalCount", queryParams);
            return  AxtCRUD.readJson("ResellerQuotationSystem.reseller_shipper.getreseller_shipperBy", queryParams, "reseller_shipper", totalCount["NUM"].ToString());
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
            
            Hashtable totalCount = (Hashtable) Mapper.Instance().QueryForObject("ResellerQuotationSystem.reseller_shipper.getWork_event",queryParams);
                if (totalCount == null )
                {
                    data["SID"] = AxtLibrary.GetUniqueKey(18);
                    AxtCRUD.insert("ResellerQuotationSystem.reseller_shipper.addStatus",data);
                }
                else
                {
                    data["SID"] = AxtLibrary.GetUniqueKey(18);
                    AxtCRUD.update("ResellerQuotationSystem.reseller_shipper.updateStatus",data);
                }
            return "ANS_00003";
        }
        public static ArrayList getreseller_shipperCustomername_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.reseller_shipper.getreseller_shipperCustomername_vBy", queryParams);
        }

        public static ArrayList getreseller_shipperUnifiednumbering_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.reseller_shipper.getreseller_shipperUnifiednumbering_vBy", queryParams);
        }

        public static ArrayList getreseller_shipperReporttitle_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.reseller_shipper.getreseller_shipperReporttitle_vBy", queryParams);
        }

        public static ArrayList getreseller_shipperQuantity_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.reseller_shipper.getreseller_shipperQuantity_vBy", queryParams);
        }

        public static ArrayList getreseller_shipperProduct_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.reseller_shipper.getreseller_shipperProduct_vBy", queryParams);
        }

        public static ArrayList getreseller_shipperPhone_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.reseller_shipper.getreseller_shipperPhone_vBy", queryParams);
        }

        public static ArrayList getreseller_shipperNote_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.reseller_shipper.getreseller_shipperNote_vBy", queryParams);
        }

        public static ArrayList getreseller_shipperManager_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.reseller_shipper.getreseller_shipperManager_vBy", queryParams);
        }

        public static ArrayList getreseller_shipperItem_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.reseller_shipper.getreseller_shipperItem_vBy", queryParams);
        }

        public static ArrayList getreseller_shipperHead_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.reseller_shipper.getreseller_shipperHead_vBy", queryParams);
        }

        public static ArrayList getreseller_shipperFax_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.reseller_shipper.getreseller_shipperFax_vBy", queryParams);
        }

        public static ArrayList getreseller_shipperEmail_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.reseller_shipper.getreseller_shipperEmail_vBy", queryParams);
        }

        public static ArrayList getreseller_shipperDeliveryaddress_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.reseller_shipper.getreseller_shipperDeliveryaddress_vBy", queryParams);
        }

        public static ArrayList getreseller_shipperCustomers_sign_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.reseller_shipper.getreseller_shipperCustomers_sign_vBy", queryParams);
        }

        public static ArrayList getreseller_shipperCompact_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.reseller_shipper.getreseller_shipperCompact_vBy", queryParams);
        }

        public static ArrayList getreseller_shipperAttn_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.reseller_shipper.getreseller_shipperAttn_vBy", queryParams);
        }

        public static ArrayList getreseller_shipperAddress_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.reseller_shipper.getreseller_shipperAddress_vBy", queryParams);
        }

        /*user code start*/
        /*user code end*/
    }

}