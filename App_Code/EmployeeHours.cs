using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class EmployeeHours
{
    public String StartDateTime { get; set; }
    public String EndDateTime { get; set; }
    public int LunchBreakDuration { get; set; }
    public string DateTimeWorked { get; set; }
    public int EmployeeId { get; set; }
    
    public EmployeeHours(int employeeId, string dateWorked, string startDateTime, string endDateTime, int lunchBreakDuration)
    {
	EmployeeId = employeeId;
	DateTimeWorked = dateWorked;
	StartDateTime = startDateTime;
	EndDateTime = endDateTime;
        LunchBreakDuration = lunchBreakDuration;
    }
}
