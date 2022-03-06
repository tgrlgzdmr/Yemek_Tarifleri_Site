<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="Yorumlar.aspx.cs" Inherits="Yorumlar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style9 {
            background-color: #00FFFF;
        }
        .auto-style10 {
            background-color: #0000FF;
        }
        .auto-style14 {
            width: 32px;
        }
        .auto-style15 {
            width: 28px;
        }
        .auto-style16 {
            width: 290px;
        }
        .auto-style21 {
            width: 57px;
            text-align: center;
        }
        .auto-style22 {
            text-align: center;
        }
        .auto-style23 {
            width: 373px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel ID="Panel1" runat="server" CssClass="auto-style9">
        <table class="auto-style3">
            <tr>
                <td class="auto-style14">
                    <asp:Button ID="Button1" runat="server" CssClass="tb5" Height="30px" Text="+" Width="30px" OnClick="Button1_Click" />
                </td>
                <td class="auto-style15"><strong>
                    <asp:Button ID="Button2" runat="server" CssClass="tb5" Height="30px" Text="-" Width="30px" OnClick="Button2_Click" />
                    </strong></td>
                <td class="auto-style23"><strong>ONAYLI YORUM LİSTESİ</strong></td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="Panel2" runat="server" CssClass="auto-style10">
        <asp:DataList ID="DataList1" runat="server" Width="444px">
            <ItemTemplate>
                <table class="auto-style3">
                    <tr>
                        <td class="auto-style16">
                            <strong>
                            <asp:Label ID="Label1" runat="server" CssClass="auto-style7" Text='<%# Eval("YorumAdSoyad") %>'></asp:Label>
                            </strong>
                        </td>
                        <td class="auto-style21"> 
                            <asp:Image ID="Image4" runat="server" Height="30px" ImageUrl="~/Resimler/icons8_Delete_240px.png" Width="30px" />     
                        </td>
                        <td class="auto-style22">
                            <asp:Image ID="Image5" runat="server" Height="30px" ImageUrl="~/Resimler/icons8_update_left_rotation_64px.png" Width="30px" />  
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
    </asp:Panel>
    <asp:Panel ID="Panel3" runat="server" CssClass="auto-style9">
        <table class="auto-style3">
            <tr>
                <td class="auto-style14">
                    <asp:Button ID="Button3" runat="server" CssClass="tb5" Height="30px" Text="+" Width="30px" OnClick="Button3_Click"  />
                </td>
                <td class="auto-style15"><strong>
                    <asp:Button ID="Button4" runat="server" CssClass="tb5" Height="30px" Text="-" Width="30px" OnClick="Button4_Click"  />
                    </strong></td>
                <td class="auto-style23"><strong>ONAYLANMAMIŞ YORUM LİSTESİ</strong></td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="Panel4" runat="server" CssClass="auto-style10">
        <asp:DataList ID="DataList2" runat="server" Width="444px">
            <ItemTemplate>
                <table class="auto-style3">
                    <tr>
                        <td class="auto-style16">
                            <strong>
                            <asp:Label ID="Label2" runat="server" CssClass="auto-style7" Text='<%# Eval("YorumAdSoyad") %>'></asp:Label>
                            </strong>
                        </td>
                        <td class="auto-style21"> 
                            <asp:Image ID="Image1" runat="server" Height="30px" ImageUrl="~/Resimler/icons8_Delete_240px.png" Width="30px" />     
                        </td>
                        <td class="auto-style22">
                            <a href="YorumDetay.aspx?Yorumid=<%#Eval("Yorumid")%>">
                                <asp:Image ID="Image2" runat="server" Height="30px" ImageUrl="~/Resimler/icons8_update_left_rotation_64px.png" Width="30px" /> 
                            </a>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
    </asp:Panel>
    </asp:Content>



