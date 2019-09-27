using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Principal
    {
        Valores R = new Valores(); //Instanciando Globalmente la clase Valores

        public void CapturarValores() //Metodo para Capturar los Valores
        {
            Console.WriteLine("Ingrese Primer Valor:");
            R.N1 = Convert.ToDouble(Console.ReadLine()); //Asignarle Valor a N1


            Console.WriteLine(" ");

            Console.WriteLine("Ingrese Segundo Valor:");
            R.N2 = Convert.ToDouble(Console.ReadLine()); //Asignarle Valor a N2

            Console.Clear();
        }

        public void Menu() //Metodo para el Menu
        {
            double Res;

            Operaciones A = new Operaciones(); //Instanciando la clase Operaciones

            Console.WriteLine("(1) Sumar");
            Console.WriteLine("(2) Restar");
            Console.WriteLine("(3) Multiplicar");
            Console.WriteLine("(4) Dividir");
            Console.WriteLine(" ");
            Console.WriteLine("(5) Salir...");

            int V;

            V = Convert.ToInt32(Console.ReadLine());

            switch (V) //Switch para la seleccion de opciones en el Menu
            {
                case 1: //Sumar
                    Console.Clear();
                    Res = A.Sumar(R);

                    Console.WriteLine("Resultado:");
                    Console.WriteLine(" ");
                    Console.WriteLine(Res); //Imprimir Resultado

                    Console.WriteLine(" ");
                    Console.WriteLine("(1) Capturar otros Valores");
                    Console.WriteLine("(2) Salir del Programa");

                    int C;

                    C = Convert.ToInt32(Console.ReadLine());

                    switch (C) //Seleccion en Switch por si quiere ingresar otros valores o salir del Programa
                    {
                        case 1:

                            Console.Clear();

                            CapturarValores(); //Mandar llamar de nuevo al metodo para Capturar Valores
                            Menu(); //Mandar llamar de nuevo al Menu Principal
                            break;

                        case 2:
                            System.Environment.Exit(-1); //Codigo para salir del Programa
                            break;
                    }
                    break;

                case 2: //Restar
                    Console.Clear();
                    Res = A.Restar(R);

                    Console.WriteLine("Resultado:");
                    Console.WriteLine(" ");
                    Console.WriteLine(Res); //Imprimir Resultado
                    Console.ReadKey();

                    Console.WriteLine(" ");
                    Console.WriteLine("(1) Capturar otros Valores");
                    Console.WriteLine("(2) Salir del Programa");

                    int D;

                    D = Convert.ToInt32(Console.ReadLine());

                    switch (D)
                    {
                        case 1:

                            Console.Clear();

                            CapturarValores();
                            Menu();
                            break;

                        case 2:
                            System.Environment.Exit(-1);
                            break;
                    }
                    break;

                case 3: //Multiplicar
                    Console.Clear();
                    Res = A.Multiplicar(R);

                    Console.WriteLine("Resultado:");
                    Console.WriteLine(" ");
                    Console.WriteLine(Res); //Imprimir Resultado
                    Console.ReadKey();

                    Console.WriteLine(" ");
                    Console.WriteLine("(1) Capturar otros Valores");
                    Console.WriteLine("(2) Salir del Programa");

                    int E;

                    E = Convert.ToInt32(Console.ReadLine());

                    switch (E)
                    {
                        case 1:

                            Console.Clear();

                            CapturarValores();
                            Menu();
                            break;

                        case 2:
                            System.Environment.Exit(-1);
                            break;
                    }
                    break;

                case 4: //Dividir
                    Console.Clear();
                    Res = A.Dividir(R);

                    Console.WriteLine("Resultado:");
                    Console.WriteLine(" ");
                    Console.WriteLine(Res); //Imprimir Resultado
                    Console.ReadKey();

                    Console.WriteLine(" ");
                    Console.WriteLine("(1) Capturar otros Valores");
                    Console.WriteLine("(2) Salir del Programa");

                    int F;

                    F = Convert.ToInt32(Console.ReadLine());

                    switch (F)
                    {
                        case 1:

                            Console.Clear();

                            CapturarValores();
                            Menu();
                            break;

                        case 2:
                            System.Environment.Exit(-1);
                            break;
                    }
                    break;

                case 5: //Salir
                    System.Environment.Exit(-1); //Codigo para Salir del Programa
                    break;
            }
        }
    }
}
