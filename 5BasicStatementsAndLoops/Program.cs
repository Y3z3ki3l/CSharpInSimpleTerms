﻿using System;
using System.Collections.Generic;

namespace _5BasicStatementsAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //CODE BLOCKS
            Console.WriteLine("-------------Code Blocks---------------");

            //In C#, a code block is a collection of lines of code bounded by curly braces {}
            {
                Console.WriteLine("Executing a code block!");
            }

            //Generally, we don't use code blocks all by themselves; most often
            //we use them as part of either selection statements or loops.

            //SELECTION STATEMENTS
            Console.WriteLine("-------------Selection Statements---------------");

            //C# includes a number of keywords designed to help us decide where
            //the code execution flow should go next.

            //For example, there's a basic IF statement.
            //Change these values to see different parts of the statement executed.
            decimal money = 6.77M;
            decimal orderTotal = 3.54M;

            if (money > orderTotal)
            {
                Console.WriteLine("Thanks for your purchase!");
            }
            else if (money == orderTotal)
            {
                Console.WriteLine("Wow! Thanks for having exact change!");
            }
            else
            {
                Console.WriteLine("Sorry, you don't have enough money.");
            }

            //We can also use a switch statement to evaluate more complex options.
            //Each possible value we want to run code for is identified
            //using the 'case' keyword, and execution of each case is ended
            //by the 'break' keyword.
            //Note that we can have multiple values execute the same code
            //by "stacking" the case statements, such as case 3 and 4 below.

            //Change this value to see different parts of the switch executed.
            var sponsorLevel = 2;

            switch (sponsorLevel)
            {
                case 1: //Gold
                    Console.WriteLine("Thanks for being a gold sponsor!");
                    break; //End code for case 1

                case 2: //Silver
                    Console.WriteLine("Thanks for being a silver sponsor!");
                    break; //End code for case 2

                case 3: //Bronze Level 2
                case 4: //Bronze Level 1
                    Console.WriteLine("Thank you for being a bronze sponsor!");
                    break; //End code for case 3

                default: //All others
                    Console.WriteLine("Thank you for sponsoring us!");
                    Console.WriteLine("Would you like to upgrade to a bronze sponsorship?");
                    break; //End code for default case
            }

            //If we need a concrete value instead of executing code, we can use
            //a switch statement.
            //The enums CardColor and CardType are defined in the Enums.cs file in this project.

            //Change this value to output different colors.
            var cardType = CardType.Economic; 

            var cardColor = cardType switch //Switch expression
            {
                CardType.NaturalResource => CardColor.Brown,
                CardType.ManufacturedResource => CardColor.Grey,
                CardType.Cultural => CardColor.Blue,
                CardType.Science => CardColor.Green,
                CardType.Economic => CardColor.Yellow,
                CardType.Military => CardColor.Red,
                CardType.Guilds => CardColor.Purple,
                _ => throw new NotImplementedException() //Default case
            };

            Console.WriteLine($"The selected card color is {cardColor}");

            //LOOPS
            Console.WriteLine("-------------Loops---------------");

            //Loops are code blocks that are executed multiple times in a row.
            //There are four ways to implement a loop.

            //FOR LOOPS
            Console.WriteLine("-------------for loop---------------");

            //A basic FOR loop has three parts:
            //1. An initializer variable
            //2. A boundary condition
            //3. An increment

            for (int i = 0; /* initializer */
                 i < 10; /* boundary condition */
                 i++ /*increment*/)
            {
                Console.WriteLine("You will see this line ten times.");
            }

            //We can also use increments of values other than 1
            for (int i = 0; i < 10; i += 2)
            {
                Console.WriteLine("You will see this line five times.");
            }

            //FOREACH LOOP
            Console.WriteLine("-------------foreach Loop---------------");

            //When dealing with collections of objects (see project 13ArraysAndCollections)
            //we can execute some code against each item in a collection using a foreach loop.
            var items = new int[] { 4, 5, 6, 7, 8 };
            foreach (var item in items) //item is an int
            {
                Console.WriteLine(item);
            }

            //Drawing class defined in Drawing.cs
            List<Drawing> drawings = new List<Drawing>() 
            {
                new Drawing()
                {
                    Name = "Test Drawing 1"
                },
                new Drawing()
                {
                    Name = "Test Drawing 2"
                }
            };

            foreach (Drawing iterator in drawings)
            {
                Console.WriteLine(iterator.Name);
            }

            //WHILE LOOP
            Console.WriteLine("-------------while Loop---------------");

            //A while loop evaluates a condition, and so long as that condition
            //is true, it will continue executing the code in the loop.
            int myVal = 5;
            while (myVal < 1000)
            {
                myVal = myVal + 2;
                //Uncomment this line to see each iteration of this loop.
                //Console.WriteLine(myVal);
            }

            //Uncomment the below lines to get a loop which never ends.
            //myVal = 5;
            //while (myVal < 1000)
            //{
            //    //We didn't increment myVal, so this loop will never end!
            //}

            //DO WHILE LOOP
            Console.WriteLine("-------------do while Loop---------------");

            //A do-while loop will always execute at least once, because
            //the condition is evaluated at the *end* of the loop
            myVal = 5;
            do
            {
                myVal++;
                //Uncomment the below line to see each iteration of this loop.
                //Console.WriteLine(myVal);
            } while (myVal < 1000);

            //BREAKING THE LOOP
            Console.WriteLine("-------------Breaking the Loop---------------");

            //BREAK
            Console.WriteLine("-------------break---------------");

            //The keyword 'break' will end the loop and no further iterations will be executed.
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("The current value of i is " + i.ToString());
                if (i == 7)
                {
                    Console.WriteLine("For loop was broken here!");
                    break; //Will exit the for loop
                }
            }

            //CONTINUE
            Console.WriteLine("-------------continue---------------");

            //The continue keyword will stop the current iteration of the loop,
            //but execution will resume at the next iteration.
            myVal = 5;
            while (myVal < 10)
            {
                if (myVal == 7)
                {
                    Console.WriteLine("Continue was executed here!");
                    myVal++;
                    continue; //If i == 7, processing stops here and resumes
                              //at the top of the loop with the next value 701.
                              //DoSomething is never called in that case.
                }
                //The below output will not happen when myVal = 7
                Console.WriteLine("The current value of myVal is " + myVal.ToString());
                myVal++;
            }

            //RETURN
            Console.WriteLine("-------------return---------------");

            //The return keyword stops execution of the loop and will return a value
            //to the calling code.
            //See the Email.cs file for the implementation of the method below, which includes a loop.

            var email = Email.GetEmail();
            Console.WriteLine(email);
        }
    }
}
