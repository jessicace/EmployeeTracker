<%@ Page Title="Report" MasterPageFile="~/MasterPage.master" Language="C#" AutoEventWireup="true" CodeFile="Report.aspx.cs" Inherits="Report" %>


<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div class="bodyContent">
        <aside>
            <asp:ListBox
            runat="server"
            ID="listEmployees"
            
            AutoPostBack="True"
                class="list" OnSelectedIndexChanged="listEmployees_SelectedIndexChanged"
                ></asp:ListBox>
        </aside>
        <asp:Label runat="server" Text="Employee Id:" class="descriptiveLabel" />
        <asp:Label runat="server" Text="" ID="lblEmployeeId" />
            <br/>
        <asp:label runat="server" id="lblName" class="descriptiveLabel" text="Full Name:"></asp:label>
        <asp:label runat="server" id="lblFullName" class="" text=""></asp:label>
         <br/>
        <asp:Label runat="server" Text="Date of Birth:" class="descriptiveLabel" />
        <asp:Label runat="server" ID="lblDateOfBirth" Text="" />
        <br/>
        <asp:Label runat="server" Text="Email:" class="descriptiveLabel" />
        <asp:Label runat="server" ID="lblEmailAddress" Text="" />    
        <br/>
        <asp:Label runat="server" Text="Phone Number:" class="descriptiveLabel" />
        <asp:Label runat="server" ID="lblPhoneNumber" Text="" />    
        <br/>
        <asp:label runat="server" id="lblStartDate" class="descriptiveLabel" text="Start Date:"></asp:label>
        <asp:DropDownList ID="listDates" runat="server"></asp:DropDownList>
        <asp:DropDownList ID="listMonths" runat="server"></asp:DropDownList>
        <asp:DropDownList ID="listYears" runat="server"></asp:DropDownList>
        <br />
        <asp:label runat="server" id="lblEndDate" class="descriptiveLabel" text="End Date:"></asp:label>
        <asp:DropDownList ID="listDates2" runat="server"></asp:DropDownList>
        <asp:DropDownList ID="listMonths2" runat="server"></asp:DropDownList>
        <asp:DropDownList ID="listYears2" runat="server"></asp:DropDownList>
            <br/>

        <asp:Button 
            ID="btnShow" 
            CssClass="button"
            runat="server" 
            Text="Show Timesheets" OnClick="btnShow_Click" />
    
        
        <asp:GridView ID="GridView1" runat="server">
            
        </asp:GridView>
    </div>
    </asp:Content>