using System;

namespace zad3
{
    class Program
    {
        private class krzeslo
        {
            private int wysokosc;
            string material;
            char model;
            public void dane()
            {
                do
                {
                    Console.WriteLine("Podaj wysokość krzesła (większa niż 10): ");
                    wysokosc = int.Parse(Console.ReadLine());
                }
                while (wysokosc < 10);
                Console.WriteLine("Podaj materiał z którego ma być wykonane krzesło: ");
                material = Console.ReadLine();
                Console.WriteLine("Podaj model krzesła (jeden znak): ");
                model = char.Parse(Console.ReadLine());
                Console.WriteLine("\n");

            }
            public void rysuj()
            {
                char[,] array = new char[wysokosc, wysokosc / 2];
                for (int i = 0; i < wysokosc; i++)
                {
                    if (i > (wysokosc / 3))
                    {
                        for (int j = 0; j < wysokosc / 2 - 1; j++)
                        {
                            array[i, j] = ' ';
                        }
                        array[i, wysokosc / 2 - 1] = model;
                    }
                    else
                    {
                        if (i == wysokosc / 3)
                        {
                            for (int j = 0; j < wysokosc / 2; j++)
                            {
                                array[i, j] = model;
                            }
                        }
                        else
                        {
                            array[i, 0] = model;
                            for (int j = 1; j < (wysokosc / 2) - 1; j++)
                            {
                                array[i, j] = ' ';
                            }
                            array[i, wysokosc / 2 - 1] = model;
                        }
                    }
                }
                Console.WriteLine("Krzesło wykonane z materiału " + material + ":\n");

                for (int i = wysokosc - 1; i >= 0; i--)
                {
                    for (int j = wysokosc / 2 - 1; j >= 0; j--)
                    {
                        Console.Write(array[i, j]);
                    }
                    Console.Write("\n");
                }
            }
        }
        private class stol
        {
            int wysokosc;
           protected string material;
            char model;
            public void dane()
            {
                do
                {
                    Console.WriteLine("Podaj wysokość stołu (większa niż 10): ");
                    wysokosc = int.Parse(Console.ReadLine());
                }
                while (wysokosc < 10);
                Console.WriteLine("Podaj materiał z którego ma być wykonany stół: ");
                material = Console.ReadLine();
                Console.WriteLine("Podaj model stołu (jeden znak): ");
                model = char.Parse(Console.ReadLine());
                Console.WriteLine("\n");

            }
            public void rysuj()
            {
                char[,] array = new char[wysokosc, wysokosc * 3];
                for (int j = 0; j < wysokosc * 3; j++)
                {
                    array[0, j] = model;
                }
                for (int i = 1; i < wysokosc; i++)
                {

                    for (int j = 0; j < wysokosc * 3; j++)
                    {
                        if (j == 3 || j == wysokosc * 3 - 4)
                        {
                            array[i, j] = model;
                        }
                        else
                        {
                            array[i, j] = ' ';
                        }
                    }
                }
                Console.WriteLine("Stół wykonany z materiału " + material + ":\n");
                for (int i = 0; i < wysokosc; i++)
                {
                    for (int j = 0; j < wysokosc * 3; j++)
                    {
                        Console.Write(array[i, j]);
                    }
                    Console.Write("\n");
                }
            }
        }
        private class szafa
        {
            int wysokosc;
            string material;
           public char model;
            public void dane()
            {
                do
                {
                    Console.WriteLine("Podaj wysokosc szafy (większa niż 20): ");
                    wysokosc = int.Parse(Console.ReadLine());
                }
                while (wysokosc < 20);
                Console.WriteLine("Podaj materiał z którego ma być wykonana szafa: ");
                material = Console.ReadLine();
                Console.WriteLine("Podaj model szafy (jeden znak): ");
                model = char.Parse(Console.ReadLine());
                Console.WriteLine("\n");

            }
            public void rysuj()
            {
                char[,] array = new char[wysokosc, wysokosc ];
                for (int j = 0; j < wysokosc ; j++)
                {
                    array[0, j] = model;
                }
                for (int i = 1; i < wysokosc-1; i++)
                {
                    if (i == wysokosc/2 )
                    {
                        for (int j = 0; j < wysokosc ; j++)
                        {
                            if (j == 0 || j == wysokosc  - 1 || j == wysokosc / 2 || j==wysokosc/2-2||j==wysokosc/2+2)
                            {
                                array[i, j] = model;
                            }
                            else
                            {
                                array[i, j] = ' ';
                            }
                        }
                    }
                    else
                    {
                        for (int j = 0; j < wysokosc ; j++)
                        {
                            if (j == 0 || j == wysokosc  - 1 || j == wysokosc / 2)
                            {
                                array[i, j] = model;
                            }
                            else
                            {
                                array[i, j] = ' ';
                            }

                        }
                    }
                    for(int j = 0; j < wysokosc; j++)
                    {
                        array[wysokosc - 1, j] = model;
                    }
                }
                Console.WriteLine("Szafa wykonana z materiału " + material + ":\n");
                for (int i = 0; i < wysokosc; i++)
                {
                    for (int j = 0; j < wysokosc; j++)
                    {
                        Console.Write(array[i, j]);
                    }
                    Console.Write("\n");
                }
            }

            static void Main(string[] args)
            {
                krzeslo krzeslo = new krzeslo();
                krzeslo.dane();
                krzeslo.rysuj();
                stol stol = new stol();
                Console.WriteLine("\n");
                stol.dane();
                stol.rysuj();
                Console.WriteLine("\n");
                szafa szafa = new szafa();
                szafa.dane();
                szafa.rysuj();
                Console.ReadLine();
            }
        }
    }
}
