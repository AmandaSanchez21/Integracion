<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="AlmacenWS._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Almacén de vinos Web Service</h1>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Button" />
            <asp:GridView ID="grdVinos" runat="server">
            </asp:GridView>
        </p>
    </div>

    <div class="row">
    </div>

</asp:Content>
