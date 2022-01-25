/*
* Author: Lucky Jaxxon Woods
* Date: 1/23/22
* File: Shark.cs
* Description: A C# file containing the implementation of the Shark class
*
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA1Project352
{
    public class Shark : Animal
    {
        public override void PrintInfo()
        {
            Console.WriteLine("Name: " + callName());
            Console.WriteLine("Age: " + callAge() + " years old");
            Console.WriteLine("Noise: " + callNoise());
            Console.WriteLine("Weight: " + callWeight() + " lbs");

        }
        /*
         * Description: Function that prints the 
         * private values of the shark
         * 
         * Inputs:
         *   No Inputs
         *
         * Result:
         *   Prints the private values of the shark such as their name, age, noise, weight, or anything else special.
         *
         */

        public override void MakeNoise()
        {
            Console.WriteLine(callName() + ": " + callNoise() + "!");
        }
        /*
         * Description: Function that prints the 
         * noise of a shark.
         *
         * Inputs:
         *   No Inputs
         *
         * Result:
         *   Prints a shark making a noise.
         *
         */

        public override void ageUp()
        {
            updatedPet(callName(), callAge() + 1, callNoise(), callWeight());

        }
        /*
         * Description: A function meant to update a sharks age.
         *
         * Inputs:
         *   No Inputs
         *
         * Result:
         *   Ages the shark up by one year.
         *
         */

    }
}
