/*
* Author: Lucky Jaxxon Woods
* Date: 1/23/22
* File: Animal.cs
* Description: A C# file containing the implementation of the abstract Animal class
*
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA1Project352
{
    public abstract class Animal
    {

        private string aniName; //this should be a private variable, stating the name for the animals
        private double aniAge; //this should be a private variable, stating the age for the animals
        private string aniNoise; //this should be a private variable, stating the noise for the animals
        private double aniWeight; //this should be a private variable, stating the weight for the animals

        public Animal(){
            aniName = "Frank"; //name value set.
            aniAge = 2.0; //age value set.
            aniNoise = "Wof!"; //happyNoise value set.
            aniWeight = 3.75; //attackNoise value set.

        }

        public void updatedPet(string n, double o, string p, double q){
            aniName = n; //name value set changed.
            aniAge = o; //age value set changed.
            aniNoise = p; //happyNoise value set changed.
            aniWeight = q; //attackNoise value set changed.
        }
        
        public string callName()
        {
            return aniName; //Used to give the child classes their name.
        }

        public double callAge()
        {
            return aniAge; //Used to give the child classes their age.
        }

        public string callNoise()
        {
            return aniNoise; //Used to give the child classes their noise.
        }

        public double callWeight()
        {
            return aniWeight; //Used to give the child classes their weight.
        }

        public abstract void PrintInfo();
        /*
         * Description:this should be accessible by any of its children. It print the 
         * private values of the Animals
         * 
         * Inputs:
         *   No Inputs
         *
         * Result:
         *   Prints the private values of the animals such as their name, age, noise, weight, or anything else special.
         *
         */

        public abstract void MakeNoise();
        /*
         * Description: this should be accessible by any of its children. It prints the 
         * noise of an animal.
         *
         * Inputs:
         *   No Inputs
         *
         * Result:
         *   Prints an animal making a noise.
         *
         */

        public abstract void ageUp();
        /*
         * Description: this should be accessible by any of its children. It is the base ageUp(), which is meant to update an animals age.
         *
         * Inputs:
         *   No Inputs
         *
         * Result:
         *   Ages the animal up by one year.
         *
         */

    }
}
