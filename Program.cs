using System;

namespace DarkHallow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Introduction to the game
            Console.WriteLine("Welcome to Darkhallow.\n\n");
            Console.WriteLine("You find yourself in an open field at the edge of a forest...");

            // Field or forest
            string userInput;
            do
            {
                Console.WriteLine("Would you like to go further into the field or enter the forest? FIELD or FOREST\n");
                userInput = Console.ReadLine().ToLower();
            } while (userInput != "field" && userInput != "forest");

            // Forest entry
            while (userInput == "forest")
            {
                string forestAdventure;
                do
                {
                    Console.WriteLine("\nWould you like to take the left path or the right path? RIGHT or LEFT\n");
                    forestAdventure = Console.ReadLine().ToLower();
                } while (forestAdventure != "right" && forestAdventure != "left");

                // Right forest path 
                if (forestAdventure == "right")
                {
                    string forestAction;
                    do
                    {
                        Console.WriteLine("\nWould you like to investigate the opening or continue down the path? INVESTIGATE or PATH.\n");
                        forestAction = Console.ReadLine().ToLower();
                    } while (forestAction != "investigate" && forestAction != "path");

                    if (forestAction == "path")
                    {
                        Console.WriteLine("\nYou wander in the forest until you get tired and set up camp.");
                        break;
                    }

                    // Investigate opening 
                    Console.WriteLine("\nYou walk over to the tree and peer into the opening to see a stone staircase descending into the ground.");
                    string enterOpening;
                    do
                    {
                        Console.WriteLine("Do you enter the opening? YES or NO");
                        enterOpening = Console.ReadLine().ToLower();
                    } while (enterOpening != "yes" && enterOpening != "no");

                    if (enterOpening == "no")
                    {
                        Console.WriteLine("\n\nIt's getting dark. You set up camp for the night.");
                        break;
                    }

                    // Crown encounter
                    Console.WriteLine("\nYou walk down the staircase. There is a crown on a pedestal in the middle of a dimly lit room.");
                    string approachCrown;
                    do
                    {
                        Console.WriteLine("The crown seems to be calling you. Do you approach it? YES or NO");
                        approachCrown = Console.ReadLine().ToLower();
                    } while (approachCrown != "yes" && approachCrown != "no");

                    // Crown choice
                    if (approachCrown == "yes")
                    {
                        Console.WriteLine("\nYou hear a voice:\n");
                        Console.WriteLine("\"What has no beginning, end or middle, but is always present?\"");
                        string crownAnswer = Console.ReadLine().ToLower();

                        if (crownAnswer == "time")
                        {
                            Console.WriteLine("\nThe crown disappears and you are imbued with a blessing.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\n\nYou choke and die.");
                            break;
                        }

                    }
                    if (approachCrown == "no")
                    {
                        Console.WriteLine("\n\nYou leave the opening and set up camp outside the tree");
                        break;
                    }
                }

                // Left forest path 
                if (forestAdventure == "left")
                {
                    // Dryad encounter
                    string dryadConvo;
                    do
                    {
                        Console.WriteLine("\nYou come across a dryad bathing in a stream.");
                        Console.WriteLine("Do you greet the dryad? YES or NO\n");
                        dryadConvo = Console.ReadLine().ToLower();
                    } while (dryadConvo != "yes" && dryadConvo != "no");

                    // Dryad choice
                    if (dryadConvo == "yes")
                    {
                        Console.WriteLine("\nThe druid speaks:\n");
                        Console.WriteLine("\"I whisper in the rustling leaves,\nI dance upon the rolling seas.\nI paint the sky with dawn’s first light,\nAnd fill the world with sounds of life.\nWhat am I?\"");
                        string dryadRiddle = Console.ReadLine().ToLower();

                        if (dryadRiddle == "nature")
                        {
                            Console.WriteLine("\n\nThe dryad gives the blessing of the forest.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\n\nBranches grow from your skin and you turn into a tree.");
                            break;
                        }
                    }

                    if (dryadConvo == "no")
                    {
                        Console.WriteLine("You continue down the path until you tire and set up camp.");
                        break;
                    }
                }
            }

            // Field entry
            while (userInput == "field")
            {
                string fieldAdventure;
                do
                {
                    Console.WriteLine("\nWould you like to investigate the building or explore the trail? BUILDING or TRAIL\n");
                    fieldAdventure = Console.ReadLine().ToLower();
                } while (fieldAdventure != "building" && fieldAdventure != "trail");

                // Building choice
                if (fieldAdventure == "building")
                {
                    string mausoleumAdventure;
                    do
                    {
                        Console.WriteLine("\nYou approach the building. It is an old mausoleum. The door is ajar. Do you enter? YES or NO");
                        mausoleumAdventure = Console.ReadLine().ToLower();
                    } while (mausoleumAdventure != "yes" && mausoleumAdventure != "no");

                    if (mausoleumAdventure == "yes")
                    {
                        Console.WriteLine("You enter the mausoleum. There is a large stone chest in the middle of the room.");
                    }
                    if (mausoleumAdventure == "no")
                    {
                        Console.WriteLine("\n\nIt's getting dark. You decide to lay in the grass and stare up at the sky.");
                        break;
                    }

                    // Mausoleum chest
                    string openChest;
                    do
                    {
                        Console.WriteLine("\nDo you open the chest? YES or NO");
                        openChest = Console.ReadLine().ToLower();
                    } while (openChest != "yes" && openChest != "no");

                    if (openChest == "yes")
                    {
                        Console.WriteLine("\nYou hear an eerie voice coming from the walls:\n");
                        Console.WriteLine("\"I am the end of every journey, yet the start of none.\nI take kings and beggars alike, sparing no one.\nYou may fear me or embrace me, but never escape me.\nWhat am I?\"\n");
                        string riddleAnswer = Console.ReadLine().ToLower();


                        // Mausoleum riddle
                        if (riddleAnswer == "death")
                        {
                            Console.WriteLine("\nThe chest opens to reveal a magnificent treasure beyond your wildest dreams.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\n\nYou die.");
                            break;
                        }
                    }
                    if (openChest == "no")
                    {
                        Console.WriteLine("\n\nYou decide to leave the mausoleum and set up camp for the night");
                        break;
                    }
                }
                // Trail choice
                if (fieldAdventure == "trail")
                {
                    Console.WriteLine("\nYou continue down the path down the side of the hill.");
                    Console.WriteLine("You don't see anything extraordinary and resume your adventure.");
                    break;
                }
            }
        }
    }
}
