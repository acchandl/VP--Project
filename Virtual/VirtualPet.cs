using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual
{
    class VirtualPet
    {

        //fields
        private int feed;
        private int happy;
        private int play;
        private int exercise;


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
            this.feed = 50;
            this.happy = 50;
            this.play = 50;
            this.exercise = 50;
        }


        public void Eat()
        {
            feed = feed + 10;
        }

        public void Eatr()
        {
            feed = feed - 15;
        }

        public void Playfulness()
        {
            play = play + 10;
        }

        public void Playfulnessr()
        {
            play = play - 14;
        }

        public void Work()
        {
            exercise = exercise + 10;
        }

        public void Workr()
        {
            exercise = exercise - 12;
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


        public void Queen()
        {
            Console.WriteLine("hello friend! my name is fluffy bunny! to keep me happy, healthy, and sane you \nmust feed me the right food, play with me, and take me for walks! ");
            Console.WriteLine();
            Console.WriteLine(" /)_/)");
            Console.WriteLine();
            Console.WriteLine(" ( . .)");
            Console.WriteLine();
            Console.WriteLine("C('')('')");

        }

        }
}
