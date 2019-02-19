using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopEFDb
{
    public class Adress
    {
        public int Id { get; set; }

        public virtual Country Country { get; set; }

        public virtual  Building Building { get; set; }
        public virtual Producer Producer { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
