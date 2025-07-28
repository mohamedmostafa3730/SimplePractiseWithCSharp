using C__OOB_L1; 
using System.Xml.Linq;

#region Solution => 1
/* 1-Create an Enum called "WeekDays" with the days of the week (Monday to Sunday) as its members.
    Then, write a C# program that prints out all the days of the week using this Enum.*/
void printDaysOfWeek()
{
    foreach (WeekDays Day in Enum.GetValues(typeof(WeekDays)))
    {
        Console.Write($" {{{Day}}}, ");
    }
}
//printDaysOfWeek();
#endregion

#region Solution => 2

/* 2- Create an Enum called "Seas on" with the four seasons 
    (Spring, Summer, Autumn, Winter) as its members.
    Write a C# program that takes a season name
    as input from the user and displays the corresponding month range for that season.
    Note range for seasons ( spring march to may , summer june to august , autumn September to November,
    winter December to February) */

string GetMonthRangeForSeason(string seasonName)
{
    string Note = "";
    if (seasonName.ToLower() == SeasOn.spring.ToString())
    {
        return Note = "spring march to may";
    }
    else if (seasonName.ToLower() == SeasOn.summer.ToString())
    {
        return Note = "summer june to august";
    }
    else if (seasonName.ToLower() == SeasOn.autumn.ToString())
    {
        return Note = "autumn September to November";
    }
    else if ((seasonName.ToLower() == SeasOn.winter.ToString()))
    {
        return Note = "winter December to February";
    }
    else
    {
        return Note = "Not Valid";
    }
}

//Console.WriteLine(GetMonthRangeForSeason("spring"));
//Console.WriteLine(GetMonthRangeForSeason("dfg"));
#endregion

#region => 3
/* 3-Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum
    Create Variable from previous Enum to Add and Remove Permission from variable,
    check if specific Permission existed inside variable */




#endregion

#region Solution => 4
/* 4.Create an Enum called "Colors" with the basic colors (Red, Green, Blue) as its members.
    Write a C# program that takes a color name as input from the user and displays
    a message indicating whether the input color is a primary color or not. */

bool IsPrimaryColor(string color)
{
    foreach (Colors cole in Enum.GetValues(typeof(Colors)))
    {
        if (color.ToLower() == cole.ToString().ToLower())
        {
            return true;
        }
    }
    return false;
}

Console.WriteLine(IsPrimaryColor("Black"));
Console.WriteLine(IsPrimaryColor("ReD"));
#endregion
