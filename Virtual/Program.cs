using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VP
{
    class Program
    {

        static void Main(string[] args)
        {

            //constants to call
            const string sHealth = "Health ";
            const string sPlay = "Playfulness ";
            const string sExercise = "Exercise Health ";

            //starts the main menu
            VirtualPet virtualPet = new VirtualPet();
            virtualPet.Opening();
            string restart;
            virtualPet.Print();
            Console.WriteLine();
            string interact;

            do
            {
                Console.WriteLine();
                virtualPet.Interact();
                Console.WriteLine();
                interact = Console.ReadLine().ToUpper();
                Console.Clear();
                virtualPet.Opening();

                //Feed Options
                if (interact == "FEED")
                {
                    Console.WriteLine("To feed me, pick one of these: \nCarrot, Candy, Cherries, Veggies, or Soda");
                    interact = Console.ReadLine().ToUpper();

                    switch (interact)
                    {

                        case "CARROT":
                            virtualPet.Eating(true);
                            virtualPet.DisplayResponse(sHealth, true);
                            virtualPet.Print();
                            break;

                        case "CANDY":
                            virtualPet.Eating(false);
                            virtualPet.DisplayResponse(sHealth, false);
                            virtualPet.Print();
                            break;

                        case "CHERRIES":
                            virtualPet.Eating(true);
                            virtualPet.DisplayResponse(sHealth, true);
                            virtualPet.Print();
                            break;

                        case "VEGGIES":
                            virtualPet.Eating(true);
                            virtualPet.DisplayResponse(sHealth, true);
                            virtualPet.Print();
                            break;

                        case "SODA":
                            virtualPet.Eating(false);
                            virtualPet.DisplayResponse(sHealth, false);
                            virtualPet.Print();
                            break;
                    }
                    Console.WriteLine();
                }
                //Play Options
                if (interact == "PLAY")
                {
                    Console.WriteLine("To play with me, pick one of these numbers: \n1- Throw the Striped Ball \n2- Throw the Bear Trap \n3- Throw the Chew Toy");
                    interact = Console.ReadLine().ToUpper();

                    switch (interact)
                    {
                        case "1":
                            virtualPet.Playfulness(1);
                            virtualPet.DisplayResponse(sPlay, true);
                            virtualPet.Print();
                            break;
                        case "2":
                            virtualPet.Playfulness(2);
                            virtualPet.DisplayResponse(sPlay, false);
                            virtualPet.Print();
                            break;
                        case "3":
                            virtualPet.Playfulness(3);
                            virtualPet.DisplayResponse(sPlay, true);
                            virtualPet.Print();
                            break;
                    }
                    Console.WriteLine();
                }
                //Exercise Options
                if (interact == "EXERCISE")
                {
                    Console.WriteLine("To exercise me, pick one of these numbers: \n1- Sit Around the Garden \n2- Run Around the Garden \n3- Walk Around the Garden");
                    interact = Console.ReadLine().ToUpper();

                    switch (interact)
                    {
                        case "1":
                            virtualPet.Work(1);
                            virtualPet.DisplayResponse(sExercise, true);
                            virtualPet.Print();
                            break;
                        case "2":
                            virtualPet.Work(2);
                            virtualPet.DisplayResponse(sExercise, false);
                            virtualPet.Print();
                            break;
                        case "3":
                            virtualPet.Work(3);
                            virtualPet.DisplayResponse(sExercise, true);
                            virtualPet.Print();
                            break;
                    }
                    Console.WriteLine();
                }
                else
                {
                    virtualPet.Interact();
                }
                //Loop around again
                Console.WriteLine();
                Console.WriteLine("Do you want to interact with Fluffy Bunny again?");
                restart = Console.ReadLine().ToUpper();
                virtualPet.Tick();
                Console.Clear();
                virtualPet.Opening();
                virtualPet.Print();
            }
            while (restart == "YES");
            Console.Clear();
            interact = Console.ReadLine().ToUpper();

        }
    }
}

