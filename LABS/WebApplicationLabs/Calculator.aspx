<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="WebApplicationLabs.Calculator" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <h1>CALCULATOR</h1>
    <p>
        <asp:TextBox ID="screen" runat="server" Width="236px"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="1" Width="61px" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="2" Width="61px" />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="3" Width="61px" />
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="/" Width="61px" />
    </p>
    <p>
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="4" Width="61px" />
        <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="5" Width="61px" />
        <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="6" Width="61px" />
        <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="*" Width="61px" />
    </p>
    <p>
        <asp:Button ID="Button9" runat="server" OnClick="Button9_Click" Text="7" Width="61px" />
        <asp:Button ID="Button10" runat="server" OnClick="Button10_Click" Text="8" Width="61px" />
        <asp:Button ID="Button11" runat="server" OnClick="Button11_Click" Text="9" Width="61px" />
        <asp:Button ID="Button12" runat="server" OnClick="Button12_Click" Text="+" Width="61px" />
    </p>
    <p>
        <asp:Button ID="Button13" runat="server" OnClick="Button13_Click" Text="C" Width="61px" />
        <asp:Button ID="Button14" runat="server" OnClick="Button14_Click" Text="0" Width="61px" />
        <asp:Button ID="Button15" runat="server" OnClick="Button15_Click" Text="-" Width="61px" />
        <asp:Button ID="Button16" runat="server" OnClick="Button16_Click" Text="=" Width="61px" />
    </p>
    <p>
        <asp:Image ID="Image1" runat="server" Height="142px" ImageUrl="~/images/calculator.jpg" Visible="False" Width="247px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="ImageButton1" runat="server" Height="73px" ImageUrl="~/images/calculator.jpg" OnClick="ImageButton1_Click" Width="136px" />
    </p>
    <p>&nbsp;</p>


</asp:Content>
