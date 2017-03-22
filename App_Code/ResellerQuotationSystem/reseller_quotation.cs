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
    public class reseller_quotation
    {
        public static void createTable()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable queryParams = new Hashtable();
            AxtCRUD.createTable("ResellerQuotationSystem.reseller_quotation.createreseller_quotation", queryParams);
            AxtCRUD.createTable("ResellerQuotationSystem.reseller_quotation.createreseller_quotationHistory", queryParams);
        }

        public static string getreseller_quotation(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable totalCount = (Hashtable)Mapper.Instance().QueryForObject("ResellerQuotationSystem.reseller_quotationgetreseller_quotationTotalCount", queryParams);
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_quotation.getreseller_quotation", queryParams, "reseller_quotation", totalCount["NUM"].ToString());
        }

        public static string getCBXRESELLERNAME_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_quotation.getCBXRESELLERNAME_V", queryParams, "reseller_quotation");
        }
        public static string getCBXQUOTATIONNO_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_quotation.getCBXQUOTATIONNO_V", queryParams, "reseller_quotation");
        }
        public static string getCBXPAYMENT_CONDITIONS_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_quotation.getCBXPAYMENT_CONDITIONS_V", queryParams, "reseller_quotation");
        }
        public static string getCBXCOMPETITIVEBRANDS_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_quotation.getCBXCOMPETITIVEBRANDS_V", queryParams, "reseller_quotation");
        }
        public static string getCBXCUSTOMERNAME_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_quotation.getCBXCUSTOMERNAME_V", queryParams, "reseller_quotation");
        }
        public static string getCBXORDERTYPE_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_quotation.getCBXORDERTYPE_V", queryParams, "reseller_quotation");
        }
        public static string getCBXOFFERORS_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_quotation.getCBXOFFERORS_V", queryParams, "reseller_quotation");
        }
        public static string getCBXITEM1_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_quotation.getCBXITEM1_V", queryParams, "reseller_quotation");
        }
        public static string getCBXPRODUCT_NAME1_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_quotation.getCBXPRODUCT_NAME1_V", queryParams, "reseller_quotation");
        }
        public static string getCBXSPECIFICATION1_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_quotation.getCBXSPECIFICATION1_V", queryParams, "reseller_quotation");
        }
        public static string getCBXQUANTITY1_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_quotation.getCBXQUANTITY1_V", queryParams, "reseller_quotation");
        }
        public static string getCBXITEM2_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_quotation.getCBXITEM2_V", queryParams, "reseller_quotation");
        }
        public static string getCBXPRODUCT_NAME2_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_quotation.getCBXPRODUCT_NAME2_V", queryParams, "reseller_quotation");
        }
        public static string getCBXSPECIFICATION2_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_quotation.getCBXSPECIFICATION2_V", queryParams, "reseller_quotation");
        }
        public static string getCBXQUANTITY2_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_quotation.getCBXQUANTITY2_V", queryParams, "reseller_quotation");
        }
        public static string getCBXITEM3_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_quotation.getCBXITEM3_V", queryParams, "reseller_quotation");
        }
        public static string getCBXPRODUCT_NAME3_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_quotation.getCBXPRODUCT_NAME3_V", queryParams, "reseller_quotation");
        }
        public static string getCBXSPECIFICATION3_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_quotation.getCBXSPECIFICATION3_V", queryParams, "reseller_quotation");
        }
        public static string getCBXQUANTITY3_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_quotation.getCBXQUANTITY3_V", queryParams, "reseller_quotation");
        }
        public static string getCBXITEM4_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_quotation.getCBXITEM4_V", queryParams, "reseller_quotation");
        }
        public static string getCBXPRODUCT_NAME4_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_quotation.getCBXPRODUCT_NAME4_V", queryParams, "reseller_quotation");
        }
        public static string getCBXSPECIFICATION4_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_quotation.getCBXSPECIFICATION4_V", queryParams, "reseller_quotation");
        }
        public static string getCBXQUANTITY4_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_quotation.getCBXQUANTITY4_V", queryParams, "reseller_quotation");
        }
        public static string getCBXHEAD_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_quotation.getCBXHEAD_V", queryParams, "reseller_quotation");
        }
        public static string getCBXSALES_MANAGER_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_quotation.getCBXSALES_MANAGER_V", queryParams, "reseller_quotation");
        }
        public static string getCBXATTN_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_quotation.getCBXATTN_V", queryParams, "reseller_quotation");
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
                    AxtCRUD.insert("ResellerQuotationSystem.reseller_quotation.addData", data);

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

            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation.updateData", data);
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
            AxtCRUD.delete("ResellerQuotationSystem.reseller_quotation.deleteAll", queryParams);
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
                    AxtCRUD.delete("ResellerQuotationSystem.reseller_quotation.deleteData", data);
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

        public static string getreseller_quotationBy(Hashtable queryParams)
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
            if (null != queryParams["QUOTE_DATE_V"] && "" != queryParams["QUOTE_DATE_V"].ToString().Trim())
            {
                queryParams["QUOTE_DATE_V"] = "%" + queryParams["QUOTE_DATE_V"] + "%";
            }
            if (null != queryParams["COMPACT_V"] && "" != queryParams["COMPACT_V"].ToString().Trim())
            {
                queryParams["COMPACT_V"] = "%" + queryParams["COMPACT_V"] + "%";
            }
            if (null != queryParams["SHIP_DATE_V"] && "" != queryParams["SHIP_DATE_V"].ToString().Trim())
            {
                queryParams["SHIP_DATE_V"] = "%" + queryParams["SHIP_DATE_V"] + "%";
            }
            if (null != queryParams["EMAIL_V"] && "" != queryParams["EMAIL_V"].ToString().Trim())
            {
                queryParams["EMAIL_V"] = "%" + queryParams["EMAIL_V"] + "%";
            }
            if (null != queryParams["PAYMENT_CONDITIONS_V"] && "" != queryParams["PAYMENT_CONDITIONS_V"].ToString().Trim())
            {
                queryParams["PAYMENT_CONDITIONS_V"] = "%" + queryParams["PAYMENT_CONDITIONS_V"] + "%";
            }
            if (null != queryParams["PHONE_V"] && "" != queryParams["PHONE_V"].ToString().Trim())
            {
                queryParams["PHONE_V"] = "%" + queryParams["PHONE_V"] + "%";
            }
            if (null != queryParams["COMPETITIVEBRANDS_V"] && "" != queryParams["COMPETITIVEBRANDS_V"].ToString().Trim())
            {
                queryParams["COMPETITIVEBRANDS_V"] = "%" + queryParams["COMPETITIVEBRANDS_V"] + "%";
            }
            if (null != queryParams["FAX_V"] && "" != queryParams["FAX_V"].ToString().Trim())
            {
                queryParams["FAX_V"] = "%" + queryParams["FAX_V"] + "%";
            }
            if (null != queryParams["CUSTOMERNAME_V"] && "" != queryParams["CUSTOMERNAME_V"].ToString().Trim())
            {
                queryParams["CUSTOMERNAME_V"] = "%" + queryParams["CUSTOMERNAME_V"] + "%";
            }
            if (null != queryParams["ADDRESS_V"] && "" != queryParams["ADDRESS_V"].ToString().Trim())
            {
                queryParams["ADDRESS_V"] = "%" + queryParams["ADDRESS_V"] + "%";
            }
            if (null != queryParams["ORDERTYPE_V"] && "" != queryParams["ORDERTYPE_V"].ToString().Trim())
            {
                queryParams["ORDERTYPE_V"] = "%" + queryParams["ORDERTYPE_V"] + "%";
            }
            if (null != queryParams["DELIVERYADDRESS_V"] && "" != queryParams["DELIVERYADDRESS_V"].ToString().Trim())
            {
                queryParams["DELIVERYADDRESS_V"] = "%" + queryParams["DELIVERYADDRESS_V"] + "%";
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
            if (null != queryParams["ONEYEARVALUE1_V"] && "" != queryParams["ONEYEARVALUE1_V"].ToString().Trim())
            {
                queryParams["ONEYEARVALUE1_V"] = "%" + queryParams["ONEYEARVALUE1_V"] + "%";
            }
            if (null != queryParams["ONE_YEAR_PRICE1_V"] && "" != queryParams["ONE_YEAR_PRICE1_V"].ToString().Trim())
            {
                queryParams["ONE_YEAR_PRICE1_V"] = "%" + queryParams["ONE_YEAR_PRICE1_V"] + "%";
            }
            if (null != queryParams["THREEYEARVALUE1_V"] && "" != queryParams["THREEYEARVALUE1_V"].ToString().Trim())
            {
                queryParams["THREEYEARVALUE1_V"] = "%" + queryParams["THREEYEARVALUE1_V"] + "%";
            }
            if (null != queryParams["THREE_YEAR_PRICE1_V"] && "" != queryParams["THREE_YEAR_PRICE1_V"].ToString().Trim())
            {
                queryParams["THREE_YEAR_PRICE1_V"] = "%" + queryParams["THREE_YEAR_PRICE1_V"] + "%";
            }
            if (null != queryParams["ITEM2_V"] && "" != queryParams["ITEM2_V"].ToString().Trim())
            {
                queryParams["ITEM2_V"] = "%" + queryParams["ITEM2_V"] + "%";
            }
            if (null != queryParams["PRODUCT_NAME2_V"] && "" != queryParams["PRODUCT_NAME2_V"].ToString().Trim())
            {
                queryParams["PRODUCT_NAME2_V"] = "%" + queryParams["PRODUCT_NAME2_V"] + "%";
            }
            if (null != queryParams["SPECIFICATION2_V"] && "" != queryParams["SPECIFICATION2_V"].ToString().Trim())
            {
                queryParams["SPECIFICATION2_V"] = "%" + queryParams["SPECIFICATION2_V"] + "%";
            }
            if (null != queryParams["QUANTITY2_V"] && "" != queryParams["QUANTITY2_V"].ToString().Trim())
            {
                queryParams["QUANTITY2_V"] = "%" + queryParams["QUANTITY2_V"] + "%";
            }
            if (null != queryParams["ONEYEARVALUE2_V"] && "" != queryParams["ONEYEARVALUE2_V"].ToString().Trim())
            {
                queryParams["ONEYEARVALUE2_V"] = "%" + queryParams["ONEYEARVALUE2_V"] + "%";
            }
            if (null != queryParams["ONE_YEAR_PRICE2_V"] && "" != queryParams["ONE_YEAR_PRICE2_V"].ToString().Trim())
            {
                queryParams["ONE_YEAR_PRICE2_V"] = "%" + queryParams["ONE_YEAR_PRICE2_V"] + "%";
            }
            if (null != queryParams["THREEYEARVALUE2_V"] && "" != queryParams["THREEYEARVALUE2_V"].ToString().Trim())
            {
                queryParams["THREEYEARVALUE2_V"] = "%" + queryParams["THREEYEARVALUE2_V"] + "%";
            }
            if (null != queryParams["THREE_YEAR_PRICE2_V"] && "" != queryParams["THREE_YEAR_PRICE2_V"].ToString().Trim())
            {
                queryParams["THREE_YEAR_PRICE2_V"] = "%" + queryParams["THREE_YEAR_PRICE2_V"] + "%";
            }
            if (null != queryParams["ITEM3_V"] && "" != queryParams["ITEM3_V"].ToString().Trim())
            {
                queryParams["ITEM3_V"] = "%" + queryParams["ITEM3_V"] + "%";
            }
            if (null != queryParams["PRODUCT_NAME3_V"] && "" != queryParams["PRODUCT_NAME3_V"].ToString().Trim())
            {
                queryParams["PRODUCT_NAME3_V"] = "%" + queryParams["PRODUCT_NAME3_V"] + "%";
            }
            if (null != queryParams["SPECIFICATION3_V"] && "" != queryParams["SPECIFICATION3_V"].ToString().Trim())
            {
                queryParams["SPECIFICATION3_V"] = "%" + queryParams["SPECIFICATION3_V"] + "%";
            }
            if (null != queryParams["QUANTITY3_V"] && "" != queryParams["QUANTITY3_V"].ToString().Trim())
            {
                queryParams["QUANTITY3_V"] = "%" + queryParams["QUANTITY3_V"] + "%";
            }
            if (null != queryParams["ONEYEARVALUE3_V"] && "" != queryParams["ONEYEARVALUE3_V"].ToString().Trim())
            {
                queryParams["ONEYEARVALUE3_V"] = "%" + queryParams["ONEYEARVALUE3_V"] + "%";
            }
            if (null != queryParams["ONE_YEAR_PRICE3_V"] && "" != queryParams["ONE_YEAR_PRICE3_V"].ToString().Trim())
            {
                queryParams["ONE_YEAR_PRICE3_V"] = "%" + queryParams["ONE_YEAR_PRICE3_V"] + "%";
            }
            if (null != queryParams["THREEYEARVALUE3_V"] && "" != queryParams["THREEYEARVALUE3_V"].ToString().Trim())
            {
                queryParams["THREEYEARVALUE3_V"] = "%" + queryParams["THREEYEARVALUE3_V"] + "%";
            }
            if (null != queryParams["THREE_YEAR_PRICE3_V"] && "" != queryParams["THREE_YEAR_PRICE3_V"].ToString().Trim())
            {
                queryParams["THREE_YEAR_PRICE3_V"] = "%" + queryParams["THREE_YEAR_PRICE3_V"] + "%";
            }
            if (null != queryParams["ITEM4_V"] && "" != queryParams["ITEM4_V"].ToString().Trim())
            {
                queryParams["ITEM4_V"] = "%" + queryParams["ITEM4_V"] + "%";
            }
            if (null != queryParams["PRODUCT_NAME4_V"] && "" != queryParams["PRODUCT_NAME4_V"].ToString().Trim())
            {
                queryParams["PRODUCT_NAME4_V"] = "%" + queryParams["PRODUCT_NAME4_V"] + "%";
            }
            if (null != queryParams["SPECIFICATION4_V"] && "" != queryParams["SPECIFICATION4_V"].ToString().Trim())
            {
                queryParams["SPECIFICATION4_V"] = "%" + queryParams["SPECIFICATION4_V"] + "%";
            }
            if (null != queryParams["QUANTITY4_V"] && "" != queryParams["QUANTITY4_V"].ToString().Trim())
            {
                queryParams["QUANTITY4_V"] = "%" + queryParams["QUANTITY4_V"] + "%";
            }
            if (null != queryParams["ONE_YEAR_VALUE4_V"] && "" != queryParams["ONE_YEAR_VALUE4_V"].ToString().Trim())
            {
                queryParams["ONE_YEAR_VALUE4_V"] = "%" + queryParams["ONE_YEAR_VALUE4_V"] + "%";
            }
            if (null != queryParams["ONE_YEAR_PRICE4_V"] && "" != queryParams["ONE_YEAR_PRICE4_V"].ToString().Trim())
            {
                queryParams["ONE_YEAR_PRICE4_V"] = "%" + queryParams["ONE_YEAR_PRICE4_V"] + "%";
            }
            if (null != queryParams["THREE_YEAR_VALUE4_V"] && "" != queryParams["THREE_YEAR_VALUE4_V"].ToString().Trim())
            {
                queryParams["THREE_YEAR_VALUE4_V"] = "%" + queryParams["THREE_YEAR_VALUE4_V"] + "%";
            }
            if (null != queryParams["THREE_YEAR_PRICE4_V"] && "" != queryParams["THREE_YEAR_PRICE4_V"].ToString().Trim())
            {
                queryParams["THREE_YEAR_PRICE4_V"] = "%" + queryParams["THREE_YEAR_PRICE4_V"] + "%";
            }
            if (null != queryParams["NOAMOUNTTAXVALUEYEAR_V"] && "" != queryParams["NOAMOUNTTAXVALUEYEAR_V"].ToString().Trim())
            {
                queryParams["NOAMOUNTTAXVALUEYEAR_V"] = "%" + queryParams["NOAMOUNTTAXVALUEYEAR_V"] + "%";
            }
            if (null != queryParams["NO_AMOUNT_TAX_YEAR_V"] && "" != queryParams["NO_AMOUNT_TAX_YEAR_V"].ToString().Trim())
            {
                queryParams["NO_AMOUNT_TAX_YEAR_V"] = "%" + queryParams["NO_AMOUNT_TAX_YEAR_V"] + "%";
            }
            if (null != queryParams["NOAMOUNTTAXVALUETRIENNIAL_V"] && "" != queryParams["NOAMOUNTTAXVALUETRIENNIAL_V"].ToString().Trim())
            {
                queryParams["NOAMOUNTTAXVALUETRIENNIAL_V"] = "%" + queryParams["NOAMOUNTTAXVALUETRIENNIAL_V"] + "%";
            }
            if (null != queryParams["NO_TAX_AMOUNT_TRIENNIAL_V"] && "" != queryParams["NO_TAX_AMOUNT_TRIENNIAL_V"].ToString().Trim())
            {
                queryParams["NO_TAX_AMOUNT_TRIENNIAL_V"] = "%" + queryParams["NO_TAX_AMOUNT_TRIENNIAL_V"] + "%";
            }
            if (null != queryParams["ONEYEARSALESTAXVALUE_V"] && "" != queryParams["ONEYEARSALESTAXVALUE_V"].ToString().Trim())
            {
                queryParams["ONEYEARSALESTAXVALUE_V"] = "%" + queryParams["ONEYEARSALESTAXVALUE_V"] + "%";
            }
            if (null != queryParams["ONE_YEAR_SALES_TAX_V"] && "" != queryParams["ONE_YEAR_SALES_TAX_V"].ToString().Trim())
            {
                queryParams["ONE_YEAR_SALES_TAX_V"] = "%" + queryParams["ONE_YEAR_SALES_TAX_V"] + "%";
            }
            if (null != queryParams["THREEYEARSALESTAXVALUE_V"] && "" != queryParams["THREEYEARSALESTAXVALUE_V"].ToString().Trim())
            {
                queryParams["THREEYEARSALESTAXVALUE_V"] = "%" + queryParams["THREEYEARSALESTAXVALUE_V"] + "%";
            }
            if (null != queryParams["THREE_YEAR_SALES_TAX_V"] && "" != queryParams["THREE_YEAR_SALES_TAX_V"].ToString().Trim())
            {
                queryParams["THREE_YEAR_SALES_TAX_V"] = "%" + queryParams["THREE_YEAR_SALES_TAX_V"] + "%";
            }
            if (null != queryParams["TOTALVALUEYEAR_V"] && "" != queryParams["TOTALVALUEYEAR_V"].ToString().Trim())
            {
                queryParams["TOTALVALUEYEAR_V"] = "%" + queryParams["TOTALVALUEYEAR_V"] + "%";
            }
            if (null != queryParams["TOTAL_YEAR_V"] && "" != queryParams["TOTAL_YEAR_V"].ToString().Trim())
            {
                queryParams["TOTAL_YEAR_V"] = "%" + queryParams["TOTAL_YEAR_V"] + "%";
            }
            if (null != queryParams["TOTALTHREEYEARVALUEPERIOD_V"] && "" != queryParams["TOTALTHREEYEARVALUEPERIOD_V"].ToString().Trim())
            {
                queryParams["TOTALTHREEYEARVALUEPERIOD_V"] = "%" + queryParams["TOTALTHREEYEARVALUEPERIOD_V"] + "%";
            }
            if (null != queryParams["TOTAL_THREE_YEAR_PERIOD_V"] && "" != queryParams["TOTAL_THREE_YEAR_PERIOD_V"].ToString().Trim())
            {
                queryParams["TOTAL_THREE_YEAR_PERIOD_V"] = "%" + queryParams["TOTAL_THREE_YEAR_PERIOD_V"] + "%";
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

            Hashtable totalCount = (Hashtable)Mapper.Instance().QueryForObject("ResellerQuotationSystem.reseller_quotation.getreseller_quotationByTotalCount", queryParams);
            return  AxtCRUD.readJson("ResellerQuotationSystem.reseller_quotation.getreseller_quotationBy", queryParams, "reseller_quotation", totalCount["NUM"].ToString());
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
            
            Hashtable totalCount = (Hashtable) Mapper.Instance().QueryForObject("ResellerQuotationSystem.reseller_quotation.getWork_event",queryParams);
                if (totalCount == null )
                {
                    data["SID"] = AxtLibrary.GetUniqueKey(18);
                    AxtCRUD.insert("ResellerQuotationSystem.reseller_quotation.addStatus",data);
                }
                else
                {
                    data["SID"] = AxtLibrary.GetUniqueKey(18);
                    AxtCRUD.update("ResellerQuotationSystem.reseller_quotation.updateStatus",data);
                }
            return "ANS_00003";
        }
        public static ArrayList getreseller_quotationAddress_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.reseller_quotation.getreseller_quotationAddress_vBy", queryParams);
        }

        public static ArrayList getreseller_quotationCompact_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.reseller_quotation.getreseller_quotationCompact_vBy", queryParams);
        }

        public static ArrayList getreseller_quotationCustomername_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.reseller_quotation.getreseller_quotationCustomername_vBy", queryParams);
        }

        public static ArrayList getreseller_quotationEmail_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.reseller_quotation.getreseller_quotationEmail_vBy", queryParams);
        }

        public static ArrayList getreseller_quotationFax_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.reseller_quotation.getreseller_quotationFax_vBy", queryParams);
        }

        /*user code start*/
        /*user code end*/
    }

}