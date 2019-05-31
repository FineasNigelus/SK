using System;

namespace szyfrCezara
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj ciąg znaków: ");
            string sentence = Console.ReadLine();
            string newSentence ="";
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] + 3 > 90)
                {
                    newSentence += Convert.ToChar(((sentence[i] + 3) % 90) + 64);

                }
                else
                {
                    newSentence += Convert.ToChar(sentence[i] + 3);
                }
            }
            Console.Write("Zaszyfrowane: " + newSentence );
            Console.ReadLine();
        }
    }
}
