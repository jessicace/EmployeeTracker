﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddEmployee : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DateTimeFormatInfo dateTimeInformation = new DateTimeFormatInfo();

            for (int date = 1; date <= 31; date++)
            {
                ListItem newDate = new ListItem();
                newDate.Text = date.ToString();
                newDate.Value = date.ToString();
                listDates.Items.Add(newDate);
            }

            for (int month = 1; month <= 12; month++)
            {
                ListItem newMonth = new ListItem();
                newMonth.Text = dateTimeInformation.GetMonthName(month);
                newMonth.Value = month.ToString();
                listMonths.Items.Add(newMonth);
            }

            int year = System.DateTime.Now.Year;
            int counter = 0;
            while (counter < 100)
            {
                ListItem newYear = new ListItem();
                newYear.Text = year.ToString();
                newYear.Value = year.ToString();
                listYears.Items.Add(newYear);
                year -= 1;
                counter += 1;
            }
        }
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        Validate();
        if (RequiredFieldValidator1.IsValid &&
            RequiredFieldValidator2.IsValid &&
            RequiredFieldValidator3.IsValid &&
            RequiredFieldValidator5.IsValid &&
            RegularExpressionValidator1.IsValid &&
            RegularExpressionValidator1.IsValid)
        {
            DateTime birthDateTime =
            new DateTime(
                int.Parse(listYears.SelectedValue),
                int.Parse(listMonths.SelectedValue),
                int.Parse(listDates.SelectedValue)
            );

            Employee newEmployee =
                new Employee(
                    txtFirstName.Text,
                    txtMiddleName.Text,
                    txtSurname.Text,
                    txtEmail.Text,
                    birthDateTime.ToShortDateString(),
                    txtPhone.Text);
            EmployeeService employeeService = new EmployeeService();
            int employeeId = employeeService.InsertEmployee(newEmployee);
        }        
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        txtFirstName.Text = "";
        txtMiddleName.Text = "";
        txtSurname.Text = "";
        txtPhone.Text = "";
        txtEmail.Text = "";
    }

}
