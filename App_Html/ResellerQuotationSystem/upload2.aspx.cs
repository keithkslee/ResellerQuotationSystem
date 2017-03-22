using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ResellerQuotationSystem.App_Html.ResellerQuotationSystem
{
    public partial class upload2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void UploadBtn_Click(object sender, EventArgs e)
        {
            if (FileUpLoad1.HasFile)
            {
		
                string FileName = FileUpLoad1.FileName;
                string FilePath = System.AppDomain.CurrentDomain.BaseDirectory + "Upload\\";

		if(FileName.EndsWith(".xls") || FileName.EndsWith(".xlsx") || FileName.EndsWith(".jpeg") || FileName.EndsWith(".jpg") || FileName.EndsWith(".png")){
			FileUpLoad1.SaveAs(FilePath + FileName);
			//UploadStatusLabel.Text = "Your File was uploaded successfully";		
			UploadStatusLabel.Text = "檔案上傳成功,請關閉此視窗,在原始視窗填入檔案名稱";		
		}else{
			//UploadStatusLabel.Text = "Only Excel and Image can be uploaded";
			UploadStatusLabel.Text = "只能上傳Excel(.xls|.xlsx)或圖檔(.jpeg|.jpg|.png)";
		}
                
            }
            else
            {
		UploadStatusLabel.Text = "Please select file";
            }
        }

    }
}
