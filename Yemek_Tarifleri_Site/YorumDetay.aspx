<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="YorumDetay.aspx.cs" Inherits="YorumDetay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style9 {
            height: 23px;
        }
        .auto-style10 {
            height: 23px;
            background-color: #0000FF;
        }
        .auto-style11 {
            width: 100%;
            background-color: #0000FF;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style11">
        <tr>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style9"></td>
        </tr>
        <tr>
            <td class="auto-style10">Yorum Ad Soyad:</td>
            <td class="auto-style9">
                <asp:TextBox ID="TxtAdSoyad" runat="server" CssClass="tb5"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style10">Mail Adresi:</td>
            <td class="auto-style9">
                <asp:TextBox ID="TxtMail" runat="server" CssClass="tb5"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style10">İçerik:</td>
            <td class="auto-style9">
                <asp:TextBox ID="Txticerik" runat="server" CssClass="tb5" Height="150px" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style10">Yemek:</td>
            <td class="auto-style9">
                <asp:TextBox ID="TxtYemek" runat="server" CssClass="tb5"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style9">
                <asp:Button ID="BtnOnay" runat="server" CssClass="tb5" OnClick="BtnOnay_Click" Text="ONAYLA" />
            </td>
        </tr>
    </table>
</asp:Content>

