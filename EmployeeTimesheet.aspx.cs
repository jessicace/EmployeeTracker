using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class EmployeeTimesheet : System.Web.UI.Page
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

            DateTime dateWorked = new DateTime();
            dateWorked = DateTime.Today;

            for (int hour = 0; hour <= 24; hour++)
            {
                DateTime hours = new DateTime();
                hours = hours.AddHours(hour);
                ListItem newTime = new ListItem();
                newTime.Text = hours.ToShortTimeString();
                newTime.Value = hours.ToShortTimeString();
                listStartTime.Items.Add(newTime);
                listEndTime.Items.Add(newTime);
            }
        }

        for (int lunchBreak = 0; lunchBreak <= 120; lunchBreak += 15)
        {
            ListItem newBreak = new ListItem();
            newBreak.Text = lunchBreak.ToString() + " minutes";
            newBreak.Value = lunchBreak.ToString();
            listBreak.Items.Add(newBreak);
        }
    }

    protected void calDateWorked_SelectionChanged(object sender, EventArgs e)
    {
        txtDateWorked.Text = calDateWorked.SelectedDate.ToShortDateString();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        EmployeeHoursService employeeHoursService = new EmployeeHoursService();

        EmployeeHours newTimesheet = 
            new EmployeeHours(
                int.Parse(listEmployees.SelectedValue),
                txtDateWorked.Text,
                listStartTime.SelectedValue,
                listEndTime.SelectedValue,
                int.Parse(listBreak.SelectedValue));

        employeeHoursService.InsertTimesheet(newTimesheet);
    }

    protected void listEmployees_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtEmployeeId.Text = listEmployees.SelectedValue;
    }
}
