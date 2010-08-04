<%@ Page Title="" Language="C#" Inherits="System.Web.Mvc.ViewPage<UI.Models.SprintDto>" MasterPageFile="~/Views/Shared/General.Master" %>
<asp:Content runat="server" ID="Title" ContentPlaceHolderID="TitleContent">Create a sprint</asp:Content>
<asp:Content runat="server" ID="ScriptsAndStyles" ContentPlaceHolderID="ScriptsAndStylesContent">

</asp:Content>
<asp:Content runat="server" ID="Main" ContentPlaceHolderID="MainContent">

<h1>Create a Sprint</h1>
    <%=Html.EditorForModel(Model)%>

</asp:Content>
