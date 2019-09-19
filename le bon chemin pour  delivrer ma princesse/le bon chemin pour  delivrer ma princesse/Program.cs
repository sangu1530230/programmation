using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace le_bon_chemin_pour__delivrer_ma_princesse
{
    class Program
    {
        static void Main(string[] args)
        {
            int chemin= 0;

            Console.WriteLine("Hero,quel est le chemin a prendre?");

            //conversion ici
            chemin = Convert.ToInt32(Console.ReadLine());

            if (chemin == 1) 
            {
                Console.WriteLine("pas de probleme, vous êtes sur le bon chemin");

                int choix = 0;

                Console.WriteLine("hero, quel choix a prendre?");

                //conversion ici
                choix = Convert.ToInt32(Console.ReadLine());

                if (choix == 1)
                {
                    Console.WriteLine("vous allez croiser les serpents et vous ne seriez plus sur le bon chemin");
                    
                }
                else
                {
                    Console.WriteLine("vous aviez reçu, vous pouvez passer au combat");

                    int choixadv = 0;

                    Random generateurchoixadv = new Random();

                    //genere un nombre entre 1 et 2, le 3 est exclus

                    choixadv = (int)generateurchoixadv.Next(1, 3);
                    Console.WriteLine("nombre genere" + choixadv);

                    Console.WriteLine("le choix a été fait, votre adversaire est le nombre généré");

                    if (choixadv == 1)
                    {
                        Console.WriteLine("votre adversaire est jimmy");

                        int coupReçu = 0;

                        Console.WriteLine("quel est le nombre de coup reçu?");

                        //conversion ici
                        coupReçu = Convert.ToInt32(Console.ReadLine());

                        if (coupReçu >= 17 )
                        {
                          Console.WriteLine("vous êtes mort, game over"); 
                        }
                        else
                        {
                            Console.WriteLine("vous aviez gagné le combat, vous êtes sur le chemin du vieux maître pour le jeux aux questions");

                            int nbreReponsevraie = 0;

                            Console.WriteLine("quel est le nombre de reponse vraie?");

                            //conversion ici
                            nbreReponsevraie = Convert.ToInt32(Console.ReadLine());

                            if (nbreReponsevraie >= 2)
                            {

                                Console.WriteLine("vous aviez gagné le jeux et vous passez au second combat");

                                int choixcom = 0;

                                Random generateurchoixcom = new Random();

                                //genere un nombre entre 1 et 2, le 3 est exclus

                                choixcom = (int)generateurchoixadv.Next(1, 3);
                                Console.WriteLine("nombre genere" + choixadv);

                                Console.WriteLine("le choix a été fait, votre adversaire est le nombre généré");

                                if (choixadv == 1)
                                {
                                    Console.WriteLine("votre adversaire est billy");
                                    int coupreçu = 0;

                                    Console.WriteLine("quel est le nombre de coup reçu?");

                                    //conversion ici
                                     coupreçu = Convert.ToInt32(Console.ReadLine());

                                     if (coupreçu >= 17)
                                     {
                                        Console.WriteLine("vous êtes mort, game over");
                                     }
                                     else
                                     {
                                        Console.WriteLine("vous aviez gagné le combat, vous avez delivré votre princesse");
                                     }
                                       // Attendre avant de fermer la fenêtre
                                       Console.ReadKey();
                                }
                                else
                                {
                                    Console.WriteLine("votre adversaire est olivier");
                                    int coupreçu = 0;

                                    Console.WriteLine("quel est le nombre de coup reçu?");

                                    //conversion ici
                                    coupreçu = Convert.ToInt32(Console.ReadLine());

                                    if (coupreçu >= 17)
                                    {
                                        Console.WriteLine("vous êtes mort, game over");
                                    }
                                    else
                                    {
                                        Console.WriteLine("vous aviez gagné le combat, vous avez delivré votre princesse");
                                    }
                                    // Attendre avant de fermer la fenêtre
                                    Console.ReadKey();
                                }
                            }
                            else
                            {
                                Console.WriteLine("vous aviez perdu le jeux et vous êtes devoré par les crocodiles");

                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("votre adversaire est mike");

                        int coupReçu = 0;

                        Console.WriteLine("quel est le nombre de coup reçu?");

                        //conversion ici
                        coupReçu = Convert.ToInt32(Console.ReadLine());

                        if (coupReçu >= 17)
                        {
                            Console.WriteLine("vous êtes mort, game over");
                        }
                        else
                        {
                            Console.WriteLine("vous aviez gagné le combat, vous êtes sur le chemin du vieux maître pour le jeux aux questions");

                            int nbreReponsevraie = 0;


                            Console.WriteLine("quel est le nombre de reponse vraie?");

                            //conversion ici
                            nbreReponsevraie = Convert.ToInt32(Console.ReadLine());


                            if (nbreReponsevraie >= 2)
                            {
                                Console.WriteLine("vous aviez gagné le jeux et vous passez au combat avec billy");

                                int coupreçu = 0;

                                Console.WriteLine("quel est le nombre de coup reçu?");

                                //conversion ici
                                coupreçu = Convert.ToInt32(Console.ReadLine());

                                if (coupreçu >= 17)
                                {
                                    Console.WriteLine("vous êtes mort, game over");
                                }
                                else
                                {
                                    Console.WriteLine("vous aviez gagné le combat, vous avez delivré votre princesse");
                                }
                                // Attendre avant de fermer la fenêtre
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("vous aviez perdu le jeux et vous êtes devoré par les crocodiles");

                            }
                        }
                    }
                }
            }

            if (chemin == 2)
            {
                Console.WriteLine("pas de probleme, vous êtes sur le bon chemin, mais une baitalle armée vous attend");

                int balesReçues = 0;

                Console.WriteLine("quel est le nombre de bales reçues?");

                //conversion ici
                balesReçues = Convert.ToInt32(Console.ReadLine());
                
                if (balesReçues >3)
                {
                   Console.WriteLine("game over, vous êtes mort");
                }
                else
                {
                   Console.WriteLine("vous aviez reçu, vous pouvez passer au combat");

                    int choixadv = 0;

                    Random generateurchoixadv = new Random();

                    //genere un nombre entre 1 et 2, le 3 est exclus

                    choixadv= (int)generateurchoixadv.Next(1, 3);
                    Console.WriteLine("nombre genere"+choixadv);

                    Console.WriteLine("le choix a été fait, votre adversaire est le nombre généré");

                    if (choixadv==1)
                    {
                        Console.WriteLine("votre adversaire est luke");

                        int coupReçu = 0;

                        Console.WriteLine("quel est le nombre de coup reçu?");

                        //conversion ici
                        coupReçu = Convert.ToInt32(Console.ReadLine());

                        if (coupReçu < 17)
                        {
                            Console.WriteLine("vous aviez gagné, vous pouvez passer au jeux de porte");

                            int choixPorte = 0;

                            Console.WriteLine("quel est le numero de la porte choisie?");

                            //conversion ici
                            choixPorte = Convert.ToInt32(Console.ReadLine());

                            if (choixPorte == 1)
                            {
                                Console.WriteLine("bon choix, vous aviez delivre votre princesse");

                                // Attendre avant de fermer la fenêtre
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("mauvais choix, vous aviez perdu, game over");
                            }
                        }
                        else
                        {
                            Console.WriteLine("game over, vous êtes mort");
                        }
                    }
                    else
                    {
                        Console.WriteLine("votre adversaire est mike");

                        int coupReçu = 0;

                        Console.WriteLine("quel est le nombre de coup reçu?");

                        //conversion ici
                          coupReçu = Convert.ToInt32(Console.ReadLine());

                        if (coupReçu < 17)
                        {
                             Console.WriteLine("vous aviez gagné, vous pouvez passer au jeux de porte");

                             int choixPorte = 0;

                             Console.WriteLine("quel est le numero de la porte choisie?");

                             //conversion ici
                              choixPorte = Convert.ToInt32(Console.ReadLine());

                             if (choixPorte == 1)
                             {
                                 Console.WriteLine("bon choix, vous aviez delivre votre princesse");

                                 // Attendre avant de fermer la fenêtre
                                  Console.ReadKey();
                             }                           
                             else
                             {

                                 Console.WriteLine("mauvais choix, vous aviez perdu, game over");
                             }
                        }
                        else
                        {

                           Console.WriteLine("game over, vous êtes mort");
                        }    
                    }
                }
            }
            else
            {
                Console.WriteLine("vous n'êtes pas sur le bon chemin, vous avez perdu");
            }
        }
    }
}
    
