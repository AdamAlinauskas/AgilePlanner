<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/General.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<UI.Models.SprintDto>>" %>
<%@ Import Namespace="UI.Controllers" %>
<%@ Import Namespace="Microsoft.Web.Mvc" %>
<%@ Import Namespace="MvcContrib.UI.Grid" %>
<%@ Import Namespace="UI.Models" %>
<%@ Import Namespace="MvcContrib.UI.Grid.ActionSyntax" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
Sprints
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ScriptsAndStylesContent" runat="server">
<style type="text/css">
h2
{
    color:darkred;
    margin-top:50px;    
}

</style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">

<%=Html.ActionLink<SprintController>(x=>x.AddEdit(0),"Create") %>
<div>
<h2>Sprints</h2>
(This grid was created with mvc contrib using html.grid)
<%
  Html.Grid(Model).Columns(
      column =>
          {
              column.For(x => x.Id).Named("Edit").Action(x =>{%>
                <td>
                    <%=Html.ActionLink<SprintController>(sprint => sprint.AddEdit(x.Id), "Edit")%>       
                </td>
                <%
               });
              column.For(x => x.Name);
              column.For(x => x.Description);
          }
      ).Attributes(new Dictionary<string, object>{ {"class","grid"}}).Render();%>

</div>

</asp:Content>
