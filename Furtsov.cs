using System;

namespace Practice
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(PluxOne(Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine())));
            //Console.WriteLine(Empty(Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine())));
            //Console.WriteLine(Name(Console.ReadLine()));
            Console.WriteLine("{0:0.0}",Herons_formula(Double.Parse(Console.ReadLine()), Double.Parse(Console.ReadLine()), Double.Parse(Console.ReadLine())));
        }

        public static string PluxOne(int x, int y)
        {
            string result = x+"";
            for(int i=0; i < y-1;i++)
            {
                x += 2;
                result +=", " + x;
            }
            return result;
        }

        public static string Empty(int number, int lives)
        {
            int attempts = lives;
            for (int i = 0; i < lives; i++)
            {
                Console.WriteLine("Осталось попыток:"+ attempts);
                int player = Int32.Parse(Console.ReadLine());
                if (player == number)
                    return "win!";
                else
                    Console.WriteLine("wrong!");
                attempts--;
            }
            return "game over!";
        }

        public static string Name(string name)
        {
            
            string[] fio = name.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            name = "";
            for(int i=0; i < fio.Length; i++)
            {
                fio[i] = fio[i].Substring(0, 1).ToUpper() + fio[i].Substring(1);
                name += fio[i] + " ";
            }
            return name;
        }

        public static double Herons_formula(double a, double b, double c)
        {
            double s = (a + b + c) / 2;
            return Math.Sqrt(s*(s-a)*(s-b)*(s-c));
        }
    }
}
