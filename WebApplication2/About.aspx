<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WebApplication2.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <p>Enter First Number :<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p>Enter Second Number:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Find Sum" />
&nbsp;The Result:
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </p>
    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information.</p>






</asp:Content>
