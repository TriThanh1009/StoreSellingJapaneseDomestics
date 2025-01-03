using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSJD.Entities.GeneralEntity;

namespace SSJD.Entities.EmployeeEntity
{
    public class Contract
    {
        public int ID { get; set; }
        public int EmployeeID { get; set; }
        public int PositionID { get; set; }
        public int LevelID { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Salary { get; set; }
        public Active Active { get; set; }

        public Employee Employee { get; set; } 
        public Position Position { get; set; }
        public Level Level { get; set; }
    }

}
