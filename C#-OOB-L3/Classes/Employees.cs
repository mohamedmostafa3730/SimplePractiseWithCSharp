using C__OOB_L3.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__OOB_L3.Classes
{
    internal class Employees
    {
        private int id;
        private string name;
        private Securitylevel securitylevel;
        private decimal salary;
        private String hireDate;
        private Gender gender;
        public Employees(int id, string name, Securitylevel securitylevel, decimal salary, String hireDate,Gender gender)
        {
           this.id = id;
            this.name = name;
            this.securitylevel = securitylevel;
            this.salary = salary;
            this.hireDate = hireDate;
        }
        public Employees(int id, string name, Securitylevel securitylevel, decimal salary, String hireDate) : this(id, name, securitylevel, salary, "Not Have Data", Gender.male ) { }
        public Employees(int id, string name, Securitylevel securitylevel) : this(id, name, securitylevel, 0.0m, "Not Have Data") { }
        public Employees(int id, string name) : this(id, name, Securitylevel.Guest, 0.0m, "Not Have Data") { }
        public Employees(int id) : this(id, "Not Inserted yet!", Securitylevel.Guest, 0.0m, "Not Have Data") { }
        public Employees() : this(1010, "Not Inserted yet!", Securitylevel.Guest, 0.0m, "Not Have Data") { }


        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {   get { return name; }
            set { name = value; }
        }
        public Securitylevel SecurityLevel
        {
            get { return securitylevel; }
            set { securitylevel = value; }
        }
        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public string HireDate
        {
            get { return hireDate; }
            set { hireDate = value; }
        }
        public Gender Gender
        {
            get { return gender; }
            set { Gender = value; }
        }
        
        override public string ToString()
        {
            String AllText = " ";
            AllText += "ID: " + id + "\n";
            AllText += "Name: " + name + "\n";
            AllText += "Security Level: " + securitylevel.ToString() + "\n";
            AllText += "Salary: " + String.Format("{0:C}", salary) + "\n";
            AllText += "Hire Date: " + hireDate + "\n";
            AllText += "Gender: " + gender.ToString() + "\n";
            return AllText;
        }
        /*
         1.	Design and implement a Class for the employees in a company:
            Notes:
            ●	Employees are identified by an ID, Name, security level, salary, hire date and Gender.
            ●	We need to restrict the Gender field to be only M or F [Male or Female] 
            ●	Assign the following security privileges to the employee (guest, Developer, secretary and DBA) in a form of Enum.
            ●	We want to provide the Employee Class to represent Employee data in a string Form (override ToString ()), display employee salary in a currency format. [Use String.Format() Function].

         */
    }
}
