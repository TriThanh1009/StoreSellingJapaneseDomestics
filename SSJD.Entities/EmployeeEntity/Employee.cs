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
        public string AccountID { get; set; }
        public string RoleID { get; set; }

        public Contract Contract { get; set; } = null!;
        public List<Position> Positions { get; set; }
        public List<Level> Levels { get; set; }
        public List<Account> Accounts { get; set; }
    }
}
