/*  Program Name:  BodyMassIndex
 *  Program Author: Matthew Bate
 *  Date:           January 31, 2018
 *  
 *  Description:    A program to calculate a person's body mass index based on user input.  In this
 *                  version additional validation will be taking place as outlined in the Plan Read Me File.
 *                  The concept of the if statements within this application is to valid for errors and if true
 *                  error then it will provide the error statement and then skip to end of nested if statements.
 *                  This allows for errors to be displayed in order of them happening rather than bunching them 
 *                  at the end of the code and tracking the else statements.
 *  Modified By:    Matthew Bate
 *  Modified Date:  2/26/2018
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
            double userInput;                                       // User Input Variable
            string userCategory;                                    // User Weight Classification    
            double height;                                          // Height of Person (lbs)
            double mass;                                            // Weight of Person (inches)
            double bodyMassIndex;                                   // BodyMassIndex Result of Math Calculation
            const int conversionFactor = 703;                       // Conversion Factor

            /* Requesting Information From User
             */
            // Output Request for Information from User
            Console.Write("Please enter the person's height in inches: ");
            // Parse Height into Double Variable and Validate userInput
            if (!Double.TryParse(Console.ReadLine(), out userInput) || (userInput < 5) || (userInput > 120)) {
                // Error Processing / Validating userInput
                Console.WriteLine("\nEntry Error. \n\nThe height entered must be a valid number between 5\" and 120\" inclusive.");
            } else {
                // Save and Continue to Next Question
                height = userInput;                                 // Save userInput as Height
                // Output Request for Information from User
                Console.Write("Please enter the person's weight in pounds: ");
                // Parse Weight into Double Variable and Validate userInput
                if (!Double.TryParse(Console.ReadLine(), out userInput) || (userInput < 0.5) || (userInput > 999)) {
                    Console.WriteLine("\nEntry Error. \n\nThe weight entered must be a valid number between 0.5 lbs and 999 lbs inclusive.");
                } else {
                    // Save and Continue to Processing BodyMassIndex Math
                    mass = userInput;
                    // Do the Math! Also round to 1 decimal place.
                    bodyMassIndex = Math.Round((mass / Math.Pow(height, 2) * conversionFactor), 1);
                    // Determine Weight Classification
                    if (bodyMassIndex < 16) { userCategory = "severely underweight"; }          // Less than 16
                    else if (bodyMassIndex < 18.5) { userCategory = "underweight"; }            // 16 up to but less than 18.5
                    else if (bodyMassIndex < 25) { userCategory = "healthy"; }                  // 18.5 up to but less than 25
                    else if (bodyMassIndex < 30) { userCategory = "overweight"; }               // 25 up to but less than 30
                    else { userCategory = "obese"; }                                            // 30 and above
                    // Output Results of Calculations
                    Console.WriteLine("\nThe BMI for a {0:n1}\" tall person who weighs {1:n1} lb. is {2:n1}, which is categorized as “{3}”.", height, mass, bodyMassIndex, userCategory);
                }
            }
            //(Write)(\n)Press any key to end this application...(ReadKey)
            Console.Write("\nPress any key to end this application...");
            Console.ReadKey();                                                      // Hold for User

        } // Main
    } // Program
}// BodyMassIndex
