<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/General.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<UI.Models.SprintDto>>" %>
<%@ Import Namespace="UI.Controllers" %>
<%@ Import Namespace="Microsoft.Web.Mvc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
Sprints
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ScriptsAndStylesContent" runat="server">

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">

<table>
<tr><th>Edit</th><th>Name</th><th>Description</th></tr>

<%foreach (var item in Model)
	{%>
		<tr>
            <td><%=Html.ActionLink<SprintController>(x=>x.AddEdit(item.Id),"Edit") %></td>
            <td><%= item.Name%></td>
            <td><%= item.Description%></td>
        </tr> 
<%	} %>

</table>

</asp:Content>
