using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main()
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Você deseja rodar minutos ou segundos?");
            Console.Write("S = Segundo\nM = Minuto\n0 = Sair\n-------------\n");

            String selection = Console.ReadLine().ToLower();

            switch (selection)
            {
                case "s": Second(); break;
                case "m": Minute(); break;
                case "exit": System.Environment.Exit(0); break;
            }
        }
        static void Second()
        {
            int currentTime = 0;

            Console.WriteLine("Quanto tempo você deseja?");
            int time = int.Parse(Console.ReadLine());

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado!");
            Thread.Sleep(1500);

            Menu();
        }

        static void Minute()
        {
            int currentTime = 0;

            Console.WriteLine("Quanto tempo você deseja?");
            int time = int.Parse(Console.ReadLine());

            while (currentTime != time * 60)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime); //-depois de 60 verificar que chegou em 1m
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado!");
            Thread.Sleep(1500);

            Menu();
        }
    }
}