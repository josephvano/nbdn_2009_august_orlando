<%@ MasterType VirtualPath="Store.master" %>
<%@ Page Language="C#" AutoEventWireup="true" 
Inherits="nothinbutdotnetstore.web.ui.views.DepartmentBrowser" CodeFile="DepartmentBrowser.aspx.cs" MasterPageFile="Store.master" %>
<%@ Import Namespace="nothinbutdotnetstore.infrastructure"%>
<asp:Content ID="content" runat="server" ContentPlaceHolderID="childContentPlaceHolder">
    <p class="ListHead">Select An Isle</p>

            <table>            
      		    <% this.model.each(department => {%>
              	<tr class="ListItem">
               		 <td>                     
                    <%=department.name%>                   
                	</td>
             	 </tr>        
           	 <% });%>
	    </table>            
</asp:Content>
