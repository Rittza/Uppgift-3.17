using System;
namespace Uppgift_3_17
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Vilket tal väljer du?");
            float tal1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Välj ett till tal");
            float tal2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Välj ett räknesätt " + "addition, subtraktion, multiplikation, division");
            string räknesätt = Console.ReadLine();

            switch (räknesätt)
            {
                case "addition":
                float svar = tal1 + tal2;
                Console.WriteLine("Summan blir " + svar);
                int.Parse(Console.ReadLine());
                break;

                case "subtraktion":
                float svar2 = tal1 - tal2;
                Console.WriteLine("Differansen blir " + svar2);
                break;

                case "multiplikation":
                float svar3 = tal1 * tal2;
                Console.WriteLine("Produkten blir " + svar3);
                break;

                case "division":
                float svar4 = tal1 / tal2;
                Console.Write("Kvoten blir " + svar4);
                break;

            }
                         
        }
    }
}
