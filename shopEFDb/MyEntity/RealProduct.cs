using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopEFDb
{
   public class RealProduct
    {
        public int Id { get; set; }

        public DateTime ProductionDate { get; set; }

        public DateTime ExpiresDate { get; set; }
        public int Quantity { get; set; }
     
        public virtual AbstractProduct AbstractProducts { get; set; }
        public virtual ICollection<Producer> Producers { get; set; }
    }
}
