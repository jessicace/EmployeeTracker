<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" Title="Add New Timesheet" AutoEventWireup="true" CodeFile="EmployeeTimesheet.aspx.cs" Inherits="EmployeeTimesheet" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">

    <div class="bodyContent">
	<aside>
            <asp:listbox 
                class="list"
                runat="server" 
                ID="listEmployees" 
                AutoPostBack="True" 
                OnSelectedIndexChanged="listEmployees_SelectedIndexChanged">
            </asp:listbox>
        </aside>

        <asp:Label ID="lblEmployeeId" runat="server" Text="Employee Id:" class="descriptiveLabel"></asp:Label>
        <asp:TextBox ID="txtEmployeeId" runat="server" class="textInformation"></asp:TextBox><br />
        <asp:label runat="server" id="lblStartTime" text="Start Time:" class="descriptiveLabel"></asp:label>
        <asp:DropDownList ID="listStartTime" runat="server"></asp:DropDownList> <br/>
        <asp:label runat="server" id="lblEndTime" text="End Time:" class="descriptiveLabel"></asp:label>
        <asp:DropDownList ID="listEndTime" runat="server" Width="150px"></asp:DropDownList> <br/>
        <asp:label runat="server" id="lblBreakTime" text="Break Duration:" class="descriptiveLabel"></asp:label>
        <asp:DropDownList ID="listBreak" runat="server" Width="150px"></asp:DropDownList>
        <br />
        
	<asp:label runat="server" id="lblCalendar" text="Date:" class="descriptiveLabel"></asp:label>
        <asp:TextBox ID="txtDateWorked" runat="server" class="textInformation"></asp:TextBox> <br/> <br />
        <asp:Calendar ID="calDateWorked" runat="server" OnSelectionChanged="calDateWorked_SelectionChanged"></asp:Calendar><br />
        <asp:Button ID="btnAdd" runat="server" Text="Add Timesheet" OnClick="btnAdd_Click" class="button" />
        <asp:Button ID="btnClear" runat="server" Text="Clear" class="button"/>
    </div>

</asp:Content>
