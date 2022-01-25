/*
* Author: Lucky Jaxxon Woods
* Date: 1/23/22
* File: World.cs
* Description: A C# file containing the implementation of the main driver
*
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA1Project352
{
     class World
    {
        static void Main(string[] args)
        {
            //Names off what we will be refering to each animal as.
            Animal A = new Cat();
            Animal C = new Cassowary();
            Animal S = new Shark();

            //Used to help with the loop
            int aniList = 0;

            while (aniList != 13)
            {
                //List of all of the possible numbers to enter.
                Console.WriteLine("Please enter which command you want to do:");
                Console.WriteLine("Enter 1 to print the Cat's information.");
                Console.WriteLine("Enter 2 to update the Cat's information.");
                Console.WriteLine("Enter 3 to make the Cat's Noise.");
                Console.WriteLine("Enter 4 to make a Cat's older");

                Console.WriteLine("Enter 5 to print the Cassowary's information.");
                Console.WriteLine("Enter 6 to update the Cassowary's information.");
                Console.WriteLine("Enter 7 to make the Cassowary's Noise.");
                Console.WriteLine("Enter 8 to make a Cassowary's older");

                Console.WriteLine("Enter 9 to print the Shark's information.");
                Console.WriteLine("Enter 10 to update the Shark's information.");
                Console.WriteLine("Enter 11 to make the Shark's Noise.");
                Console.WriteLine("Enter 12 to make a Shark's older");
                Console.WriteLine("Enter 13 to end the program");

                Console.WriteLine(" ");
                Console.WriteLine("Enter here:");
                string loopNum = Console.ReadLine();
                aniList = int.Parse(loopNum);
                Console.WriteLine(" ");

                //The info of each animal
                if (aniList == 1)
                {
                    A.PrintInfo();
                    Console.WriteLine(" ");
                }
                else if (aniList == 5)
                {
                    C.PrintInfo();
                    Console.WriteLine(" ");
                }
                else if (aniList == 9)
                {
                    S.PrintInfo();
                    Console.WriteLine(" ");
                }

                //Updating each animal info.
                else if (aniList == 2 || aniList == 6 || aniList == 10)
                {
                    //Asks user the new names, ages, noises, and weights.
                    Console.WriteLine("New Name");
                    string newName = Console.ReadLine();

                    Console.WriteLine("New age");
                    string ageConvert = Console.ReadLine();
                    double newAge = double.Parse(ageConvert);

                    Console.WriteLine("New Noise");
                    string newNoise = Console.ReadLine();

                    Console.WriteLine("New weight");
                    string weightConvert = Console.ReadLine();
                    double newWeight = double.Parse(weightConvert);
                    Console.WriteLine(" ");

                    //Updates each animal dependent on which one was picked
                    if (aniList == 2)
                    {
                        A.updatedPet(newName, newAge, newNoise, newWeight);
                    }

                    if (aniList == 6)
                    {
                        C.updatedPet(newName, newAge, newNoise, newWeight);
                    }

                    if (aniList == 10)
                    {
                        S.updatedPet(newName, newAge, newNoise, newWeight);
                    }


                }

                //an animal makes a noise
                else if (aniList == 3)
                {
                    A.MakeNoise();
                    Console.WriteLine(" ");
                }
                else if (aniList == 7)
                {
                    C.MakeNoise();
                    Console.WriteLine(" ");
                }
                else if (aniList == 11)
                {
                    S.MakeNoise();
                    Console.WriteLine(" ");
                }

                //Ages animal up by one
                else if (aniList == 4)
                {
                    A.ageUp();
                    Console.WriteLine(" ");
                }
                else if (aniList == 8)
                {
                    C.ageUp();
                    Console.WriteLine(" ");
                }
                else if (aniList == 12)
                {
                    S.ageUp();
                    Console.WriteLine(" ");
                }


            }
            //end of loop.
        }
    }

}
