<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/AutovynModules/AUTOVYN.Master" CodeBehind="InsuranceData.aspx.vb" Inherits="AutovynERP.InsuranceData" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
	<style>
        * {
            margin: 0;
            padding: 0;
            font-family: 'Ubuntu', sans-serif;
        }

        body{
            font-size: 13px;
            background-image:url()
        }

        .main-section{
            margin-top:70px;
        }


        ::-webkit-scrollbar {
            display: none;
        }
        .popup {
            display: none;
            position: absolute;
            width: 50%;
            transform: translate(-50%, -50%);
            z-index: 999;
            background-color: #e9e9e9;
            padding: 20px;
            border: 1px solid #ccc;
            margin-left: 48%;
            margin-top: -21%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<div class="container main-section">
        <div class="row">
            <div class="row text-center text-bold ">
                    <div class="title">
                        <h5>Dse insurance response</h5>
                    </div>
                </div>
            <div class="container-fluid">
                    <div class="row mt-1 mb-1 amt-box">

                        <asp:Label ID="Label1" Class="col-2 col-form-label amt-box-lbl" runat="server" Text="Customer Name/Location"></asp:Label>
                        <div class="col-lg-3  amt-box-total">
                            <asp:TextBox ID="searchbox" Class="col-2 form-control" runat="server"></asp:TextBox>
                        </div>

                        <div class="col-lg-1 amt-box-total-1">
                            <asp:Button ID="search" Class="btn" runat="server" Text="Filter" />
                        </div>

                        <div class="col-lg-1 amt-box-total-1">
                            <asp:Button ID="viewall" Class="btn" runat="server" Text="viewall" />
                        </div>

                    </div>
                </div>

            <div class="col-12">
                <div class="gridView">
                    <div class='popup'>

						<div class="row">
							<asp:Image ID="Image1" runat="server" />
						</div>
                        <button id="closePopupBtn" class="btn">Close</button>
                        </div>


                     <asp:Panel ID="Panel1" CssClass="grid_panel" ScrollBars="Horizontal" runat="server">
                         <asp:GridView ID="Data_Grid" runat="server" Style="top: 0px; border: 1px solid #6fd472; text-align: center; border-collapse: inherit; background-color: hsla(40deg, 4%, 36%, 0.25); position: relative; width: 100%; table-layout: auto;"
                            ShowHeaderWhenEmpty="True" CellPadding="3" BackColor="White" PagerStyle-CssClass="myPagerStyle" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellSpacing="1">
							<%-- <Columns>
                                 <asp:CommandField ShowSelectButton="True" HeaderText="Send Link" ButtonType="Image" SelectImageUrl="https://png.pngtree.com/element_our/20190529/ourmid/pngtree-link-icon-image_1198606.jpg" SelectText="Edit">
                                    <ControlStyle Width="20px" />
                                    <ItemStyle HorizontalAlign="center" CssClass="ms-3" VerticalAlign="Middle" Width="80px" />
                                </asp:CommandField>
							 </Columns>--%>
                             
                            <AlternatingRowStyle BackColor="White" />
                            <HeaderStyle BackColor="#6B696B" Font-Bold="true" Font-Size="Larger" ForeColor="White" />
                            <RowStyle BackColor="#f5f5f5" />
                            <HeaderStyle BackColor="#0C4160" ForeColor="WhiteSmoke" Width="100%" />
                             
                            <FooterStyle BackColor="#CCCCCC" />
                            <SelectedRowStyle Font-Size="Large" />
                            <HeaderStyle Font-Bold="True" ForeColor="White" Width="100%" />
                            <SelectedRowStyle BackColor="#336699" Font-Bold="True" ForeColor="White" />
                            <PagerSettings FirstPageText="1" LastPageText="last" NextPageText="next" PreviousPageText="previous" />
                            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                        </asp:GridView>
                    
                    </asp:Panel>
                </div>
            </div>
        </div>

         
    </div>

    <script>
		// Get the close button element
		var closePopupBtn = document.getElementById("closePopupBtn");

		// Get the popup element
		var popup = document.querySelector('.popup');

		closePopupBtn.addEventListener("click", function () {
			// Hide the popup
			popup.style.display = "none";
		});
	</script>
</asp:Content>
