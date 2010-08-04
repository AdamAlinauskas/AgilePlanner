﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/General.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<UI.Models.SprintDto>>" %>
<%@ Import Namespace="UI.Controllers" %>
<%@ Import Namespace="Microsoft.Web.Mvc" %>
<%@ Import Namespace="MvcContrib.UI.Grid" %>
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


<h2>Hand rolled grid</h2>
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


<div>
<h2>Auto grid</h2>

<%=Html.Grid(Model).AutoGenerateColumns()%>

</div>

</asp:Content>
