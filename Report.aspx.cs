using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Report : System.Web.UI.Page
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
            
            DateTimeFormatInfo dateTimeInformation = new DateTimeFormatInfo();

            for (int date = 1; date <= 31; date++)
            {
                ListItem newDate = new ListItem();
                newDate.Text = date.ToString();
                newDate.Value = date.ToString();
                listDates.Items.Add(newDate);
                listDates2.Items.Add(newDate);
            }

            for (int month = 1; month <= 12; month++)
            {
                ListItem newMonth = new ListItem();
                newMonth.Text = dateTimeInformation.GetMonthName(month);
                newMonth.Value = month.ToString();
                listMonths.Items.Add(newMonth);
                listMonths2.Items.Add(newMonth);
            }

            int year = System.DateTime.Now.Year;
            int counter = 0;
            while (counter < 5)
            {
                ListItem newYear = new ListItem();
                newYear.Text = year.ToString();
                newYear.Value = year.ToString();
                listYears.Items.Add(newYear);
                listYears2.Items.Add(newYear);
                year -= 1;
                counter += 1;
            }
        }
    }
    protected void btnShow_Click(object sender, EventArgs e)
    {
        DateTime startDateTime =
            new DateTime(
                int.Parse(listYears.SelectedValue),
                int.Parse(listMonths.SelectedValue),
                int.Parse(listDates.SelectedValue)
            );

        DateTime endDateTime =
            new DateTime(
                int.Parse(listYears2.SelectedValue),
                int.Parse(listMonths2.SelectedValue),
                int.Parse(listDates2.SelectedValue)
            );

        EmployeeHoursService employeeHoursService = new EmployeeHoursService();
        List<EmployeeHours> timesheets = 
            employeeHoursService.EmployeeReportById(
            int.Parse(listEmployees.SelectedValue),
            startDateTime,
            endDateTime);

        GridView1.DataSource = timesheets;
        GridViewColumnsGenerator auto = new GridViewColumnsGenerator();
        GridView1.AutoGenerateColumns = true;
        GridView1.DataBind();

    }
    protected void listEmployees_SelectedIndexChanged(object sender, EventArgs e)
    {
        EmployeeService employeeService = new EmployeeService();
        Employee employee = employeeService.SelectById(listEmployees.SelectedValue);

        lblEmployeeId.Text = employee.EmployeeId.ToString();
        lblFullName.Text = employeeService.SelectFullNameById(int.Parse(listEmployees.SelectedValue));
        lblPhoneNumber.Text = employee.PhoneNumber;
        lblEmailAddress.Text = employee.Email;
        lblDateOfBirth.Text = employee.DateOfBirth;
    }
}