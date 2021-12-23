/*
 * Created by SharpDevelop.
 * User: alumno
 * Date: 10/12/2021
 * Time: 06:07 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace calcu
{
	class Program
	{
		public static void Main(string[] args)
		{
            double cantidad1;
            double cantidad2;
            string operacion;
            double resultado;

            Console.WriteLine("Digite el nombre de la operación a realizar");
            Console.WriteLine("SUMA");
            Console.WriteLine("RESTA");
            Console.WriteLine("MULTIPLICACIÓN");
            Console.WriteLine("DIVISIÓN");

            operacion = Console.ReadLine();

            Console.WriteLine("Digite la primer cantidad");
            cantidad1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite la segunda cantidad");
            cantidad2 = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            if(operacion == "SUMA")
            {
                resultado = cantidad1 + cantidad2;
                Console.WriteLine("El resultado de la suma es:" + resultado);
                Console.ReadLine();
            }
            if(operacion == "RESTA")
            {
                resultado = cantidad1 - cantidad2;
                Console.WriteLine("El resultado de la resta es:" + resultado);
                Console.ReadLine();
            }
            if(operacion == "MULTIPLICACIÓN")
            {
                resultado = cantidad1 * cantidad2;
                Console.WriteLine("El resultado de la multiplicación es:" + resultado);
                Console.ReadLine();
            }
            if(operacion == "DIVISIÓN")
            {
                resultado = cantidad1 / cantidad2;
                Console.WriteLine("El resultado de la división es:" + resultado);
                Console.ReadLine();
            }
		}
	}
}