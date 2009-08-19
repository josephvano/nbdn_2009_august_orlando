<%@ MasterType VirtualPath="Store.master" %>
<%@ Page Language="C#" AutoEventWireup="true" 
Inherits="System.Web.UI.Page" MasterPageFile="Store.master" %>
<%@ Import Namespace="nothinbutdotnetstore.dto"%>
<%@ Import Namespace="System.Collections.Generic"%>
<asp:Content ID="content" runat="server" ContentPlaceHolderID="childContentPlaceHolder">
    <p class="ListHead">Select An Isle</p>

            <table>            
		<!-- for each of the main departments in the store -->
		    <% foreach (var department in ((IEnumerable<DepartmentItem>)Context.Items["blah"]))
 {%>
        	<tr class="ListItem">
               		 <td>                     
                    <%= department.name %>                   
                	</td>
           	 </tr>        
           	 
           	 <%
 }%>
	    </table>            
</asp:Content>
