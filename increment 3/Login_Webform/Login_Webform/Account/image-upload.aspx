<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="image-upload.aspx.cs" Inherits="Login_Webform.Account.no_master_test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

        <script src="../Scripts/jquery-1.6.4.min.js" type="text/javascript"></script>
<!--                        
        <script src="../Scripts/jquery-mobile/jquery.mobile-1.0.min.js" type="text/javascript"></script>
        <link rel="stylesheet" media="screen" href="~/Styles/jquery.mobile.theme-1.0.min.css" runat="server" />

        <link rel="stylesheet" media="screen" href="~/Styles/jquery.mobile.structure-1.0.min.css" runat="server" />
-->
<script type="text/javascript">

    $(window).load(function () {
        //alert(3);
        $($('#<%=Button1.ClientID %>')).live("click", function () {
            alert("clicked!");
            //alert('<%=Server.MapPath("~/Images") %>');

        });

    });
</script>

</head>
<body>

    <div data-role="page" id="homepage">
        <div data-role="header">
            <h1>GimmePaw</h1>
        </div>
        <div data-role="content">

            <!--<form id="form1" runat="server">-->
                <asp:FileUpload ID="FileUpload1" runat="server" />
                <br />
                <br />

                <div id="upload">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Upload File" />
                </div>

            <asp:Label runat="server" id="StatusLabel" text="Upload status: " />

            <!--</form>-->
        </div>
    </div>
</body>
</html>
