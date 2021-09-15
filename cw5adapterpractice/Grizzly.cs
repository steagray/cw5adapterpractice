using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw5adapterpractice
{
    class Grizzly : Bear
    {

        public Grizzly()
        {

        }
        public void maul()
        {
            Console.WriteLine("Grizzly Maul");
        }

        public void hibernate()
        {
            Console.WriteLine("Time to Hibernate. Zzz");
        }
    }
}
