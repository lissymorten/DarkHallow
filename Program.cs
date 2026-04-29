using System;

namespace DarkHallow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;

            while (playAgain)
            {
                bool playerDied = false;

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
                    Console.WriteLine("\nYou step beneath the canopy. The forest hums with quiet life.");

                    string forestAdventure;
                    do
                    {
                        Console.WriteLine("\nWould you like to take the left path or the right path? RIGHT or LEFT\n");
                        forestAdventure = Console.ReadLine().ToLower();
                    } while (forestAdventure != "right" && forestAdventure != "left");

                    // Right forest path 
                    if (forestAdventure == "right")
                    {
                        Console.WriteLine("\nThe forest grows denser as you walk. You see an opening in the roots of a gigantic tree.");

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

                        Console.WriteLine("\nYou walk over to the tree and peer into the opening to see a stone staircase descending into the ground.");
                        string enterOpening;
                        do
                        {
                            Console.WriteLine("Do you enter the opening? YES or NO");
                            enterOpening = Console.ReadLine().ToLower();
                        } while (enterOpening != "yes" && enterOpening != "no");

                        if (enterOpening == "no")
                        {
                            Console.WriteLine("\nIt's getting dark. You set up camp for the night.");
                            break;
                        }

                        Console.WriteLine("\nYou walk down the staircase. There is a crown on a pedestal in the middle of a dimly lit room.");
                        string approachCrown;
                        do
                        {
                            Console.WriteLine("The crown seems to be calling you. Do you approach it? YES or NO");
                            approachCrown = Console.ReadLine().ToLower();
                        } while (approachCrown != "yes" && approachCrown != "no");

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
                                Console.WriteLine("\nYou choke and die.");
                                playerDied = true;
                                break;
                            }
                        }

                        if (approachCrown == "no")
                        {
                            Console.WriteLine("\nYou resist the pull of the crown and leave the chamber.");
                            Console.WriteLine("You return to the forest and set up camp outside the tree.");
                            break;
                        }
                    }

                    // Left forest path 
                    if (forestAdventure == "left")
                    {
                        Console.WriteLine("\nThe air grows lighter. You hear water nearby.");

                        string dryadConvo;
                        do
                        {
                            Console.WriteLine("\nYou come across a dryad bathing in a stream.");
                            Console.WriteLine("Do you greet the dryad? YES or NO\n");
                            dryadConvo = Console.ReadLine().ToLower();
                        } while (dryadConvo != "yes" && dryadConvo != "no");

                        if (dryadConvo == "yes")
                        {
                            Console.WriteLine("\nThe dryad turns to you and speaks:\n");
                            Console.WriteLine("\"I whisper in the rustling leaves,\nI dance upon the rolling seas.\nI paint the sky with dawn’s first light,\nAnd fill the world with sounds of life.\nWhat am I?\"");
                            string dryadRiddle = Console.ReadLine().ToLower();

                            if (dryadRiddle == "nature")
                            {
                                Console.WriteLine("\nThe dryad smiles and grants you the blessing of the forest.");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("\nBranches grow from your skin and you turn into a tree.");
                                playerDied = true;
                                break;
                            }
                        }

                        if (dryadConvo == "no")
                        {
                            Console.WriteLine("\nYou quietly pass by, choosing not to disturb the spirit.");
                            Console.WriteLine("You continue down the path until you tire and set up camp.");
                            break;
                        }
                    }
                }

                // Field entry
                while (userInput == "field")
                {
                    Console.WriteLine("\nYou walk into the open field. The wind brushes against the tall grass.");

                    string fieldAdventure;
                    do
                    {
                        Console.WriteLine("\nWould you like to investigate the building or explore the trail? BUILDING or TRAIL\n");
                        fieldAdventure = Console.ReadLine().ToLower();
                    } while (fieldAdventure != "building" && fieldAdventure != "trail");

                    if (fieldAdventure == "building")
                    {
                        Console.WriteLine("\nThe structure looms ahead, old and forgotten.");

                        string mausoleumAdventure;
                        do
                        {
                            Console.WriteLine("\nYou approach the building. It is an old mausoleum. The door is ajar. Do you enter? YES or NO");
                            mausoleumAdventure = Console.ReadLine().ToLower();
                        } while (mausoleumAdventure != "yes" && mausoleumAdventure != "no");

                        if (mausoleumAdventure == "no")
                        {
                            Console.WriteLine("\nIt's getting dark. You decide to lay in the grass and stare up at the sky.");
                            break;
                        }

                        Console.WriteLine("\nYou enter the mausoleum. There is a large stone chest in the middle of the room.");

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

                            if (riddleAnswer == "death")
                            {
                                Console.WriteLine("\nThe chest opens to reveal a magnificent treasure beyond your wildest dreams.");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("\nYou die.");
                                playerDied = true;
                                break;
                            }
                        }

                        if (openChest == "no")
                        {
                            Console.WriteLine("\nYou decide to leave the mausoleum and set up camp for the night.");
                            break;
                        }
                    }

                    // TRAIL (UPDATED LOVE RIDDLE VERSION)
                    if (fieldAdventure == "trail")
                    {
                        Console.WriteLine("\nYou follow the trail along the hillside.");
                        Console.WriteLine("The wind grows colder as the sun begins to fade behind the hills.");

                        Console.WriteLine("\nAfter some time, you notice something half-buried near the path...");

                        string trailObject;
                        do
                        {
                            Console.WriteLine("\nDo you investigate the object or continue walking? INVESTIGATE or CONTINUE");
                            trailObject = Console.ReadLine().ToLower();
                        } while (trailObject != "investigate" && trailObject != "continue");

                        if (trailObject == "continue")
                        {
                            Console.WriteLine("\nYou choose not to linger.");
                            Console.WriteLine("The trail eventually fades, and you find a safe place to rest for the night.");
                            break;
                        }

                        Console.WriteLine("\nYou kneel beside the object and brush away the dirt.");
                        Console.WriteLine("It is an old stone lantern, worn but intact.");

                        string lanternChoice;
                        do
                        {
                            Console.WriteLine("\nDo you touch the lantern? YES or NO");
                            lanternChoice = Console.ReadLine().ToLower();
                        } while (lanternChoice != "yes" && lanternChoice != "no");

                        if (lanternChoice == "no")
                        {
                            Console.WriteLine("\nYou leave the lantern untouched and continue down the trail.");
                            Console.WriteLine("Eventually, you find a quiet place to rest for the night.");
                            break;
                        }

                        Console.WriteLine("\nThe lantern flickers and a voice whispers:");
                        Console.WriteLine("\"I am born in a glance, grow in silence, and can outlive time itself. What am I?\"");

                        string lanternRiddle = Console.ReadLine().ToLower();

                        if (lanternRiddle == "love")
                        {
                            Console.WriteLine("\nThe lantern glows warmly, as if something unseen has awakened.");
                            Console.WriteLine("The path ahead feels strangely gentle, and you find a safe place to rest for the night.");
                        }
                        else
                        {
                            Console.WriteLine("\nThe lantern dims.");
                            Console.WriteLine("You feel uncertain, but continue on and eventually find a place to rest for the night.");
                        }

                        break;
                    }
                }

                // END STATE
                Console.WriteLine("\n==============================");

                if (playerDied)
                {
                    Console.WriteLine("YOU DIED");
                }
                else
                {
                    Console.WriteLine("YOU SURVIVED");
                }

                Console.WriteLine("==============================\n");

                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();

                Console.WriteLine("Would you like to play again? YES or NO");
                string restart = Console.ReadLine().ToLower();

                if (restart != "yes")
                {
                    playAgain = false;
                }

                Console.Clear();
            }
        }
    }
}