<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_20220302FileUpLoad.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            上传文件路径：<asp:FileUpload ID="FileUpload1" runat="server" />
            <br />
            <br />
            <br />
            <asp:Button ID="btn_upload" runat="server" OnClick="btn_upload_Click" Text="上传" />
            <br />
            <br />
            <br />
            <asp:Image ID="Image1" runat="server" Height="120px" Width="100px" />
            <br />
            <br />
            <br />
            <asp:TextBox ID="TextBox1" runat="server" Height="164px" TextMode="MultiLine" Width="575px"></asp:TextBox>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
