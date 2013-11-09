<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewImages.aspx.cs" Inherits="Login_Webform.Account.ViewImages" %>

<asp:Content ID="Content2" ContentPlaceHolderID="javascript" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="MainContent" runat="server">
    <div data-role="page" id="homepage">
        <div data-role="header">
            <h1>GimmePaw</h1>

        </div>

           <b> Hello <asp:Label ID="lblName" runat="server" Text=""></asp:Label>
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Home</asp:LinkButton>
        </b>
        <div data-role="content">

    <asp:Repeater ID="RepeaterImages" runat="server">
        <ItemTemplate>
            <asp:Image ID="Image" runat="server" ImageUrl='<%# Container.DataItem %>' />
        </ItemTemplate>
    </asp:Repeater>

        </div>
    </div>
</asp:Content>
