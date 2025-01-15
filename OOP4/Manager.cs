using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    internal class Manager:Employee
    {
        public override void printStatus()
        {
            Console.WriteLine("Manager is managing");
        }
    }
}
