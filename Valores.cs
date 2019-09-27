using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Valores
    {
        private double n1; //Declarando la variable N1 como double
        private double n2; //Declarando la variable N2 como double

        public double N1 //Encapsular Valor 1
        {
            get { return n1; }
            set { n1 = value; }
        }

        public double N2 //Encapsular Valor 2
        {
            get { return n2; }
            set { n2 = value; }
        }

    }
}
