using System;

namespace szyfrPlayfaira
{
    class Program
    {
        public static string TekstZaszyfrowany(string tekstJawny)
        {
            char[,] Matrix = new char[,]
            {
                {'H', 'A', 'R', 'P', 'S' },
                {'I', 'C', 'O', 'D', 'B' },
                {'E', 'F', 'G', 'K', 'L' },
                {'M', 'N', 'Q', 'T', 'U' },
                {'V', 'W', 'X', 'Y', 'Z' },
            };

            int[,] sprawdzana = new int[tekstJawny.Length, 2];

            for (int i = 0; i < tekstJawny.Length; i++)
            {
                for (int j = 0; j < Matrix.GetLength(0); j++)
                {
                    for (int k = 0; k < Matrix.GetLength(1); k++)
                    {
                        if (tekstJawny[i] == Matrix[j, k])
                        {
                            sprawdzana[i, 0] = j;
                            sprawdzana[i, 1] = k;
                        }
                    }
                }
            }

            string tekstZaszyfrowany = "";

            for (int i = 0; i < tekstJawny.Length; i += 2)
            {
                if ((sprawdzana[i, 0] == sprawdzana[i + 1, 0]) && (sprawdzana[i, 1] == sprawdzana[i + 1, 1]))
                {
                    tekstZaszyfrowany += tekstJawny[i] + "V ";
                }
                if (sprawdzana[i,0] == sprawdzana[i+1,0])
                {
                    if(sprawdzana[i,1] == 4)
                    {
                        tekstZaszyfrowany += Matrix[sprawdzana[i, 0], 0];
                        if(sprawdzana[i+1,1]==4)
                        {
                            tekstZaszyfrowany += Matrix[sprawdzana[i + 1, 0], 0] + " ";
                        }
                        else
                        {
                            tekstZaszyfrowany += Matrix[sprawdzana[i + 1, 0], sprawdzana[i + 1, 1] + 1] + " ";
                        }
                    }
                    else
                    {
                        tekstZaszyfrowany += Matrix[sprawdzana[i, 0], sprawdzana[i, 1] + 1];
                        if (sprawdzana[i + 1, 1] == 4)
                        {
                            tekstZaszyfrowany += Matrix[sprawdzana[i + 1, 0], 0] + " ";
                        }
                        else
                        {
                            tekstZaszyfrowany += Matrix[sprawdzana[i + 1, 0], sprawdzana[i + 1, 1] + 1] + " ";
                        }
                    }
                }
                if (sprawdzana[i, 1] == sprawdzana[i + 1, 1])
                {
                    if (sprawdzana[i,0] == 4)
                    {
                        tekstZaszyfrowany += Matrix[0, sprawdzana[i, 1]];
                        if (sprawdzana[i+1,0]==4)
                        {
                            tekstZaszyfrowany += Matrix[0, sprawdzana[i + 1, 1]] + " ";
                        }
                        else
                        {
                            tekstZaszyfrowany += Matrix[sprawdzana[i + 1, 0] + 1, sprawdzana[i + 1,1]] + " ";
                        }
                    }
                    else
                    {
                        tekstZaszyfrowany += Matrix[sprawdzana[i, 0] + 1, sprawdzana[i, 1]];
                        if (sprawdzana[i + 1, 0] == 4)
                        {
                            tekstZaszyfrowany += Matrix[0, sprawdzana[i + 1, 1]] + " ";
                        }
                        else
                        {
                            tekstZaszyfrowany += Matrix[sprawdzana[i + 1, 0] + 1, sprawdzana[i + 1, 1]] + " ";
                        }
                    }
                }
                else
                {
                    tekstZaszyfrowany += Matrix[sprawdzana[i, 0], sprawdzana[i + 1, 1]];
                    tekstZaszyfrowany += Matrix[sprawdzana[i + 1, 0], sprawdzana[i, 1]] + " ";
                }
            }

            return tekstZaszyfrowany;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj tekst jawny: ");
            string tekstJawny = new string(Console.ReadLine()).ToUpper();

            if (tekstJawny.Length % 2 != 0)
                tekstJawny += "V";

            Console.WriteLine("Tekst zaszyfrowany: ");
            Console.WriteLine(TekstZaszyfrowany(tekstJawny));
        }
    }
}
