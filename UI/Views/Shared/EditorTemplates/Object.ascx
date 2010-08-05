<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>

<%foreach(var prop in ViewData.ModelMetadata.Properties.Where(x=>x.ShowForEdit && !ViewData.TemplateInfo.Visited(x)) ){%>

      <%if (prop.TemplateHint != null && prop.TemplateHint.Equals("HiddenField")){%>
        <%=Html.Hidden(prop.PropertyName) %>
        <%=Html.Editor(prop.PropertyName) %>
    <%}%>
    
    <%else { %>
        <div>
        <%=Html.Label(prop.PropertyName)%>
        <%=Html.Editor(prop.PropertyName) %>
        <%=Html.ValidationMessage(prop.PropertyName,"*") %>
</div>        
    <%}%>

<%}%>