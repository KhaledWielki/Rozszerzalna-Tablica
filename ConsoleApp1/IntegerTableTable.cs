using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{   
    class IntegerTable
    {
        private int[] integerTable = new int[10];

        public int this[int indeks]
        {
            get
            {
                return this.integerTable[indeks];
            }
            set
            {
                this.integerTable[indeks] = value;
            }
        }
    } 
}
