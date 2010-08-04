<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>

<%foreach(var prop in ViewData.ModelMetadata.Properties.Where(x=>x.ShowForEdit && !ViewData.TemplateInfo.Visited(x)) )
  {
   %>

   <%if (prop.TemplateHint != null && prop.TemplateHint.Equals("HiddenField"))
     {%>
        <%=Html.Editor(prop.PropertyName,prop.TemplateHint) %>
    <%}%>
<%else { %>
   <div class="FieldContainer">
        <div>
        <%=Html.Label(prop.PropertyName)%>
        <%=Html.Editor(prop.PropertyName) %>
        <%=Html.ValidationMessage(prop.PropertyName,"*") %>
        
        </div>
   
   </div>

<%}%>

<%}%>