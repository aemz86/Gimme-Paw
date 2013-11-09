<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UploadImages.aspx.cs" Inherits="Login_Webform.Account.UploadImages" %>

<asp:Content ID="Content2" ContentPlaceHolderID="javascript" runat="server">
    <script type="text/javascript">

        $(document).ready(function () {

            //alert(3);
            $($('#<%=Button1.ClientID %>')).live("click", function () {
                alert("clicked!");
                //alert('<%=Server.MapPath("~/Images") %>');
        });
    });
</script>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="MainContent" runat="server">
    <div data-role="page" id="homepage">
        <div data-role="header">
            <h1>GimmePaw</h1>
        </div>
           <b> Hello <asp:Label ID="lblName" runat="server" Text=""></asp:Label></b>
        <div data-role="content">

                <asp:FileUpload ID="FileUpload1" runat="server" />
                <div align="right">
                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Home</asp:LinkButton>
                    <!--<asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Account/Home.aspx">Home</asp:HyperLink>-->

                </div>
                <br />
                <br />

                <div id="upload">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Upload File" />                    
                </div>

            <asp:Label runat="server" id="StatusLabel" text="Upload status: " />


        </div>
    </div>
</asp:Content>
