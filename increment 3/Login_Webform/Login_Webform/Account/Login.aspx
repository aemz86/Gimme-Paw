<%@ Page Title="GimmePaw | Log in" Language="C#"  MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Login_Webform.Account.Login" %>



<asp:Content runat="server" ContentPlaceHolderID="javascript">

    <script type="text/javascript">


</script>
</asp:Content>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">

    <div data-role="page" id="page1">
    <div data-role="header">
    <h1>Login</h1>
    </div>
    <div data-role="content">
        <div data-role="fieldcontain">
            <p>
                <label for="textinput">Username</label>
                <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            </p>
      
            <div data-role="fieldcontain">
                <p>
                    <label for="passwordinput">Password</label>
                    <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                </p>
                <p>
                    <asp:Label ID="lbl_loginfail" runat="server" Text=""></asp:Label>
                </p>
                <div data-role="fieldcontain">        
                    <p>                                        
                        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Button" />
                        <asp:TextBox ID="LoginStatus" runat="server"></asp:TextBox>
                    </p>
                </div>
            </div>
        <div id="results"></div>
        </div>

    </div>
    <div id="foot"></div>
    <div data-role="footer">
        <h4>Footer  </h4>
    </div>
</div>
</asp:Content>