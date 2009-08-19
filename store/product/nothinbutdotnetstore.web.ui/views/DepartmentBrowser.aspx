<%@ MasterType VirtualPath="Store.master" %>
<%@ Page Language="C#" AutoEventWireup="true" 
Inherits="nothinbutdotnetstore.web.core.ViewModel<IEnumerable<DepartmentItem>>" MasterPageFile="Store.master" %>
<%@ Import Namespace="nothinbutdotnetstore.dto"%>
<%@ Import Namespace="System.Collections.Generic"%>
<asp:Content ID="content" runat="server" ContentPlaceHolderID="childContentPlaceHolder">
    <p class="ListHead">Select An Isle</p>

            <table>            
		<!-- for each of the main departments in the store -->
		    <% foreach (var department in this.data)
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
