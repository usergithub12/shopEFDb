using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopEFDb
{
  public  class Order
    {
        public int Id { get; set; }
        public virtual User Users { get; set; }
        public virtual ICollection<RealProduct> RealProducts { get; set; }
        public virtual Adress DeliveryAdress { get; set; }
        public int Quantity { get; set; }
    }
}
