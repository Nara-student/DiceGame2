namespace DiceGame2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sump = 0;
            int sumr = 0;
            Random rand = new Random();
            int dice = rand.Next(1, 7);
            int dice2 = rand.Next(1, 7);
            
            Console.WriteLine("Hej välkommen till 21");
            Console.WriteLine();
            Console.WriteLine("Vill du slå eller stanna?");

            

            //första slag
            string answer = Console.ReadLine();
            sump += dice;
            sumr += dice2;

            Console.WriteLine("Du slog " + dice + ", du har " + sump + " poäng");
            Console.WriteLine();
            Console.WriteLine("Dealern har slått " + dice2 + ", dealern har nu totalt " + sumr + " poäng");
            Console.WriteLine("-----------------------------------------------------------");

            //Player
            while (answer != "stanna")
            {
                dice = rand.Next(1, 7);
                dice2 = rand.Next(1, 7);

                //Dealerns stopp notis
                if (sumr >= 17)
                {
                    Console.WriteLine("Dealern har stannat");
                    Console.WriteLine();
                }
                else
                {
                    answer = Console.ReadLine();
                    Console.WriteLine("Vill du slå eller stanna?1");
                }
                

                //player stanna
                if (answer == "stanna")
                {
                    Console.WriteLine("Du har totalt " + sump + " Poäng");
                    Console.WriteLine();
                    break;
                    //dealer stanna
                }else if(sumr >= 17)
                {
                    
                    while(answer != "stanna")
                    {
                        Console.WriteLine("Vill du slå eller stanna?");

                        answer = Console.ReadLine();
                        if(answer == "stanna")
                        {
                            Console.WriteLine("Du har totalt " + sump + " poäng");
                            Console.WriteLine("-----------------------------------------------------------");
                            break;
                        }

                        dice = rand.Next(1, 7);
                        sump += dice;
                        Console.WriteLine("Du slog " + dice + ", du har " + sump + " poäng");
                        Console.WriteLine("-----------------------------------------------------------");
                    }break;
                }

                sump += dice;
                sumr += dice2;

                Console.WriteLine("Du slog " + dice + ", du har " + sump + " Poäng1");
                Console.WriteLine();
                Console.WriteLine("Dealerns tur");
                Console.WriteLine();
                Console.WriteLine("Dealern har slått " + dice2 + ", dealern har nu totalt " + sumr + " poäng");
                Console.WriteLine("-----------------------------------------------------------");
            }

            //Dealer
            if(sumr < 17)
            {
                Console.WriteLine("Dealerns tur");
                while (sumr <= 17)
                {
                    dice2 = rand.Next(1, 7);
                    sumr += dice2;

                    Console.WriteLine("Dealern har slått " + dice2 + ", dealern har nu totalt " + sumr + " poäng");
                    Console.WriteLine("-----------------------------------------------------------");
                }
                Console.WriteLine("Dealern har stannat");
            }


            //Avgör
            if(sump > sumr && sump < 22)
            {
                Console.WriteLine("Du vann1");
            }else if(sump > sumr && sump >= 22)
            {
                Console.WriteLine("Ditt poäng är högre än 21 du har förlorat2");
            }else if(sump >= 22 && sumr >= 22)
            {
                Console.WriteLine("Dealern har vunnit3");
            }else if(sump < sumr && sumr < 22)
            {
                Console.WriteLine("Dealern har vunnit4");
            }else if(sumr > 21 && sump < 22)
            {
                Console.WriteLine("Dealerns poäng är över 21, du vann");
            }
            else
            {
                Console.WriteLine("Dealern har vunnit5");
            }

        }
    }
}
