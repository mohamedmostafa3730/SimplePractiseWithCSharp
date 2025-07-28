using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__OOB_L1
{
    public class Person
    {
        public int ID;
        public string Name;
        public string Email;
        public Gender gender;
        public Person(int id,string name, string email, Gender gender) 
        {
            this.Email = email;
            this.ID = id;
            this.Name = name;
            this.gender = gender;
        }
        int GetID()
        {
            return this.ID;
        }
        string GetName()
        {
            return this.Name;
        }
        string GetEmail()
        {
            return this.Email;
        }
    }
}
