<%@ Page Language="C#" Title="Insert New Employee" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AddEmployee.aspx.cs" Inherits="AddEmployee" %>

<asp:Content runat="server" id="BodyContent" ContentPlaceHolderId="MainContent">

<div class="bodyContent">
    <asp:label runat="server" id="lblFirstName" class="descriptiveLabel" text="First Name:"></asp:label>
    <asp:textbox id="txtFirstName" runat="server" AutoPostBack="True" class="textInformation" Width="150px"></asp:textbox>
    <asp:requiredfieldvalidator ValidationGroup="group" controltovalidate="txtFirstName" id="RequiredFieldValidator1" runat="server" errormessage="A first name is required." Display="Dynamic" SetFocusOnError="True" ValidateRequestMode="Enabled" ViewStateMode="Enabled" Width="400px">Required</asp:requiredfieldvalidator>
    <asp:rangevalidator runat="server" controltovalidate="txtFirstName" type="String"></asp:rangevalidator>
    <br />

    <asp:label runat="server" id="lblMiddleName" class="descriptiveLabel"  text="Middle Name:"></asp:label>
    <asp:textbox id="txtMiddleName" runat="server" Width="150px" class="textInformation"></asp:textbox>
    <br />

    <asp:label runat="server" id="lblSurname" class="descriptiveLabel"  text="Surname:"></asp:label>
    <asp:textbox id="txtSurname" runat="server" AutoPostBack="True" class="textInformation" Width="150px"></asp:textbox>
    <asp:requiredfieldvalidator ValidationGroup="group" controltovalidate="txtSurname"  id="RequiredFieldValidator2" runat="server" errormessage="A surname is required."></asp:requiredfieldvalidator>
    <br />

    <asp:label runat="server" id="lblEmail" class="descriptiveLabel" text="Email Address:"></asp:label>
    <asp:textbox id="txtEmail" runat="server" AutoPostBack="True" class="textInformation" Width="150px"></asp:textbox>
    <asp:requiredfieldvalidator ValidationGroup="group" controltovalidate="txtEmail" id="RequiredFieldValidator3" runat="server" errormessage="An email is required." Display="Dynamic"></asp:requiredfieldvalidator>
    <asp:RegularExpressionValidator ValidationGroup="group" ControlToValidate="txtEmail" ID="RegularExpressionValidator1" runat="server" ErrorMessage="This is not a valid email address." ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" Display="Dynamic"></asp:RegularExpressionValidator>
    <br />

    <asp:label runat="server" id="lblDOB" class="descriptiveLabel" text="Date of Birth:"></asp:label>
    <asp:DropDownList ID="listDates" runat="server"></asp:DropDownList>
    <asp:DropDownList ID="listMonths" runat="server"></asp:DropDownList>
    <asp:DropDownList ID="listYears" runat="server"></asp:DropDownList>
    <br />
        
    <asp:Label runat="server" class="descriptiveLabel" ID="lblPhoneNumber" Text="Phone Number:"></asp:Label>
    <asp:TextBox ID="txtPhone" runat="server" AutoPostBack="True" Width="150px" class="textInformation"></asp:TextBox>
    <asp:RequiredFieldValidator ControlToValidate="txtPhone" ValidationGroup="group" ID="RequiredFieldValidator5" runat="server" ErrorMessage="Please enter a contact number." Display="Dynamic"></asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator runat="server" ValidationGroup="group" ControlToValidate="txtPhone" ValidationExpression="\d{10}" Display="Dynamic">Please enter a valid 10-digit phone number.</asp:RegularExpressionValidator>    
    <br />

    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="group" />
    <asp:Button ID="btnUpdate" runat="server" Text="Save" OnClick="btnUpdate_Click" class="button"/> 
    <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click" class="button"/>    
</div>     

</asp:Content>
