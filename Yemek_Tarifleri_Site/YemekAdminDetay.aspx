<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="YemekAdminDetay.aspx.cs" Inherits="YemekAdminDetay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style9 {
            width: 100%;
            background-color: #3333FF;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel ID="Panel4" runat="server" CssClass="auto-style10">
        <table class="auto-style9">
            <tr>
                <td class="auto-style20">&nbsp;</td>
                <td class="auto-style20">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style20"><span class="auto-style7">YEMEK AD:</span></td>
                <td class="auto-style20">
                    <asp:TextBox ID="TxtAd" runat="server" CssClass="tb5"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">MALZEME:</td>
                <td>
                    <asp:TextBox ID="TxtMalzeme" runat="server" CssClass="tb5" Height="150px" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">TARİF</td>
                <td>
                    <asp:TextBox ID="TxtTarif" runat="server" CssClass="tb5" Height="200px" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">RESİM</td>
                <td>
                    <asp:FileUpload ID="Fikon" runat="server" CssClass="tb5" />
                </td>
            </tr>
            <tr>
                <td class="auto-style7">KATEGORİ</td>
                <td>
                    <asp:DropDownList ID="DrpKategori" runat="server" CssClass="tb5">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td>
                    <asp:Button ID="BtnGuncelle" runat="server" CssClass="tb5" OnClick="BtnEkle_Click" Text="GÜNCELLE" />
                </td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>

