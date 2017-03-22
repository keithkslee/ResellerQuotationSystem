<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="upload2.aspx.cs" Inherits="ResellerQuotationSystem.App_Html.ResellerQuotationSystem.upload2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:FileUpLoad id="FileUpLoad1" runat="server" />
    <br />
    <asp:Button id="UploadBtn" Text="檔案上傳" OnClick="UploadBtn_Click" runat="server" Width="105px" />
    </div>

    <asp:Label id="UploadStatusLabel" runat="server" />
    </form>
</body>
</html>
