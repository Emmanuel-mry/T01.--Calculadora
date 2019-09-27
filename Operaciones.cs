using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Operaciones
    {
        Valores R = new Valores(); //Instanciando Globalmente la clase Valores

        double Res; //Declarando como double la variable Res para los Resultados

        public Double Sumar(Valores R)
        {
            Res = R.N1 + R.N2; //Operacion de Suma
            return Res;  
        }

        public Double Restar(Valores R)
        {
            Res = R.N1 - R.N2; //Operacion de Resta
            return Res;
        }

        public Double Multiplicar(Valores R)
        {
            Res = R.N1 * R.N2; //Operacion de Multiplicacion
            return Res;
        }

        public Double Dividir(Valores R)
        {
            Res = R.N1 / R.N2; //Operacion de Division
            return Res;
        }
    }
}
