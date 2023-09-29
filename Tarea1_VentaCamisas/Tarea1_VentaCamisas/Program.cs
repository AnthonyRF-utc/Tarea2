using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Tarea1_VentaCamisas
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Bienvenido profe a la nueva venta de camisas");
            Console.WriteLine("______________________________________________");
            

            Console.WriteLine("Ingrese el total de camisas que desea llevar");
            int totalCamisas = int.Parse(Console.ReadLine());
            Console.WriteLine("______________________________________________");


            Console.WriteLine("Ingrese el precio por Camisa");
            double precXCamisa = double.Parse(Console.ReadLine());
            Console.WriteLine("______________________________________________");


            double precTotal = CalcularPrecTotal(totalCamisas, precXCamisa);

            Console.WriteLine("El precio total a pagar es: $" + precTotal);
            Console.WriteLine("______________________________________________");

        }

         static double CalcularPrecTotal(int totalCamisas, double precXcamisas)
        {
            double precTotal = 0;

            if (totalCamisas == 1)
            {
                precTotal = totalCamisas * precXcamisas;
            }
            else if (totalCamisas >= 2 && totalCamisas <= 5)
            {
                double desc = totalCamisas * precXcamisas * 0.15;
                precTotal = (totalCamisas * precXcamisas) - desc;
            }
            else if (totalCamisas > 5)
            {
                double desc = totalCamisas * precXcamisas * 0.20;
                precTotal = (totalCamisas * precXcamisas) - desc;
            }
            return precTotal; 
        }
    }
}
