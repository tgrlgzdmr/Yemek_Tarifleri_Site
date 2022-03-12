<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminLogin.aspx.cs" Inherits="AdminLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Kullanici.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            background-color: #0000FF;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            color: #FFFFFF;
            height: 23px;
        }
        .auto-style4 {
            text-align: right;
        }
        .auto-style5 {
            color: #FFFFFF;
            text-align: left;
        }
        .auto-style6 {
            text-align: left;
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left:100px; margin-top:100px; height:200px; width:400px;" class="auto-style1">
            <table class="auto-style2">
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5"><strong>ADMIN LOGIN</strong></td>
                    <td class="auto-style4">
                        <asp:Image ID="Image1" runat="server" Height="42px" ImageUrl="~/Resimler/icons8_lock_80px.png" Width="47px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Kullanıcı Adı</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="TxtKAd" runat="server" CssClass="tb5"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Şifre</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="TxtSifre" runat="server" CssClass="tb5"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style6">
                        <asp:Button ID="BtnGiris" runat="server" Text="Giriş" CssClass="tb5" OnClick="BtnGiris_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
