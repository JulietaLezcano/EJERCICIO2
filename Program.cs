using System;

 namespace Productoria
 {
     class Program
     {
            static void Main (string[] args)
            {
                Console.Write("Ingrese el primer numero: ");
                int n1= Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese el segundo numero: ");
                int n2= Convert.ToInt32(Console.ReadLine());
                int Producto = 0;
                for (int i=0;  i<n2; i++)
                {
                    
                    Producto += n2;
                }
                Console.WriteLine(Producto);
            }
     }
 }

