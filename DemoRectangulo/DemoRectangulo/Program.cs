using System;

namespace DemoRectangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular el Área y Perimetro de un Rectangulo\n");
         
            Rectangulo rectangulo = new Rectangulo();

            Console.WriteLine("Ingrese un valor para x1:");
            double valor1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese un valor para y1:");
            double valor2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese un valor para x2:");
            double valor3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese un valor para y2:");
            double valor4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese un valor para x3:");
            double valor5 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese un valor para y3:");
            double valor6 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese un valor para x4:");
            double valor7 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese un valor para y4:");
            double valor8 = Convert.ToDouble(Console.ReadLine());

            rectangulo.x1 = valor1;
            rectangulo.y1 = valor2;
            rectangulo.x2 = valor3;
            rectangulo.y2 = valor4;
            rectangulo.x3 = valor5;
            rectangulo.y3 = valor6;
            rectangulo.x4 = valor7;
            rectangulo.y4 = valor8;

      
            Console.WriteLine("El Área del Rectangulo es:"+rectangulo.CalcularArea(rectangulo.x1, rectangulo.y1, rectangulo.x2, rectangulo.y2, rectangulo.x3, rectangulo.y3, rectangulo.x4, rectangulo.y4)+ "\n");
            Console.WriteLine("El Perimetro del Rectangulo es:"+rectangulo.CalcularPerimetro(rectangulo.x1, rectangulo.y1, rectangulo.x2, rectangulo.y2, rectangulo.x3, rectangulo.y3, rectangulo.x4, rectangulo.y4));
            Console.ReadKey();
        }
    }
}
