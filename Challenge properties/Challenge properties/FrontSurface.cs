using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_properties
{
    class FrontSurface
    {
        public int height = 5;
        private int length = 5;
        public int frontsurface
         {
         get
            {
                return length* height;
            }

        }
    }
}
