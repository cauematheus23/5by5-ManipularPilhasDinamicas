using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5by5_ManipularPilhasDinamicas
{
    internal class Integer
    {
        int number;
        Integer previous;

        public Integer(int n)
        {
            this.number = n;
            this.previous = null; 
        }

        public override string? ToString()
        {
            return "" + number;
        }

        public void setPrevious(Integer n) { 
            this.previous = n;
        }

        public Integer getPrevious()
        {
            return this.previous;
        }
        public int getNumber()
        {
            return this.number;
        }
    }

}
