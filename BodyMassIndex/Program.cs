/*  /Program Name:  BodyMassIndex
 *  Program Author: Matthew Bate
 *  Date:           January 31, 2018
 *  
 *  Description:    A program to calculate a person's body mass index based on user input.
 *  Modified By:    Matthew Bate
 *  Modified Date:  2/19/2008
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyMassIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Defining Required Variables
             */
            double  height;                                         // Height of Person (lbs)
            double  mass;                                           // Weight of Person (inches)
            double  bodyMassIndex;                                  // BodyMassIndex Result of Math Calculation
            const int conversionFactor = 703;                       // Conversion Factor

            /* Requesting Information From User
             */
            Console.Write("Please enter the person's height in inches: ");          // Output Request for Information
            Double.TryParse(Console.ReadLine(), out height);                        // Parse Height into Double Variable
            Console.Write("Please enter the person's weight in pounds: ");          // Output Request for Information
            Double.TryParse(Console.ReadLine(), out mass);                          // Parse Height into Double Variable

            /* Processing Information For User
            */
            bodyMassIndex = (mass / Math.Pow(height, 2)) * conversionFactor;        // The Math Processed

            /* Output Information For User
             */
            // (WriteLine)(\n)The BMI for a (67.5).toString("n1")" tall person who weighs (173.0).toString("n1") lb. is (26.7).toString("n1")
            Console.WriteLine("\nThe BMI for a {0:n1}\" tall person who weighs {1:n1} lb. is {2:n1}", height, mass, bodyMassIndex);

            //(Write)(\n)Press any key to end this application...(ReadKey)
            Console.Write("\nPress any key to end this application...");
            Console.ReadKey();                                                      // Hold for User

        } // Main
    } // Program
}// BodyMassIndex
