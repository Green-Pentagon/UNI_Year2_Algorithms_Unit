using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_2_Stakcs___Queues
{
    partial class Employee : Person
    {
        private string specialism;
        private int salary; //in Thousands K
        public Employee(string name, string specialism, int salary) : base(name)
        {
            this.specialism = specialism;
            this.salary = salary;
        }
    }
}
