<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="KontenjanGoruntule.aspx.cs" Inherits="YazOkuluDersler.KontenjanGoruntule" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <table class="table table-bordered table-hover">
        <tr>
            <th>Ders Ad</th>
            <th>Ders Min Kontenjan</th>
            <th>Ders Maks Kontenjan</th>
        </tr>

        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("DersAd") %></td>
                        <td><%#Eval("DersMinKontenjan") %></td>
                        <td><%#Eval("DersMaksKontenjan") %></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>

    </table>

</asp:Content>
