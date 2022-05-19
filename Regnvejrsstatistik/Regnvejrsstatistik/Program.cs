using System;
using System.Linq;

namespace Regnvejrsstatistik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Indtast regnvejrs statestikkerne fra mandag til søndag: ");
            double[] regnvejr = new double[7];
            try
            {
                string input = Console.ReadLine().Split(' ');
                for (int i = 0; i < 7; i++)
                    regnvejr[i] = Convert.ToDouble(input[i]);
                Console.WriteLine("Gennemsnit regn i mm: " + CalcAverage(regnvejr));
                Console.WriteLine("Højeste målte regn i mm: " + regnvejr.Max());
                Console.WriteLine("Laveste målte regn i mm: " + regnvejr.Min());

                string[,] menu = new string[7, 2] { {"Mandag", null }, { "Tirsdag", null }, { "Onsdag", null }, { "Torsdag", null }, { "Fredag", null }, { "Lørdag", null }, { "Søndag", null } };
                for (int i = 0; i < regnvejr.Length; i++)
                    menu[i, 1] = regnvejr[i].ToString();
                for (int i = 0; i < regnvejr.Length; i++)
                    Console.WriteLine(menu[i, 0] + " - " + menu[i, 1]);


            }
            catch (Exception)
            {
                Console.WriteLine("Der skete en fejl i programmet. ");
                throw;
            }
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
