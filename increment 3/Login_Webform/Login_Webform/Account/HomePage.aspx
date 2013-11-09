<%@ Page Language="C#" AutoEventWireup="true"  CodeBehind="HomePage.aspx.cs" Inherits="Login_Webform.Account.HomePage" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>HomePage</title>
</head>
<body>
    <form runat="server">
    <div id="lo" align="right">
        <asp:LinkButton ID="lnkbtnLogout" runat="server" OnClick="lnkbtnLogout_Click">Logout</asp:LinkButton>
    </div>
    </form>
    <div>
        Hello <asp:Label ID="lblName" runat="server" Text=""></asp:Label>
        <br />
        <p>
        

        </p>
    </div>

    <div data-role="page" id="homepage">
        <div data-role="header">
            <h1>GimmePaw</h1>
        </div>
        <div data-role="content">
            <div class="ui-grid-a">
                <div class="ui-block-a"> <a href='hospital/hospital-map.html' 
			        class='lightview'
			        data-lightview-group='example'
			        data-lightview-title="Dog Hospital List" 
			        data-lightview-caption="All local Dog hospitals near you."
			        data-role="button">Hospital</a>
	            </div>
                <div class="ui-block-b"> <a href='food/food-map.html' 
				class='lightview'
				data-lightview-group='example' 
				data-lightview-title="Dog Food Store List" 
				data-lightview-caption="All local food stores near you." 
				data-role="button">Food</a>
	            </div>
                <div class="ui-block-a">
	            <a href='parks/parks-map.html' 
			     class='lightview' 
			     data-lightview-group='example'
			     data-lightview-title="Dog Parks List" 
			     data-lightview-caption="All local Dog parks near you."
			     data-role="button">
			     Parks</a>	  
                </div>

                <div class="ui-block-b">
			    <a href='stores/stores-map.html' 
			    class='lightview' 
			    data-lightview-group='example'
			    data-lightview-title="Pet Stores List" 
			    data-lightview-caption="All local pet stores near you."
			    data-role="button">
			    Stores
			    </a>
	            </div>
                <div class="ui-block-a">
			    <a href='vet/vet-map.html' 
			     class='lightview' 
			     data-lightview-group='example'
			     data-lightview-title="Veterinarian List" 
			     data-lightview-caption="All local vet. near you."
			     data-role="button">
			    Vets
			    </a>
		        </div>
                <div class="ui-block-b">
			    <a href='services/services-map.html' 
			     class='lightview' 
			     data-lightview-group='example'
			     data-lightview-title="Dog Services List" 
			     data-lightview-caption="All local Dog services near you."
			     data-role="button">
			    Services
			    </a>
			    </div>
            </div>
        </div>
        <div data-role="footer" align="center">
            <h10>Alex | Rebar | Soumick</h10>
        </div>
    </div>
</body>
</html>
