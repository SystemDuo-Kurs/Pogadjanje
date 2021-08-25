using System;
using System.Collections.Generic;

namespace Pogadjanje
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> reci = new();
            reci.Add("Tes"); //0
            reci.Add("Bla"); //1
            reci.Add("Trec"); //2
            reci.Add("Qwe"); //3
            reci.Add("Asd"); //4

            Random nasumicno = new();
            string rec = "Asdfg"; //reci[nasumicno.Next(reci.Count)];

            bool[] pogodjenje = new bool[rec.Length];
            // pogodjenje[0] = true;
            //pogodjenje[1] = true;
            //pogodjenje[2] = true;
            //pogodjenje[3] = true;
            while (true)
            {

                for (int indeks = 0; indeks < rec.Length; indeks++)
                {
                    if (pogodjenje[indeks])
                    {
                        Console.Write($"{rec[indeks]} ");
                    }
                    else
                    {
                        Console.Write("_ ");
                    }
                }
                Console.WriteLine("\nUnesite slovo ili rec: ");

                string slovo = Console.ReadLine();
                if (slovo.Length > 1)
                {
                    if (slovo.ToLower() == rec.ToLower())
                    {
                        Console.WriteLine("Pogodjeno!");
                        break;
                    }
                }
                if (rec.ToLower().Contains(slovo.ToLower()))
                {
                    pogodjenje[rec.ToLower().IndexOf(slovo.ToLower())] = true;
                    Console.WriteLine("Ima!");
                }
                else
                {
                    Console.WriteLine("Nema :/");
                }
                bool zavrseno = true;
                foreach (bool sl in pogodjenje)
                {
                    if (sl == false)
                    {
                        zavrseno = false;
                    }
                }
                if (zavrseno)
                {
                    Console.WriteLine("Pogodjeno!");
                    break;
                }
            }

        }
    }
}
