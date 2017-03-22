using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ResellerQuotationSystem.App_Html.ResellerQuotationSystem
{
    public partial class upload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string fileName = string.Empty;
            string fileURL = string.Empty;
            string rt = string.Empty;
            try
            {
                HttpPostedFile file = Request.Files[0];
                fileName = GetFileName(file.FileName);
                file.SaveAs(Server.MapPath("~/") + "Upload\\" + fileName);
                fileURL = "../../Upload/" + fileName;
                rt = "{success:'true',fileURL:'" + fileURL + "'}";
            }
            catch
            {
                rt = "{success:'false',fileURL:'" + fileURL + "'}";
            }

            Response.Write(rt);
        }

        private string GetFileName(string FullName)
        {
            string fileName = string.Empty;
            int last = FullName.LastIndexOf(@"\");
            fileName = FullName.Substring(last + 1, FullName.Length - last - 1);
            return fileName;
        }
    }
}
