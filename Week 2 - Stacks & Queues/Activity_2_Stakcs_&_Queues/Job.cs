using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_2_Stakcs___Queues
{
    partial class Job
    {
        string id, description;
        Employee person;

        public Job(Employee person, string id, string desc)
        {
            this.person = person;
            this.id = id;
            this.description = desc;
        }

        public string ToString()
        {
            return id + ":" + description + ", employee:" + person.Name;
        }
    }

}
