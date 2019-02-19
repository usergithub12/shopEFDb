using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopEFDb
{
   public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }

        public string ShortName { get; set; }

        public virtual ICollection<Adress> Adresses { get; set; }
    }
}
