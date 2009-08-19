<%@ MasterType VirtualPath="Store.master" %>
<%@ Page Language="C#" AutoEventWireup="true" 
Inherits="nothinbutdotnetstore.web.ui.views.DepartmentBrowser" CodeFile="DepartmentBrowser.aspx.cs" MasterPageFile="Store.master" %>
<%@ Import Namespace="nothinbutdotnetstore.web.core"%>
<asp:Content ID="content" runat="server" ContentPlaceHolderID="childContentPlaceHolder">
    <p class="ListHead">Select An Isle</p>

            <table>            
		<!-- for each of the main departments in the store -->
		    <%
		        model.list(x=>%>
        	<tr class="ListItem">
               		 <td>                     
                    <%=x.name%>                   
                	</td>
           	 </tr>        
           	 
           	 <%
		        }%>
	    </table>            
</asp:Content>
