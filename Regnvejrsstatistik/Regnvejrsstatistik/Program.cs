using System;
using System.Linq;

namespace Regnvejrsstatistik
{
    class Program
    {
        static void Main(string[] args)
        {
            string error = "";
            double[] regnvejr = new double[7];
            string[] input = new string[7], dage = new string[] { "Mandag", "Tirsdag", "Onsdag", "Torsdag", "Fredag", "Lørdag", "Søndag" };
            do
            {
                try
                {
                    Console.Clear();
                    if (error.Length > 0)
                        Console.WriteLine("Error: "+error);
                    Console.Write("Indtast regnvejrs statestikkerne fra mandag til søndag: ");
                    input = Console.ReadLine().Split(' ');
                    for (int i = 0; i < input.Length; i++)
                        regnvejr[i] = Convert.ToDouble(input[i]);
                    Console.WriteLine("Gennemsnit regn i mm: " + CalcAverage(regnvejr).ToString().Remove(4));
                    Console.WriteLine("Højeste målte regn i mm: " + regnvejr.Max());
                    Console.WriteLine("Laveste målte regn i mm: " + regnvejr.Min());
                    for (int i = 0; i < dage.Length; i++)
                        Console.WriteLine(dage[i] + " - " + regnvejr[i].ToString());

                    Console.WriteLine("Tryk på en knap for at indtaste nye regnvejrs statestikker");
                    Console.ReadKey();
                    error = "";
                }
                catch (Exception e)
                {
                    Console.WriteLine("Der skete en fejl i programmet. ");
                    error = e.Message;
                }
            } while (true);

        }
        static double CalcAverage(double[] gen) 
        {
            double gennemsnit = 0;
            foreach (double equal in gen)
                gennemsnit += equal;
            return gennemsnit / gen.Length;
        }
    }
}
