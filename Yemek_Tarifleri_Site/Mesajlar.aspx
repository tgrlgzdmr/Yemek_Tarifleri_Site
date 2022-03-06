<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="Mesajlar.aspx.cs" Inherits="Mesajlar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .auto-style14 {
            width: 32px;
        }
        .auto-style15 {
            width: 28px;
        }
        .auto-style23 {
            width: 373px;
        }
        .auto-style24 {
            width: 100%;
            height: 36px;
            background-color: #00FFFF;
        }
        .auto-style25 {
            background-color: #0000FF;
        }
        .auto-style26 {
            text-align: center;
        }
        .auto-style29 {
            width: 1464px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel ID="Panel1" runat="server" CssClass="auto-style25">
        <table class="auto-style24">
            <tr>
                <td class="auto-style14">
                    <asp:Button ID="Button1" runat="server" CssClass="tb5" Height="30px" Text="+" Width="30px" OnClick="Button1_Click"/>
                </td>
                <td class="auto-style15"><strong>
                    <asp:Button ID="Button2" runat="server" CssClass="tb5" Height="30px" Text="-" Width="30px" OnClick="Button2_Click"/>
                    </strong></td>
                <td class="auto-style23"><strong>MESAJ LİSTESİ</strong></td>
            </tr>
        </table>
    </asp:Panel>   
    <asp:Panel ID="Panel2" runat="server" CssClass="auto-style25">
         <asp:DataList ID="DataList1" runat="server" Width="444px" CssClass="auto-style25">
            <ItemTemplate>
                <table class="auto-style3">
                    <tr>
                        <td class="auto-style29">
                            <strong>
                            <asp:Label ID="Label1" runat="server" CssClass="auto-style7" Text='<%# Eval("MesajGonderen") %>'></asp:Label>
                            </strong>
                        </td>
                        <td class="auto-style26">
                            <a href="MesajDetay.aspx?Mesajid=<%#Eval("Mesajid")%>">
                                <asp:Image ID="Image5" runat="server" Height="30px" ImageUrl="~/Resimler/icons8_book_reading_1.ico" Width="30px" />
                            </a>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
    </asp:Panel>
    </asp:Content>

