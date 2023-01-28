using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using Internal;

namespace ConsoleApplication15
{
    class Calculadora
    {
        static void Main(string[] args)
        {
            Console.Title = "Diego García Calderón Calculadora 0.0";
            string resp = "";
            do
            {
                double num1 = 0;
                double num2 = 0;
                double R = 0;
                int cantidad = 0;
                bool res;

                Console.WriteLine("Digite el simbolo para realizar la operación:");
                Console.WriteLine("1.-  + para Sumar");
                Console.WriteLine("2.-  - para Restar");
                Console.WriteLine("3.-  * para Multiplicar");
                Console.WriteLine("4.-  / para Dividir");
                Console.WriteLine("5.-  ^ para una Potencia");
                Console.WriteLine("6.-  √ para una Raíz");
                Console.WriteLine("7.-  sin para la función Seno");
                Console.WriteLine("8.-  cos para la función Coseno");
                Console.WriteLine("9.-  tan para la función Tangente");
                Console.WriteLine("10.- ln para el Logaritmo Natural");
                Console.WriteLine("11.- log10 para el Logaritmo Base 10");
                Console.WriteLine("12.- abs para calcular el Valor Absoluto");
                Console.WriteLine("13.- rad para calcular Radianes");
                Console.WriteLine("14.- e para calcular e Elevado A Una Potencia");
                Console.WriteLine("15.- truncate para calcular la Parte Entera De Un Número");
                Console.WriteLine("16.- round para Redondear Un Número");
                Console.WriteLine("17.- min para calcular el Número Menor");
                Console.WriteLine("18.- max para calcular el Número Mayor");
                Console.WriteLine("19.- eqls para saber si dos números son iguales");
                Console.WriteLine("20.- floor para redondear a un Número Al Múltiplo Más Cercano");
                Console.Write("Eliga Una Opcion: ");
                resp = Console.ReadLine();
                string eleccion = Convert.ToString(resp);
                string avanzada = Convert.ToString(resp);
                Console.WriteLine("Digite un número(s)");
                Console.Write("Número: ");
                num1 = double.Parse(Console.ReadLine());
                double RAD = num1 * Math.PI / 180; //Convertir un numero (grado) a radianes.
                switch (eleccion)
                {
                    case "+":
                        Console.Write("Número: ");
                        num2 = double.Parse(Console.ReadLine());

                        Console.WriteLine("El resultado de la suma es:");
                        R = num1 + num2;
                        Console.WriteLine("{0} + {1} = {2}", num1, num2, R);
                        break;

                    case "-":
                        Console.Write("Número: ");
                        num2 = double.Parse(Console.ReadLine());

                        Console.WriteLine("El resultado de la resta es:");
                        R = num1 - num2;
                        Console.WriteLine("{0} - {1} = {2}", num1, num2, R);
                        break;

                    case "*":
                        Console.Write("Número: ");
                        num2 = double.Parse(Console.ReadLine());

                        Console.WriteLine("El resultado de la multiplicacion es:");
                        R = num1* num2;
                        Console.WriteLine("{0} * {1} = {2}", num1, num2, R);
                        break;

                    case "/":
                        Console.Write("Divisor: ");
                        num2 = double.Parse(Console.ReadLine());

                        Console.WriteLine("El resultado de la division es:");
                        R = num1 / num2;
                        Console.WriteLine("{0} / {1} = {2}", num1, num2, R);
                        break;

                    case "^":
                        Console.Write("Exponente: ");
                        num2 = double.Parse(Console.ReadLine());

                        Console.WriteLine("El resultado de la potencia es:");
                        R = Math.Pow(num1, num2);
                        Console.WriteLine("{0} ^ {1} = {2}", num1, num2, R);
                        break;

                    case "√":
                        Console.Write("Exponente: ");
                        num2 = double.Parse(Console.ReadLine());

                        Console.WriteLine("El resultado de la raíz es:");
                        R = Math.Pow(num1, 1.0/num2);
                        Console.WriteLine("{1} √ {0} = {2}", num1, num2, R);
                        break;
                    case "min":
                        Console.Write("Número: ");
                        num2 = double.Parse(Console.ReadLine());

                        Console.WriteLine("El mínimo es:");
                        R = Math.Min(num1, num2);
                        Console.WriteLine("{0}, {1} = el Menor es: {2}", num1, num2, R);
                        break;
                    case "max":
                        Console.Write("Número: ");
                        num2 = double.Parse(Console.ReadLine());

                        Console.Write("Número: ");
                        Console.WriteLine("El máximo es:");
                        R = Math.Max(num1, num2);
                        Console.WriteLine("{0}, {1} = el Mayor es: {2}", num1, num2, R);
                        break;
                    case "eqls":
                        Console.Write("Número: ");
                        num2 = double.Parse(Console.ReadLine());

                        Console.Write("Número: ");
                        Console.WriteLine("Los números son iguales:");
                        res = Math.Equals(num1, num2);
                        if (res == true)
                        {
                            Console.WriteLine("Sí");
                        }
                        else
                        {
                            Console.WriteLine("No");
                        }
                        break;
                }

                switch (avanzada)
                {
                    case "sin":
                        Console.WriteLine("El resultado del seno es:");
                        R = Math.Sin(RAD);
                        Console.WriteLine("SIN({0}) = {1}", num1, R);
                        break;

                    case "cos":
                        Console.WriteLine("El resultado del coseno es:");
                        R = Math.Cos(RAD);
                        Console.WriteLine("{COS({0}) = {1}", num1, R);
                        break;

                    case "tan":
                        Console.WriteLine("El resultado de la tangente es:");
                        R = Math.Tan(RAD);
                        Console.WriteLine("TAN({0}) = {1}", num1, R);
                        break;

                    case "ln":
                        Console.WriteLine("El resultado del logaraitmo natural es:");
                        R = Math.Log(num1);
                        Console.WriteLine("Ln({0}) = {1}", num1, R);
                        break;

                    case "log10":
                        Console.WriteLine("El resultado del logaritmo natural es:");
                        R = Math.Log10(num1);
                        Console.WriteLine("Log10 ({0}) = {1}", num1, R);
                        break;

                    case "abs":
                        Console.WriteLine("El resultado del valor absoluto es:");
                        R = Math.Abs(num1);
                        Console.WriteLine("|{0}| = {1}", num1, R);
                        break;
                    case "rad":
                        Console.WriteLine("El resultado de radianes es:");
                        R = RAD;
                        Console.WriteLine("RAD {0} = {1}", num1, R);
                        break;
                    case "e":
                        Console.WriteLine("El resultado del e^x es:");
                        R = Math.Exp(num1);
                        Console.WriteLine("e{0} = {1}", num1, R);
                        break;
                    case "truncate":
                        Console.WriteLine("El resultado del entero es::");
                        R = Math.Truncate(num1);
                        Console.WriteLine("{0} = {1}", num1, R);
                        break;
                    case "round":
                        Console.WriteLine("El resultado del redondeo es:");
                        R = Math.Round(num1);
                        Console.WriteLine("{0} = {1}", num1, R);
                        break;
                    case "floor":
                                Console.WriteLine("El resultado del redondeo es:");
                        R = Math.Floor(num1);
                        Console.WriteLine("{0} = {1}", num1, R);
                        break;
                }
                Console.Write("n¿Desea Continuar? s/n: "); //s para realizarlo de nuevo y n para salir.
                resp = Console.ReadLine();
            }
            while (resp == "s" || resp == "s") ;
        }
    }
}
