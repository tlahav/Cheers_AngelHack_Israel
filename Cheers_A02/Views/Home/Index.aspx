<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="indexTitle" ContentPlaceHolderID="Title" runat="server">
    Home Page
</asp:Content>

<asp:Content ID="indexContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: ViewBag.Message %></h2>
    <p>
        Can I take your order?
    </p>

    <ul data-role="listview" data-inset="true">
        <li data-role="list-divider">Navigation</li>
        <li> <%:Html.ActionLink("Check In - Test", "CheckIn",new {strTableGuid ="6ae1c0bf-50d1-43b1-831f-b1f0b5f9ae43"}) %> </li>
        <li><%: Html.ActionLink("About", "About", "Home") %></li>
        <li><%: Html.ActionLink("Contact", "Contact", "Home") %></li>
    </ul>
</asp:Content>