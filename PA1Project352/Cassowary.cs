/*
* Author: Lucky Jaxxon Woods
* Date: 1/23/22
* File: Cassowary.cs
* Description: A C# file containing the implementation of the Cassowary class
*
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA1Project352
{
    public class Cassowary : Animal
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
         * private values of the Cassowary
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
         * noise of a Cassowary.
         *
         * Inputs:
         *   No Inputs
         *
         * Result:
         *   Prints a Cassowary making a noise.
         *
         */

        public override void ageUp()
        {
            updatedPet(callName(), callAge() + 1, callNoise(), callWeight());

        }
        /*
         * Description: A function meant to update a Cassowary's age.
         *
         * Inputs:
         *   No Inputs
         *
         * Result:
         *   Ages the Cassowary up by one year.
         *
         */
    }
}
