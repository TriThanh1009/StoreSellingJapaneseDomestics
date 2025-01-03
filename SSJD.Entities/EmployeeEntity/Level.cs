using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.Entities.EmployeeEntity
{
    public class Level
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Contract Contract { get; set; } 
        public Employee Employee { get; set; } 
        public List<Employee> Employees { get; } 
    }
}
