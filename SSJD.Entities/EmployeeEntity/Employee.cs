using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSJD.Entities.GeneralEnity;
using SSJD.Entities.GeneralEntity;

namespace SSJD.Entities.EmployeeEntity
{
    public class Employee
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public Sex Sex { get; set; } = Sex.Male;
        public int PhoneNumber { get; set; }
        public string Address { get; set; }
        public string IdentityCard { get; set; }
        public string Email { get; set; }
        public int PositionID { get; set; }
        public int LevelID { get; set; }
        public int AccountID { get; set; }
        public int RoleID { get; set; }

        public List<Contract> Contract { get; }
        public Position Position { get; set; } 
        public Level Level { get; set; }
        public Account Account { get; set; } 

        public Role Role { get; set; } 
    }
}
