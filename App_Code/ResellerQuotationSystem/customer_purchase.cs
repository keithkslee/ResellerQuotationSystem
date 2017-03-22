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
    public class customer_purchase
    {
        public static void createTable()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable queryParams = new Hashtable();
            AxtCRUD.createTable("ResellerQuotationSystem.customer_purchase.createcustomer_purchase", queryParams);
            AxtCRUD.createTable("ResellerQuotationSystem.customer_purchase.createcustomer_purchaseHistory", queryParams);
        }

        public static string getcustomer_purchase(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable totalCount = (Hashtable)Mapper.Instance().QueryForObject("ResellerQuotationSystem.customer_purchasegetcustomer_purchaseTotalCount", queryParams);
            return AxtCRUD.readJson("ResellerQuotationSystem.customer_purchase.getcustomer_purchase", queryParams, "customer_purchase", totalCount["NUM"].ToString());
        }

        public static string getCBXNO_ORDER_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.customer_purchase.getCBXNO_ORDER_V", queryParams, "customer_purchase");
        }
        public static string getCBXQUOTATIONNO_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.customer_purchase.getCBXQUOTATIONNO_V", queryParams, "customer_purchase");
        }
        public static string getCBXORDERTYPE_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.customer_purchase.getCBXORDERTYPE_V", queryParams, "customer_purchase");
        }
        public static string getCBXDEALER_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.customer_purchase.getCBXDEALER_V", queryParams, "customer_purchase");
        }
        public static string getCBXCUSTOMERID_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.customer_purchase.getCBXCUSTOMERID_V", queryParams, "customer_purchase");
        }
        public static string getCBXCUSTOMERNAME_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.customer_purchase.getCBXCUSTOMERNAME_V", queryParams, "customer_purchase");
        }
        public static string getCBXCOMPETITIVEBRANDS_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.customer_purchase.getCBXCOMPETITIVEBRANDS_V", queryParams, "customer_purchase");
        }
        public static string getCBXORDERPRODUCT1_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.customer_purchase.getCBXORDERPRODUCT1_V", queryParams, "customer_purchase");
        }
        public static string getCBXORDERPRODUCT2_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.customer_purchase.getCBXORDERPRODUCT2_V", queryParams, "customer_purchase");
        }
        public static string getCBXEXCHANGE_RATE_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.customer_purchase.getCBXEXCHANGE_RATE_V", queryParams, "customer_purchase");
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
                DateTime today = DateTime.Today;
		Hashtable queryParams = new Hashtable();
				int sequence = 0;
		queryParams["TODAY_DATE_V"] = today.ToString("yyyyMMdd");
		ArrayList sequenceByDate = AxtCRUD.read("ResellerQuotationSystem.customer_purchase.getSequenceByDate",queryParams);
				if(sequenceByDate.Count != 0){
						Hashtable sHashtable = (Hashtable) sequenceByDate[0];
						if(sHashtable["max(LAST_SEQUENCE_V)"] != null){
							sequence = (int)sHashtable["max(LAST_SEQUENCE_V)"];
						}
				}
				sequence = sequence + 1;
				data["ENTRY_DATE_V"] = today.ToString("yyyyMMdd");
				data["LAST_SEQUENCE_V"] = "" + sequence;
				
                data["GRID1"] = "P"+""+today.ToString("yyyyMMdd")+""+sequence.ToString("D2");
                    data["SID"] = AxtLibrary.GetUniqueKey(18);
                    AxtCRUD.insert("ResellerQuotationSystem.customer_purchase.addData", data);

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

            AxtCRUD.update("ResellerQuotationSystem.customer_purchase.updateData", data);
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
            AxtCRUD.delete("ResellerQuotationSystem.customer_purchase.deleteAll", queryParams);
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
                    AxtCRUD.delete("ResellerQuotationSystem.customer_purchase.deleteData", data);
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

        public static string getcustomer_purchaseBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            if (null != queryParams["NO_ORDER_V"] && "" != queryParams["NO_ORDER_V"].ToString().Trim())
            {
                queryParams["NO_ORDER_V"] = "%" + queryParams["NO_ORDER_V"] + "%";
            }
            if (null != queryParams["ORDERDATE_V"] && "" != queryParams["ORDERDATE_V"].ToString().Trim())
            {
                queryParams["ORDERDATE_V"] = "%" + queryParams["ORDERDATE_V"] + "%";
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
            if (null != queryParams["CUSTOMERNAMEEN_V"] && "" != queryParams["CUSTOMERNAMEEN_V"].ToString().Trim())
            {
                queryParams["CUSTOMERNAMEEN_V"] = "%" + queryParams["CUSTOMERNAMEEN_V"] + "%";
            }
            if (null != queryParams["WEBSITE_V"] && "" != queryParams["WEBSITE_V"].ToString().Trim())
            {
                queryParams["WEBSITE_V"] = "%" + queryParams["WEBSITE_V"] + "%";
            }
            if (null != queryParams["CONTACT_ADDRESS_V"] && "" != queryParams["CONTACT_ADDRESS_V"].ToString().Trim())
            {
                queryParams["CONTACT_ADDRESS_V"] = "%" + queryParams["CONTACT_ADDRESS_V"] + "%";
            }
            if (null != queryParams["ADDRESSENGLISH_V"] && "" != queryParams["ADDRESSENGLISH_V"].ToString().Trim())
            {
                queryParams["ADDRESSENGLISH_V"] = "%" + queryParams["ADDRESSENGLISH_V"] + "%";
            }
            if (null != queryParams["CONTACT_PHONE_V"] && "" != queryParams["CONTACT_PHONE_V"].ToString().Trim())
            {
                queryParams["CONTACT_PHONE_V"] = "%" + queryParams["CONTACT_PHONE_V"] + "%";
            }
            if (null != queryParams["CUSTOMER_CONTACT_V"] && "" != queryParams["CUSTOMER_CONTACT_V"].ToString().Trim())
            {
                queryParams["CUSTOMER_CONTACT_V"] = "%" + queryParams["CUSTOMER_CONTACT_V"] + "%";
            }
            if (null != queryParams["CONTACTENGLISH_V"] && "" != queryParams["CONTACTENGLISH_V"].ToString().Trim())
            {
                queryParams["CONTACTENGLISH_V"] = "%" + queryParams["CONTACTENGLISH_V"] + "%";
            }
            if (null != queryParams["EMAIL_V"] && "" != queryParams["EMAIL_V"].ToString().Trim())
            {
                queryParams["EMAIL_V"] = "%" + queryParams["EMAIL_V"] + "%";
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
            if (null != queryParams["QUANTITY_1_V"] && "" != queryParams["QUANTITY_1_V"].ToString().Trim())
            {
                queryParams["QUANTITY_1_V"] = "%" + queryParams["QUANTITY_1_V"] + "%";
            }
            if (null != queryParams["YEAR1_V"] && "" != queryParams["YEAR1_V"].ToString().Trim())
            {
                queryParams["YEAR1_V"] = "%" + queryParams["YEAR1_V"] + "%";
            }
            if (null != queryParams["AUTHORIZATIONSTARTDATE1_V"] && "" != queryParams["AUTHORIZATIONSTARTDATE1_V"].ToString().Trim())
            {
                queryParams["AUTHORIZATIONSTARTDATE1_V"] = "%" + queryParams["AUTHORIZATIONSTARTDATE1_V"] + "%";
            }
            if (null != queryParams["AUTHORIZATIONTERMINATIONDATE1_V"] && "" != queryParams["AUTHORIZATIONTERMINATIONDATE1_V"].ToString().Trim())
            {
                queryParams["AUTHORIZATIONTERMINATIONDATE1_V"] = "%" + queryParams["AUTHORIZATIONTERMINATIONDATE1_V"] + "%";
            }
            if (null != queryParams["QUANTITY_2_V"] && "" != queryParams["QUANTITY_2_V"].ToString().Trim())
            {
                queryParams["QUANTITY_2_V"] = "%" + queryParams["QUANTITY_2_V"] + "%";
            }
            if (null != queryParams["YEAR2_V"] && "" != queryParams["YEAR2_V"].ToString().Trim())
            {
                queryParams["YEAR2_V"] = "%" + queryParams["YEAR2_V"] + "%";
            }
            if (null != queryParams["AUTHORIZATIONSTARTDATE2_V"] && "" != queryParams["AUTHORIZATIONSTARTDATE2_V"].ToString().Trim())
            {
                queryParams["AUTHORIZATIONSTARTDATE2_V"] = "%" + queryParams["AUTHORIZATIONSTARTDATE2_V"] + "%";
            }
            if (null != queryParams["AUTHORIZETERMINATIONDATE2_V"] && "" != queryParams["AUTHORIZETERMINATIONDATE2_V"].ToString().Trim())
            {
                queryParams["AUTHORIZETERMINATIONDATE2_V"] = "%" + queryParams["AUTHORIZETERMINATIONDATE2_V"] + "%";
            }
            if (null != queryParams["AMOUNTTAX1_V"] && "" != queryParams["AMOUNTTAX1_V"].ToString().Trim())
            {
                queryParams["AMOUNTTAX1_V"] = "%" + queryParams["AMOUNTTAX1_V"] + "%";
            }
            if (null != queryParams["AMOUNTTAX2_V"] && "" != queryParams["AMOUNTTAX2_V"].ToString().Trim())
            {
                queryParams["AMOUNTTAX2_V"] = "%" + queryParams["AMOUNTTAX2_V"] + "%";
            }
            if (null != queryParams["US_DOLLAR_PRICING_V"] && "" != queryParams["US_DOLLAR_PRICING_V"].ToString().Trim())
            {
                queryParams["US_DOLLAR_PRICING_V"] = "%" + queryParams["US_DOLLAR_PRICING_V"] + "%";
            }
            if (null != queryParams["EXCHANGE_RATE_V"] && "" != queryParams["EXCHANGE_RATE_V"].ToString().Trim())
            {
                queryParams["EXCHANGE_RATE_V"] = "%" + queryParams["EXCHANGE_RATE_V"] + "%";
            }
            if (null != queryParams["NT_PRICING_V"] && "" != queryParams["NT_PRICING_V"].ToString().Trim())
            {
                queryParams["NT_PRICING_V"] = "%" + queryParams["NT_PRICING_V"] + "%";
            }
            if (null != queryParams["PRICE_NOT_TAX_V"] && "" != queryParams["PRICE_NOT_TAX_V"].ToString().Trim())
            {
                queryParams["PRICE_NOT_TAX_V"] = "%" + queryParams["PRICE_NOT_TAX_V"] + "%";
            }
            if (null != queryParams["MARGIN_V"] && "" != queryParams["MARGIN_V"].ToString().Trim())
            {
                queryParams["MARGIN_V"] = "%" + queryParams["MARGIN_V"] + "%";
            }
            if (null != queryParams["ENTRY_DATE_V"] && "" != queryParams["ENTRY_DATE_V"].ToString().Trim())
            {
                queryParams["ENTRY_DATE_V"] = "%" + queryParams["ENTRY_DATE_V"] + "%";
            }
            if (null != queryParams["LAST_SEQUENCE_V"] && "" != queryParams["LAST_SEQUENCE_V"].ToString().Trim())
            {
                queryParams["LAST_SEQUENCE_V"] = "%" + queryParams["LAST_SEQUENCE_V"] + "%";
            }

            Hashtable totalCount = (Hashtable)Mapper.Instance().QueryForObject("ResellerQuotationSystem.customer_purchase.getcustomer_purchaseByTotalCount", queryParams);
            return  AxtCRUD.readJson("ResellerQuotationSystem.customer_purchase.getcustomer_purchaseBy", queryParams, "customer_purchase", totalCount["NUM"].ToString());
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
            
            Hashtable totalCount = (Hashtable) Mapper.Instance().QueryForObject("ResellerQuotationSystem.customer_purchase.getWork_event",queryParams);
                if (totalCount == null )
                {
                    data["SID"] = AxtLibrary.GetUniqueKey(18);
                    AxtCRUD.insert("ResellerQuotationSystem.customer_purchase.addStatus",data);
                }
                else
                {
                    data["SID"] = AxtLibrary.GetUniqueKey(18);
                    AxtCRUD.update("ResellerQuotationSystem.customer_purchase.updateStatus",data);
                }
            return "ANS_00003";
        }
        public static ArrayList getcustomer_purchaseEmail_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.customer_purchase.getcustomer_purchaseEmail_vBy", queryParams);
        }

        public static ArrayList getcustomer_purchaseWebsite_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.customer_purchase.getcustomer_purchaseWebsite_vBy", queryParams);
        }

        public static ArrayList getcustomer_purchaseCustomer_contact_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.customer_purchase.getcustomer_purchaseCustomer_contact_vBy", queryParams);
        }

        public static ArrayList getcustomer_purchaseContact_phone_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.customer_purchase.getcustomer_purchaseContact_phone_vBy", queryParams);
        }

        public static ArrayList getcustomer_purchaseContact_address_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.customer_purchase.getcustomer_purchaseContact_address_vBy", queryParams);
        }

        /*user code start*/
        /*user code end*/
    }

}