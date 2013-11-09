<%@ Page Title="Register" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Login_Webform.Account.Register" %>


<asp:Content runat="server" ContentPlaceHolderID="javascript">

    <script type="text/javascript">
    //alert("test");
</script>
</asp:Content>


<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div data-role="page" id="page1" data-theme="c">
    <div data-role="header">
        <h1>Login</h1>
    </div>
    <div data-role="content">
        <div data-role="fieldcontain">
            <p>
                <label for="textinput">Username</label>
                <!--<input placeholder="Please enter your username" type="text" name="textinput" id="textinput" value=""/>-->
                <asp:TextBox ID="tb_username" runat="server"></asp:TextBox>
            </p>
            <div data-role="fieldcontain">
                <p>
                    <label for="password1">Password</label>
                    <asp:TextBox ID="tb_password" TextMode="Password" runat="server"></asp:TextBox>
                </p>
	
                <div data-role="fieldcontain">
                    <span>
                        <label for="password2">Re-type Password</label>
                        <asp:TextBox ID="tb_repassword" TextMode="Password" runat="server"></asp:TextBox>
                    </span>

                    <span id="validate-status" ></span>
                    <div data-role="fieldcontain">
                        <p>
                            <label for="email">Email</label>
                            <asp:TextBox ID="tb_email" runat="server"></asp:TextBox>
                        </p>
                        <p>&nbsp;
                            <asp:Button ID="btnRegister" runat="server" OnClick="btnRegister_Click" Text="Button" />
                            <!--<input type="submit" name="submit" class = "list" value="Register" />-->
                        </p>
                    </div>
                </div>
            </div>
        </div>
        <div data-role="footer">
            <h4>Footer  </h4>
        </div>
    </div>
</div>

</asp:Content>