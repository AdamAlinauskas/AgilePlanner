<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>

<%var prop = ViewData.ModelMetadata; %>

<div>
        <%=Html.Label(prop.PropertyName)%>
        <%=Html.Editor(prop.PropertyName) %>
        <%=Html.ValidationMessage(prop.PropertyName,"*") %>
</div>