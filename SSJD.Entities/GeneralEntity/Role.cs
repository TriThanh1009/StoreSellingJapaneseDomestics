using SSJD.Entities.EmployeeEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.Entities.GeneralEntity
{
    public class Role
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Employee Employee { get; set; }
        public List<Employee> Employees { get; } 
    }
}
