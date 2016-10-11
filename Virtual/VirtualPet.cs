using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP
{
    class VirtualPet
    {

        //fields
        private int feed;
        private int happy;
        private int play;
        private int exercise;
        const string star = "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~";

        //properties
        public int Hunger
        {
            get { return this.feed; }
            set { this.Hunger = value; }
        }

        public int Happiness
        {
            get { return this.happy; }
            set { this.Happiness = value; }
        }

        public int Playful
        {
            get { return this.play; }
            set { this.Playful = value; }
        }

        public int WorkOut
        {
            get { return this.exercise; }
            set { this.WorkOut = value; }
        }



        //constructors

        public VirtualPet()
        {
            feed = 50;
            happy = 50;
            play = 50;
            exercise = 50;
        }

        public void Eating(bool feedr)
        {
            if (feedr)
            {
                feed = feed + 10;
            }
            else
                feed = feed - 15;
        }

        public void Playfulness(int playr)
        {
            if (playr == 1 || playr == 3)
            {
                play = play + 10;
            }
            else
                play = play - 20;
        }

        public void Work(int exerciser)
        {
            if (exerciser == 1 || exerciser == 3)
            {
                exercise = exercise + 20;
            }
            else
                exercise = exercise - 10;
        }

        public void Tick()
        {
            feed = feed - 2;
            happy = happy + 1;
            play = play - 2;
            exercise = exercise - 3;

        }


        public void Print()
        {
            StringBuilder princess = new StringBuilder();
            princess.Append("\nFluffy Bunny's Health: " + this.feed);
            princess.Append("\nFluffy bunny Happiness: " + this.happy);
            princess.Append("\nfluffy bunny's Playfulness: " + this.play);
            princess.Append("\nFluffy Bunny's Exercise Health: " + this.exercise);
            Console.WriteLine(princess.ToString());
        }

        public void Interact()
        {
            Console.WriteLine("Rules: \nType \"Feed\", \"Play\", or \"Exercise\" to interact with me. \nMy Happiness increases the more you interact with me!");
        }


        public void Opening()
        {
            Console.WriteLine("hello friend! my name is fluffy bunny! to keep me happy, healthy, and sane you \nmust feed me the right food, play with me, and take me for walks! ");
            Console.WriteLine();
            Console.WriteLine(" /)_/)");
            Console.WriteLine();
            Console.WriteLine(" ( . .)");
            Console.WriteLine();
            Console.WriteLine("C('')('')");
        }




        public void DisplayResponse(string stats, bool changeAttitude)
        {
            //never going to change = use constant--usually for strings
            Console.WriteLine(star);
            Console.WriteLine();
            if (changeAttitude)
            {
                Console.WriteLine("My " + stats + "Increased");
            }
            else
            {
                Console.WriteLine("My " + stats + "Decreased");
            }
            Console.WriteLine();
            Console.WriteLine(star);

        }



    }


}

