using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopyPlanetsbyPaulVChow
{
    class LoopyPlanets
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed; // Just changes the colour of the text to dark red because dark red is a cool colour :D
            double jupiter = 2.64;
            double mars = 0.38;
            double mercury = 0.37;
            double neptune = 1.12;
            double pluto = 0.04;
            double saturn = 1.15;
            double uranus = 1.15;
            double venus = 0.88;
            double weight;
            uint z;

        //I Decided to put all the variables in the beginning to make it easier on myself

        beginning: // The beginning of the code. Later on it will return here if they decide to calculate another value
            {
                Console.Clear(); // clears the console for when they decide to calculate another value

                Console.WriteLine("\n             Menu of Planets");  // Menu options
                Console.WriteLine("             ==== == =======");
                Console.WriteLine("1. Jupiter" + "        " + "2. Mars" + "        " + "3. Mercury");
                Console.WriteLine("4. Neptune" + "        " + "5. Pluto" + "       " + "6. Saturn");
                Console.WriteLine("7. Uranus" + "         " + "8. Venus" + "       " + "9. <Quit>");
                Console.WriteLine("\n");
                Console.WriteLine("Enter your menu choice:");


                originalq:
                while (!uint.TryParse(Console.ReadLine(), out z)) //Only allows positive numeric values

                {
                    Console.WriteLine("Enter your menu choice (1-9): "); //Written when they try to enter something other than a numeric value
                }

                while (z > 9)

                {
                    Console.WriteLine("Enter your menu choice (1-9): "); //Written when they try to enter something other than a numeric value
                    goto originalq;
                }

                while (z == 9) //If they choose 9 this will close it after 2 seconds

                {
                    Console.WriteLine("Have a great day! Goodbye!");
                    System.Threading.Thread.Sleep(1000);
                   Environment.Exit(0);                                
                }

                while (z == 0) //If they choose 0 it will ask them to enter the menu choice

                {
                    Console.WriteLine("Enter your menu choice (1-9): "); //Written when they try to enter something other than a numeric value
                    goto originalq;
                }

                //otherwise the console will ask for their weight on Earth
                {
                    secondq: //this is where "goto secondq;" leads
                    Console.WriteLine("Please enter your weight on Earth:");

                    while (!Double.TryParse(Console.ReadLine(), out weight))
                    {
                        Console.WriteLine("Please enter a numeric value: ");
                    }

                    while (weight < 0) //If they choose a number less than 0 it will ask them to enter their weight on earth again

                    {
                        goto secondq;
                    }

                    while (weight == -0) //If they choose -0 it will ask them to enter their weight on earth again

                    {
                        goto secondq;
                    }



                    switch (z) //Depending on what number they selected during the menu screen a different case will be run
                                //EX: They choose 1, case 1 will be run


                    {
                        case 1:
                            Console.WriteLine("\n///////////////////////");
                            Console.WriteLine("// Weight on Jupiter //");
                            Console.WriteLine("///////////////////////");
                            Console.WriteLine("Your weight of " + weight + " pounds on Earth would be " + (weight * jupiter).ToString("0.#") + " pounds on Jupiter");
                        // This displays the users weight on the planet they have selected and the "ToString("0.#")" rounds it to one decimal

                        termination: //this is a set of termination instructions that each case goes to
                            Console.WriteLine("\nPress X to terminate, or R to calculate another value..");
                            string qr = Console.ReadLine();
                            if (qr.ToUpper() == "R")
                            {
                                goto beginning; // if they hit the R key it will go to the beginning of the code
                            }

                            else if (qr.ToUpper() == "X") //If they hit the X key it will close
                            {
                                Console.WriteLine("Have a great day! Goodbye!");
                                System.Threading.Thread.Sleep(1000); //Allows the user to see the message for 1 second before it closes
                                Environment.Exit(0);
                            }

                            else
                            {
                                Console.WriteLine("\nInvalid input, please try again..");
                                goto termination; //this will go to the set of instructions once more

                            }

                            //After it displays the weight of the user on said planet it will ask them if they would like to continue or terminate
                            



                            break;
                        case 2:
                            Console.WriteLine("\n///////////////////////");
                            Console.WriteLine("// Weight on Mars//");
                            Console.WriteLine("///////////////////////");
                            Console.WriteLine("Your weight of " + weight + " pounds on Earth would be " + (weight * mars).ToString("0.#") + " pounds on Mars");
                            // This displays the users weight on the planet they have selected and the "ToString("0.#")" rounds it to one decimal

                            {
                                goto termination; //this will go to a set to the termination instructions

                            }



                        case 3:
                            Console.WriteLine("\n///////////////////////");
                            Console.WriteLine("// Weight on Mercury //");
                            Console.WriteLine("///////////////////////");
                            Console.WriteLine("Your weight of " + weight + " pounds on Earth would be " + (weight * mercury).ToString("0.#") + " pounds on Mercury");
                            // This displays the users weight on the planet they have selected and the "ToString("0.#")" rounds it to one decimal

                            {
                                goto termination; //this will go to a set to the termination instructions

                            }

                        case 4:
                            Console.WriteLine("\n///////////////////////");
                            Console.WriteLine("// Weight on Neptune //");
                            Console.WriteLine("///////////////////////");
                            Console.WriteLine("Your weight of " + weight + " pounds on Earth would be " + (weight * neptune).ToString("0.#") + " pounds on Neptune");
                            // This displays the users weight on the planet they have selected and the "ToString("0.#")" rounds it to one decimal

                            {
                                goto termination; //this will go to a set to the termination instructions

                            }
                        case 5:
                            Console.WriteLine("\n///////////////////////");
                            Console.WriteLine("// Weight on Pluto //");
                            Console.WriteLine("///////////////////////");
                            Console.WriteLine("Your weight of " + weight + " pounds on Earth would be " + (weight * pluto).ToString("0.#") + " pounds on Pluto");
                            // This displays the users weight on the planet they have selected and the "ToString("0.#")" rounds it to one decimal

                            {
                                goto termination; //this will go to a set to the termination instructions

                            }
                        case 6:
                            Console.WriteLine("\n///////////////////////");
                            Console.WriteLine("// Weight on Saturn //");
                            Console.WriteLine("///////////////////////");
                            Console.WriteLine("Your weight of " + weight + " pounds on Earth would be " + (weight * saturn).ToString("0.#") + " pounds on Saturn");
                            // This displays the users weight on the planet they have selected and the "ToString("0.#")" rounds it to one decimal

                            {
                                goto termination; //this will go to a set to the termination instructions

                            }
                        case 7:
                            Console.WriteLine("\n///////////////////////");
                            Console.WriteLine("// Weight on Uranus //");
                            Console.WriteLine("///////////////////////");
                            Console.WriteLine("Your weight of " + weight + " pounds on Earth would be " + (weight * uranus).ToString("0.#") + " pounds on Uranus");
                            // This displays the users weight on the planet they have selected and the "ToString("0.#")" rounds it to one decimal

                            {
                                goto termination; //this will go to a set to the termination instructions

                            }
                        case 8:
                            Console.WriteLine("\n///////////////////////");
                            Console.WriteLine("// Weight on Venus //");
                            Console.WriteLine("///////////////////////");
                            Console.WriteLine("Your weight of " + weight + " pounds on Earth would be " + (weight * venus).ToString("0.#") + " pounds on Venus");
                            // This displays the users weight on the planet they have selected and the "ToString("0.#")" rounds it to one decimal

                            {
                                goto termination; //this will go to a set to the termination instructions

                            }

                    }
                    
                }
            }
        }
    }
}