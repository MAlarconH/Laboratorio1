using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1
{
    internal class Program
    {
        // Ejercicio1 

        //Funcion para calcular la suma de 2 numeros enteros

        static int Suma(int a, int b)
        {
            return a + b;
        }

        static int Resta(int a, int b)
        {
            return a - b;
        }

        static int Producto(int a, int b)
        {
            return a * b;
        }

        static int Cociente(int a, int b)
        {
            return a / b;
        }

        static int Conversion_a_celcius(int a)
        {
      
            return 5 * (a - 32)/9;
        }

        static float Conversion_a_farenheit(float a)
        {
            return 9 * a / 5 + 32;
        }

        //Procedimiento que imprime la raíz cuadrada de los 10 primeros números
        static void Raiz()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("La raiz cuadrada de {0} es: {1}", i, Math.Sqrt(i));
            }
        }

        static void Nprimos()
        {
            int num = 1;
            int i;
            int cont = 0;

            while (num <= 10)
            {
                for (i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        cont++;
                    }
                }

                if (cont == 2)
                {
                    Console.WriteLine(num);
                }

                cont = 0;
                num++;
            }
        }



        static void Main(string[] args)
        {
            Console.Title = "Procedimientos y funciones";
            string opcion;
            do 
            {
                Console.Clear();
                Console.WriteLine("[1] Suma de dos números");
                Console.WriteLine("[2] Imprimir la raiz cuadrada de los 10 primeros numeros enteros");
                Console.WriteLine("[3] Resta de dos numeros");
                Console.WriteLine("[4] Multiplicacion de dos numeros");
                Console.WriteLine("[5] Division de dos numeros");
                Console.WriteLine("[6] Imprimir los 10 primeros numeros primos");
                Console.WriteLine("[7] Convertir de Farenheit a Celcius");
                Console.WriteLine("[8] Convertir de Celcius a Farenheit");
                Console.WriteLine("[0] Salir");
                Console.WriteLine("Ingrese una opcion y presione ENTER");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    
                    case "1":
                        Console.WriteLine("Ingrese el primer número");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La suma de {0} y {1} es {2}", a, b, Suma(a, b));
                        Console.ReadKey();
                        break;

                    case "2":
                        Console.WriteLine("Calculando...");
                        Raiz();
                        Console.ReadKey();
                        break;

                    case "3":
                        Console.WriteLine("Ingrese el primer número");
                        int x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int y = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La resta de {0} y {1} es {2}", x, y, Resta(x, y));
                        Console.ReadKey();
                        break;

                    case "4":
                        Console.WriteLine("Ingrese el primer número");
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int d = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("El producto de {0} y {1} es {2}", c, d, Producto(c, d));
                        Console.ReadKey();
                        break;

                    case "5":
                        Console.WriteLine("Ingrese el primer número");
                        int e = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int f = Convert.ToInt32(Console.ReadLine());
                        if (f != 0)
                        {
                            Console.WriteLine("La division de {0} y {1} es {2}", e, f, Cociente(e, f));
                        }
                        else
                        {
                            Console.WriteLine("El denominador no puede ser 0");
                        }
                        
                        Console.ReadKey();
                        break;

                    case "6":
                        Console.WriteLine("Mostrando los 10 primeros numeros primos...");
                        Nprimos();
                        Console.ReadKey();
                        break;

                    case "7":
                        Console.WriteLine("Ingrese el grado en Farenheit");
                        int m = Convert.ToInt32(Console.ReadLine()); 
                        Console.WriteLine("La conversion de {0} Celcius a Farenheit es: {1}", m, Conversion_a_celcius(m));
                        Console.ReadKey();
                        break;

                    case "8":
                        Console.WriteLine("Ingrese el grado en Celcius");
                        float n = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La conversion de {0} Farenheit a Celcius es: {1}", n, Conversion_a_farenheit(n));
                        Console.ReadKey();
                        break;

                }
            } while (!opcion.Equals("0"));
        }
    }
}
