/*
* Author: Lucky Jaxxon Woods
* Date: 1/23/22
* File: Cat.cs
* Description: A C# file containing the implementation of the Cat class
*
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA1Project352
{
    public class Cat : Animal
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
         * private values of the Cat
         * 
         * Inputs:
         *   No Inputs
         *
         * Result:
         *   Prints the private values of the cat such as their name, age, noise, weight, or anything else special.
         *
         */

        public override void MakeNoise()
        {
            Console.WriteLine(callName() + ": " + callNoise() +"!");
        }
        /*
         * Description: Function that prints the 
         * noise of a cat.
         *
         * Inputs:
         *   No Inputs
         *
         * Result:
         *   Prints a cat making a noise.
         *
         */

        public override void ageUp()
        {
            updatedPet(callName(), callAge()+1, callNoise(), callWeight());

        }
       /*
        * Description: A function meant to update a cats age.
        *
        * Inputs:
        *   No Inputs
        *
        * Result:
        *   Ages the cat up by one year.
        *
        */

    }
}
