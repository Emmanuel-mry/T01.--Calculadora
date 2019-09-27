using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Principal R = new Principal(); //Instanciando la Clase Principal

            R.CapturarValores(); //Mando llamar el Metodo para Capturar Valores

            R.Menu(); //Mando a llamar el Menu
        }
    }
}
