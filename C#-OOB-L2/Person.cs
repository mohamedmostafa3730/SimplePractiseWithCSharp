using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__OOB_L2
{
    public struct Person
    {
        public String name;
        public short age;
        private static int count = 0; // Static variable to keep track of the number of Person instances
        private static Person[] people = new Person[3];
        // Constructor to initialize the Person struct
        public Person(String name, short age)
        {
            this.name = name;
            this.age = age;
            count++;
        }

        public void AddToPeopleArray(Person person)
        {   
                people[count] = person; // Add the person to the array
        }

        // Method to display the person's details
        public override String ToString()
        {
            return $"Person: Name = {name}, Age = {age}";
        }

        public static int GetCountOfPeople()
        {
            return count;
        }

        public static Person GetOldestPerson()
        {
            if (people.Length == 0)
            {
                Console.WriteLine("No persons available.");
            }
            Person oldestPerson = new Person() ;
            int oldestAge = 0;
            foreach (var item in people)
            {
                if (item.age > oldestAge)
                {
                    oldestAge = item.age;
                    oldestPerson = item;
                }
            }
            return oldestPerson;
        }
    }
}
