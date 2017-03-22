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
    public class reseller_quotation4_report
    {
        public static void createTable()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable queryParams = new Hashtable();
            AxtCRUD.createTable("ResellerQuotationSystem.reseller_quotation4_report.createreseller_quotation4_report", queryParams);
            AxtCRUD.createTable("ResellerQuotationSystem.reseller_quotation4_report.createreseller_quotation4_reportHistory", queryParams);
        }

        public static string getreseller_quotation4_report(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable totalCount = (Hashtable)Mapper.Instance().QueryForObject("ResellerQuotationSystem.reseller_quotation4_reportgetreseller_quotation4_reportTotalCount", queryParams);
            return AxtCRUD.readJson("ResellerQuotationSystem.reseller_quotation4_report.getreseller_quotation4_report", queryParams, "reseller_quotation4_report", totalCount["NUM"].ToString());
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
                    AxtCRUD.insert("ResellerQuotationSystem.reseller_quotation4_report.addData", data);

                }
                else
                {
                    update(data);
                }
            }

            setresellername_v();
            setquotationno_v();
            setunifiednumbering_v();
            setquote_date_v();
            setcompact_v();
            setship_date_v();
            setemail_v();
            setpayment_conditions_v();
            setphone_v();
            setfax_v();
            setaddress_v();
            setdeliveryaddress_v();
            setcustomername_v();
            setcompetitivebrands_v();
            setordertype_v();
            setofferors_v();
            setitem1_v();
            setproduct_name1_v();
            setspecification1_v();
            setquantity1_v();
            setoneyearvalue1_v();
            setoneyearsale1_v();
            setone_year_price1_v();
            setoneyearbestprice1_v();
            setthreeyearvalue1_v();
            setthreeyearsale1_v();
            setthree_year_price1_v();
            setthreeyearbestprice1_v();
            setitem2_v();
            setproduct_name2_v();
            setspecification2_v();
            setquantity2_v();
            setoneyearvalue2_v();
            setoneyearsale2_v();
            setone_year_price2_v();
            setoneyearbestprice2_v();
            setthreeyearvalue2_v();
            setthreeyearsale2_v();
            setthree_year_price2_v();
            setthreeyearbestprice2_v();
            setitem3_v();
            setproduct_name3_v();
            setspecification3_v();
            setquantity3_v();
            setoneyearvalue3_v();
            setoneyearsale3_v();
            setone_year_price3_v();
            setoneyearbestprice3_v();
            setthreeyearvalue3_v();
            setthreeyearsale3_v();
            setthree_year_price3_v();
            setthreeyearbestprice3_v();
            setnoamounttaxvalueyear_v();
            setno_amount_tax_year_v();
            setnoamounttaxvaluetriennial_v();
            setno_tax_amount_triennial_v();
            setoneyearsalestaxvalue_v();
            setone_year_sales_tax_v();
            setthreeyearsalestaxvalue_v();
            setthree_year_sales_tax_v();
            settotalvalueyear_v();
            settotal_year_v();
            settotalthreeyearvalueperiod_v();
            settotal_three_year_period_v();
            setnote_v();
            sethead_v();
            setsales_manager_v();
            setattn_v();
            setcustomers_sign_v();
            setreporttitle_v();
            setreportname_v();
            return "ANS_00003";
        }

        public static void update(Hashtable data)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.updateData", data);
            /*update user code start*/
            /*update user code end*/
        }

        public static void setresellername_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.setresellername_v", data);
        }

        public static void setquotationno_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.setquotationno_v", data);
        }

        public static void setunifiednumbering_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.setunifiednumbering_v", data);
        }

        public static void setquote_date_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.setquote_date_v", data);
        }

        public static void setcompact_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.setcompact_v", data);
        }

        public static void setship_date_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.setship_date_v", data);
        }

        public static void setemail_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.setemail_v", data);
        }

        public static void setpayment_conditions_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.setpayment_conditions_v", data);
        }

        public static void setphone_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.setphone_v", data);
        }

        public static void setfax_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.setfax_v", data);
        }

        public static void setaddress_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.setaddress_v", data);
        }

        public static void setdeliveryaddress_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.setdeliveryaddress_v", data);
        }

        public static void setcustomername_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.setcustomername_v", data);
        }

        public static void setcompetitivebrands_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.setcompetitivebrands_v", data);
        }

        public static void setordertype_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.setordertype_v", data);
        }

        public static void setofferors_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.setofferors_v", data);
        }

        public static void setitem1_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.setitem1_v", data);
        }

        public static void setproduct_name1_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.setproduct_name1_v", data);
        }

        public static void setspecification1_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.setspecification1_v", data);
        }

        public static void setquantity1_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.setquantity1_v", data);
        }

        public static void setoneyearvalue1_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.setoneyearvalue1_v", data);
        }

        public static void setoneyearsale1_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.setoneyearsale1_v", data);
        }

        public static void setone_year_price1_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.setone_year_price1_v", data);
        }

        public static void setoneyearbestprice1_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.setoneyearbestprice1_v", data);
        }

        public static void setthreeyearvalue1_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.setthreeyearvalue1_v", data);
        }

        public static void setthreeyearsale1_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.setthreeyearsale1_v", data);
        }

        public static void setthree_year_price1_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.setthree_year_price1_v", data);
        }

        public static void setthreeyearbestprice1_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.setthreeyearbestprice1_v", data);
        }

        public static void setitem2_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.setitem2_v", data);
        }

        public static void setproduct_name2_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.setproduct_name2_v", data);
        }

        public static void setspecification2_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.setspecification2_v", data);
        }

        public static void setquantity2_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.setquantity2_v", data);
        }

        public static void setoneyearvalue2_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.setoneyearvalue2_v", data);
        }

        public static void setoneyearsale2_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.setoneyearsale2_v", data);
        }

        public static void setone_year_price2_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.setone_year_price2_v", data);
        }

        public static void setoneyearbestprice2_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.setoneyearbestprice2_v", data);
        }

        public static void setthreeyearvalue2_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.setthreeyearvalue2_v", data);
        }

        public static void setthreeyearsale2_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.setthreeyearsale2_v", data);
        }

        public static void setthree_year_price2_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.setthree_year_price2_v", data);
        }

        public static void setthreeyearbestprice2_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.setthreeyearbestprice2_v", data);
        }

        public static void setitem3_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.setitem3_v", data);
        }

        public static void setproduct_name3_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.setproduct_name3_v", data);
        }

        public static void setspecification3_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.setspecification3_v", data);
        }

        public static void setquantity3_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.setquantity3_v", data);
        }

        public static void setoneyearvalue3_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.setoneyearvalue3_v", data);
        }

        public static void setoneyearsale3_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.setoneyearsale3_v", data);
        }

        public static void setone_year_price3_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.setone_year_price3_v", data);
        }

        public static void setoneyearbestprice3_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.setoneyearbestprice3_v", data);
        }

        public static void setthreeyearvalue3_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.setthreeyearvalue3_v", data);
        }

        public static void setthreeyearsale3_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.setthreeyearsale3_v", data);
        }

        public static void setthree_year_price3_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.setthree_year_price3_v", data);
        }

        public static void setthreeyearbestprice3_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.setthreeyearbestprice3_v", data);
        }

        public static void setnoamounttaxvalueyear_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.setnoamounttaxvalueyear_v", data);
        }

        public static void setno_amount_tax_year_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.setno_amount_tax_year_v", data);
        }

        public static void setnoamounttaxvaluetriennial_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.setnoamounttaxvaluetriennial_v", data);
        }

        public static void setno_tax_amount_triennial_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.setno_tax_amount_triennial_v", data);
        }

        public static void setoneyearsalestaxvalue_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.setoneyearsalestaxvalue_v", data);
        }

        public static void setone_year_sales_tax_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.setone_year_sales_tax_v", data);
        }

        public static void setthreeyearsalestaxvalue_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.setthreeyearsalestaxvalue_v", data);
        }

        public static void setthree_year_sales_tax_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.setthree_year_sales_tax_v", data);
        }

        public static void settotalvalueyear_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.settotalvalueyear_v", data);
        }

        public static void settotal_year_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.settotal_year_v", data);
        }

        public static void settotalthreeyearvalueperiod_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.settotalthreeyearvalueperiod_v", data);
        }

        public static void settotal_three_year_period_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.settotal_three_year_period_v", data);
        }

        public static void setnote_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.setnote_v", data);
        }

        public static void sethead_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.sethead_v", data);
        }

        public static void setsales_manager_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.setsales_manager_v", data);
        }

        public static void setattn_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.setattn_v", data);
        }

        public static void setcustomers_sign_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.setcustomers_sign_v", data);
        }

        public static void setreporttitle_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.setreporttitle_v", data);
        }

        public static void setreportname_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.setreportname_v", data);
        }

        public static void deleteAll()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable queryParams = new Hashtable();
            AxtCRUD.delete("ResellerQuotationSystem.reseller_quotation4_report.deleteAll", queryParams);
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
                    AxtCRUD.delete("ResellerQuotationSystem.reseller_quotation4_report.deleteData", data);
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

        public static string getreseller_quotation4_reportBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
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
            if (null != queryParams["FAX_V"] && "" != queryParams["FAX_V"].ToString().Trim())
            {
                queryParams["FAX_V"] = "%" + queryParams["FAX_V"] + "%";
            }
            if (null != queryParams["ADDRESS_V"] && "" != queryParams["ADDRESS_V"].ToString().Trim())
            {
                queryParams["ADDRESS_V"] = "%" + queryParams["ADDRESS_V"] + "%";
            }
            if (null != queryParams["DELIVERYADDRESS_V"] && "" != queryParams["DELIVERYADDRESS_V"].ToString().Trim())
            {
                queryParams["DELIVERYADDRESS_V"] = "%" + queryParams["DELIVERYADDRESS_V"] + "%";
            }
            if (null != queryParams["CUSTOMERNAME_V"] && "" != queryParams["CUSTOMERNAME_V"].ToString().Trim())
            {
                queryParams["CUSTOMERNAME_V"] = "%" + queryParams["CUSTOMERNAME_V"] + "%";
            }
            if (null != queryParams["COMPETITIVEBRANDS_V"] && "" != queryParams["COMPETITIVEBRANDS_V"].ToString().Trim())
            {
                queryParams["COMPETITIVEBRANDS_V"] = "%" + queryParams["COMPETITIVEBRANDS_V"] + "%";
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
            if (null != queryParams["ONEYEARVALUE1_V"] && "" != queryParams["ONEYEARVALUE1_V"].ToString().Trim())
            {
                queryParams["ONEYEARVALUE1_V"] = "%" + queryParams["ONEYEARVALUE1_V"] + "%";
            }
            if (null != queryParams["ONEYEARSALE1_V"] && "" != queryParams["ONEYEARSALE1_V"].ToString().Trim())
            {
                queryParams["ONEYEARSALE1_V"] = "%" + queryParams["ONEYEARSALE1_V"] + "%";
            }
            if (null != queryParams["ONE_YEAR_PRICE1_V"] && "" != queryParams["ONE_YEAR_PRICE1_V"].ToString().Trim())
            {
                queryParams["ONE_YEAR_PRICE1_V"] = "%" + queryParams["ONE_YEAR_PRICE1_V"] + "%";
            }
            if (null != queryParams["ONEYEARBESTPRICE1_V"] && "" != queryParams["ONEYEARBESTPRICE1_V"].ToString().Trim())
            {
                queryParams["ONEYEARBESTPRICE1_V"] = "%" + queryParams["ONEYEARBESTPRICE1_V"] + "%";
            }
            if (null != queryParams["THREEYEARVALUE1_V"] && "" != queryParams["THREEYEARVALUE1_V"].ToString().Trim())
            {
                queryParams["THREEYEARVALUE1_V"] = "%" + queryParams["THREEYEARVALUE1_V"] + "%";
            }
            if (null != queryParams["THREEYEARSALE1_V"] && "" != queryParams["THREEYEARSALE1_V"].ToString().Trim())
            {
                queryParams["THREEYEARSALE1_V"] = "%" + queryParams["THREEYEARSALE1_V"] + "%";
            }
            if (null != queryParams["THREE_YEAR_PRICE1_V"] && "" != queryParams["THREE_YEAR_PRICE1_V"].ToString().Trim())
            {
                queryParams["THREE_YEAR_PRICE1_V"] = "%" + queryParams["THREE_YEAR_PRICE1_V"] + "%";
            }
            if (null != queryParams["THREEYEARBESTPRICE1_V"] && "" != queryParams["THREEYEARBESTPRICE1_V"].ToString().Trim())
            {
                queryParams["THREEYEARBESTPRICE1_V"] = "%" + queryParams["THREEYEARBESTPRICE1_V"] + "%";
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
            if (null != queryParams["ONEYEARSALE2_V"] && "" != queryParams["ONEYEARSALE2_V"].ToString().Trim())
            {
                queryParams["ONEYEARSALE2_V"] = "%" + queryParams["ONEYEARSALE2_V"] + "%";
            }
            if (null != queryParams["ONE_YEAR_PRICE2_V"] && "" != queryParams["ONE_YEAR_PRICE2_V"].ToString().Trim())
            {
                queryParams["ONE_YEAR_PRICE2_V"] = "%" + queryParams["ONE_YEAR_PRICE2_V"] + "%";
            }
            if (null != queryParams["ONEYEARBESTPRICE2_V"] && "" != queryParams["ONEYEARBESTPRICE2_V"].ToString().Trim())
            {
                queryParams["ONEYEARBESTPRICE2_V"] = "%" + queryParams["ONEYEARBESTPRICE2_V"] + "%";
            }
            if (null != queryParams["THREEYEARVALUE2_V"] && "" != queryParams["THREEYEARVALUE2_V"].ToString().Trim())
            {
                queryParams["THREEYEARVALUE2_V"] = "%" + queryParams["THREEYEARVALUE2_V"] + "%";
            }
            if (null != queryParams["THREEYEARSALE2_V"] && "" != queryParams["THREEYEARSALE2_V"].ToString().Trim())
            {
                queryParams["THREEYEARSALE2_V"] = "%" + queryParams["THREEYEARSALE2_V"] + "%";
            }
            if (null != queryParams["THREE_YEAR_PRICE2_V"] && "" != queryParams["THREE_YEAR_PRICE2_V"].ToString().Trim())
            {
                queryParams["THREE_YEAR_PRICE2_V"] = "%" + queryParams["THREE_YEAR_PRICE2_V"] + "%";
            }
            if (null != queryParams["THREEYEARBESTPRICE2_V"] && "" != queryParams["THREEYEARBESTPRICE2_V"].ToString().Trim())
            {
                queryParams["THREEYEARBESTPRICE2_V"] = "%" + queryParams["THREEYEARBESTPRICE2_V"] + "%";
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
            if (null != queryParams["ONEYEARSALE3_V"] && "" != queryParams["ONEYEARSALE3_V"].ToString().Trim())
            {
                queryParams["ONEYEARSALE3_V"] = "%" + queryParams["ONEYEARSALE3_V"] + "%";
            }
            if (null != queryParams["ONE_YEAR_PRICE3_V"] && "" != queryParams["ONE_YEAR_PRICE3_V"].ToString().Trim())
            {
                queryParams["ONE_YEAR_PRICE3_V"] = "%" + queryParams["ONE_YEAR_PRICE3_V"] + "%";
            }
            if (null != queryParams["ONEYEARBESTPRICE3_V"] && "" != queryParams["ONEYEARBESTPRICE3_V"].ToString().Trim())
            {
                queryParams["ONEYEARBESTPRICE3_V"] = "%" + queryParams["ONEYEARBESTPRICE3_V"] + "%";
            }
            if (null != queryParams["THREEYEARVALUE3_V"] && "" != queryParams["THREEYEARVALUE3_V"].ToString().Trim())
            {
                queryParams["THREEYEARVALUE3_V"] = "%" + queryParams["THREEYEARVALUE3_V"] + "%";
            }
            if (null != queryParams["THREEYEARSALE3_V"] && "" != queryParams["THREEYEARSALE3_V"].ToString().Trim())
            {
                queryParams["THREEYEARSALE3_V"] = "%" + queryParams["THREEYEARSALE3_V"] + "%";
            }
            if (null != queryParams["THREE_YEAR_PRICE3_V"] && "" != queryParams["THREE_YEAR_PRICE3_V"].ToString().Trim())
            {
                queryParams["THREE_YEAR_PRICE3_V"] = "%" + queryParams["THREE_YEAR_PRICE3_V"] + "%";
            }
            if (null != queryParams["THREEYEARBESTPRICE3_V"] && "" != queryParams["THREEYEARBESTPRICE3_V"].ToString().Trim())
            {
                queryParams["THREEYEARBESTPRICE3_V"] = "%" + queryParams["THREEYEARBESTPRICE3_V"] + "%";
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
            if (null != queryParams["REPORTTITLE_V"] && "" != queryParams["REPORTTITLE_V"].ToString().Trim())
            {
                queryParams["REPORTTITLE_V"] = "%" + queryParams["REPORTTITLE_V"] + "%";
            }
            if (null != queryParams["REPORTNAME_V"] && "" != queryParams["REPORTNAME_V"].ToString().Trim())
            {
                queryParams["REPORTNAME_V"] = "%" + queryParams["REPORTNAME_V"] + "%";
            }

            Hashtable totalCount = (Hashtable)Mapper.Instance().QueryForObject("ResellerQuotationSystem.reseller_quotation4_report.getreseller_quotation4_reportByTotalCount", queryParams);
            return  AxtCRUD.readJson("ResellerQuotationSystem.reseller_quotation4_report.getreseller_quotation4_reportBy", queryParams, "reseller_quotation4_report", totalCount["NUM"].ToString());
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
            String File_Input = HttpContext.Current.Server.MapPath("~/") + "Report_Input\\ResellerQuotationSystemResellerQuotationSystem4_report.dot";
            ArrayList fileToMerge = new ArrayList();
            String resellername_v = "";
            String quotationno_v = "";
            String unifiednumbering_v = "";
            String quote_date_v = "";
            String compact_v = "";
            String ship_date_v = "";
            String email_v = "";
            String payment_conditions_v = "";
            String phone_v = "";
            String fax_v = "";
            String address_v = "";
            String deliveryaddress_v = "";
            String customername_v = "";
            String competitivebrands_v = "";
            String ordertype_v = "";
            String offerors_v = "";
            String item1_v = "";
            String product_name1_v = "";
            String specification1_v = "";
            String quantity1_v = "";
            String oneyearvalue1_v = "";
            String oneyearsale1_v = "";
            String one_year_price1_v = "";
            String oneyearbestprice1_v = "";
            String threeyearvalue1_v = "";
            String threeyearsale1_v = "";
            String three_year_price1_v = "";
            String threeyearbestprice1_v = "";
            String item2_v = "";
            String product_name2_v = "";
            String specification2_v = "";
            String quantity2_v = "";
            String oneyearvalue2_v = "";
            String oneyearsale2_v = "";
            String one_year_price2_v = "";
            String oneyearbestprice2_v = "";
            String threeyearvalue2_v = "";
            String threeyearsale2_v = "";
            String three_year_price2_v = "";
            String threeyearbestprice2_v = "";
            String item3_v = "";
            String product_name3_v = "";
            String specification3_v = "";
            String quantity3_v = "";
            String oneyearvalue3_v = "";
            String oneyearsale3_v = "";
            String one_year_price3_v = "";
            String oneyearbestprice3_v = "";
            String threeyearvalue3_v = "";
            String threeyearsale3_v = "";
            String three_year_price3_v = "";
            String threeyearbestprice3_v = "";
            String noamounttaxvalueyear_v = "";
            String no_amount_tax_year_v = "";
            String noamounttaxvaluetriennial_v = "";
            String no_tax_amount_triennial_v = "";
            String oneyearsalestaxvalue_v = "";
            String one_year_sales_tax_v = "";
            String threeyearsalestaxvalue_v = "";
            String three_year_sales_tax_v = "";
            String totalvalueyear_v = "";
            String total_year_v = "";
            String totalthreeyearvalueperiod_v = "";
            String total_three_year_period_v = "";
            String note_v = "";
            String head_v = "";
            String sales_manager_v = "";
            String attn_v = "";
            String customers_sign_v = "";
            String reporttitle_v = "";
            String reportname_v = "";
            Hashtable data = new Hashtable();
            for (int i = 0; i < datas.Count; ++i)
            {
            		data = (Hashtable)datas[i];
            		axtReport.Open(File_Input);
            		String report_title = "reseller_quotation4_report";
            		String File_Output = HttpContext.Current.Server.MapPath("~/") + "Report_Output\\"+ report_title + "_report"+i+".";
			
              		if( data["RESELLERNAME_V"] != null)
              		{
              			axtReport.GotoBookMark("ResellerName");
					resellername_v = data["RESELLERNAME_V"].ToString();
              			axtReport.InsertText(resellername_v);
              		}
              		if( data["QUOTATIONNO_V"] != null)
              		{
              			axtReport.GotoBookMark("QuotationNo");
					quotationno_v = data["QUOTATIONNO_V"].ToString();
              			axtReport.InsertText(quotationno_v);
              		}
              		if( data["UNIFIEDNUMBERING_V"] != null)
              		{
              			axtReport.GotoBookMark("UnifiedNumbering");
					unifiednumbering_v = data["UNIFIEDNUMBERING_V"].ToString();
              			axtReport.InsertText(unifiednumbering_v);
              		}
              		if( data["QUOTE_DATE_V"] != null)
              		{
              			axtReport.GotoBookMark("QuoteDate");
					quote_date_v = data["QUOTE_DATE_V"].ToString();
              			axtReport.InsertText(quote_date_v);
              		}
              		if( data["COMPACT_V"] != null)
              		{
              			axtReport.GotoBookMark("Contact");
					compact_v = data["COMPACT_V"].ToString();
              			axtReport.InsertText(compact_v);
              		}
              		if( data["SHIP_DATE_V"] != null)
              		{
              			axtReport.GotoBookMark("ShipDate");
					ship_date_v = data["SHIP_DATE_V"].ToString();
              			axtReport.InsertText(ship_date_v);
              		}
              		if( data["EMAIL_V"] != null)
              		{
              			axtReport.GotoBookMark("Email");
					email_v = data["EMAIL_V"].ToString();
              			axtReport.InsertText(email_v);
              		}
              		if( data["PAYMENT_CONDITIONS_V"] != null)
              		{
              			axtReport.GotoBookMark("PaymentConditions");
					payment_conditions_v = data["PAYMENT_CONDITIONS_V"].ToString();
              			axtReport.InsertText(payment_conditions_v);
              		}
              		if( data["PHONE_V"] != null)
              		{
              			axtReport.GotoBookMark("Phone");
					phone_v = data["PHONE_V"].ToString();
              			axtReport.InsertText(phone_v);
              		}
              		if( data["FAX_V"] != null)
              		{
              			axtReport.GotoBookMark("Fax");
					fax_v = data["FAX_V"].ToString();
              			axtReport.InsertText(fax_v);
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
              		if( data["CUSTOMERNAME_V"] != null)
              		{
              			axtReport.GotoBookMark("CustomerName");
					customername_v = data["CUSTOMERNAME_V"].ToString();
              			axtReport.InsertText(customername_v);
              		}
              		if( data["COMPETITIVEBRANDS_V"] != null)
              		{
              			axtReport.GotoBookMark("CompetitiveBrands");
					competitivebrands_v = data["COMPETITIVEBRANDS_V"].ToString();
              			axtReport.InsertText(competitivebrands_v);
              		}
              		if( data["ORDERTYPE_V"] != null)
              		{
              			axtReport.GotoBookMark("OrderType");
					ordertype_v = data["ORDERTYPE_V"].ToString();
              			axtReport.InsertText(ordertype_v);
              		}
              		if( data["OFFERORS_V"] != null)
              		{
              			axtReport.GotoBookMark("Offerors");
					offerors_v = data["OFFERORS_V"].ToString();
              			axtReport.InsertText(offerors_v);
              		}
              		if( data["ITEM1_V"] != null)
              		{
              			axtReport.GotoBookMark("Item1");
					item1_v = data["ITEM1_V"].ToString();
              			axtReport.InsertText(item1_v);
              		}
              		if( data["PRODUCT_NAME1_V"] != null)
              		{
              			axtReport.GotoBookMark("ProductName1");
					product_name1_v = data["PRODUCT_NAME1_V"].ToString();
              			axtReport.InsertText(product_name1_v);
              		}
              		if( data["SPECIFICATION1_V"] != null)
              		{
              			axtReport.GotoBookMark("Specification1");
					specification1_v = data["SPECIFICATION1_V"].ToString();
              			axtReport.InsertText(specification1_v);
              		}
              		if( data["QUANTITY1_V"] != null)
              		{
              			axtReport.GotoBookMark("Quantity1");
					quantity1_v = data["QUANTITY1_V"].ToString();
              			axtReport.InsertText(quantity1_v);
              		}
					/*
              		if( data["ONEYEARVALUE1_V"] != null)
              		{
              			axtReport.GotoBookMark("OneYearValue1");
					oneyearvalue1_v = data["ONEYEARVALUE1_V"].ToString();
              			axtReport.InsertText(oneyearvalue1_v);
              		}
					*/
              		if( data["ONEYEARSALE1_V"] != null)
              		{
              			axtReport.GotoBookMark("OneYearSale1");
					oneyearsale1_v = data["ONEYEARSALE1_V"].ToString();
              			axtReport.InsertText(oneyearsale1_v);
              		}
					/*
              		if( data["ONE_YEAR_PRICE1_V"] != null)
              		{
              			axtReport.GotoBookMark("OneYearPrice1");
					one_year_price1_v = data["ONE_YEAR_PRICE1_V"].ToString();
              			axtReport.InsertText(one_year_price1_v);
              		}
					*/
              		if( data["ONEYEARBESTPRICE1_V"] != null)
              		{
              			axtReport.GotoBookMark("OneYearBestPrice1");
					oneyearbestprice1_v = data["ONEYEARBESTPRICE1_V"].ToString();
              			axtReport.InsertText(oneyearbestprice1_v);
              		}
					/*
              		if( data["THREEYEARVALUE1_V"] != null)
              		{
              			axtReport.GotoBookMark("ThreeYearValue1");
					threeyearvalue1_v = data["THREEYEARVALUE1_V"].ToString();
              			axtReport.InsertText(threeyearvalue1_v);
              		}
					*/
              		if( data["THREEYEARSALE1_V"] != null)
              		{
              			axtReport.GotoBookMark("ThreeYearSale1");
					threeyearsale1_v = data["THREEYEARSALE1_V"].ToString();
              			axtReport.InsertText(threeyearsale1_v);
              		}
					/*
              		if( data["THREE_YEAR_PRICE1_V"] != null)
              		{
              			axtReport.GotoBookMark("ThreeYearPrice1");
					three_year_price1_v = data["THREE_YEAR_PRICE1_V"].ToString();
              			axtReport.InsertText(three_year_price1_v);
              		}
					*/
              		if( data["THREEYEARBESTPRICE1_V"] != null)
              		{
              			axtReport.GotoBookMark("ThreeYearBestPrice1");
					threeyearbestprice1_v = data["THREEYEARBESTPRICE1_V"].ToString();
              			axtReport.InsertText(threeyearbestprice1_v);
              		}
              		if( data["ITEM2_V"] != null)
              		{
              			axtReport.GotoBookMark("Item2");
					item2_v = data["ITEM2_V"].ToString();
              			axtReport.InsertText(item2_v);
              		}
              		if( data["PRODUCT_NAME2_V"] != null)
              		{
              			axtReport.GotoBookMark("ProductName2");
					product_name2_v = data["PRODUCT_NAME2_V"].ToString();
              			axtReport.InsertText(product_name2_v);
              		}
              		if( data["SPECIFICATION2_V"] != null)
              		{
              			axtReport.GotoBookMark("Specification2");
					specification2_v = data["SPECIFICATION2_V"].ToString();
              			axtReport.InsertText(specification2_v);
              		}
              		if( data["QUANTITY2_V"] != null)
              		{
              			axtReport.GotoBookMark("Quantity2");
					quantity2_v = data["QUANTITY2_V"].ToString();
              			axtReport.InsertText(quantity2_v);
              		}
              		/*
              		if( data["ONEYEARVALUE2_V"] != null)
              		{
              			axtReport.GotoBookMark("OneYearValue2");
					oneyearvalue2_v = data["ONEYEARVALUE2_V"].ToString();
              			axtReport.InsertText(oneyearvalue2_v);
              		}
              		*/
              		if( data["ONEYEARSALE2_V"] != null)
              		{
              			axtReport.GotoBookMark("OneYearSale2");
					oneyearsale2_v = data["ONEYEARSALE2_V"].ToString();
              			axtReport.InsertText(oneyearsale2_v);
              		}
              		/*
              		if( data["ONE_YEAR_PRICE2_V"] != null)
              		{
              			axtReport.GotoBookMark("OneYearPrice2");
					one_year_price2_v = data["ONE_YEAR_PRICE2_V"].ToString();
              			axtReport.InsertText(one_year_price2_v);
              		}
              		*/
              		if( data["ONEYEARBESTPRICE2_V"] != null)
              		{
              			axtReport.GotoBookMark("OneYearBestPrice2");
					oneyearbestprice2_v = data["ONEYEARBESTPRICE2_V"].ToString();
              			axtReport.InsertText(oneyearbestprice2_v);
              		}
              		/*
              		if( data["THREEYEARVALUE2_V"] != null)
              		{
              			axtReport.GotoBookMark("ThreeYearValue2");
					threeyearvalue2_v = data["THREEYEARVALUE2_V"].ToString();
              			axtReport.InsertText(threeyearvalue2_v);
              		}
              		*/
              		if( data["THREEYEARSALE2_V"] != null)
              		{
              			axtReport.GotoBookMark("ThreeYearSale2");
					threeyearsale2_v = data["THREEYEARSALE2_V"].ToString();
              			axtReport.InsertText(threeyearsale2_v);
              		}
              		/*
              		if( data["THREE_YEAR_PRICE2_V"] != null)
              		{
              			axtReport.GotoBookMark("ThreeYearPrice2");
					three_year_price2_v = data["THREE_YEAR_PRICE2_V"].ToString();
              			axtReport.InsertText(three_year_price2_v);
              		}
              		*/
              		if( data["THREEYEARBESTPRICE2_V"] != null)
              		{
              			axtReport.GotoBookMark("ThreeYearBestPrice2");
					threeyearbestprice2_v = data["THREEYEARBESTPRICE2_V"].ToString();
              			axtReport.InsertText(threeyearbestprice2_v);
              		}
              		if( data["ITEM3_V"] != null)
              		{
              			axtReport.GotoBookMark("Item3");
					item3_v = data["ITEM3_V"].ToString();
              			axtReport.InsertText(item3_v);
              		}
              		if( data["PRODUCT_NAME3_V"] != null)
              		{
              			axtReport.GotoBookMark("ProductName3");
					product_name3_v = data["PRODUCT_NAME3_V"].ToString();
              			axtReport.InsertText(product_name3_v);
              		}
              		if( data["SPECIFICATION3_V"] != null)
              		{
              			axtReport.GotoBookMark("Specification3");
					specification3_v = data["SPECIFICATION3_V"].ToString();
              			axtReport.InsertText(specification3_v);
              		}
              		if( data["QUANTITY3_V"] != null)
              		{
              			axtReport.GotoBookMark("Quantity3");
					quantity3_v = data["QUANTITY3_V"].ToString();
              			axtReport.InsertText(quantity3_v);
              		}
              		/*
              		if( data["ONEYEARVALUE3_V"] != null)
              		{
              			axtReport.GotoBookMark("OneYearValue3");
					oneyearvalue3_v = data["ONEYEARVALUE3_V"].ToString();
              			axtReport.InsertText(oneyearvalue3_v);
              		}
              		*/
              		if( data["ONEYEARSALE3_V"] != null)
              		{
              			axtReport.GotoBookMark("OneYearSale3");
					oneyearsale3_v = data["ONEYEARSALE3_V"].ToString();
              			axtReport.InsertText(oneyearsale3_v);
              		}
              		/*
              		if( data["ONE_YEAR_PRICE3_V"] != null)
              		{
              			axtReport.GotoBookMark("OneYearPrice3");
					one_year_price3_v = data["ONE_YEAR_PRICE3_V"].ToString();
              			axtReport.InsertText(one_year_price3_v);
              		}
              		*/
              		if( data["ONEYEARBESTPRICE3_V"] != null)
              		{
              			axtReport.GotoBookMark("OneYearBestPrice3");
					oneyearbestprice3_v = data["ONEYEARBESTPRICE3_V"].ToString();
              			axtReport.InsertText(oneyearbestprice3_v);
              		}
              		/*
              		if( data["THREEYEARVALUE3_V"] != null)
              		{
              			axtReport.GotoBookMark("ThreeYearValue3");
					threeyearvalue3_v = data["THREEYEARVALUE3_V"].ToString();
              			axtReport.InsertText(threeyearvalue3_v);
              		}
              		*/
              		if( data["THREEYEARSALE3_V"] != null)
              		{
              			axtReport.GotoBookMark("ThreeYearSale3");
					threeyearsale3_v = data["THREEYEARSALE3_V"].ToString();
              			axtReport.InsertText(threeyearsale3_v);
              		}
              		/*
              		if( data["THREE_YEAR_PRICE3_V"] != null)
              		{
              			axtReport.GotoBookMark("ThreeYearPrice3");
					three_year_price3_v = data["THREE_YEAR_PRICE3_V"].ToString();
              			axtReport.InsertText(three_year_price3_v);
              		}
              		*/
              		if( data["THREEYEARBESTPRICE3_V"] != null)
              		{
              			axtReport.GotoBookMark("ThreeYearBestPrice3");
					threeyearbestprice3_v = data["THREEYEARBESTPRICE3_V"].ToString();
              			axtReport.InsertText(threeyearbestprice3_v);
              		}
              		if( data["NOAMOUNTTAXVALUEYEAR_V"] != null)
              		{
              			axtReport.GotoBookMark("NoAmountTaxValueYear");
					noamounttaxvalueyear_v = data["NOAMOUNTTAXVALUEYEAR_V"].ToString();
              			axtReport.InsertText(noamounttaxvalueyear_v);
              		}
              		if( data["NO_AMOUNT_TAX_YEAR_V"] != null)
              		{
              			axtReport.GotoBookMark("NoAmountTaxYear");
					no_amount_tax_year_v = data["NO_AMOUNT_TAX_YEAR_V"].ToString();
              			axtReport.InsertText(no_amount_tax_year_v);
              		}
              		if( data["NOAMOUNTTAXVALUETRIENNIAL_V"] != null)
              		{
              			axtReport.GotoBookMark("NoAmountTaxValueTriennial");
					noamounttaxvaluetriennial_v = data["NOAMOUNTTAXVALUETRIENNIAL_V"].ToString();
              			axtReport.InsertText(noamounttaxvaluetriennial_v);
              		}
              		if( data["NO_TAX_AMOUNT_TRIENNIAL_V"] != null)
              		{
              			axtReport.GotoBookMark("NoTaxAmountTriennial");
					no_tax_amount_triennial_v = data["NO_TAX_AMOUNT_TRIENNIAL_V"].ToString();
              			axtReport.InsertText(no_tax_amount_triennial_v);
              		}
              		if( data["ONEYEARSALESTAXVALUE_V"] != null)
              		{
              			axtReport.GotoBookMark("OneYearSalesTaxValue");
					oneyearsalestaxvalue_v = data["ONEYEARSALESTAXVALUE_V"].ToString();
              			axtReport.InsertText(oneyearsalestaxvalue_v);
              		}
              		if( data["ONE_YEAR_SALES_TAX_V"] != null)
              		{
              			axtReport.GotoBookMark("OneYearSalesTax");
					one_year_sales_tax_v = data["ONE_YEAR_SALES_TAX_V"].ToString();
              			axtReport.InsertText(one_year_sales_tax_v);
              		}
              		if( data["THREEYEARSALESTAXVALUE_V"] != null)
              		{
              			axtReport.GotoBookMark("ThreeYearSalesTaxValue");
					threeyearsalestaxvalue_v = data["THREEYEARSALESTAXVALUE_V"].ToString();
              			axtReport.InsertText(threeyearsalestaxvalue_v);
              		}
              		if( data["THREE_YEAR_SALES_TAX_V"] != null)
              		{
              			axtReport.GotoBookMark("ThreeYearSalesTax");
					three_year_sales_tax_v = data["THREE_YEAR_SALES_TAX_V"].ToString();
              			axtReport.InsertText(three_year_sales_tax_v);
              		}
              		if( data["TOTALVALUEYEAR_V"] != null)
              		{
              			axtReport.GotoBookMark("TotalValueYear");
					totalvalueyear_v = data["TOTALVALUEYEAR_V"].ToString();
              			axtReport.InsertText(totalvalueyear_v);
              		}
              		if( data["TOTAL_YEAR_V"] != null)
              		{
              			axtReport.GotoBookMark("TotalYear");
					total_year_v = data["TOTAL_YEAR_V"].ToString();
              			axtReport.InsertText(total_year_v);
              		}
              		if( data["TOTALTHREEYEARVALUEPERIOD_V"] != null)
              		{
              			axtReport.GotoBookMark("TotalThreeYearValuePeriod");
					totalthreeyearvalueperiod_v = data["TOTALTHREEYEARVALUEPERIOD_V"].ToString();
              			axtReport.InsertText(totalthreeyearvalueperiod_v);
              		}
              		if( data["TOTAL_THREE_YEAR_PERIOD_V"] != null)
              		{
              			axtReport.GotoBookMark("TotalThreeYearPeriod");
					total_three_year_period_v = data["TOTAL_THREE_YEAR_PERIOD_V"].ToString();
              			axtReport.InsertText(total_three_year_period_v);
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
              		if( data["SALES_MANAGER_V"] != null)
              		{
              			axtReport.GotoBookMark("SalesManager");
					sales_manager_v = data["SALES_MANAGER_V"].ToString();
              			axtReport.InsertText(sales_manager_v);
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
					/*
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
					*/
            		axtReport.SaveAs(File_Output + "doc" , "doc");

            		fileToMerge.Add(File_Output + "doc");
            }

            String file_output = HttpContext.Current.Server.MapPath("~/") + "Report_Output\\ResellerQuotationSystemResellerQuotationSystem4_report.";
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
            
            Hashtable totalCount = (Hashtable) Mapper.Instance().QueryForObject("ResellerQuotationSystem.reseller_quotation4_report.getWork_event",queryParams);
                if (totalCount == null )
                {
                    data["SID"] = AxtLibrary.GetUniqueKey(18);
                    AxtCRUD.insert("ResellerQuotationSystem.reseller_quotation4_report.addStatus",data);
                }
                else
                {
                    data["SID"] = AxtLibrary.GetUniqueKey(18);
                    AxtCRUD.update("ResellerQuotationSystem.reseller_quotation4_report.updateStatus",data);
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
    		ArrayList datas = AxtCRUD.read("ResellerQuotationSystem.reseller_quotation4_report.getEmailSetting", queryData);
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