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
    public class reseller_shipper3
    {
        public static void createTable()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable queryParams = new Hashtable();
            AxtCRUD.createTable("ResellerQuotationSystem.reseller_shipper3.createreseller_shipper3", queryParams);
            AxtCRUD.createTable("ResellerQuotationSystem.reseller_shipper3.createreseller_shipper3History", queryParams);
        }

        public static string getreseller_shipper3(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable totalCount = (Hashtable)Mapper.Instance().QueryForObject("ResellerQuotationSystem.reseller_shipper3getreseller_shipper3TotalCount", queryParams);
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_shipper3.getreseller_shipper3", queryParams, "reseller_shipper3", totalCount["NUM"].ToString());
        }

        public static string getCBXREPORTTITLE_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_shipper3.getCBXREPORTTITLE_V", queryParams, "reseller_shipper3");
        }
        public static string getCBXREPORTNAME_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_shipper3.getCBXREPORTNAME_V", queryParams, "reseller_shipper3");
        }
        public static string getCBXCUSTOMERNAME_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_shipper3.getCBXCUSTOMERNAME_V", queryParams, "reseller_shipper3");
        }
        public static string getCBXUNIFIEDNUMBERING_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_shipper3.getCBXUNIFIEDNUMBERING_V", queryParams, "reseller_shipper3");
        }
        public static string getCBXSHIPPER_NUMBER_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_shipper3.getCBXSHIPPER_NUMBER_V", queryParams, "reseller_shipper3");
        }
        public static string getCBXCOMPACT_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_shipper3.getCBXCOMPACT_V", queryParams, "reseller_shipper3");
        }
        public static string getCBXPURCHASEORDERNUMBER_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_shipper3.getCBXPURCHASEORDERNUMBER_V", queryParams, "reseller_shipper3");
        }
        public static string getCBXQUOTATIONNO_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_shipper3.getCBXQUOTATIONNO_V", queryParams, "reseller_shipper3");
        }
		public static string getCBXFINALCUSTOMER_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_shipper3.getCBXFINALCUSTOMER_V", queryParams, "reseller_shipper3");
        }
        public static string getCBXDEALER_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_shipper3.getCBXDEALER_V", queryParams, "reseller_shipper3");
        }
        public static string getCBXITEM_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_shipper3.getCBXITEM_V", queryParams, "reseller_shipper3");
        }
        public static string getCBXPRODUCT_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_shipper3.getCBXPRODUCT_V", queryParams, "reseller_shipper3");
        }
        public static string getCBXITEM2_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_shipper3.getCBXITEM2_V", queryParams, "reseller_shipper3");
        }
        public static string getCBXPRODUCT2_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_shipper3.getCBXPRODUCT2_V", queryParams, "reseller_shipper3");
        }
        public static string getCBXITEM3_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_shipper3.getCBXITEM3_V", queryParams, "reseller_shipper3");
        }
        public static string getCBXPRODUCT3_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_shipper3.getCBXPRODUCT3_V", queryParams, "reseller_shipper3");
        }
        public static string getCBXHEAD_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_shipper3.getCBXHEAD_V", queryParams, "reseller_shipper3");
        }
        public static string getCBXMANAGER_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_shipper3.getCBXMANAGER_V", queryParams, "reseller_shipper3");
        }
        public static string getCBXATTN_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_shipper3.getCBXATTN_V", queryParams, "reseller_shipper3");
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
                    AxtCRUD.insert("ResellerQuotationSystem.reseller_shipper3.addData", data);

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

            AxtCRUD.update("ResellerQuotationSystem.reseller_shipper3.updateData", data);
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
            AxtCRUD.delete("ResellerQuotationSystem.reseller_shipper3.deleteAll", queryParams);
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
                    AxtCRUD.delete("ResellerQuotationSystem.reseller_shipper3.deleteData", data);
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

        public static string getreseller_shipper3By(Hashtable queryParams)
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
            if (null != queryParams["FINALCUSTOMER_V"] && "" != queryParams["FINALCUSTOMER_V"].ToString().Trim())
            {
                queryParams["FINALCUSTOMER_V"] = "%" + queryParams["FINALCUSTOMER_V"] + "%";
            }
            if (null != queryParams["DEALER_V"] && "" != queryParams["DEALER_V"].ToString().Trim())
            {
                queryParams["DEALER_V"] = "%" + queryParams["DEALER_V"] + "%";
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
            if (null != queryParams["ITEM2_V"] && "" != queryParams["ITEM2_V"].ToString().Trim())
            {
                queryParams["ITEM2_V"] = "%" + queryParams["ITEM2_V"] + "%";
            }
            if (null != queryParams["PRODUCT2_V"] && "" != queryParams["PRODUCT2_V"].ToString().Trim())
            {
                queryParams["PRODUCT2_V"] = "%" + queryParams["PRODUCT2_V"] + "%";
            }
            if (null != queryParams["AUTHORIZATIONNUMBER2_V"] && "" != queryParams["AUTHORIZATIONNUMBER2_V"].ToString().Trim())
            {
                queryParams["AUTHORIZATIONNUMBER2_V"] = "%" + queryParams["AUTHORIZATIONNUMBER2_V"] + "%";
            }
            if (null != queryParams["QUANTITY2_V"] && "" != queryParams["QUANTITY2_V"].ToString().Trim())
            {
                queryParams["QUANTITY2_V"] = "%" + queryParams["QUANTITY2_V"] + "%";
            }
            if (null != queryParams["YEAR2_V"] && "" != queryParams["YEAR2_V"].ToString().Trim())
            {
                queryParams["YEAR2_V"] = "%" + queryParams["YEAR2_V"] + "%";
            }
            if (null != queryParams["LICENSESTART2_V"] && "" != queryParams["LICENSESTART2_V"].ToString().Trim())
            {
                queryParams["LICENSESTART2_V"] = "%" + queryParams["LICENSESTART2_V"] + "%";
            }
            if (null != queryParams["LICENSEEND2_V"] && "" != queryParams["LICENSEEND2_V"].ToString().Trim())
            {
                queryParams["LICENSEEND2_V"] = "%" + queryParams["LICENSEEND2_V"] + "%";
            }
            if (null != queryParams["MONEY2_V"] && "" != queryParams["MONEY2_V"].ToString().Trim())
            {
                queryParams["MONEY2_V"] = "%" + queryParams["MONEY2_V"] + "%";
            }
            if (null != queryParams["ITEM3_V"] && "" != queryParams["ITEM3_V"].ToString().Trim())
            {
                queryParams["ITEM3_V"] = "%" + queryParams["ITEM3_V"] + "%";
            }
            if (null != queryParams["PRODUCT3_V"] && "" != queryParams["PRODUCT3_V"].ToString().Trim())
            {
                queryParams["PRODUCT3_V"] = "%" + queryParams["PRODUCT3_V"] + "%";
            }
            if (null != queryParams["AUTHORIZATIONNUMBER3_V"] && "" != queryParams["AUTHORIZATIONNUMBER3_V"].ToString().Trim())
            {
                queryParams["AUTHORIZATIONNUMBER3_V"] = "%" + queryParams["AUTHORIZATIONNUMBER3_V"] + "%";
            }
            if (null != queryParams["QUANTITY3_V"] && "" != queryParams["QUANTITY3_V"].ToString().Trim())
            {
                queryParams["QUANTITY3_V"] = "%" + queryParams["QUANTITY3_V"] + "%";
            }
            if (null != queryParams["YEAR3_V"] && "" != queryParams["YEAR3_V"].ToString().Trim())
            {
                queryParams["YEAR3_V"] = "%" + queryParams["YEAR3_V"] + "%";
            }
            if (null != queryParams["LICENSESTART3_V"] && "" != queryParams["LICENSESTART3_V"].ToString().Trim())
            {
                queryParams["LICENSESTART3_V"] = "%" + queryParams["LICENSESTART3_V"] + "%";
            }
            if (null != queryParams["LICENSEEND3_V"] && "" != queryParams["LICENSEEND3_V"].ToString().Trim())
            {
                queryParams["LICENSEEND3_V"] = "%" + queryParams["LICENSEEND3_V"] + "%";
            }
            if (null != queryParams["MONEY3_V"] && "" != queryParams["MONEY3_V"].ToString().Trim())
            {
                queryParams["MONEY3_V"] = "%" + queryParams["MONEY3_V"] + "%";
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

            Hashtable totalCount = (Hashtable)Mapper.Instance().QueryForObject("ResellerQuotationSystem.reseller_shipper3.getreseller_shipper3ByTotalCount", queryParams);
            return  AxtCRUD.readJson("ResellerQuotationSystem.reseller_shipper3.getreseller_shipper3By", queryParams, "reseller_shipper3", totalCount["NUM"].ToString());
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
            
            Hashtable totalCount = (Hashtable) Mapper.Instance().QueryForObject("ResellerQuotationSystem.reseller_shipper3.getWork_event",queryParams);
                if (totalCount == null )
                {
                    data["SID"] = AxtLibrary.GetUniqueKey(18);
                    AxtCRUD.insert("ResellerQuotationSystem.reseller_shipper3.addStatus",data);
                }
                else
                {
                    data["SID"] = AxtLibrary.GetUniqueKey(18);
                    AxtCRUD.update("ResellerQuotationSystem.reseller_shipper3.updateStatus",data);
                }
            return "ANS_00003";
        }
        public static ArrayList getreseller_shipper3Ship_date_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.reseller_shipper3.getreseller_shipper3Ship_date_vBy", queryParams);
        }

        public static ArrayList getreseller_shipper3Manager_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.reseller_shipper3.getreseller_shipper3Manager_vBy", queryParams);
        }

        public static ArrayList getreseller_shipper3Quantity3_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.reseller_shipper3.getreseller_shipper3Quantity3_vBy", queryParams);
        }

        public static ArrayList getreseller_shipper3Quantity2_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.reseller_shipper3.getreseller_shipper3Quantity2_vBy", queryParams);
        }

        public static ArrayList getreseller_shipper3Quantity_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.reseller_shipper3.getreseller_shipper3Quantity_vBy", queryParams);
        }

        public static ArrayList getreseller_shipper3Product3_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.reseller_shipper3.getreseller_shipper3Product3_vBy", queryParams);
        }

        public static ArrayList getreseller_shipper3Product2_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.reseller_shipper3.getreseller_shipper3Product2_vBy", queryParams);
        }

        public static ArrayList getreseller_shipper3Product_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.reseller_shipper3.getreseller_shipper3Product_vBy", queryParams);
        }

        public static ArrayList getreseller_shipper3Note_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.reseller_shipper3.getreseller_shipper3Note_vBy", queryParams);
        }

        public static ArrayList getreseller_shipper3Item3_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.reseller_shipper3.getreseller_shipper3Item3_vBy", queryParams);
        }

        public static ArrayList getreseller_shipper3Item2_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.reseller_shipper3.getreseller_shipper3Item2_vBy", queryParams);
        }

        public static ArrayList getreseller_shipper3Item_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.reseller_shipper3.getreseller_shipper3Item_vBy", queryParams);
        }

        public static ArrayList getreseller_shipper3Head_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.reseller_shipper3.getreseller_shipper3Head_vBy", queryParams);
        }

        public static ArrayList getreseller_shipper3Deliveryaddress_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.reseller_shipper3.getreseller_shipper3Deliveryaddress_vBy", queryParams);
        }

        public static ArrayList getreseller_shipper3Finalcustomer_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.reseller_shipper3.getreseller_shipper3Finalcustomer_vBy", queryParams);
        }

        public static ArrayList getreseller_shipper3Dealer_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.reseller_shipper3.getreseller_shipper3Dealer_vBy", queryParams);
        }

        public static ArrayList getreseller_shipper3Customers_sign_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.reseller_shipper3.getreseller_shipper3Customers_sign_vBy", queryParams);
        }

        public static ArrayList getreseller_shipper3Attn_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.reseller_shipper3.getreseller_shipper3Attn_vBy", queryParams);
        }

        public static ArrayList getreseller_shipper3Address_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.reseller_shipper3.getreseller_shipper3Address_vBy", queryParams);
        }

        public static ArrayList getreseller_shipper3Fax_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.reseller_shipper3.getreseller_shipper3Fax_vBy", queryParams);
        }

        public static ArrayList getreseller_shipper3Phone_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.reseller_shipper3.getreseller_shipper3Phone_vBy", queryParams);
        }

        public static ArrayList getreseller_shipper3Email_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.reseller_shipper3.getreseller_shipper3Email_vBy", queryParams);
        }

        public static ArrayList getreseller_shipper3Compact_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.reseller_shipper3.getreseller_shipper3Compact_vBy", queryParams);
        }

        public static ArrayList getreseller_shipper3Unifiednumbering_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.reseller_shipper3.getreseller_shipper3Unifiednumbering_vBy", queryParams);
        }

        public static ArrayList getreseller_shipper3Customername_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.reseller_shipper3.getreseller_shipper3Customername_vBy", queryParams);
        }

        /*user code start*/
        /*user code end*/
    }

}