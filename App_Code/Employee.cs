using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Employee
{
    // properties
    public int EmployeeId { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string DateOfBirth { get; set; }
    public string PhoneNumber { get; set; }

    public Employee()
    {
        
    }

    public Employee(string firstName, string middleName, string surname, string email, string dateOfBirth, string phoneNumber)
    {
        FirstName = firstName;
        MiddleName = middleName;
        Surname = surname;
        Email = email;
        DateOfBirth = dateOfBirth;
        PhoneNumber = phoneNumber;
    }

    public Employee(int id, string firstName, string middleName, string surname, string email, string dateOfBirth, string phoneNumber)
    {
        EmployeeId = id;
        FirstName = firstName;
        MiddleName = middleName;
        Surname = surname;
        Email = email;
        DateOfBirth = dateOfBirth;
        PhoneNumber = phoneNumber;
    }

    public string GetEmployeeName(string firstName, string middleName, string lastName)
    {

        string fullName = firstName + " " + middleName + " " + lastName;
        return fullName;
    }

    public string GetEmployeeName(string firstName, string lastName)
    {
        
        string fullName = firstName + " " + lastName;
        return fullName;
    }

}
