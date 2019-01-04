using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Lesson_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //одномерный массив далее P3/6
            //int[] six = new[] { 1, 2, 3, 4, 5, 6 };
            //for (int i = 0; i < six.Length; i++)
            //{
            //    Console.WriteLine(six[i]); //shown in correct order  - from first element
            //}

            //for (int i = six.Length-1; i >= 0; i--)
            //{
            //    Console.WriteLine(six[i]); //shown in reverse order  - from last element
            //}

            //Console.WriteLine(string.Join(",", six));

            //двумерный массив далее P4/ 6
            Random rnd = new Random();

            int[,] six2 = new int[3, 4];
            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 4; j++)
                {
                    six2[i, j] = rnd.Next(100);
                    Console.WriteLine(six2[i, j]);
                }
            }

            //using Rank and GetUpperBound(i) methods
            //int[,] six2 = new int[3, 4];
            //for (int i = 0; i < six2.Rank; i++)
            //{
            //    Console.WriteLine(i);
            //    Console.WriteLine(six2.GetUpperBound(i));
            //    for (int j = 0; j < six2.GetUpperBound(i); j++)
            //    {
            //        six2[i, j] = rnd.Next(100);
            //        Console.WriteLine(six2[i, j]);
            //    }
            //}


            //PoemGeneration();
            //PoemGenerationForEach();
            Pyatnashki();

            Console.ReadLine();
        }

        public static void OutHugeMassive(int[,] six2)
        {
            //Random rnd = new Random();
            //int[,] six2 = new int[3, 4];
            //for (int i = 0; i < six2.Rank; i++)
            //{

            //    for (int j = 0; j < six2.GetUpperBound(i); j++)
            //    {
            //        six2[i, j] = rnd.Next(100);
            //        Console.WriteLine(six2[i, j]);
            //    }
            //    Console.WriteLine(i);
            //    Console.WriteLine(six2.GetUpperBound(i));
            //}
            foreach (var element in six2)
            {
                Console.WriteLine(element);
            }
        }

        public static void PoemGeneration()
        {
            Random rnd = new Random();
            char[][] poem = new char[100][];
            for (int i = 0; i <= 99; i++)
            {
                var word = new char[rnd.Next(10)];
                for (int j = 0; j < word.Length; j++)
                {
                    word[j] = (char)rnd.Next(1040 - 1, 1103 - 1);
                }
                poem[i] = word;
            }
            for (int i = 0; i < poem.Length; i++)
            {
                Console.WriteLine(poem[i]);
            }

        }

        public static void PoemGenerationForEach()
        {
            Random rnd = new Random();
            char[][] poem = new char[100][];
            for (int i = 0; i <= 99; i++)
            {
                var word = new char[rnd.Next(10)];
                for (int j = 0; j < word.Length; j++)
                {
                    word[j] = (char)rnd.Next(1040 - 1, 1103 - 1);
                }
                poem[i] = word;
            }
            foreach (var word in poem)
            {
                Console.WriteLine(word);
            }

        }
        public static void Pyatnashki()
        {
            char again = 'y';
            
            Random rnd = new Random();
            string oper;
            int[,] pyatnashki = new int[4, 4];
            int iCoordZero = 0;
            int jCoordZero = 0;

            for (int i = 0; i < 4; i++)
            {

                for (int j = 0; j < 4; j++)
                {
                    if (i == iCoordZero && j == jCoordZero)
                    {
                        pyatnashki[i, j] = 0;
                    }
                    else
                    {
                        pyatnashki[i, j] = rnd.Next(100);
                    }
                    Console.Write(pyatnashki[i, j] + " ");
                }
                Console.WriteLine();
            }

            while (again == 'y')
            {

                Console.WriteLine("Insert the WASD operator:");
                oper = Console.ReadLine();
                
                switch (oper)
                {
                    case "W":
                        if (iCoordZero != 0)
                        {
                            int temp = pyatnashki[iCoordZero - 1, jCoordZero];
                            pyatnashki[iCoordZero - 1, jCoordZero] = pyatnashki[iCoordZero, jCoordZero];
                            pyatnashki[iCoordZero, jCoordZero] = temp;
                            iCoordZero--;

                            Console.WriteLine("Switch numbers: " + pyatnashki[iCoordZero, jCoordZero] + " and " + pyatnashki[iCoordZero + 1, jCoordZero]);
                        }
                        else
                        {
                            Console.WriteLine("No rows to return the value ");
                        }

                        break;

                    case "S":

                        if (iCoordZero != 3)
                        {
                            int temp = pyatnashki[iCoordZero, jCoordZero];
                            pyatnashki[iCoordZero, jCoordZero] = pyatnashki[iCoordZero + 1, jCoordZero];
                            pyatnashki[iCoordZero + 1, jCoordZero] = temp;
                            iCoordZero++;
                            Console.WriteLine("Switch numbers: " + pyatnashki[iCoordZero, jCoordZero] + " and " + pyatnashki[iCoordZero - 1, jCoordZero]);
                        }
                        else
                        {
                            Console.WriteLine("No rows to return the value ");
                        }

                        break;

                    case "A":
                        if (jCoordZero != 0)
                        {
                            int temp = pyatnashki[iCoordZero, jCoordZero - 1];
                            pyatnashki[iCoordZero, jCoordZero - 1] = pyatnashki[iCoordZero, jCoordZero];
                            pyatnashki[iCoordZero, jCoordZero] = temp;
                            jCoordZero--;
                            Console.WriteLine("Switch numbers: " + pyatnashki[iCoordZero, jCoordZero] + " and " + pyatnashki[iCoordZero, jCoordZero + 1]);
                        }
                        else
                        {
                            Console.WriteLine("No columns to return the value ");
                        }
                        break;

                    case "D":
                        if (jCoordZero != 3)
                        {
                            int temp = pyatnashki[iCoordZero, jCoordZero + 1];
                            pyatnashki[iCoordZero, jCoordZero + 1] = pyatnashki[iCoordZero, jCoordZero];
                            pyatnashki[iCoordZero, jCoordZero] = temp;
                            jCoordZero++;
                            Console.WriteLine("Switch numbers: " + pyatnashki[iCoordZero, jCoordZero] + " and " + pyatnashki[iCoordZero, jCoordZero - 1]);
                        }
                        else
                        {
                            Console.WriteLine("No columns to return the value ");
                        }
                        break;

                    default:
                        Console.WriteLine("Unknown operator.");
                        Console.WriteLine("Do you want to continue using WASD? (y/n)");
                        again = Convert.ToChar(Console.ReadLine());
                        break;
                }

                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write(pyatnashki[i, j] + " ");
                    }
                    Console.WriteLine();
                }


            }
        }

        //public static void PoemExample()
        //{

        //}
    }
}

