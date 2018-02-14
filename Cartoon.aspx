<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Cartoon.aspx.cs" Inherits="MasterAndTheme.Cartoon" Theme="ThemeCartoon" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Image ID="Image1" runat="server" ImageUrl="~/Pictures/kat6.jpg" />
<br />
<br />
<asp:Label ID="Label1" runat="server" Text="Tom"></asp:Label>
<br />
</asp:Content>
