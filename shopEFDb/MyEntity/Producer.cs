using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopEFDb
{
    public class Producer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Adress Adress { get; set; }
    }
}
