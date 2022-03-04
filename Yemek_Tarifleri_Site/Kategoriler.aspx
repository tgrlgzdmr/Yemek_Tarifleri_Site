<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="Kategoriler.aspx.cs" Inherits="Kategoriler" %>

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
        .auto-style18 {
            font-size: medium;
        }
        .auto-style19 {
            width: 30px;
        }
        .auto-style20 {
            height: 32px;
        }
        .auto-style21 {
            width: 57px;
            text-align: center;
        }
        .auto-style22 {
            text-align: center;
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
                <td><strong>KATEGORİ LİSTESİ</strong></td>
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
                            <asp:Label ID="Label1" runat="server" CssClass="auto-style7" Text='<%# Eval("KategoriAd") %>'></asp:Label>
                            </strong>
                        </td>
                        <td class="auto-style21">
                            <a href="Kategoriler.aspx?Kategoriid=<%#Eval("Kategoriid")%>&islem=sil">
                                <asp:Image ID="Image4" runat="server" Height="30px" ImageUrl="~/Resimler/icons8_Delete_240px.png" Width="30px" />
                            </a>
                        </td>
                        <td class="auto-style22">
                            
                            <a href="KategoriAdminDetay.aspx?Kategoriid=<%#Eval("Kategoriid")%>">
                                <asp:Image ID="Image5" runat="server" Height="30px" ImageUrl="~/Resimler/icons8_update_left_rotation_64px.png" Width="30px" />
                            </a>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
    </asp:Panel>
    <asp:Panel ID="Panel3" runat="server" CssClass="auto-style9">
        <table class="auto-style3">
            <tr>
                <td class="auto-style19"><strong>
                    <asp:Button ID="Button3" runat="server" CssClass="tb5" Height="30px" OnClick="Button3_Click" Text="+" Width="30px" />
                    </strong></td>
                <td class="auto-style19"><strong>
                    <asp:Button ID="Button4" runat="server" CssClass="tb5" Height="30px" OnClick="Button4_Click" Text="-" Width="30px" />
                    </strong></td>
                <td><strong><span class="auto-style18">KATEGORİ EKLE</span></strong></td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="Panel4" runat="server" CssClass="auto-style10">
        <table class="auto-style3">
            <tr>
                <td class="auto-style20">&nbsp;</td>
                <td class="auto-style20">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style20"><span class="auto-style7">KATEGORİ AD</span></td>
                <td class="auto-style20">
                    <asp:TextBox ID="TxtAd" runat="server" CssClass="tb5"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">KATEGORİ İKON</td>
                <td>
                    <asp:FileUpload ID="Fikon" runat="server" CssClass="tb5" />
                </td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td>
                    <asp:Button ID="BtnEkle" runat="server" CssClass="tb5" Text="Ekle" OnClick="BtnEkle_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>

