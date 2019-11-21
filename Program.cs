using System;


namespace Magic8Ball
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-Hello! Welcome to the Magic 8 Ball, it I can see the future! \n-However... I can only answer yes or no questions... \n-What is your question?\n");
            Console.ReadLine();

            var gate = 0;

            while (gate == 0)
            {


                Random rnd = new Random();

                int q1 = rnd.Next(0, 12);

                switch (q1)
                {
                    case 0:
                        Console.WriteLine("Definetly NOT! TOO BAD BUDDY!");
                        break;
                    case 2:
                        Console.WriteLine("Ooooh, Yes! Definetly");
                        break;
                    case 3:
                        Console.WriteLine("Hmm... Leaning towards a no.");
                        break;
                    case 4:
                        Console.WriteLine("Well... it going to be a... YES");
                        break;
                    case 5:
                        Console.WriteLine("Lol no. You're screwed.");
                        break;
                    case 6:
                        Console.WriteLine("Yes!! Yes!! Mega Yess!!!");
                        break;
                    case 7:
                        Console.WriteLine("That's a negative. Lmao");
                        break;
                    case 8:
                        Console.WriteLine("Oh shoot, Thas a yusss");
                        break;
                    case 9:
                        Console.WriteLine("Nah buddy, never.");
                        break;
                    case 10:
                        Console.WriteLine("Yes dude, but don't get cocky");
                        break;
                    case 11:
                        Console.WriteLine("Nope! ahahah... its okay man...");
                        break;
                    case 12:
                        Console.WriteLine("YHUPPP, LETS GOOO");
                        break;
                    case 13:
                        Console.WriteLine("Oh shoot... This one... I actually don't know...");
                        break;
                    default:
                        break;
                }

                Console.WriteLine("\n-Would you like to ask another question? y/n");
                var keying = Console.ReadLine();

                if (keying == "n")
                {
                    gate = 1;
                }

                else 
                {
                    Console.Clear();
                    Console.WriteLine("-What is your next question...?");
                    Console.ReadLine();
                }
            }
            Console.WriteLine("Thank you for using the Magic 8 Ball!!");
            Console.WriteLine("Press anything to exit");
            Console.ReadLine();
        }
    }
}
