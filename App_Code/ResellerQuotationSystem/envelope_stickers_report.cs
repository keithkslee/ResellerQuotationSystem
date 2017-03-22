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
    public class envelope_stickers_report
    {
        public static void createTable()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable queryParams = new Hashtable();
            AxtCRUD.createTable("ResellerQuotationSystem.envelope_stickers_report.createenvelope_stickers_report", queryParams);
            AxtCRUD.createTable("ResellerQuotationSystem.envelope_stickers_report.createenvelope_stickers_reportHistory", queryParams);
        }

        public static string getenvelope_stickers_report(Hashtable queryParams)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return null;
            }

            Hashtable totalCount = (Hashtable)Mapper.Instance().QueryForObject("ResellerQuotationSystem.envelope_stickers_reportgetenvelope_stickers_reportTotalCount", queryParams);
            return AxtCRUD.readJson("ResellerQuotationSystem.envelope_stickers_report.getenvelope_stickers_report", queryParams, "envelope_stickers_report", totalCount["NUM"].ToString());
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
                    AxtCRUD.insert("ResellerQuotationSystem.envelope_stickers_report.addData", data);

                }
                else
                {
                    update(data);
                }
            }

            setdeliveryaddress_v();
            setcustomername_v();
            setcustomercontact_v();
            setnote_v();
            setproduct_v();
            setpurchaseordernumber_v();
            return "ANS_00003";
        }

        public static void update(Hashtable data)
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            AxtCRUD.update("ResellerQuotationSystem.envelope_stickers_report.updateData", data);
            /*update user code start*/
            /*update user code end*/
        }

        public static void setdeliveryaddress_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.envelope_stickers_report.setdeliveryaddress_v", data);
        }

        public static void setcustomername_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.envelope_stickers_report.setcustomername_v", data);
        }

        public static void setcustomercontact_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.envelope_stickers_report.setcustomercontact_v", data);
        }

        public static void setnote_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.envelope_stickers_report.setnote_v", data);
        }

        public static void setproduct_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.envelope_stickers_report.setproduct_v", data);
        }

        public static void setpurchaseordernumber_v()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable data = new Hashtable();
            AxtCRUD.update("ResellerQuotationSystem.envelope_stickers_report.setpurchaseordernumber_v", data);
        }

        public static void deleteAll()
        {
            if (AxtLoginCheck.isLogin() == false)
            {
                return;
            }

            Hashtable queryParams = new Hashtable();
            AxtCRUD.delete("ResellerQuotationSystem.envelope_stickers_report.deleteAll", queryParams);
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
                    AxtCRUD.delete("ResellerQuotationSystem.envelope_stickers_report.deleteData", data);
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

        public static string getenvelope_stickers_reportBy(Hashtable queryParams)
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

            Hashtable totalCount = (Hashtable)Mapper.Instance().QueryForObject("ResellerQuotationSystem.envelope_stickers_report.getenvelope_stickers_reportByTotalCount", queryParams);
            return  AxtCRUD.readJson("ResellerQuotationSystem.envelope_stickers_report.getenvelope_stickers_reportBy", queryParams, "envelope_stickers_report", totalCount["NUM"].ToString());
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
            String File_Input = HttpContext.Current.Server.MapPath("~/") + "Report_Input\\ResellerQuotationSystememailbox_report.dot";
            ArrayList fileToMerge = new ArrayList();
            String deliveryaddress_v = "";
            String customername_v = "";
            String customercontact_v = "";
            String note_v = "";
            String product_v = "";
            String purchaseordernumber_v = "";
            Hashtable data = new Hashtable();
            for (int i = 0; i < datas.Count; ++i)
            {
            		data = (Hashtable)datas[i];
            		axtReport.Open(File_Input);
            		String report_title = "envelope_stickers_report";
            		String File_Output = HttpContext.Current.Server.MapPath("~/") + "Report_Output\\"+ report_title + "_report"+i+".";
			
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
              		if( data["CUSTOMERCONTACT_V"] != null)
              		{
              			axtReport.GotoBookMark("CustomerContact");
					customercontact_v = data["CUSTOMERCONTACT_V"].ToString();
              			axtReport.InsertText(customercontact_v);
              		}
              		if( data["NOTE_V"] != null)
              		{
              			axtReport.GotoBookMark("Note");
					note_v = data["NOTE_V"].ToString();
              			axtReport.InsertText(note_v);
              		}
              		if( data["PRODUCT_V"] != null)
              		{
              			axtReport.GotoBookMark("Product");
					product_v = data["PRODUCT_V"].ToString();
              			axtReport.InsertText(product_v);
              		}
              		if( data["PURCHASEORDERNUMBER_V"] != null)
              		{
              			axtReport.GotoBookMark("PurchaseOrderNumber");
					purchaseordernumber_v = data["PURCHASEORDERNUMBER_V"].ToString();
              			axtReport.InsertText(purchaseordernumber_v);
              		}
            		axtReport.SaveAs(File_Output + "doc" , "doc");

            		fileToMerge.Add(File_Output + "doc");
            }

            String file_output = HttpContext.Current.Server.MapPath("~/") + "Report_Output\\ResellerQuotationSystememailbox_report.";
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
            
            Hashtable totalCount = (Hashtable) Mapper.Instance().QueryForObject("ResellerQuotationSystem.envelope_stickers_report.getWork_event",queryParams);
                if (totalCount == null )
                {
                    data["SID"] = AxtLibrary.GetUniqueKey(18);
                    AxtCRUD.insert("ResellerQuotationSystem.envelope_stickers_report.addStatus",data);
                }
                else
                {
                    data["SID"] = AxtLibrary.GetUniqueKey(18);
                    AxtCRUD.update("ResellerQuotationSystem.envelope_stickers_report.updateStatus",data);
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
    		ArrayList datas = AxtCRUD.read("ResellerQuotationSystem.envelope_stickers_report.getEmailSetting", queryData);
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