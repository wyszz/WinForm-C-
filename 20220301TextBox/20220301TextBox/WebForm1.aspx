<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_20220301TextBox.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 24px;
        }
        .auto-style3 {
            height: 24px;
            width: 150px;
        }
        .auto-style4 {
            width: 150px;
        }
        .auto-style5 {
            height: 24px;
            width: 175px;
        }
        .auto-style6 {
            width: 175px;
        }
        .auto-style7 {
            height: 24px;
            width: 138px;
        }
        .auto-style8 {
            width: 138px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">长度换算</td>
                    <td class="auto-style5"></td>
                    <td class="auto-style7"></td>
                    <td class="auto-style2"></td>
                </tr>
                <tr>
                    <td class="auto-style3">英制单位</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style7">公制单位</td>
                    <td class="auto-style2">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">码yd</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="tbx_yd" runat="server" AutoPostBack="True" OnTextChanged="tbx_TextChanged"></asp:TextBox>
                    </td>
                    <td class="auto-style8">米m</td>
                    <td>
                        <asp:TextBox ID="tbx_m" runat="server" AutoPostBack="True" OnTextChanged="tbx_TextChanged"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">英尺ft</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="tbx_ft" runat="server" AutoPostBack="True" OnTextChanged="tbx_TextChanged"></asp:TextBox>
                    </td>
                    <td class="auto-style8">厘米cm</td>
                    <td>
                        <asp:TextBox ID="tbx_cm" runat="server" AutoPostBack="True" OnTextChanged="tbx_TextChanged"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">英寸in</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="tbx_in" runat="server" AutoPostBack="True" OnTextChanged="tbx_TextChanged"></asp:TextBox>
                    </td>
                    <td class="auto-style8">微米um</td>
                    <td>
                        <asp:TextBox ID="tbx_um" runat="server" AutoPostBack="True" OnTextChanged="tbx_TextChanged"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
