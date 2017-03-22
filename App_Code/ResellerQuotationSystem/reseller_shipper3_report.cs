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
using AxtEmail;
namespace ResellerQuotationSystem.ResellerQuotationSystem
{
    public class reseller_shipper3_report
    {
        public static void createTable()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable queryParams = new Hashtable();
            AxtCRUD.createTable("ResellerQuotationSystem.reseller_shipper3_report.createreseller_shipper3_report", queryParams);
            AxtCRUD.createTable("ResellerQuotationSystem.reseller_shipper3_report.createreseller_shipper3_reportHistory", queryParams);
        }

        public static string getreseller_shipper3_report(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable totalCount = (Hashtable)Mapper.Instance().QueryForObject("ResellerQuotationSystem.reseller_shipper3_reportgetreseller_shipper3_reportTotalCount", queryParams);
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_shipper3_report.getreseller_shipper3_report", queryParams, "reseller_shipper3_report", totalCount["NUM"].ToString());
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
                    AxtCRUD.insert("ResellerQuotationSystem.reseller_shipper3_report.addData", data);

                }
                else
                {
                    update(data);
                }
            }

            setreporttitle_v();
            setreportname_v();
            setcustomername_v();
            setship_date_v();
            setunifiednumbering_v();
            setshipper_number_v();
            setcompact_v();
            setpayment_date_v();
            setemail_v();
            setpurchaseordernumber_v();
            setphone_v();
            setorderdate_v();
            setfax_v();
            setquotationno_v();
            setaddress_v();
            setdeliveryaddress_v();
            setitem_v();
            setproduct_v();
            setautorization_number_v();
            setquantity_v();
            setyear_v();
            setlicense_start_v();
            setlicense_end_v();
            setmoney_v();
            setitem2_v();
            setproduct2_v();
            setauthorizationnumber2_v();
            setquantity2_v();
            setyear2_v();
            setlicensestart2_v();
            setlicenseend2_v();
            setmoney2_v();
            setitem3_v();
            setproduct3_v();
            setauthorizationnumber3_v();
            setquantity3_v();
            setyear3_v();
            setlicensestart3_v();
            setlicenseend3_v();
            setmoney3_v();
            setno_tax_amount_v();
            setsales_tax_v();
            settotal_v();
            setnote_v();
            sethead_v();
            setmanager_v();
            setattn_v();
            setcustomers_sign_v();
            return "ANS_00003";
        }

        public static void update(Hashtable data)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            AxtCRUD.update("ResellerQuotationSystem.reseller_shipper3_report.updateData", data);
            /*update user code start*/
            /*update user code end*/
        }

        public static void setreporttitle_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_shipper3_report.setreporttitle_v", data);
        }

        public static void setreportname_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_shipper3_report.setreportname_v", data);
        }

        public static void setcustomername_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_shipper3_report.setcustomername_v", data);
        }

        public static void setship_date_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_shipper3_report.setship_date_v", data);
        }

        public static void setunifiednumbering_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_shipper3_report.setunifiednumbering_v", data);
        }

        public static void setshipper_number_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_shipper3_report.setshipper_number_v", data);
        }

        public static void setcompact_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_shipper3_report.setcompact_v", data);
        }

        public static void setpayment_date_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_shipper3_report.setpayment_date_v", data);
        }

        public static void setemail_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_shipper3_report.setemail_v", data);
        }

        public static void setpurchaseordernumber_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_shipper3_report.setpurchaseordernumber_v", data);
        }

        public static void setphone_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_shipper3_report.setphone_v", data);
        }

        public static void setorderdate_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_shipper3_report.setorderdate_v", data);
        }

        public static void setfax_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_shipper3_report.setfax_v", data);
        }

        public static void setquotationno_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_shipper3_report.setquotationno_v", data);
        }

        public static void setaddress_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_shipper3_report.setaddress_v", data);
        }

        public static void setdeliveryaddress_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_shipper3_report.setdeliveryaddress_v", data);
        }

        public static void setitem_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_shipper3_report.setitem_v", data);
        }

        public static void setproduct_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_shipper3_report.setproduct_v", data);
        }

        public static void setautorization_number_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_shipper3_report.setautorization_number_v", data);
        }

        public static void setquantity_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_shipper3_report.setquantity_v", data);
        }

        public static void setyear_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_shipper3_report.setyear_v", data);
        }

        public static void setlicense_start_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_shipper3_report.setlicense_start_v", data);
        }

        public static void setlicense_end_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_shipper3_report.setlicense_end_v", data);
        }

        public static void setmoney_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_shipper3_report.setmoney_v", data);
        }

        public static void setitem2_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_shipper3_report.setitem2_v", data);
        }

        public static void setproduct2_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_shipper3_report.setproduct2_v", data);
        }

        public static void setauthorizationnumber2_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_shipper3_report.setauthorizationnumber2_v", data);
        }

        public static void setquantity2_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_shipper3_report.setquantity2_v", data);
        }

        public static void setyear2_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_shipper3_report.setyear2_v", data);
        }

        public static void setlicensestart2_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_shipper3_report.setlicensestart2_v", data);
        }

        public static void setlicenseend2_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_shipper3_report.setlicenseend2_v", data);
        }

        public static void setmoney2_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_shipper3_report.setmoney2_v", data);
        }

        public static void setitem3_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_shipper3_report.setitem3_v", data);
        }

        public static void setproduct3_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_shipper3_report.setproduct3_v", data);
        }

        public static void setauthorizationnumber3_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_shipper3_report.setauthorizationnumber3_v", data);
        }

        public static void setquantity3_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_shipper3_report.setquantity3_v", data);
        }

        public static void setyear3_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_shipper3_report.setyear3_v", data);
        }

        public static void setlicensestart3_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_shipper3_report.setlicensestart3_v", data);
        }

        public static void setlicenseend3_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_shipper3_report.setlicenseend3_v", data);
        }

        public static void setmoney3_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_shipper3_report.setmoney3_v", data);
        }

        public static void setno_tax_amount_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_shipper3_report.setno_tax_amount_v", data);
        }

        public static void setsales_tax_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_shipper3_report.setsales_tax_v", data);
        }

        public static void settotal_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_shipper3_report.settotal_v", data);
        }

        public static void setnote_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_shipper3_report.setnote_v", data);
        }

        public static void sethead_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_shipper3_report.sethead_v", data);
        }

        public static void setmanager_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_shipper3_report.setmanager_v", data);
        }

        public static void setattn_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_shipper3_report.setattn_v", data);
        }

        public static void setcustomers_sign_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_shipper3_report.setcustomers_sign_v", data);
        }

        public static void deleteAll()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable queryParams = new Hashtable();
            AxtCRUD.delete("ResellerQuotationSystem.reseller_shipper3_report.deleteAll", queryParams);
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
                    AxtCRUD.delete("ResellerQuotationSystem.reseller_shipper3_report.deleteData", data);
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

        public static string getreseller_shipper3_reportBy(Hashtable queryParams)
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

            Hashtable totalCount = (Hashtable)Mapper.Instance().QueryForObject("ResellerQuotationSystem.reseller_shipper3_report.getreseller_shipper3_reportByTotalCount", queryParams);
            return  AxtCRUD.readJson("ResellerQuotationSystem.reseller_shipper3_report.getreseller_shipper3_reportBy", queryParams, "reseller_shipper3_report", totalCount["NUM"].ToString());
            /*appcode btnQuery user code start*/
            /*appcode btnQuery user code end*/
        }

        public static string exportData(String FileFormat, ArrayList datas, Boolean sendEmailFlag)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return "ERR_00004";
            }

		try{
			foreach(System.Diagnostics.Process proc in System.Diagnostics.Process.GetProcessesByName("winword")){
				proc.Kill();
			}
		}catch(Exception ex){

		}

            WordHelper axtReport = new WordHelper();
            String File_Input = HttpContext.Current.Server.MapPath("~/") + "Report_Input\\ResellerQuotationSystemResellerShipper3_report.dot";
            ArrayList fileToMerge = new ArrayList();
            String reporttitle_v = "";
            String reportname_v = "";
            String customername_v = "";
            String ship_date_v = "";
            String unifiednumbering_v = "";
            String shipper_number_v = "";
            String compact_v = "";
            String payment_date_v = "";
            String email_v = "";
            String purchaseordernumber_v = "";
            String phone_v = "";
            String orderdate_v = "";
            String fax_v = "";
            String quotationno_v = "";
            String address_v = "";
            String deliveryaddress_v = "";
            String item_v = "";
            String product_v = "";
            String autorization_number_v = "";
            String quantity_v = "";
            String year_v = "";
            String license_start_v = "";
            String license_end_v = "";
            String money_v = "";
            String item2_v = "";
            String product2_v = "";
            String authorizationnumber2_v = "";
            String quantity2_v = "";
            String year2_v = "";
            String licensestart2_v = "";
            String licenseend2_v = "";
            String money2_v = "";
            String item3_v = "";
            String product3_v = "";
            String authorizationnumber3_v = "";
            String quantity3_v = "";
            String year3_v = "";
            String licensestart3_v = "";
            String licenseend3_v = "";
            String money3_v = "";
            String no_tax_amount_v = "";
            String sales_tax_v = "";
            String total_v = "";
            String note_v = "";
            String head_v = "";
            String manager_v = "";
            String attn_v = "";
            String customers_sign_v = "";
            Hashtable data = new Hashtable();
            for (int i = 0; i < datas.Count; ++i)
            {
            		data = (Hashtable)datas[i];
            		axtReport.Open(File_Input);
            		String report_title = "reseller_shipper3_report";
            		String File_Output = HttpContext.Current.Server.MapPath("~/") + "Report_Output\\"+ report_title + "_report"+i+".";
			
              		if( data["REPORTTITLE_V"] != null)
              		{
              			axtReport.GotoBookMark("ReportTitle");
					reporttitle_v = data["REPORTTITLE_V"].ToString();
              			axtReport.InsertText(reporttitle_v);
              		}
              		if( data["REPORTNAME_V"] != null)
              		{
              			axtReport.GotoBookMark("ReportName");
					reportname_v = data["REPORTNAME_V"].ToString();
              			axtReport.InsertText(reportname_v);
              		}
              		if( data["CUSTOMERNAME_V"] != null)
              		{
              			axtReport.GotoBookMark("CustomerName");
					customername_v = data["CUSTOMERNAME_V"].ToString();
              			axtReport.InsertText(customername_v);
              		}
              		if( data["SHIP_DATE_V"] != null)
              		{
              			axtReport.GotoBookMark("ShipDate");
					ship_date_v = data["SHIP_DATE_V"].ToString();
              			axtReport.InsertText(ship_date_v);
              		}
              		if( data["UNIFIEDNUMBERING_V"] != null)
              		{
              			axtReport.GotoBookMark("UnifiedNumbering");
					unifiednumbering_v = data["UNIFIEDNUMBERING_V"].ToString();
              			axtReport.InsertText(unifiednumbering_v);
              		}
              		if( data["SHIPPER_NUMBER_V"] != null)
              		{
              			axtReport.GotoBookMark("ShipperNumber");
					shipper_number_v = data["SHIPPER_NUMBER_V"].ToString();
              			axtReport.InsertText(shipper_number_v);
              		}
              		if( data["COMPACT_V"] != null)
              		{
              			axtReport.GotoBookMark("Contact");
					compact_v = data["COMPACT_V"].ToString();
              			axtReport.InsertText(compact_v);
              		}
              		if( data["PAYMENT_DATE_V"] != null)
              		{
              			axtReport.GotoBookMark("PaymentDate");
					payment_date_v = data["PAYMENT_DATE_V"].ToString();
              			axtReport.InsertText(payment_date_v);
              		}
              		if( data["EMAIL_V"] != null)
              		{
              			axtReport.GotoBookMark("Email");
					email_v = data["EMAIL_V"].ToString();
              			axtReport.InsertText(email_v);
              		}
              		if( data["PURCHASEORDERNUMBER_V"] != null)
              		{
              			axtReport.GotoBookMark("PurchaseOrderNumber");
					purchaseordernumber_v = data["PURCHASEORDERNUMBER_V"].ToString();
              			axtReport.InsertText(purchaseordernumber_v);
              		}
              		if( data["PHONE_V"] != null)
              		{
              			axtReport.GotoBookMark("Phone");
					phone_v = data["PHONE_V"].ToString();
              			axtReport.InsertText(phone_v);
              		}
              		if( data["ORDERDATE_V"] != null)
              		{
              			axtReport.GotoBookMark("OrderDate");
					orderdate_v = data["ORDERDATE_V"].ToString();
              			axtReport.InsertText(orderdate_v);
              		}
              		if( data["FAX_V"] != null)
              		{
              			axtReport.GotoBookMark("Fax");
					fax_v = data["FAX_V"].ToString();
              			axtReport.InsertText(fax_v);
              		}
              		if( data["QUOTATIONNO_V"] != null)
              		{
              			axtReport.GotoBookMark("QuotationNo");
					quotationno_v = data["QUOTATIONNO_V"].ToString();
              			axtReport.InsertText(quotationno_v);
              		}
              		if( data["ADDRESS_V"] != null)
              		{
              			axtReport.GotoBookMark("Address");
					address_v = data["ADDRESS_V"].ToString();
              			axtReport.InsertText(address_v);
              		}
              		if( data["DELIVERYADDRESS_V"] != null)
              		{
              			axtReport.GotoBookMark("DeliveryAddress");
					deliveryaddress_v = data["DELIVERYADDRESS_V"].ToString();
              			axtReport.InsertText(deliveryaddress_v);
              		}
              		if( data["ITEM_V"] != null)
              		{
              			axtReport.GotoBookMark("Item");
					item_v = data["ITEM_V"].ToString();
              			axtReport.InsertText(item_v);
              		}
              		if( data["PRODUCT_V"] != null)
              		{
              			axtReport.GotoBookMark("Product");
					product_v = data["PRODUCT_V"].ToString();
              			axtReport.InsertText(product_v);
              		}
              		if( data["AUTORIZATION_NUMBER_V"] != null)
              		{
              			axtReport.GotoBookMark("AuthorizationNumber");
					autorization_number_v = data["AUTORIZATION_NUMBER_V"].ToString();
              			axtReport.InsertText(autorization_number_v);
              		}
              		if( data["QUANTITY_V"] != null)
              		{
              			axtReport.GotoBookMark("Quantity");
					quantity_v = data["QUANTITY_V"].ToString();
              			axtReport.InsertText(quantity_v);
              		}
              		if( data["YEAR_V"] != null)
              		{
              			axtReport.GotoBookMark("Year");
					year_v = data["YEAR_V"].ToString();
              			axtReport.InsertText(year_v);
              		}
              		if( data["LICENSE_START_V"] != null)
              		{
              			axtReport.GotoBookMark("LicenseStart");
					license_start_v = data["LICENSE_START_V"].ToString();
              			axtReport.InsertText(license_start_v);
              		}
              		if( data["LICENSE_END_V"] != null)
              		{
              			axtReport.GotoBookMark("LicenseEnd");
					license_end_v = data["LICENSE_END_V"].ToString();
              			axtReport.InsertText(license_end_v);
              		}
              		if( data["MONEY_V"] != null)
              		{
              			axtReport.GotoBookMark("Money");
					money_v = data["MONEY_V"].ToString();
              			axtReport.InsertText(money_v);
              		}
              		if( data["ITEM2_V"] != null)
              		{
              			axtReport.GotoBookMark("Item2");
					item2_v = data["ITEM2_V"].ToString();
              			axtReport.InsertText(item2_v);
              		}
              		if( data["PRODUCT2_V"] != null)
              		{
              			axtReport.GotoBookMark("Product2");
					product2_v = data["PRODUCT2_V"].ToString();
              			axtReport.InsertText(product2_v);
              		}
              		if( data["AUTHORIZATIONNUMBER2_V"] != null)
              		{
              			axtReport.GotoBookMark("AuthorizationNumber2");
					authorizationnumber2_v = data["AUTHORIZATIONNUMBER2_V"].ToString();
              			axtReport.InsertText(authorizationnumber2_v);
              		}
              		if( data["QUANTITY2_V"] != null)
              		{
              			axtReport.GotoBookMark("Quantity2");
					quantity2_v = data["QUANTITY2_V"].ToString();
              			axtReport.InsertText(quantity2_v);
              		}
              		if( data["YEAR2_V"] != null)
              		{
              			axtReport.GotoBookMark("Year2");
					year2_v = data["YEAR2_V"].ToString();
              			axtReport.InsertText(year2_v);
              		}
              		if( data["LICENSESTART2_V"] != null)
              		{
              			axtReport.GotoBookMark("LicenseStart2");
					licensestart2_v = data["LICENSESTART2_V"].ToString();
              			axtReport.InsertText(licensestart2_v);
              		}
              		if( data["LICENSEEND2_V"] != null)
              		{
              			axtReport.GotoBookMark("LicenseEnd2");
					licenseend2_v = data["LICENSEEND2_V"].ToString();
              			axtReport.InsertText(licenseend2_v);
              		}
              		if( data["MONEY2_V"] != null)
              		{
              			axtReport.GotoBookMark("Money2");
					money2_v = data["MONEY2_V"].ToString();
              			axtReport.InsertText(money2_v);
              		}
              		if( data["ITEM3_V"] != null)
              		{
              			axtReport.GotoBookMark("Item3");
					item3_v = data["ITEM3_V"].ToString();
              			axtReport.InsertText(item3_v);
              		}
              		if( data["PRODUCT3_V"] != null)
              		{
              			axtReport.GotoBookMark("Product3");
					product3_v = data["PRODUCT3_V"].ToString();
              			axtReport.InsertText(product3_v);
              		}
              		if( data["AUTHORIZATIONNUMBER3_V"] != null)
              		{
              			axtReport.GotoBookMark("AuthorizationNumber3");
					authorizationnumber3_v = data["AUTHORIZATIONNUMBER3_V"].ToString();
              			axtReport.InsertText(authorizationnumber3_v);
              		}
              		if( data["QUANTITY3_V"] != null)
              		{
              			axtReport.GotoBookMark("Quantity3");
					quantity3_v = data["QUANTITY3_V"].ToString();
              			axtReport.InsertText(quantity3_v);
              		}
              		if( data["YEAR3_V"] != null)
              		{
              			axtReport.GotoBookMark("Year3");
					year3_v = data["YEAR3_V"].ToString();
              			axtReport.InsertText(year3_v);
              		}
              		if( data["LICENSESTART3_V"] != null)
              		{
              			axtReport.GotoBookMark("LicenseStart3");
					licensestart3_v = data["LICENSESTART3_V"].ToString();
              			axtReport.InsertText(licensestart3_v);
              		}
              		if( data["LICENSEEND3_V"] != null)
              		{
              			axtReport.GotoBookMark("LicenseEnd3");
					licenseend3_v = data["LICENSEEND3_V"].ToString();
              			axtReport.InsertText(licenseend3_v);
              		}
              		if( data["MONEY3_V"] != null)
              		{
              			axtReport.GotoBookMark("Money3");
					money3_v = data["MONEY3_V"].ToString();
              			axtReport.InsertText(money3_v);
              		}
              		if( data["NO_TAX_AMOUNT_V"] != null)
              		{
              			axtReport.GotoBookMark("NoTaxAmount");
					no_tax_amount_v = data["NO_TAX_AMOUNT_V"].ToString();
              			axtReport.InsertText(no_tax_amount_v);
              		}
              		if( data["SALES_TAX_V"] != null)
              		{
              			axtReport.GotoBookMark("SalesTax");
					sales_tax_v = data["SALES_TAX_V"].ToString();
              			axtReport.InsertText(sales_tax_v);
              		}
              		if( data["TOTAL_V"] != null)
              		{
              			axtReport.GotoBookMark("Total");
					total_v = data["TOTAL_V"].ToString();
              			axtReport.InsertText(total_v);
              		}
              		if( data["NOTE_V"] != null)
              		{
              			axtReport.GotoBookMark("Note");
					note_v = data["NOTE_V"].ToString();
              			axtReport.InsertText(note_v);
              		}
              		if( data["HEAD_V"] != null)
              		{
              			axtReport.GotoBookMark("Head");
					head_v = data["HEAD_V"].ToString();
              			axtReport.InsertText(head_v);
              		}
              		if( data["MANAGER_V"] != null)
              		{
              			axtReport.GotoBookMark("Manager");
					manager_v = data["MANAGER_V"].ToString();
              			axtReport.InsertText(manager_v);
              		}
              		if( data["ATTN_V"] != null)
              		{
              			axtReport.GotoBookMark("Attn");
					attn_v = data["ATTN_V"].ToString();
              			axtReport.InsertText(attn_v);
              		}
              		if( data["CUSTOMERS_SIGN_V"] != null)
              		{
              			axtReport.GotoBookMark("CustomersSign");
					customers_sign_v = data["CUSTOMERS_SIGN_V"].ToString();
              			axtReport.InsertText(customers_sign_v);
              		}
            		axtReport.SaveAs(File_Output + "doc" , "doc");

            		fileToMerge.Add(File_Output + "doc");
            }

            String file_output = HttpContext.Current.Server.MapPath("~/") + "Report_Output\\ResellerQuotationSystemResellerShipper3_report.";
            axtReport.Merge(fileToMerge, file_output, true, File_Input, FileFormat);
            AxtCRUD.addEventLog("Report Gen: "+ file_output + FileFormat);
            axtReport.Quit();
            if(sendEmailFlag){
            		sendEmail(file_output,FileFormat, data);
            }

            return "ANS_00003";
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
            
            Hashtable totalCount = (Hashtable) Mapper.Instance().QueryForObject("ResellerQuotationSystem.reseller_shipper3_report.getWork_event",queryParams);
                if (totalCount == null )
                {
                    data["SID"] = AxtLibrary.GetUniqueKey(18);
                    AxtCRUD.insert("ResellerQuotationSystem.reseller_shipper3_report.addStatus",data);
                }
                else
                {
                    data["SID"] = AxtLibrary.GetUniqueKey(18);
                    AxtCRUD.update("ResellerQuotationSystem.reseller_shipper3_report.updateStatus",data);
                }
            return "ANS_00003";
        }
        /*user code start*/
        /*user code end*/
    public static void sendEmail(String file_output, String fileFormat, Hashtable Data){
    		Hashtable queryData = new Hashtable();
    		foreach(DictionaryEntry entry in Data){
    			String key = entry.Key.ToString();
    			String value = entry.Value.ToString();
    			if(key.Equals("SENDERNAME_V") || key.Equals("SENDEREMAIL_V")){
    				queryData.Add(key,value);
    			}
    		}
    		if(Data["SENDERNAME_V"] != "" || Data["SENDERNAME_V"] != null){
    			Data["SENDERNAME_V"] = "#" + Data["SENDERNAME_V"] + "#";
    		}
    		if(Data["SENDEREMAIL_V"] != "" || Data["SENDEREMAIL_V"] != null){
    			Data["SENDEREMAIL_V"] = "#" + Data["SENDEREMAIL_V"] + "#";
    		}
    		ArrayList datas = AxtCRUD.read("ResellerQuotationSystem.reseller_shipper3_report.getEmailSetting", queryData);
    		Hashtable data = (Hashtable)datas[0];
    		AxtEmailSender axtemail = new AxtEmailSender();
    		if(data["EMAILSERVER_V"].ToString().Trim() != "" && data["EMAILSERVER_V"] != null){
    			axtemail.setEmailServerIp(data["EMAILSERVER_V"].ToString().Trim());
    		}
    		if(data["SENDEREMAIL_V"].ToString().Trim() != "" && data["SENDEREMAIL_V"] != null){
    			axtemail.setSenderEmail(data["SENDEREMAIL_V"].ToString().Trim());
    		}
    		if(data["SENDERACCOUNT_V"].ToString().Trim() != "" && data["SENDERACCOUNT_V"] != null){
    			axtemail.setSenderAccount(data["SENDERACCOUNT_V"].ToString().Trim());
    		}
    		if(data["SENDERPASSWORD_V"].ToString().Trim() != "" && data["SENDERPASSWORD_V"] != null){
    			axtemail.setSenderPassword(data["SENDERPASSWORD_V"].ToString().Trim());
    		}
    		String emailConfirm = "http://www.axtronics.com.tw";
    		axtemail.setMailSubject("報價單送出通知!");
    		axtemail.setMailBody("<br>收到此信不需回覆<br>點擊連結<a href= '" + emailConfirm + "'> 確認回報 回報文佳科技即可!<br>");
    		String fileUrl = "" + file_output + fileFormat;
    		axtemail.setAttachment(fileUrl);
    		if(null != Data["RECIPIENTNAME_V"] && "" != Data["RECIPIENTNAME_V"].ToString().Trim()){
    			axtemail.setRecipientName(Data["RECIPIENTNAME_V"].ToString().Trim());
    			if(null != Data["RECIPIENTEMAIL_V"] && "" != Data["RECIPIENTEMAIL_V"].ToString().Trim()){
    				axtemail.setRecipientEmail(Data["RECIPIENTEMAIL_V"].ToString().Trim());
    				axtemail.sendEmail();
    			}
    		}
    		if(null != Data["REVIEWERNAME_V"] && "" != Data["REVIEWERNAME_V"].ToString().Trim()){
    			axtemail.setRecipientName(Data["REVIEWERNAME_V"].ToString().Trim());
    			if(null != Data["REVIEWEREMAIL_V"] && "" != Data["REVIEWEREMAIL_V"].ToString().Trim()){
    				axtemail.setRecipientEmail(Data["REVIEWEREMAIL_V"].ToString().Trim());
    				axtemail.sendEmail();
    			}
    		}
    	}
    }

}