<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Project2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <link rel="stylesheet" href="Content/flexslider.css" type="text/css" media="screen" />



    <section class="slider">
        <div class="flexslider">
              <ul class="slides">
                <li>
  	    	        <img src="img/1.jpg" />
  	    		</li>
  	    		<li>
  	    	        <img src="img/2.jpg" />
  	    		</li>
  	    		<li>
  	    	        <img src="img/3.jpg" />
  	    		</li>
              </ul>
        </div>
    </section>

    <div class="row">
        <div class="col-md-4">
            <h2>Getting started</h2>
            <p align="justify">
                ASP.NET Web Forms lets you build dynamic websites using a familiar drag-and-drop, event-driven model.
            A design surface and hundreds of controls and components let you rapidly build sophisticated, powerful UI-driven sites with data access.
            </p>
        </div>
        <div class="col-md-4">
            <h2>Get more libraries</h2>
            <p align="justify">
                NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.
            </p>
        </div>
        <div class="col-md-4">
            <h2>Web Hosting</h2>
            <p align="justify">
                You can easily find a web hosting company that offers the right mix of features and price for your applications.
            </p>
        </div>
    </div>

      <script defer src="Scripts/jquery.flexslider.js"></script>

      <script type="text/javascript">
          $(function () {
              SyntaxHighlighter.all();
          });
          $(window).load(function () {
              $('.flexslider').flexslider({
                  animation: "slide",
                  start: function (slider) {
                      $('body').removeClass('loading');
                  }
              });
          });
      </script>


</asp:Content>
