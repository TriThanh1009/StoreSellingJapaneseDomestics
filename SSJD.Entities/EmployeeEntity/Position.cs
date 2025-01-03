using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.Entities.EmployeeEntity
{
    public class Position
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Contract Contract { get; set; } 
        public Employee Employee { get; set; } 
        public List<Employee> Employees { get; } 
    }
}
