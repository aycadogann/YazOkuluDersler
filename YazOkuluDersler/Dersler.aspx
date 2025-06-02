<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Dersler.aspx.cs" Inherits="YazOkuluDersler.Dersler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Ders Seçin"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
        <br />
        <div>
            <asp:Label ID="Label2" runat="server" Text="Öğrenci ID"></asp:Label>
            <asp:TextBox ID="txtOgrenciId" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <asp:Button ID="btnTalepOlustur" runat="server" Text="Ders Talep Oluştur" CssClass="btn btn-warning" OnClick="btnTalepOlustur_Click" />
        <br />
        <br />
        <br />
        <div>
            <table class="table table-bordered table-hover">
                <tr>
                    <th>Öğrenci ID</th>
                    <th>Öğrenci Ad</th>
                    <th>Öğrenci Soyad</th>
                </tr>
                <tbody>
                    <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                            <tr>
                                <td><%#Eval("OgrId") %></td>
                                <td><%#Eval("OgrAd") %></td>
                                <td><%#Eval("OgrSoyad") %></td>
                        </ItemTemplate>
                    </asp:Repeater>
                </tbody>
            </table>
        </div>
    </form>
</asp:Content>
