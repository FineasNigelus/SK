using System;
using System.Collections;
using System.Collections.Generic;

namespace szyfrHomofoniczny
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<char, string[]> tablicaHomofonow = new SortedList<char, string[]>();

            tablicaHomofonow.Add('A', new string[] { "02", "12", "42", "90" });
            tablicaHomofonow.Add('D', new string[] { "09", "19" });
            tablicaHomofonow.Add('E', new string[] { "23", "98" });
            tablicaHomofonow.Add('F', new string[] { "03", "42", "57" });
            tablicaHomofonow.Add('G', new string[] { "34", "14" });
            tablicaHomofonow.Add('I', new string[] { "25", "63", "74" });
            tablicaHomofonow.Add('J', new string[] { "11", "99" });
            tablicaHomofonow.Add('K', new string[] { "31", "56" });
            tablicaHomofonow.Add('M', new string[] { "19", "83" });
            tablicaHomofonow.Add('N', new string[] { "32", "51" });
            tablicaHomofonow.Add('O', new string[] { "04", "97" });
            tablicaHomofonow.Add('P', new string[] { "05", "45" });
            tablicaHomofonow.Add('R', new string[] { "44", "39" });
            tablicaHomofonow.Add('S', new string[] { "55", "88" });
            tablicaHomofonow.Add('T', new string[] { "82", "08" });
            tablicaHomofonow.Add('W', new string[] { "75", "22" });
            tablicaHomofonow.Add('Y', new string[] { "50", "90" });
            tablicaHomofonow.Add('Z', new string[] { "40", "55" });



            Console.WriteLine("Tekst jawny: ");
            string tekstJawny = Console.ReadLine();
            string tekstZaszyfrowany = "";
            Random random = new Random();
            int losowa;

            for (int i = 0; i < tekstJawny.Length; i++)
            {
                losowa = random.Next(0, tablicaHomofonow[tekstJawny[i]].Length);
                tekstZaszyfrowany += tablicaHomofonow[tekstJawny[i]].GetValue(losowa);
            }

            Console.WriteLine("Tekst zaszyfrowany: ");
            Console.WriteLine(tekstZaszyfrowany);
        }
    }
}
