using System;
using System.Collections.Generic;
using System.Text;

namespace Dia1.Example2
{
    class Divisao
    {
        private int num1;
        private int num2;

        public int Dividir()
        {
            return num1 / num2;
        }

        public int Num1 {
            get
            {
                return num1;
            }
            set
            {
                num1 = value;
            }
        }

        public int Num2
        {
            get
            {
                return num2;
            }
            set
            {
                if (value == 0)
                {
                    num2 = 1;
                }
                else
                {
                    num2 = value;
                }
            }
        }
    }
}
