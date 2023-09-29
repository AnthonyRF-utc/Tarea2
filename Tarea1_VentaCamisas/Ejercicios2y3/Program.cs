using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios2y3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("****************");
                Console.WriteLine("1-Ejercicio2");
                Console.WriteLine("2-Ejercicio 3");
                Console.WriteLine("3-Salir");
                Console.WriteLine("****************");
                Console.WriteLine("Digite su opcion");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: Ejercicio2(); break;
                    case 2: Ejercicio3(); break;
                    case 3: Console.WriteLine("Gracias");
                          break;
                    default: 
                        Console.Clear();
                        Console.WriteLine("La opcion digitada es incorrecta");
                        Console.ReadLine();
                        break;
                }
            } while (opcion != 3);
        }
        static void Ejercicio2()
        {
            Console.WriteLine("ejercicio 2");
            Console.Clear();

            Console.WriteLine("Ingrese el total de estudiantes: ");
            int numEstudiantes = int.Parse(Console.ReadLine());

            for (int i = 0; i < numEstudiantes; i++)
            {
                Console.WriteLine("Ingrese el Carnet del estudiante: ");
                string carnet = Console.ReadLine();

                Console.WriteLine("Ingrese el nombre del estudiante: ");
                string nombre = Console.ReadLine();

                Console.WriteLine("Ingrese la nota del quiz 1: ");
                double quiz1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la nota del quiz 2: ");
                double quiz2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la nota del quiz 3: ");
                double quiz3 = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la nota de la tarea 1: ");
                double tarea1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la nota de la tarea 2: ");
                double tarea2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la nota de la tarea 3: ");
                double tarea3 = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la nota del primer examen: ");
                double pExamen = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la nota del segundo examen: ");
                double sExamen = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la nota del tercer examen: ");
                double tExamen = double.Parse(Console.ReadLine());

                double porcentajeQuices = (quiz1 + quiz2 + quiz3) / 3 * 0.25;
                double porcentajeTareas = (tarea1 + tarea2 + tarea3) / 3 * 0.30;
                double porcentajeExamenes = (pExamen + sExamen + tExamen) / 3 * 0.45;

                double promedioFinal = (porcentajeQuices + porcentajeTareas + porcentajeExamenes);

                string condicion;

                if (promedioFinal >= 70)
                {
                    condicion = "Aprobado";
                }

                else if (promedioFinal >= 50 && promedioFinal < 70)
                {
                    condicion = "Aplazado";
                }

                else 
                {
                    condicion = "Reprobado";
                }

                Console.WriteLine($"Carnet: {carnet}");
                Console.WriteLine($"Nombre: {nombre}");
                Console.WriteLine($"Porcentaje Quices: {porcentajeQuices}");
                Console.WriteLine($"Porcentaje Tareas: {porcentajeTareas}");
                Console.WriteLine($"Porcentaje Examenes: {porcentajeExamenes}");
                Console.WriteLine($"Promedio final: {promedioFinal}");
                Console.WriteLine($"Condicion: {condicion}");
                Console.WriteLine();
                
                Console.ReadLine();

                Console.Clear();

            }
        }

        static void Ejercicio3()
        {
            Console.WriteLine("ejercicio 3");

            Console.WriteLine("Ingrese el total de articulos que desea llevar");
            int cArticulos = int.Parse( Console.ReadLine() );

            double PrecXArticulo;

            if ( cArticulos <= 10 )
            {
                PrecXArticulo = 20.0;
            }

            else
            {
                PrecXArticulo = 15.0;
            }

            double total = cArticulos * PrecXArticulo;

            Console.WriteLine($"Cantidad de articulos: {cArticulos}");
            Console.WriteLine($"Precio por articulo: {PrecXArticulo} ");
            Console.WriteLine($"Total: {total}");

            Console.ReadLine();

            Console.Clear();
        }

    }
}
