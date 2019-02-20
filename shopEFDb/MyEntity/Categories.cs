using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopEFDb
{
  public  class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsLegal { get; set; }

        public ICollection<AbstractProduct> AbstractProducts { get; set; }
    }
}
