<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="OneriDetay.aspx.cs" Inherits="OneriDetay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style9 {
            height: 23px;
        }
        .auto-style10 {
            height: 23px;
            color: #FFFFFF;
            background-color: #0000FF;
        }
        .auto-style11 {
            width: 100%;
            background-color: #0000FF;
        }
        .auto-style12 {
            height: 23px;
            margin-left: 40px;
        }
        .auto-style13 {
            height: 23px;
            color: #FFFFFF;
            text-align: right;
            background-color: #0000FF;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style11">
        <tr>
            <td class="auto-style10" colspan="2"><strong>Tarif Öneri Onay Ve Güncelleme</strong></td>
        </tr>
        <tr>
            <td class="auto-style13">Tarif Ad:</td>
            <td class="auto-style9">
                <asp:TextBox ID="TxtAd" runat="server" CssClass="tb5"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style13">Tarif Malzeme:</td>
            <td class="auto-style12">
                <asp:TextBox ID="TxtMalzeme" runat="server" CssClass="tb5" Height="150px" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style13">Tarif Yapılış:</td>
            <td class="auto-style12">
                <asp:TextBox ID="TxtYapilis" runat="server" CssClass="tb5" Height="200px" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style13">Tarif Resim:</td>
            <td class="auto-style12">
                <asp:FileUpload ID="Fikon" runat="server" CssClass="tb5" />
            </td>
        </tr>
        <tr>
            <td class="auto-style13">Tarif Sahibi:</td>
            <td class="auto-style12">
                <asp:TextBox ID="TxtSahip" runat="server" CssClass="tb5"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style13">Tarif Sahip Mail:</td>
            <td class="auto-style12">
                <asp:TextBox ID="TxtMail" runat="server" CssClass="tb5"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style13">Kategori:</td>
            <td class="auto-style12">
                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="tb5">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style12">
                <asp:Button ID="BtnEkle" runat="server" CssClass="tb5" OnClick="BtnEkle_Click" Text="TARİF EKLE / ONAYLA" />
            </td>
        </tr>
    </table>
</asp:Content>

