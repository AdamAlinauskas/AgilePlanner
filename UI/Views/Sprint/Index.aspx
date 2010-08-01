<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/General.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Domain.Sprints.Sprint>>" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
Sprints
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ScriptsAndStylesContent" runat="server">

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">

<%=Html.DisplayForModel()%>

</asp:Content>
