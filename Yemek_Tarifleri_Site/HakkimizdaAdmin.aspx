<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="HakkimizdaAdmin.aspx.cs" Inherits="HakkimizdaAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style9 {
            color: #FFFFFF;
            font-size: large;
            background-color: #0000FF;
        }
        .auto-style10 {
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p class="auto-style9">
        <div class="auto-style10">
            <strong>Hakkımızda&nbsp;&nbsp;&nbsp; </strong>
        </div>
        <table class="auto-style3">
            <tr>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="tb5" Height="300px" TextMode="MultiLine" Width="435px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style10">
                    <asp:Button ID="Button1" runat="server" CssClass="tb5" OnClick="Button1_Click" Text="Güncelle" />
                </td>
            </tr>
        </table>
    </p>
</asp:Content>

