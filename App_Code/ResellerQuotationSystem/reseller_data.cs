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
    public class reseller_data
    {
        public static void createTable()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable queryParams = new Hashtable();
            AxtCRUD.createTable("ResellerQuotationSystem.reseller_data.createreseller_data", queryParams);
            AxtCRUD.createTable("ResellerQuotationSystem.reseller_data.createreseller_dataHistory", queryParams);
        }

        public static string getreseller_data(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable totalCount = (Hashtable)Mapper.Instance().QueryForObject("ResellerQuotationSystem.reseller_datagetreseller_dataTotalCount", queryParams);
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_data.getreseller_data", queryParams, "reseller_data", totalCount["NUM"].ToString());
        }

        public static string getCBXDEALER_TW_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_data.getCBXDEALER_TW_V", queryParams, "reseller_data");
        }
        public static string getCBXORDER_CUSTOMER_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_data.getCBXORDER_CUSTOMER_V", queryParams, "reseller_data");
        }
		public static string getCBXDEALER_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_data.getCBXDEALER_V", queryParams, "reseller_data");
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
                    AxtCRUD.insert("ResellerQuotationSystem.reseller_data.addData", data);

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

            AxtCRUD.update("ResellerQuotationSystem.reseller_data.updateData", data);
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
            AxtCRUD.delete("ResellerQuotationSystem.reseller_data.deleteAll", queryParams);
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
                    AxtCRUD.delete("ResellerQuotationSystem.reseller_data.deleteData", data);
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

        public static string getreseller_dataBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            if (null != queryParams["DEALER_TW_V"] && "" != queryParams["DEALER_TW_V"].ToString().Trim())
            {
                queryParams["DEALER_TW_V"] = "%" + queryParams["DEALER_TW_V"] + "%";
            }
            if (null != queryParams["UNIFORM_NUMBERS_V"] && "" != queryParams["UNIFORM_NUMBERS_V"].ToString().Trim())
            {
                queryParams["UNIFORM_NUMBERS_V"] = "%" + queryParams["UNIFORM_NUMBERS_V"] + "%";
            }
            if (null != queryParams["CUSTOMER_CONTACT_V"] && "" != queryParams["CUSTOMER_CONTACT_V"].ToString().Trim())
            {
                queryParams["CUSTOMER_CONTACT_V"] = "%" + queryParams["CUSTOMER_CONTACT_V"] + "%";
            }
            if (null != queryParams["CONTACT_PHONE_V"] && "" != queryParams["CONTACT_PHONE_V"].ToString().Trim())
            {
                queryParams["CONTACT_PHONE_V"] = "%" + queryParams["CONTACT_PHONE_V"] + "%";
            }
            if (null != queryParams["FAX_NUMBER_V"] && "" != queryParams["FAX_NUMBER_V"].ToString().Trim())
            {
                queryParams["FAX_NUMBER_V"] = "%" + queryParams["FAX_NUMBER_V"] + "%";
            }
            if (null != queryParams["CONTACT_ADDRESS_V"] && "" != queryParams["CONTACT_ADDRESS_V"].ToString().Trim())
            {
                queryParams["CONTACT_ADDRESS_V"] = "%" + queryParams["CONTACT_ADDRESS_V"] + "%";
            }
            if (null != queryParams["SHIPPING_ADDRESS_V"] && "" != queryParams["SHIPPING_ADDRESS_V"].ToString().Trim())
            {
                queryParams["SHIPPING_ADDRESS_V"] = "%" + queryParams["SHIPPING_ADDRESS_V"] + "%";
            }
            if (null != queryParams["EMAIL_V"] && "" != queryParams["EMAIL_V"].ToString().Trim())
            {
                queryParams["EMAIL_V"] = "%" + queryParams["EMAIL_V"] + "%";
            }
            if (null != queryParams["WEBSITE_V"] && "" != queryParams["WEBSITE_V"].ToString().Trim())
            {
                queryParams["WEBSITE_V"] = "%" + queryParams["WEBSITE_V"] + "%";
            }
            if (null != queryParams["ORDER_CUSTOMER_V"] && "" != queryParams["ORDER_CUSTOMER_V"].ToString().Trim())
            {
                queryParams["ORDER_CUSTOMER_V"] = "%" + queryParams["ORDER_CUSTOMER_V"] + "%";
            }
            if (null != queryParams["DEALER_V"] && "" != queryParams["DEALER_V"].ToString().Trim())
            {
                queryParams["DEALER_V"] = "%" + queryParams["DEALER_V"] + "%";
            }
            if (null != queryParams["ENTRY_DATE_V"] && "" != queryParams["ENTRY_DATE_V"].ToString().Trim())
            {
                queryParams["ENTRY_DATE_V"] = "%" + queryParams["ENTRY_DATE_V"] + "%";
            }
            if (null != queryParams["LAST_SEQUENCE_V"] && "" != queryParams["LAST_SEQUENCE_V"].ToString().Trim())
            {
                queryParams["LAST_SEQUENCE_V"] = "%" + queryParams["LAST_SEQUENCE_V"] + "%";
            }

            Hashtable totalCount = (Hashtable)Mapper.Instance().QueryForObject("ResellerQuotationSystem.reseller_data.getreseller_dataByTotalCount", queryParams);
            return  AxtCRUD.readJson("ResellerQuotationSystem.reseller_data.getreseller_dataBy", queryParams, "reseller_data", totalCount["NUM"].ToString());
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
            
            Hashtable totalCount = (Hashtable) Mapper.Instance().QueryForObject("ResellerQuotationSystem.reseller_data.getWork_event",queryParams);
                if (totalCount == null )
                {
                    data["SID"] = AxtLibrary.GetUniqueKey(18);
                    AxtCRUD.insert("ResellerQuotationSystem.reseller_data.addStatus",data);
                }
                else
                {
                    data["SID"] = AxtLibrary.GetUniqueKey(18);
                    AxtCRUD.update("ResellerQuotationSystem.reseller_data.updateStatus",data);
                }
            return "ANS_00003";
        }
        public static ArrayList getreseller_dataContact_address_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.reseller_data.getreseller_dataContact_address_vBy", queryParams);
        }

        public static ArrayList getreseller_dataContact_phone_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.reseller_data.getreseller_dataContact_phone_vBy", queryParams);
        }

        public static ArrayList getreseller_dataCustomer_contact_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.reseller_data.getreseller_dataCustomer_contact_vBy", queryParams);
        }

        public static ArrayList getreseller_dataEmail_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.reseller_data.getreseller_dataEmail_vBy", queryParams);
        }

        public static ArrayList getreseller_dataFax_number_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.reseller_data.getreseller_dataFax_number_vBy", queryParams);
        }

        public static ArrayList getreseller_dataOrder_customer_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.reseller_data.getreseller_dataOrder_customer_vBy", queryParams);
        }

        public static ArrayList getreseller_dataShipping_address_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.reseller_data.getreseller_dataShipping_address_vBy", queryParams);
        }

        public static ArrayList getreseller_dataUniform_numbers_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.reseller_data.getreseller_dataUniform_numbers_vBy", queryParams);
        }

        public static ArrayList getreseller_dataWebsite_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.reseller_data.getreseller_dataWebsite_vBy", queryParams);
        }

        public static ArrayList getreseller_dataDealer_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.reseller_data.getreseller_dataDealer_vBy", queryParams);
        }
        /*user code start*/
        /*user code end*/
    }

}