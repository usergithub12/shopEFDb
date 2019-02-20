using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopEFDb
{
    class Program
    {
        static void Main(string[] args)
        {

            using (Shop db = new Shop())
            {
                // создаем два объекта User
                User user1 = new User { Name = "Tom", Age = 33 };
                User user2 = new User { Name = "Sam", Age = 26 };

            }
    }
}
