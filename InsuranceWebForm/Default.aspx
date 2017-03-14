<%@ Page Title="Insurance Calc" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="InsuranceWebForm._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row form-group">
    <asp:Label runat="server" CssClass="form-label" AssociatedControlID="genderTxt">
        Gender:
    <asp:TextBox runat="server" CssClass="form-control" ID="genderTxt"></asp:TextBox>
    </asp:Label>
    </div>
    <div class="row form-group">
    <asp:Label runat="server" CssClass="form-label" AssociatedControlID="AgeTxt">
        Age: 
    <asp:TextBox runat="server" CssClass="form-control" ID="AgeTxt"></asp:TextBox>
    </asp:Label>
    </div>
    <asp:Button runat="server" UseSubmitBehavior="true" CssClass="btn btn-success" Text="Submit" ID="SubmitBtn" OnClick="SubmitBtn_Click" />
    
    <asp:Label runat="server">Premium: </asp:Label>
    <asp:Label runat="server" ID="PremiumLbl"></asp:Label>
</asp:Content>
