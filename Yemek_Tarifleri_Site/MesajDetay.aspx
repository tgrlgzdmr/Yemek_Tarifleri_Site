<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="MesajDetay.aspx.cs" Inherits="MesajDetay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style9 {
            width: 100%;
            background-color: #0000FF;
        }
        .auto-style10 {
            text-align: right;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style9">
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Mesaj Gönderen:</td>
            <td>
                <asp:TextBox ID="TxtGonderen" runat="server" CssClass="tb5"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Başlık:</td>
            <td>
                <asp:TextBox ID="TxtBaslik" runat="server" CssClass="tb5"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Mail Adresi:</td>
            <td>
                <asp:TextBox ID="TxtMail" runat="server" CssClass="tb5"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Mesaj İçerik:</td>
            <td>
                <asp:TextBox ID="Txticerik" runat="server" CssClass="tb5" Height="150px" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Tarih:</td>
            <td class="auto-style10">
                <asp:Label ID="LblTarih" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>

