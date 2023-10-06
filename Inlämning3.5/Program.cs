using System;
namespace Inlämning_3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv två tal, på detta sätt: tal1 tal2, tänk på att tal1 borde vara det största talet");
            string svar = Console.ReadLine();
            int mellanslag = svar.IndexOf(" ");
            double tal1 = double.Parse(svar[..mellanslag]);
            double tal2 = double.Parse(svar[(mellanslag+1)..]);
            Console.WriteLine(tal1+" och " + tal2 +" bra val!");
            Console.WriteLine("Nu välj vilket räknesätt du ska få ut ett resultat på");
            Console.WriteLine("1 för Adiition");
            Console.WriteLine("2 för Subtraktion");
            Console.WriteLine("3 för Multiplikation");
            Console.WriteLine("4 för Division");
            string räknesätt = Console.ReadLine();
            switch (räknesätt)
            {
                case "1":
                    double add = tal1 + tal2;
                    Console.WriteLine("Svaret blir " + add);
                    break;
                case "2":
                    double sub = tal1 - tal2;
                    Console.WriteLine("Svaret blir "+sub);
                    break;
                case "3":
                    double pro = tal1 * tal2;
                    Console.WriteLine("Svaret blir "+pro);
                    break;
                case "4":
                    double kvot = tal1 / tal2;
                    Console.WriteLine("Svaret blir "+kvot);
                    break;
                default:
                    Console.WriteLine("Du skrev något fel");
                    break;

            }
        }
    }
}