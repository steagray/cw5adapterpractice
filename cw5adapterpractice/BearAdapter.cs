using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw5adapterpractice
{
    class BearAdapter : ToyBear
    {
        public Bear adaptedBear;

        public BearAdapter(Bear conBear)
        {
            adaptedBear = conBear;
        }
        public void hug()
        {
            adaptedBear.maul();
        }
    }
}
