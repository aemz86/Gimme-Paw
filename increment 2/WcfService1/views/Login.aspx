<html>
<%@ Page Title="" Language="C#"
AutoEventWireup="true"
CodeFile="Login.aspx.cs" Inherits="Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
<style type="text/css">
.style2
{
font-size: large;
}
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
<div>
<h2 style="color: Green">
Login in ASP.NET 4, C#
</h2>
<asp:Login ID="Login1" runat="server" BackColor="#F7F6F3" BorderColor="#E6E2D8" 
BorderPadding="4"
BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em"
ForeColor="#333333" Height="192px" Style="font-size: medium" Width="308px" 
onauthenticate="Login1_Authenticate">
<InstructionTextStyle Font-Italic="True" ForeColor="Black" />
<LoginButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid" 
BorderWidth="1px"
Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284775" />
<TextBoxStyle Font-Size="0.8em" />
<TitleTextStyle BackColor="#5D7B9D" Font-Bold="True" Font-Size="0.9em" 
ForeColor="White" />
</asp:Login>
</div>
</asp:Content>
</html>