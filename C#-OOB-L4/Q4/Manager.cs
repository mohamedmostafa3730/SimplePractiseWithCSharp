using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__OOB_L4.Q4
{
    internal class Manager : Employee
    {// b) Create a derived class named Manager that overrides the Work method to print "Manager is managing"
        public override void Work()
        {
            Console.WriteLine("Manager is managing");
        }
    }
}
