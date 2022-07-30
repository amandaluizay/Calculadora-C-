using System;

namespace ExercicioC_
{
    class Program
    {
        static void Main(string[] args)
        {
           Menu();
        }

        static void Menu(){
           Console.Clear();
           Console.WriteLine("O que deseja fazer?");
           Console.WriteLine("1 - Soma");
           Console.WriteLine("2 - Subtração");
           Console.WriteLine("3 - Multiplicação");
           Console.WriteLine("4 - Divisão");
           Console.WriteLine("5 - Sair");
           Console.WriteLine("-----------");
           short res = short.Parse(Console.ReadLine());
           
           switch (res)
           {

            case 1: Soma();break;
            case 2: Subtração();break;
            case 3: Multiplicação();break;
            case 4: Divisão();break;
            case 5: System.Environment.Exit(0);break;

            default: Menu();break;
           }

        }

        static void Soma(){
            
              Console.Clear();
            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine("");
            float resultado = v1+v2;
            Console.WriteLine("O resultado da soma é " + resultado);

        }

        static void Subtração(){

            Console.Clear();
            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("O resultado da subtração é " + (v1-v2));
        }

        static void Multiplicação(){
              Console.Clear();
            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine("");
            float resultado = v1+v2;
            Console.WriteLine("O resultado da Multiplicação é " + (v1*v2) );
        }

        static void Divisão(){
              Console.Clear();
            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine("");
            float resultado = v1+v2;
            Console.WriteLine("O resultado da Divisão é " + (v1/v2));
        }
    }
}
