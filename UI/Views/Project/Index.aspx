<%@ Page Title="" Language="C#" Inherits="System.Web.Mvc.ViewPage<ViewModel.ProjectListingDto>" MasterPageFile="~/Views/Shared/General.Master" %>
<%@ Import Namespace="MvcContrib.UI.Grid" %>
<%@ Import Namespace="MvcContrib.UI.Grid.ActionSyntax" %>
<%@ Import Namespace="UI.Controllers" %>
<%@ Import Namespace="Microsoft.Web.Mvc" %>
<asp:Content runat="server" ID="Title" ContentPlaceHolderID="TitleContent">Projects</asp:Content>
<asp:Content runat="server" ID="ScriptsAndStyles" ContentPlaceHolderID="ScriptsAndStylesContent"></asp:Content>
<asp:Content runat="server" ID="Main" ContentPlaceHolderID="MainContent">

<%=Html.ActionLink<ProjectController>(x=>x.Create(),"Create") %>

<%
  Html.Grid(Model.Projects).Columns(
      column =>
          {
              column.For(x => x.Id).Named("Edit").Action(x =>{%>
                <td>
                    <%=Html.ActionLink<ProjectController>(project => project.AddEdit(x.Id), "Edit")%>       
                </td>
                <%
               });
              column.For(x => x.Name);
              column.For(x => x.Description);
          }
      ).Attributes(new Dictionary<string, object>{ {"class","grid"}}).Render();%>

</asp:Content>
