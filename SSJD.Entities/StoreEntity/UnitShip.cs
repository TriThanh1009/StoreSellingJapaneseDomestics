using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.Entities.StoreEntity
{
    public class UnitShip
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public List<Order> Orders { get; } 
    }
}
