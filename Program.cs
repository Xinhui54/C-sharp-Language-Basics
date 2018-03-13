using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public const byte sample1 = 0x3A;
        byte sample2 = 58;
        int heartRate = 85;
        double deposits = 135002796;
        public const float acceleration = 9.800F;
        float mass = 14.6F;
        double distance = 129.763001;
        bool lost = true;
        bool expensive = true;
        int choice = 2;
        public const char integral = '\u222B';
        public const String greeting = "Hello";
        String name = "Karen";

        float force = 0;

        private void sampleCompare()
        {
            if (sample1 == sample2)
                Console.WriteLine("The samples are equal.");
            else
                Console.WriteLine("The samples are not equal.");
        }

        private void judgeHeartRate()
        {
            if(heartRate >= 40 && heartRate <= 80)
                Console.WriteLine("Heart rate is normal.");
            else
                Console.WriteLine("Heart rate is not normal.");
        }

        private void judgeDeposits()
        {
            if (deposits >= 100000000)
                Console.WriteLine("You are exceedingly wealthy.");
            else
                Console.WriteLine("Sorry you are so poor.");
        }

        private float getForce()
        {
            return mass * acceleration;
        }

        private void displayForce(float force)
        {
            Console.WriteLine("force = " + force);
        }

        private void displayDistance()
        {
            Console.WriteLine(this.distance + " is the distance.");
        }

        private void lostAndExpensive()
        {
            if (this.lost && this.expensive)
                Console.WriteLine("I am really sorry! I will get the manager.");
            else if (this.lost && !this.expensive)
                Console.WriteLine("Here is coupon for 10% off.");
        }

        private void displayChoice()
        {
            switch(this.choice)
            {
                case 1:
                    Console.WriteLine("You chose 1.");
                    break;
                case 2:
                    Console.WriteLine("You chose 2.");
                    break;
                case 3:
                    Console.WriteLine("You chose 3.");
                    break;
                default:
                    Console.WriteLine("You made an unknown choice.");
                    break;
            }
        }

        private void displayIntegrale()
        {
            Console.WriteLine(integral + " is an integral.");
        }

        private void displayInteger(int start, int end)
        {
            for(int i = start; i <= end; i++)
                Console.WriteLine("i = " + i);
        }
        private void displayAge()
        {
            int age = 0;
            while (age < 6)
            {
                Console.WriteLine("age = " + age);
                age++;
            }
        }
        private void displayName()
        {
            Console.WriteLine(greeting + ' ' + name);
        }


        static void Main(string[] args)
        {
            Program program = new Program();
            program.sampleCompare();
            program.judgeHeartRate();
            program.judgeDeposits();
            float force = program.getForce();
            program.displayForce(force);
            program.displayDistance();
            program.lostAndExpensive();
            program.displayChoice();
            program.displayIntegrale();
            program.displayInteger(5, 10);
            program.displayAge();
            program.displayName();


            Console.ReadLine();
        }

    }
}
