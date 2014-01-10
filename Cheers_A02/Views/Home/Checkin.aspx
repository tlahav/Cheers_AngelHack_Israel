<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<h2>Welcome to <%: ViewBag.restName %></h2>
    <div style="text-align:center;">
    <img src="<%:ViewBag.imageURL %>" alt="Alternate Text"  style="text-align:center;"/>
  </div>
    <div>
   <b>There are</b> <span id="counter"></span> <b> persons in your party</b>
        </div>
      <ul data-role="listview" data-inset="true">
        <li data-role="list-divider">Navigation</li>
        <li><%: Html.ActionLink("Our Menu", "Index", "Home") %></li>
        <li><%: Html.ActionLink("View Specials", "Contact", "Home") %></li>
    </ul>
    <div>
    <input type="button" value="Call for Service" />
    <input type="button" name="check" value="Check Please!" />
        </div>
   <ul data-role="listview" data-inset="true">
        <li data-role="list-divider">Navigation</li>
         <li><%: Html.ActionLink("Home", "Index", "Home") %></li>
    </ul>
    <input type="hidden" id="guidTable" value="<%:ViewBag.guidTable %>"/>
    <script type="text/javascript" src="../../Scripts/jquery-1.6.4.js"></script>
    <script type="text/javascript" src="../../Scripts/modernizr-2.0.6-development-only.js"></script>
    <script type="text/javascript" src="../../Scripts/myJS.js"></script>
</asp:Content>
