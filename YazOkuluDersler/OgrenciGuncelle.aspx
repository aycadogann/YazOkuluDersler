<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="OgrenciGuncelle.aspx.cs" Inherits="YazOkuluDersler.OgrenciGuncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="Form1" runat="server">
        <div class="form-group">

            <div>
                <strong>
                    <asp:Label for="txtOgrId" runat="server" Text="Öğrenci ID : "></asp:Label>
                </strong>
                <asp:TextBox ID="txtOgrId" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                    <asp:Label for="txtOgrAd" runat="server" Text="Öğrenci Ad : "></asp:Label>
                </strong>
                <asp:TextBox ID="txtOgrAd" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                    <asp:Label for="txtOgrSoyad" runat="server" Text="Öğrenci Soyad : "></asp:Label>
                </strong>
                <asp:TextBox ID="txtOgrSoyad" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                    <asp:Label for="txtOgrNumara" runat="server" Text="Öğrenci Numara : "></asp:Label>
                </strong>
                <asp:TextBox ID="txtOgrNumara" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                    <asp:Label for="txtOgrFotograf" runat="server" Text="Öğrenci Fotoğraf : "></asp:Label>
                </strong>
                <asp:TextBox ID="txtOgrFotograf" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                    <asp:Label for="txtOgrSifre" runat="server" Text="Öğrenci Şifre : "></asp:Label>
                </strong>
                <asp:TextBox ID="txtOgrSifre" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />

        </div>
        <asp:Button ID="btnGuncelle" runat="server" Text="Güncelle" CssClass="btn btn-warning" OnClick="btnGuncelle_Click" />
    </form>
</asp:Content>

