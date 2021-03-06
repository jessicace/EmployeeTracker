﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

public class EmployeeHoursService
{
    public void InsertTimesheet(EmployeeHours employeeHours)
    {
        // 1. Connection
        SqlConnection connection = new SqlConnection();
        connection.ConnectionString = @"Data Source=JASUS;Initial Catalog=CompanyDatabase;Integrated Security=True";
        connection.Open();

        // 2. Command
        SqlCommand command = new SqlCommand("EmployeeHours_Insert", connection);
        command.CommandType = System.Data.CommandType.StoredProcedure;

        // Input Parameters
        command.Parameters.Add(new SqlParameter("@employee_id_fk", employeeHours.EmployeeId));
        command.Parameters.Add(new SqlParameter("@date", DateTime.Parse(employeeHours.DateTimeWorked)));
        command.Parameters.Add(new SqlParameter("@start_time", employeeHours.StartDateTime));
        command.Parameters.Add(new SqlParameter("@end_time", employeeHours.EndDateTime));
        command.Parameters.Add(new SqlParameter("@lunch_break", employeeHours.LunchBreakDuration));

        // 3. Run
        command.ExecuteNonQuery();
        
        // 4. Handle results
        connection.Close();
    }

    public List<EmployeeHours> EmployeeReportById(int id, DateTime startTime, DateTime endTime)
    {
        // 1. Connection
        SqlConnection connection = new SqlConnection();
        connection.ConnectionString = @"Data Source=JASUS;Initial Catalog=CompanyDatabase;Integrated Security=True";
        connection.Open();

        // 2. Command
        SqlCommand command = new SqlCommand("EmployeeHours_Select", connection);
        command.CommandType = System.Data.CommandType.StoredProcedure;

        // Input Parameters
        command.Parameters.Add(new SqlParameter("@employee_id", id));
        command.Parameters.Add(new SqlParameter("@start_time", startTime));
        command.Parameters.Add(new SqlParameter("@end_time", endTime));

        // 3. Run
        SqlDataReader reader = command.ExecuteReader();
        List<EmployeeHours> list = new List<EmployeeHours>();
        while (reader.Read())
        {
            EmployeeHours timesheet = new EmployeeHours
                (Convert.ToInt32(reader["employee_id_fk"]),
                Convert.ToString(reader["date"]),
                Convert.ToString(reader["start_time"]),
                Convert.ToString(reader["end_time"]),
                Convert.ToInt32(reader["lunch_break"]));
            list.Add(timesheet);
        }

        // 4. Handle results
        connection.Close();
        return list;
    }
	
    public List<EmployeeHours> EmployeeReportById(int id)
    {
        // 1. Connection
        SqlConnection connection = new SqlConnection();
        connection.ConnectionString = @"Data Source=JASUS;Initial Catalog=CompanyDatabase;Integrated Security=True";
        connection.Open();

        // 2. Command
        SqlCommand command = new SqlCommand("EmployeeHours_SelectById", connection);
        command.CommandType = System.Data.CommandType.StoredProcedure;

        // Input Parameters
        command.Parameters.Add(new SqlParameter("@employee_id_fk", id));

        // 3. Run
        SqlDataReader reader = command.ExecuteReader();
        List<EmployeeHours> list = new List<EmployeeHours>();
        while (reader.Read())
        {
            EmployeeHours timesheet = new EmployeeHours
            (Convert.ToInt32(reader["employee_id_fk"]),
                Convert.ToString(reader["date"]),
                Convert.ToString(reader["start_time"]),
                Convert.ToString(reader["end_time"]),
                Convert.ToInt32(reader["lunch_break"])); 
            list.Add(timesheet);
        }

        // 4. Handle results
        connection.Close();
        return list;
    }

    public List<EmployeeHours> EmployeeReportSelectAll()
    {
        // 1. Connection
        SqlConnection connection = new SqlConnection();
        connection.ConnectionString = @"Data Source=JASUS;Initial Catalog=CompanyDatabase;Integrated Security=True";
        connection.Open();

        // 2. Command
        SqlCommand command = new SqlCommand("EmployeeHours_SelectAll", connection);
        command.CommandType = System.Data.CommandType.StoredProcedure;

        // 3. Run
        SqlDataReader reader = command.ExecuteReader();
        List<EmployeeHours> list = new List<EmployeeHours>();
        while (reader.Read())
        {
            EmployeeHours timesheet = new EmployeeHours
            (Convert.ToInt32(reader["employee_id_fk"]),
                Convert.ToString(reader["date"]),
                Convert.ToString(reader["start_time"]),
                Convert.ToString(reader["end_time"]),
                Convert.ToInt32(reader["lunch_break"]));
            list.Add(timesheet);
        }

        // 4. Handle results
        connection.Close();
        return list;
    }
}
