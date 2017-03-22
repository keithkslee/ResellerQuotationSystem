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
    public class notification
    {
        public static void createTable()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable queryParams = new Hashtable();
            AxtCRUD.createTable("ResellerQuotationSystem.notification.createnotification", queryParams);
            AxtCRUD.createTable("ResellerQuotationSystem.notification.createnotificationHistory", queryParams);
        }

        public static string getnotification(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable totalCount = (Hashtable)Mapper.Instance().QueryForObject("ResellerQuotationSystem.notificationgetnotificationTotalCount", queryParams);
            return AxtCRUD.readJson("ResellerQuotationSystem.notification.getnotification", queryParams, "notification", totalCount["NUM"].ToString());
        }

        public static string getCBXCUSTOMERNAMECHINESE_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.notification.getCBXCUSTOMERNAMECHINESE_V", queryParams, "notification");
        }
        public static string getCBXCUSTOMERNAMEEN_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.notification.getCBXCUSTOMERNAMEEN_V", queryParams, "notification");
        }
        public static string getCBXCONTACTCHINESE_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.notification.getCBXCONTACTCHINESE_V", queryParams, "notification");
        }
        public static string getCBXCONTACTENGLISH_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.notification.getCBXCONTACTENGLISH_V", queryParams, "notification");
        }
        public static string getCBXORDERPRODUCT_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.notification.getCBXORDERPRODUCT_V", queryParams, "notification");
        }
        public static string getCBXRENEWCUSTOMERNO_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.notification.getCBXRENEWCUSTOMERNO_V", queryParams, "notification");
        }
        public static string getCBXNEWCUSTOMERBRANDS_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.notification.getCBXNEWCUSTOMERBRANDS_V", queryParams, "notification");
        }
        public static string getCBXCOMPETITIVEBRANDS_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.notification.getCBXCOMPETITIVEBRANDS_V", queryParams, "notification");
        }
        public static string getCBXDEALER_TW_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.notification.getCBXDEALER_TW_V", queryParams, "notification");
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
                    AxtCRUD.insert("ResellerQuotationSystem.notification.addData", data);

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

            AxtCRUD.update("ResellerQuotationSystem.notification.updateData", data);
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
            AxtCRUD.delete("ResellerQuotationSystem.notification.deleteAll", queryParams);
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
                    AxtCRUD.delete("ResellerQuotationSystem.notification.deleteData", data);
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

        public static string getnotificationBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            if (null != queryParams["BOOKED_DATE_V"] && "" != queryParams["BOOKED_DATE_V"].ToString().Trim())
            {
                queryParams["BOOKED_DATE_V"] = "%" + queryParams["BOOKED_DATE_V"] + "%";
            }
            if (null != queryParams["CUSTOMERNAMECHINESE_V"] && "" != queryParams["CUSTOMERNAMECHINESE_V"].ToString().Trim())
            {
                queryParams["CUSTOMERNAMECHINESE_V"] = "%" + queryParams["CUSTOMERNAMECHINESE_V"] + "%";
            }
            if (null != queryParams["CUSTOMERNAMEEN_V"] && "" != queryParams["CUSTOMERNAMEEN_V"].ToString().Trim())
            {
                queryParams["CUSTOMERNAMEEN_V"] = "%" + queryParams["CUSTOMERNAMEEN_V"] + "%";
            }
            if (null != queryParams["WEBSITECHINESE_V"] && "" != queryParams["WEBSITECHINESE_V"].ToString().Trim())
            {
                queryParams["WEBSITECHINESE_V"] = "%" + queryParams["WEBSITECHINESE_V"] + "%";
            }
            if (null != queryParams["WEBSITEENGLISH_V"] && "" != queryParams["WEBSITEENGLISH_V"].ToString().Trim())
            {
                queryParams["WEBSITEENGLISH_V"] = "%" + queryParams["WEBSITEENGLISH_V"] + "%";
            }
            if (null != queryParams["ADDRESSCHINESE_V"] && "" != queryParams["ADDRESSCHINESE_V"].ToString().Trim())
            {
                queryParams["ADDRESSCHINESE_V"] = "%" + queryParams["ADDRESSCHINESE_V"] + "%";
            }
            if (null != queryParams["ADDRESSENGLISH_V"] && "" != queryParams["ADDRESSENGLISH_V"].ToString().Trim())
            {
                queryParams["ADDRESSENGLISH_V"] = "%" + queryParams["ADDRESSENGLISH_V"] + "%";
            }
            if (null != queryParams["CONTACTCHINESE_V"] && "" != queryParams["CONTACTCHINESE_V"].ToString().Trim())
            {
                queryParams["CONTACTCHINESE_V"] = "%" + queryParams["CONTACTCHINESE_V"] + "%";
            }
            if (null != queryParams["CONTACTENGLISH_V"] && "" != queryParams["CONTACTENGLISH_V"].ToString().Trim())
            {
                queryParams["CONTACTENGLISH_V"] = "%" + queryParams["CONTACTENGLISH_V"] + "%";
            }
            if (null != queryParams["CONTACT_PHONE_V"] && "" != queryParams["CONTACT_PHONE_V"].ToString().Trim())
            {
                queryParams["CONTACT_PHONE_V"] = "%" + queryParams["CONTACT_PHONE_V"] + "%";
            }
            if (null != queryParams["FAX_NUMBER_V"] && "" != queryParams["FAX_NUMBER_V"].ToString().Trim())
            {
                queryParams["FAX_NUMBER_V"] = "%" + queryParams["FAX_NUMBER_V"] + "%";
            }
            if (null != queryParams["UNIFORM_NUMBERS_V"] && "" != queryParams["UNIFORM_NUMBERS_V"].ToString().Trim())
            {
                queryParams["UNIFORM_NUMBERS_V"] = "%" + queryParams["UNIFORM_NUMBERS_V"] + "%";
            }
            if (null != queryParams["EMAIL_V"] && "" != queryParams["EMAIL_V"].ToString().Trim())
            {
                queryParams["EMAIL_V"] = "%" + queryParams["EMAIL_V"] + "%";
            }
            if (null != queryParams["ORDERPRODUCT_V"] && "" != queryParams["ORDERPRODUCT_V"].ToString().Trim())
            {
                queryParams["ORDERPRODUCT_V"] = "%" + queryParams["ORDERPRODUCT_V"] + "%";
            }
            if (null != queryParams["ORDERQUANTITY_V"] && "" != queryParams["ORDERQUANTITY_V"].ToString().Trim())
            {
                queryParams["ORDERQUANTITY_V"] = "%" + queryParams["ORDERQUANTITY_V"] + "%";
            }
            if (null != queryParams["TERM_V"] && "" != queryParams["TERM_V"].ToString().Trim())
            {
                queryParams["TERM_V"] = "%" + queryParams["TERM_V"] + "%";
            }
            if (null != queryParams["LICENSE_START_V"] && "" != queryParams["LICENSE_START_V"].ToString().Trim())
            {
                queryParams["LICENSE_START_V"] = "%" + queryParams["LICENSE_START_V"] + "%";
            }
            if (null != queryParams["LICENSE_END_V"] && "" != queryParams["LICENSE_END_V"].ToString().Trim())
            {
                queryParams["LICENSE_END_V"] = "%" + queryParams["LICENSE_END_V"] + "%";
            }
            if (null != queryParams["RENEWCUSTOMERNO_V"] && "" != queryParams["RENEWCUSTOMERNO_V"].ToString().Trim())
            {
                queryParams["RENEWCUSTOMERNO_V"] = "%" + queryParams["RENEWCUSTOMERNO_V"] + "%";
            }
            if (null != queryParams["NEWCUSTOMERBRANDS_V"] && "" != queryParams["NEWCUSTOMERBRANDS_V"].ToString().Trim())
            {
                queryParams["NEWCUSTOMERBRANDS_V"] = "%" + queryParams["NEWCUSTOMERBRANDS_V"] + "%";
            }
            if (null != queryParams["COMPETITIVEBRANDS_V"] && "" != queryParams["COMPETITIVEBRANDS_V"].ToString().Trim())
            {
                queryParams["COMPETITIVEBRANDS_V"] = "%" + queryParams["COMPETITIVEBRANDS_V"] + "%";
            }
            if (null != queryParams["DEALER_TW_V"] && "" != queryParams["DEALER_TW_V"].ToString().Trim())
            {
                queryParams["DEALER_TW_V"] = "%" + queryParams["DEALER_TW_V"] + "%";
            }
            if (null != queryParams["BUSINESSUNDERTAKER_V"] && "" != queryParams["BUSINESSUNDERTAKER_V"].ToString().Trim())
            {
                queryParams["BUSINESSUNDERTAKER_V"] = "%" + queryParams["BUSINESSUNDERTAKER_V"] + "%";
            }
            if (null != queryParams["BUSINESSUNDERTAKERPHONE_V"] && "" != queryParams["BUSINESSUNDERTAKERPHONE_V"].ToString().Trim())
            {
                queryParams["BUSINESSUNDERTAKERPHONE_V"] = "%" + queryParams["BUSINESSUNDERTAKERPHONE_V"] + "%";
            }
            if (null != queryParams["ENTRY_DATE_V"] && "" != queryParams["ENTRY_DATE_V"].ToString().Trim())
            {
                queryParams["ENTRY_DATE_V"] = "%" + queryParams["ENTRY_DATE_V"] + "%";
            }
            if (null != queryParams["LAST_SEQUENCE_V"] && "" != queryParams["LAST_SEQUENCE_V"].ToString().Trim())
            {
                queryParams["LAST_SEQUENCE_V"] = "%" + queryParams["LAST_SEQUENCE_V"] + "%";
            }

            Hashtable totalCount = (Hashtable)Mapper.Instance().QueryForObject("ResellerQuotationSystem.notification.getnotificationByTotalCount", queryParams);
            return  AxtCRUD.readJson("ResellerQuotationSystem.notification.getnotificationBy", queryParams, "notification", totalCount["NUM"].ToString());
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
            
            Hashtable totalCount = (Hashtable) Mapper.Instance().QueryForObject("ResellerQuotationSystem.notification.getWork_event",queryParams);
                if (totalCount == null )
                {
                    data["SID"] = AxtLibrary.GetUniqueKey(18);
                    AxtCRUD.insert("ResellerQuotationSystem.notification.addStatus",data);
                }
                else
                {
                    data["SID"] = AxtLibrary.GetUniqueKey(18);
                    AxtCRUD.update("ResellerQuotationSystem.notification.updateStatus",data);
                }
            return "ANS_00003";
        }
        public static ArrayList getnotificationAddresschinese_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.notification.getnotificationAddresschinese_vBy", queryParams);
        }

        public static ArrayList getnotificationContact_phone_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.notification.getnotificationContact_phone_vBy", queryParams);
        }

        public static ArrayList getnotificationContactchinese_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.notification.getnotificationContactchinese_vBy", queryParams);
        }

        public static ArrayList getnotificationEmail_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.notification.getnotificationEmail_vBy", queryParams);
        }

        public static ArrayList getnotificationFax_number_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.notification.getnotificationFax_number_vBy", queryParams);
        }

        public static ArrayList getnotificationUniform_numbers_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.notification.getnotificationUniform_numbers_vBy", queryParams);
        }

        public static ArrayList getnotificationWebsitechinese_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.notification.getnotificationWebsitechinese_vBy", queryParams);
        }

        /*user code start*/
        /*user code end*/
    }

}