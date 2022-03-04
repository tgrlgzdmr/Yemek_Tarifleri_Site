<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.master" AutoEventWireup="true" CodeFile="Iletisim.aspx.cs" Inherits="Iletisim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .auto-style4 {
        height: 23px;
    }
    .auto-style6 {
        height: 23px;
        text-align: right;
    }
    .auto-style7 {
        text-align: right;
    }
    .auto-style8 {
        font-size: x-large;
        color: #6699FF;
    }
        .auto-style9 {
            border: 2px solid #777;
            border-radius: 10px;
            outline: none;
            height: 40px;
            font-weight: bold;
            font-size: medium;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
    <tr>
        <td class="auto-style8" colspan="2"><strong>Mesaj Paneli</strong></td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style7"><strong>Ad Soyad:</strong></td>
        <td>
            <asp:TextBox ID="TxtAdSoyad" runat="server" Height="25px" Width="230px" CssClass="tb5"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style6"><strong>Mesaj Konu:</strong></td>
        <td class="auto-style4">
            <asp:TextBox ID="TxtKonu" runat="server" Height="25px" Width="230px" CssClass="tb5"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style6"><strong>Email:</strong></td>
        <td class="auto-style4">
            <asp:TextBox ID="TxtMail" runat="server" Height="25px" TextMode="Email" Width="230px" CssClass="tb5"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style6"><strong>Mesaj İçerik:</strong></td>
        <td class="auto-style4">
            <asp:TextBox ID="TxtMesaj" runat="server" Height="100px" TextMode="MultiLine" Width="230px" CssClass="tb5"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style4">&nbsp;</td>
        <td class="auto-style4"><strong>
            <asp:Button ID="BtnGonder" runat="server" CssClass="auto-style9" Text="Gönder" Width="230px" OnClick="BtnGonder_Click" />
            </strong></td>
    </tr>
</table>
</asp:Content>

