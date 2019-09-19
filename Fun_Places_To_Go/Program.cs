using System;

// This program is meant to find places for you and possibly your friends to have fun.
// It also is meant to determine what transportation you should use.

namespace Fun_Places_To_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setting up the variables
            bool checkNum = false;
            string activity = "";
            string people = "";
            int activityInt = 0;
            int peopleInt = 0;
            string activityStr = "";
            string peopleStr = "";

            // The first question, there is a while loop so that if they put the wrong answer it can be repeated
            while (checkNum == false)
            {
                Console.WriteLine("Hello there, what kind of activity are you looking for?\n" +
                                  "Please look at the options below and type a number to pick that activity: \n" +
                                  "1) Fast Food\n" +
                                  "2) Casual Dining Experience\n" +
                                  "3) Chilling\n" +
                                  "4) Intense\n" +
                                  "5) On the Water\n" +
                                  "6) Competitive\n" +
                                  "7) Watching\n" +
                                  "8) Exciting\n");
                activity = Console.ReadLine();
                activityInt = int.Parse(activity);
                if (1 <= activityInt && activityInt <= 8)
                {
                    checkNum = true;
                }
                else
                {
                    Console.WriteLine("\nPlease enter a number that exists within the range given.\n");
                    checkNum = false;
                    continue;
                }
            }

            // Resets the check
            checkNum = false;

            // The second question with a while loop for the same reason as the first question
            while (checkNum == false)
            {
                Console.WriteLine("\nHow many people are going with you?\n");
                people = Console.ReadLine();
                peopleInt = int.Parse(people);
                if (0 <= peopleInt)
                {
                    checkNum = true;
                }
                else
                {
                    Console.WriteLine("\nPlease enter a number that exists within the range given.");
                    checkNum = false;
                    continue;
                }
            }

            // The first switch statement for the first question detailing the places you could be going
            switch (activityInt)
            {
                case 1:
                    activityStr = "If you're in for a quick meal, then go to Taco Bell ";
                    break;
                case 2:
                    activityStr = "A pretty great casual dining experience is at Buffalo Wild Wings ";
                    break;
                case 3:
                    activityStr = "If you want to chill, then it might be a great idea to go camping ";
                    break;
                case 4:
                    activityStr = "An intense activity can be found in playing capture the flag ";
                    break;
                case 5:
                    activityStr = "If you want to do something on the water, then maybe you should go kayaking ";
                    break;
                case 6:
                    activityStr = "A fun competitive game is mini-golf ";
                    break;
                case 7:
                    activityStr = "A good place to watch things is the movies ";
                    break;
                case 8:
                    activityStr = "Okay if you want to do something exciting, then you could go to an Amusement Park ";
                    break;
                default:
                    break;
            }

            // These if statements are for the second question detailing the method of transportation
            if (peopleInt == 0)
            {
                peopleStr = "walk there.";
            }
            else if (peopleInt < 5)
            {
                peopleStr = "take a car with your friends.";
            }
            else if (peopleInt < 8)
            {
                peopleStr = "take a large van to fit everyone.";
            }
            else
            {
                peopleStr = "find commercial transportation.";
            }
            Console.WriteLine("\n{0}and you should {1}", activityStr, peopleStr);
            Console.WriteLine("Have a good time.");
        }
    }
}
