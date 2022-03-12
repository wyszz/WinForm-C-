<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_20220304_Validators.WebForm1" %>

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
            width: 150px;
        }
        .auto-style3 {
            width: 150px;
            height: 24px;
        }
        .auto-style4 {
            height: 24px;
        }
        .auto-style5 {
            width: 230px;
        }
        .auto-style6 {
            height: 24px;
            width: 230px;
        }
        .auto-style7 {
            width: 150px;
            height: 27px;
        }
        .auto-style8 {
            width: 230px;
            height: 27px;
        }
        .auto-style9 {
            height: 27px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">个人资料：</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">用户名：</td>
                <td class="auto-style6">
                    <asp:TextBox ID="tbx_uname" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tbx_uname" ErrorMessage="用户名不能为空！" ForeColor="Red">不能为空</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style6"></td>
                <td class="auto-style4"></td>
            </tr>
            <tr>
                <td class="auto-style2">密码：</td>
                <td class="auto-style5">
                    <asp:TextBox ID="tbx_pwd" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="tbx_pwd" ErrorMessage="密码不能为空！" ForeColor="Red">不能为空</asp:RequiredFieldValidator>
&nbsp;
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="tbx_pwd2" ControlToValidate="tbx_pwd" ErrorMessage="两次输入的密码不一致" ForeColor="Red">密码不一致</asp:CompareValidator>
&nbsp;
                    <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="tbx_pwd" ForeColor="Red" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">再次输入密码：</td>
                <td class="auto-style8">
                    <asp:TextBox ID="tbx_pwd2" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style9"></td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Email：</td>
                <td class="auto-style5">
                    <asp:TextBox ID="tbx_email" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="tbx_email" ErrorMessage="请输入正确的邮箱格式" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">Email格式不正确</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style6"></td>
                <td class="auto-style4"></td>
            </tr>
            <tr>
                <td class="auto-style2">年龄</td>
                <td class="auto-style5">
                    <asp:TextBox ID="tbx_age" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="tbx_age" ErrorMessage="请输入正确范围内的年龄" ForeColor="Red" MaximumValue="150" MinimumValue="18" Type="Integer">请输入18~150之间的整数</asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                        <asp:ListItem>男</asp:ListItem>
                        <asp:ListItem>女</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td class="auto-style5">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="提交" />
                </td>
                <td>
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
                </td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
