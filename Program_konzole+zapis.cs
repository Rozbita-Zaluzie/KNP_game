using System;
using System.IO;

namespace _15___knp
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                CreateFile();
            }
            catch (Exception)
            {
                Console.WriteLine("Někde se stala chyba :(");
                throw;
            }

            Console.Write("\ntoto je hra kámen, nůžky, papír. ");            
            Zapis("\ntoto je hra kámen, nůžky, papír. ");
            int skorehr = 0;
            int skorepc = 0;
            int kola = 0;
            string zapis;


            knp(false);
            
            void knp(bool skip) //hra
            {

                
                if (!skip)
                {
                    Console.Write("kolik chcete hrát kol ? - ");
                    bool okola = int.TryParse(Console.ReadLine(), out kola);
                    Zapis("kolik chcete hrát kol ? - " + kola);

                    skorehr = 0;
                    skorepc = 0;
                }

                    
                for (int i = 0; i < kola; i++)
                {
                    Console.Write("\nmomentální skóre je [ " + skorehr + " | " + skorepc + " ]\nvyberte jednu z možností\n\n1 - kámen\n2 - nůžky\n3 - papír\n\n [ 1 | 2 | 3 ] - ");
                    Zapis("\nmomentální skóre je [ " + skorehr + " | " + skorepc + " ]\nvyberte jednu z možností\n\n1 - kámen\n2 - nůžky\n3 - papír\n\n [ 1 | 2 | 3 ] - ");
                    bool ok = int.TryParse(Console.ReadLine(), out int vyb);

                    Random rand = new Random();
                    int vybpc = rand.Next(1, 4);
                    if (ok)
                    {
                        if (vyb > 0 && vyb < 4)
                        {
                            if (vybpc == 1)
                            {
                                if (vyb == 1)
                                {
                                    Console.WriteLine("\nhráč      - kámen\nprotihráč - kámen\n\n====================\nremíza !\n====================");
                                    Zapis("\nhráč      - kámen\nprotihráč - kámen\n\n====================\nremíza !\n====================");

                                }
                                else if (vyb == 2)
                                {
                                    Console.WriteLine("\nhráč      - nůžky\nprotihráč - kámen\n\n====================\nprotihráč vyhrává !\n====================");
                                    Zapis("\nhráč      - nůžky\nprotihráč - kámen\n\n====================\nprotihráč vyhrává !\n====================");
                                    skorepc++;

                                }
                                else if (vyb == 3)
                                {
                                    Console.WriteLine("\nhráč      - papír\nprotihráč - kámen\n\n====================\nvyhrál jste !\n====================");
                                    Zapis("\nhráč      - papír\nprotihráč - kámen\n\n====================\nvyhrál jste !\n====================");
                                    skorehr++;

                                }
                            }
                            else if (vybpc == 2)
                            {
                                if (vyb == 1)
                                {
                                    Console.WriteLine("\nhráč      - kámen\nprotihráč - nůžky\n\n====================\nvyhrál jste !\n====================");
                                    Zapis("\nhráč      - kámen\nprotihráč - nůžky\n\n====================\nvyhrál jste !\n====================");
                                    skorehr++;

                                }
                                else if (vyb == 2)
                                {
                                    Console.WriteLine("\nhráč      - nůžky\nprotihráč - nůžky\n\n====================\nremíza !\n====================");
                                    Zapis("\nhráč      - nůžky\nprotihráč - nůžky\n\n====================\nremíza !\n====================");

                                }
                                else if (vyb == 3)
                                {
                                    Console.WriteLine("\nhráč      - papír\nprotihráč - nůžky\n\n====================\nprotihráč vyhrává !\n====================");
                                    Zapis("\nhráč      - papír\nprotihráč - nůžky\n\n====================\nprotihráč vyhrává !\n====================");
                                    skorepc++;

                                }
                            }
                            else if (vybpc == 3)
                            {
                                if (vyb == 1)
                                {
                                    Console.WriteLine("\nhráč      - kámen\nprotihráč - papír\n\n====================\nprotihráč vyhrává !\n====================");
                                    Zapis("\nhráč      - kámen\nprotihráč - papír\n\n====================\nprotihráč vyhrává !\n====================");
                                    skorepc++;

                                }
                                else if (vyb == 2)
                                {
                                    Console.WriteLine("\nhráč      - nůžky\nprotihráč - papír\n\n====================\nvyhrál jste !\n====================");
                                    Zapis("\nhráč      - nůžky\nprotihráč - papír\n\n====================\nvyhrál jste !\n====================");
                                    skorehr++;

                                }
                                else if (vyb == 3)
                                {
                                    Console.WriteLine("\nhráč      - papír\nprotihráč - papír\n\n====================\nremíza !\n====================");
                                    Zapis("\nhráč      - papír\nprotihráč - papír\n\n====================\nremíza !\n====================");

                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nvyberte číslo mezi 1 - 3\nzkuste to znovu");
                            Zapis("\nvyberte číslo mezi 1 - 3\nzkuste to znovu");
                            knp(true);
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nvyberte 1, 2, 3\nzkuste to znovu.");
                        Zapis("\nvyberte 1, 2, 3\nzkuste to znovu.");
                        knp(true);
                    }
                }
                dalsihra();
            }


            void dalsihra() // hrát znovu ?
            {
                Console.WriteLine("\nkonečné skóre je\n\nhráč      - " + skorehr + "\nprotihráč - " + skorepc);
                if (skorehr == skorepc)
                {
                    Console.WriteLine("\n====================\nRemíza !\n====================");
                    Zapis("\n====================\nRemíza !\n====================");
                }
                else if (skorehr > skorepc)
                {
                    Console.WriteLine("\n====================\nVyhrál jste !\n====================");
                    Zapis("\n====================\nVyhrál jste !\n====================");
                }
                else if (skorepc > skorehr)
                {
                    Console.WriteLine("\n====================\nVyhrává protihráč !\n====================");
                    Zapis("\n====================\nVyhrává protihráč !\n====================");
                }
                Console.Write("\n\nchcete hrát znovu ?\n\n- ano\n- ne\n\n další hra ?  - ");
                Zapis("\n\nchcete hrát znovu ?\n\n- ano\n- ne\n\n další hra ?  - ");
                string dlsv = Console.ReadLine();
                if (dlsv == "ano")
                {
                    Console.Write("==================================================\n\n\n\n");
                    Zapis("==================================================\n\n\n\n");
                    knp(false);
                }
            }

            void CreateFile()
            {
                if (File.Exists("KNP_zaznam.txt"))
                {
                    zapis = "KNP_zaznam.txt";
                    File.WriteAllText(zapis, "");
                }
                else
                {
                    StreamWriter writer = new StreamWriter("KNP_zaznam.txt");
                    zapis = "KNP_zaznam.txt";
                }
            }

            void Zapis(string text)
            {
                using (StreamWriter sw = File.AppendText(zapis))
                {
                    sw.WriteLine(text);
                }
            }
        }
    }
}
