using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session3.Models
{
    internal class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public double Salary { get; set; }
        public DateTime createdAt { get; set; }
    }
}
