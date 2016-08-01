using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual
{
    class Program
    {
        static void Main(string[] args)
        {


            VirtualPet pokemon2 = new VirtualPet();
            pokemon2.Queen();
            string hellobunny;
            pokemon2.Print();
            Console.WriteLine();
            string interact;

            do
            {
                Console.WriteLine();
                pokemon2.Interact();
                Console.WriteLine();
                interact = Console.ReadLine().ToUpper();
                Console.Clear();
                pokemon2.Queen();



                if (interact == "FEED")
                {
                    Console.WriteLine("To feed me, pick one of these: \nCarrot, Candy, Cherries, Veggies, or Soda");
                    interact = Console.ReadLine().ToUpper();

                    switch (interact)
                    {


                        case "CARROT":
                            pokemon2.Eat();
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            Console.WriteLine();
                            Console.WriteLine("   My Health Increased !");
                            Console.WriteLine();
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            pokemon2.Print();


                            break;
                        case "CANDY":
                            pokemon2.Eatr();
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            Console.WriteLine();
                            Console.WriteLine("   My Health Decreased !");
                            Console.WriteLine();
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            pokemon2.Print();

                            break;
                        case "CHERRIES":
                            pokemon2.Eat();
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            Console.WriteLine();
                            Console.WriteLine("   My Health Increased !");
                            Console.WriteLine();
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            pokemon2.Print();

                            break;
                        case "VEGGIES":
                            pokemon2.Eat();
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            Console.WriteLine();
                            Console.WriteLine("   My Health Increased !");
                            Console.WriteLine();
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            pokemon2.Print();

                            break;
                        case "SODA":
                            pokemon2.Eatr();
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            Console.WriteLine();
                            Console.WriteLine("   My Health Decreased !");
                            Console.WriteLine();
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            pokemon2.Print();
                            break;

                    }
                    Console.WriteLine();
                }

                if (interact == "PLAY")
                {
                    Console.WriteLine("To play with me, pick one of these numbers: \n1- Throw the Striped Ball \n2- Throw the Bear Trap \n3- Throw the Chew Toy");
                    interact = Console.ReadLine().ToUpper();

                    switch (interact)
                    {


                        case "1":
                            pokemon2.Playfulness();
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            Console.WriteLine();
                            Console.WriteLine("   My Playfulness Increased !");
                            Console.WriteLine();
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            pokemon2.Print();


                            break;
                        case "2":
                            pokemon2.Playfulnessr();
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            Console.WriteLine();
                            Console.WriteLine("   My Playfulness Decreased !");
                            Console.WriteLine();
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            pokemon2.Print();

                            break;
                        case "3":
                            pokemon2.Playfulness();
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            Console.WriteLine();
                            Console.WriteLine("   My Playfulness Increased !");
                            Console.WriteLine();
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            pokemon2.Print();

                            break;

                    }
                    Console.WriteLine();
                }

                if (interact == "EXERCISE")
                {
                    Console.WriteLine("To exercise me, pick one of these numbers: \n1- Sit Around the Garden \n2- Run Around the Garden \n3- Walk Around the Garden");
                    interact = Console.ReadLine().ToUpper();

                    switch (interact)
                    {


                        case "1":
                            pokemon2.Workr();
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            Console.WriteLine();
                            Console.WriteLine(" My Exercise Health Increased !");
                            Console.WriteLine();
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            pokemon2.Print();


                            break;
                        case "2":
                            pokemon2.Work();
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            Console.WriteLine();
                            Console.WriteLine(" My Exercise Health Decreased !");
                            Console.WriteLine();
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

                            pokemon2.Print();

                            break;
                        case "3":
                            pokemon2.Work();
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            Console.WriteLine();
                            Console.WriteLine(" My Exercise Health Increased !");
                            Console.WriteLine();
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            pokemon2.Print();

                            break;
                    }
                    Console.WriteLine();
                }

                else
                {
                    pokemon2.Interact();
                }

                Console.WriteLine();
                Console.WriteLine("Do you want to interact with Fluffy Bunny again?");
                hellobunny = Console.ReadLine().ToUpper();
                pokemon2.Tick();
                Console.Clear();
                pokemon2.Queen();
                pokemon2.Print();



            }
            while (hellobunny == "YES");

            Console.Clear();

            interact = Console.ReadLine().ToUpper();






        }
    }
}
