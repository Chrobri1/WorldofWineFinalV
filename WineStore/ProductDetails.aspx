<%@ Page Title="Product Details" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" 
         CodeBehind="ProductDetails.aspx.cs" Inherits="WineStore.ProductDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="fb-root"></div>
    <script>(function(d, s, id) {
    var js, fjs = d.getElementsByTagName(s)[0];
    if (d.getElementById(id)) return;
    js = d.createElement(s); js.id = id;
    js.src = "//connect.facebook.net/en_US/sdk.js#xfbml=1&version=v2.6";
    fjs.parentNode.insertBefore(js, fjs);
    }(document, 'script', 'facebook-jssdk'));</script>
    <asp:FormView ID="productDetail" runat="server" ItemType="WineStore.Models.Product" SelectMethod ="GetProduct" RenderOuterTable="false">
        <ItemTemplate>
            <div><br /><br />
                <h4><%#:Item.ProductName %></h4>
            </div>
            
            <table>
                <tr>
                    <td>
                        <img src="/Catalog/Images/<%#:Item.ImagePath %>" style="border:solid; color:darkgrey; height:400px"  alt="<%#:Item.ProductName %>"/>
                    </td>
                    <td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td>  
                    <td style="vertical-align: top; text-align:left;">
                        <b>Description:</b><br /><%#:Item.Description %><br /><span><br /><b>Price:</b>&nbsp;<%#: String.Format("{0:c}", Item.UnitPrice) %></span><br /><span><b>Product Number:</b>&nbsp;<%#:Item.ProductID %></span><br />
                        <a href="/AddToCart.aspx?productID=<%#:Item.ProductID %>">               
                                        <span class="ProductListItem">
                                            <br /> <b <button type="submit" class="btn btn-default" name="provider" value="White Wine" title=""></button>
                                            <b>Add To Cart</b></b>
                                        </span> <br /> <br /> <div class="fb-like" data-href="http://winestore1.azurewebsites.net/Product" data-width="160px" data-layout="button_count" data-action="recommend" data-show-faces="true" data-share="true"></div>
                         </a>
                    </td>
                    
               </tr>
            </table><br />
                 <!-- Start reviewbuddy code -->
                <a href="//worldofwine.reviewbuddy.com/" id="reviewbuddylink">Open customer reviews about World of Wine</a>
                <script type="text/javascript">
                 (function () {
                var rb = document.createElement('script'); rb.type = 'text/javascript'; rb.async = true;
                rb.src = '//worldofwine.reviewbuddy.com/widget.js';
                var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(rb, s);
                })();
                </script>                        
                <!-- End reviewbuddy code -->
        </ItemTemplate>
    </asp:FormView>
</asp:Content>