<%@ Page Language="C#" MasterPageFile="~/Error.Master" AutoEventWireup="true" CodeBehind="GenericException.aspx.cs" Inherits="WebApplicationLabs.GenericException" %>

<asp:Content ContentPlaceHolderID="ErrorPlaceholder" runat="server">
<h1>Generic Error Occured</h1>
    <hr />
    <h3>your ticket id for future reference<%= Guid.NewGuid() %><br /><b>Contact Customer Support for more informaiton</b></h3>

</asp:Content>