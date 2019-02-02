using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_and_encapsulation
{
    class box
    {
        private int length;
        private int height;
        private int width;
        private int volume;


        //Properties
        public int Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }
        //expression body members
        public int thing {
            get => length;
            set => length = value;
        }

        //Auto implemented property enter prop and double tab
        public int Width { get; set; }

        //Write only
       /* public int Volume {
            set
            {
                Volume = value;
            }
         }
         */

        public box(int length, int height, int width)
        {
            this.length = length;
            this.height = height;
            this.width = width;
        }

        public int Volume
        {
            get
            {
                return height * width * length;
            }
            set
            {
                Volume = value;
            }
        }

        //Read only
      /*  public int Height
        {
            get
            {
                return height;
            }
          /*  set
            {
                if (value < 0) //throw new Exception("Size should be positive");
                    value = -value;
                height = value;
            }
            /*
        }
        /*
        public void Setlength(int length)
        {
            this.length = length;
        }
        */
        public int GetLenght()
        {
            return this.length;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Length is {0}, height is {1}, width is {2}, and volume is {3}",
                length, height, width, volume = width*height*length);
        }
    }
}
