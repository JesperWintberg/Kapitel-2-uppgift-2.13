using System;
namespace uppgift_2_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in lön 1");
            string lön1 = Console.ReadLine();
            Console.WriteLine("Matan in lön 2");
            string lön2 = Console.ReadLine();
            Console.WriteLine("Mata in lön 3");
            string lön3 = Console.ReadLine();

            float lön1_tal = float.Parse(lön1);
            float lön2_tal = float.Parse(lön2);
            float lön3_tal = float.Parse(lön3);

            float Samman = lön1_tal + lön2_tal + lön3_tal; 

            Console.WriteLine("Sammanlagda lönenen är" + Samman);   

        }
    }
}