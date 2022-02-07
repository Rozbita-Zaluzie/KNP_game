using System;

namespace _15___knp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\ntoto je hra kámen, nůžky, papír.\n");
            knp();
            void knp() //hra
            {
                Console.Write("\nvyberte jednu z možností\n\n1 - kámen\n2 - nůžky\n3 - papír\n\n [ 1 | 2 | 3 ] - ");
                bool ok = int.TryParse(Console.ReadLine(),out int vyb);

                Random rand = new Random();
                int vybpc = rand.Next(1,4);
                if (ok)
                {
                    if (vyb > 0 && vyb < 4)
                    {
                        if (vybpc == 1)
                        {
                            if (vyb == 1)
                            {
                                Console.WriteLine("\nhráč      - kámen\nprotihráč - kámen\n\n====================\nremíza !\n====================");
                                dalsihra();
                            }
                            else if (vyb == 2)
                            {
                                Console.WriteLine("\nhráč      - nůžky\nprotihráč - kámen\n\n====================\nprotihráč vyhrává !\n====================");
                                dalsihra();
                            }
                            else if (vyb == 3)
                            {
                                Console.WriteLine("\nhráč      - papír\nprotihráč - kámen\n\n====================\nvyhrál jste !\n====================");
                                dalsihra();
                            }
                        }
                        else if (vybpc == 2)
                        {
                            if (vyb == 1)
                            {
                                Console.WriteLine("\nhráč      - kámen\nprotihráč - nůžky\n\n====================\nvyhrál jste !\n====================");
                                dalsihra();
                            }
                            else if (vyb == 2)
                            {
                                Console.WriteLine("\nhráč      - nůžky\nprotihráč - nůžky\n\n====================\nremíza !\n====================");
                                dalsihra();
                            }
                            else if (vyb == 3)
                            {
                                Console.WriteLine("\nhráč      - papír\nprotihráč - nůžky\n\n====================\nprotihráč vyhrává !\n====================");
                                dalsihra();
                            }
                        }
                        else if (vybpc == 3)
                        {
                            if (vyb == 1)
                            {
                                Console.WriteLine("\nhráč      - kámen\nprotihráč - papír\n\n====================\nprotihráč vyhrává !\n====================");
                                dalsihra();
                            }
                            else if (vyb == 2)
                            {
                                Console.WriteLine("\nhráč      - nůžky\nprotihráč - papír\n\n====================\nvyhrál jste !\n====================");
                                dalsihra();
                            }
                            else if (vyb == 3)
                            {
                                Console.WriteLine("\nhráč      - papír\nprotihráč - papír\n\n====================\nremíza !\n====================");
                                dalsihra();
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nvyberte číslo mezi 1 - 3\nzkuste to znovu");
                        knp();
                    }
                }
                else
                {
                    Console.WriteLine("\nvyberte 1, 2, 3\nzkuste to znovu.");
                    knp();
                }
            }


            void dalsihra() // hrát znovu ?
            {
                Console.WriteLine("\n\nchcete hrát znovu ?\n\n- ano\n- ne");
                string dlsv = Console.ReadLine();
                if (dlsv == "ano")
                {
                    Console.Clear();
                    knp();
                }
                else { }
            }
        }
    }
}
