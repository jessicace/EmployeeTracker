using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Management : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            EmployeeService employeeService = new EmployeeService();
            List<Employee> employeeNames = employeeService.SelectEmployeeName();

            listEmployees.DataSource = employeeNames;
            foreach (Employee employee in employeeNames)
            {
                ListItem newName = new ListItem();
                newName.Text = employee.FullName;
                newName.Value = employee.EmployeeId.ToString();
                listEmployees.Items.Add(newName);
            }
        }
    }
    protected void listEmployees_SelectedIndexChanged(object sender, EventArgs e)
    {
        EmployeeService employeeService = new EmployeeService();
        Employee employee = employeeService.SelectById(listEmployees.SelectedValue);

        lblEmployeeId.Text = employee.EmployeeId.ToString();
        txtFirstName.Text = employee.FirstName;
        txtMiddleName.Text = employee.MiddleName;
        txtLastName.Text = employee.Surname;
        txtPhoneNumber.Text = employee.PhoneNumber;
        txtEmailAddress.Text = employee.Email;
        txtDateOfBirth.Text = employee.DateOfBirth;

    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        Validate();
        if (requiredFieldValidator1.IsValid &&
            requiredFieldValidator2.IsValid &&
            requiredFieldValidator3.IsValid &&
            requiredFieldValidator4.IsValid &&
            requiredFieldValidator5.IsValid &&
            requiredFieldValidator6.IsValid &&
            RegularExpressionValidator1.IsValid)
        {

            Employee newEmployee =
                new Employee(
                    int.Parse(lblEmployeeId.Text),
                    txtFirstName.Text,
                    txtMiddleName.Text,
                    txtLastName.Text,
                    txtEmailAddress.Text,
                    txtDateOfBirth.Text,
                    txtPhoneNumber.Text);
            EmployeeService employeeService = new EmployeeService();
            employeeService.UpdateEmployee(newEmployee);
        }
    }
}