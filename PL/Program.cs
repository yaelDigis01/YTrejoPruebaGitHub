using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hola esta es mi primer prueba de GitHub");
       
            Console.WriteLine("BIENVENIDO A LA CALCULADORA");
            Console.WriteLine("");
            Console.WriteLine("Ingresa el número (1) para SUMA");
          
            Calculadora calculadora = new Calculadora();


            int Operaciones = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("INGRESA EL PRIMER NÚMERO:");
            calculadora.Numero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("INGRESA EL SEGUNDO NÚMERO:");
            calculadora.Numero2 = Convert.ToDouble(Console.ReadLine());

            double resultado = 0;

            switch (Operaciones)
            {
                case 1:
                    resultado = calculadora.Suma(calculadora.Numero1, calculadora.Numero2);
                    break;
                
                default:
                    Console.WriteLine("OPERACIÓN FALLIDA");
                    return;
            }

            Console.WriteLine("EL RESULTADO ES: " + resultado);
            Console.ReadKey();

        }
    }



 
    public class Calculadora
    {

        public double Numero1 { get; set; }
        public double Numero2 { get; set; }

        public double Suma(double numero1, double numero2)
        {
            return numero1 + numero2;
        }
      
    }
}
