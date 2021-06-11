using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    static class Field
    {
        public static int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
                Console.SetWindowSize(_width, Field.HEIHT);
                Console.SetBufferSize(_width, Field.HEIHT);
            }
        }


        private static int _width = 40;
        public const int HEIHT = 30;

        public static int GetWigth()
        {
            return _width;
        }

        public static void SetWidth(int value)
        {
            _width = value;
            Console.SetWindowSize(_width, Field.HEIHT);
            Console.SetBufferSize(_width, Field.HEIHT);
        }
    }
}
