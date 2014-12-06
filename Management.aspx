<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="Management.aspx.cs" Inherits="Management" Title="Manage Employees" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div class="bodyContent">
        <aside>
            <asp:ListBox
            runat="server"
            ID="listEmployees"
            OnSelectedIndexChanged="listEmployees_SelectedIndexChanged"
            AutoPostBack="True"
                class="list"
                ></asp:ListBox>
        </aside>
            <p>To edit a current employee's details,
                click on the staff member's name and enter the updated information.</p>
            <asp:Label runat="server" Text="Employee Id:" class="descriptiveLabel" />
            <asp:Label runat="server" Text="" ID="lblEmployeeId" />
            <br />

            <asp:Label runat="server" Text="First Name:" class="descriptiveLabel" />
            <asp:TextBox runat="server" Text="" ID="txtFirstName" class="textInformation" />
            <asp:RequiredFieldValidator
                runat="server"
                ErrorMessage="A first name is required."
                ControlToValidate="txtFirstName"
                Display="Dynamic"
                ID="requiredFieldValidator3" 
                />
            <br />

            <asp:Label runat="server" Text="Middle Name:" class="descriptiveLabel" />
            <asp:TextBox runat="server" Text="" ID="txtMiddleName" class="textInformation" />
            <br />

            <asp:Label runat="server" Text="Last Name:" class="descriptiveLabel" />
            <asp:TextBox runat="server" Text="" ID="txtLastName" class="textInformation" />
            <asp:RequiredFieldValidator
                runat="server"
                ErrorMessage="A last name is required."
                ControlToValidate="txtLastName"
                Display="Dynamic" 
                ID="requiredFieldValidator2"
                />
            <br />

            <asp:Label runat="server" Text="Date of Birth:" class="descriptiveLabel" />
            <asp:TextBox runat="server" Text="" ID="txtDateOfBirth" class="textInformation" />
            <asp:RequiredFieldValidator
                runat="server"
                ErrorMessage="A date of birth is required."
                ControlToValidate="txtDateOfBirth"
                Display="Dynamic" 
                ID="requiredFieldValidator1"/>
            <br />

            <asp:Label runat="server" Text="Phone Number:" class="descriptiveLabel" />
            <asp:TextBox runat="server" Text="" ID="txtPhoneNumber" class="textInformation" />
            <asp:RequiredFieldValidator
                runat="server"
                ErrorMessage="A phone number is required."
                ControlToValidate="txtPhoneNumber"
                Display="Dynamic" 
                ID="requiredFieldValidator5"
                />
            <asp:RegularExpressionValidator
                runat="server"
                ErrorMessage="A valid phone number is required."
                ControlToValidate="txtPhoneNumber"
                Display="Dynamic"
                ValidationExpression="\d{10}" 
                ID="requiredFieldValidator4"/>
            <br />

            <asp:Label runat="server" Text="Email Address:" class="descriptiveLabel" />
            <asp:TextBox runat="server" Text="" ID="txtEmailAddress" class="textInformation" />
            <asp:RequiredFieldValidator
                runat="server"
                ErrorMessage="An email address is required."
                ControlToValidate="txtEmailAddress"
                Display="Dynamic" 
                ID="requiredFieldValidator6"/>
            <asp:RegularExpressionValidator
                ID="RegularExpressionValidator1"
                runat="server"
                ControlToValidate="txtEmailAddress"
                Display="Dynamic"
                ErrorMessage="A valid email address is required."
                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
            <br />

            <asp:Button
                ID="btnUpdate"
                runat="server"
                Text="Save"
                OnClick="btnUpdate_Click" 
                class="button"
                />

            <asp:Button
                ID="btnDelete"
                runat="server"
                Text="Delete"
                class="button"
                />
    </div>
</asp:Content>
