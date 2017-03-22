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
    public class envelope_stickers
    {
        public static void createTable()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable queryParams = new Hashtable();
            AxtCRUD.createTable("ResellerQuotationSystem.envelope_stickers.createenvelope_stickers", queryParams);
            AxtCRUD.createTable("ResellerQuotationSystem.envelope_stickers.createenvelope_stickersHistory", queryParams);
        }

        public static string getenvelope_stickers(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable totalCount = (Hashtable)Mapper.Instance().QueryForObject("ResellerQuotationSystem.envelope_stickersgetenvelope_stickersTotalCount", queryParams);
            return AxtCRUD.readJson("ResellerQuotationSystem.envelope_stickers.getenvelope_stickers", queryParams, "envelope_stickers", totalCount["NUM"].ToString());
        }

        public static string getCBXCUSTOMERNAME_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.envelope_stickers.getCBXCUSTOMERNAME_V", queryParams, "envelope_stickers");
        }
        public static string getCBXCUSTOMERCONTACT_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.envelope_stickers.getCBXCUSTOMERCONTACT_V", queryParams, "envelope_stickers");
        }
        public static string getCBXPRODUCT_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.envelope_stickers.getCBXPRODUCT_V", queryParams, "envelope_stickers");
        }
        public static string getCBXPURCHASEORDERNUMBER_V()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable queryParams = new Hashtable();
            return AxtCRUD.readJson("ResellerQuotationSystem.envelope_stickers.getCBXPURCHASEORDERNUMBER_V", queryParams, "envelope_stickers");
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
                    AxtCRUD.insert("ResellerQuotationSystem.envelope_stickers.addData", data);

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

            AxtCRUD.update("ResellerQuotationSystem.envelope_stickers.updateData", data);
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
            AxtCRUD.delete("ResellerQuotationSystem.envelope_stickers.deleteAll", queryParams);
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
                    AxtCRUD.delete("ResellerQuotationSystem.envelope_stickers.deleteData", data);
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

        public static string getenvelope_stickersBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            if (null != queryParams["DELIVERYADDRESS_V"] && "" != queryParams["DELIVERYADDRESS_V"].ToString().Trim())
            {
                queryParams["DELIVERYADDRESS_V"] = "%" + queryParams["DELIVERYADDRESS_V"] + "%";
            }
            if (null != queryParams["CUSTOMERNAME_V"] && "" != queryParams["CUSTOMERNAME_V"].ToString().Trim())
            {
                queryParams["CUSTOMERNAME_V"] = "%" + queryParams["CUSTOMERNAME_V"] + "%";
            }
            if (null != queryParams["CUSTOMERCONTACT_V"] && "" != queryParams["CUSTOMERCONTACT_V"].ToString().Trim())
            {
                queryParams["CUSTOMERCONTACT_V"] = "%" + queryParams["CUSTOMERCONTACT_V"] + "%";
            }
            if (null != queryParams["NOTE_V"] && "" != queryParams["NOTE_V"].ToString().Trim())
            {
                queryParams["NOTE_V"] = "%" + queryParams["NOTE_V"] + "%";
            }
            if (null != queryParams["PRODUCT_V"] && "" != queryParams["PRODUCT_V"].ToString().Trim())
            {
                queryParams["PRODUCT_V"] = "%" + queryParams["PRODUCT_V"] + "%";
            }
            if (null != queryParams["PURCHASEORDERNUMBER_V"] && "" != queryParams["PURCHASEORDERNUMBER_V"].ToString().Trim())
            {
                queryParams["PURCHASEORDERNUMBER_V"] = "%" + queryParams["PURCHASEORDERNUMBER_V"] + "%";
            }

            Hashtable totalCount = (Hashtable)Mapper.Instance().QueryForObject("ResellerQuotationSystem.envelope_stickers.getenvelope_stickersByTotalCount", queryParams);
            return  AxtCRUD.readJson("ResellerQuotationSystem.envelope_stickers.getenvelope_stickersBy", queryParams, "envelope_stickers", totalCount["NUM"].ToString());
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
            
            Hashtable totalCount = (Hashtable) Mapper.Instance().QueryForObject("ResellerQuotationSystem.envelope_stickers.getWork_event",queryParams);
                if (totalCount == null )
                {
                    data["SID"] = AxtLibrary.GetUniqueKey(18);
                    AxtCRUD.insert("ResellerQuotationSystem.envelope_stickers.addStatus",data);
                }
                else
                {
                    data["SID"] = AxtLibrary.GetUniqueKey(18);
                    AxtCRUD.update("ResellerQuotationSystem.envelope_stickers.updateStatus",data);
                }
            return "ANS_00003";
        }
        public static ArrayList getenvelope_stickersNote_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.envelope_stickers.getenvelope_stickersNote_vBy", queryParams);
        }

        public static ArrayList getenvelope_stickersProduct_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.envelope_stickers.getenvelope_stickersProduct_vBy", queryParams);
        }

        public static ArrayList getenvelope_stickersDeliveryaddress_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.envelope_stickers.getenvelope_stickersDeliveryaddress_vBy", queryParams);
        }

        public static ArrayList getenvelope_stickersCustomercontact_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.envelope_stickers.getenvelope_stickersCustomercontact_vBy", queryParams);
        }

        public static ArrayList getenvelope_stickersCustomername_vBy(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            return AxtCRUD.read("ResellerQuotationSystem.envelope_stickers.getenvelope_stickersCustomername_vBy", queryParams);
        }

        /*user code start*/
        /*user code end*/
    }

}