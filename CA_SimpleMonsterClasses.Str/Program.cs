using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_SimpleMonsterClasses
{
    class Program
    {
        // **************************************************
        //
        // Title: MonsterClassesRH
        // Description: Using Classes but More Monstery. 
        // Application Type: Console
        // Author: Ryan D Hall
        // Dated Created: 11/28/18
        // Last Modified: 11/29/18
        //
        // **************************************************
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            DisplayOpeningScreen();
            DisplayMenu();
            DisplayClosingScreen();
        }

        /// <summary>
        /// instantiate and initialize sid the sea monster
        /// </summary>
        /// <param name="name">name</param>
        /// <returns>SeaMonster object</returns>
        static SeaMonster InitializeSeaMonsterSid(string name)
        {
            SeaMonster sid = new SeaMonster("Sid");

            sid.Weight = 2.5;
            sid.CanUseFreshWater = true;
            sid.CurrentEmotionalState = SeaMonster.EmotionalState.Angry;
            sid.HomeSea = "Red Sea";
            sid.NumberOfTeeth = 77;
            return sid;
        }

        /// <summary>
        /// instantiate and initialize suzy the sea monster
        /// </summary>
        /// <returns>SeaMonster object</returns>
        static SeaMonster InitializeSeaMonsterSuzy()
        {
            SeaMonster suzy = new SeaMonster();

            suzy.Name = "Suzy";
            suzy.Weight = 1.2;
            suzy.CanUseFreshWater = true;
            suzy.CurrentEmotionalState = SeaMonster.EmotionalState.Sad;
            suzy.HomeSea = "Loch Ness";
            suzy.NumberOfTeeth = 44;
            return suzy;
        }

        /// <summary>
        /// display all information about a sea monster
        /// </summary>
        /// <param name="seaMonster">SeaMonster object</param>
        static void DisplaySeaMonsterInfo(List<SeaMonster> seaMonsters)
        {
            string seaMonsterName;
            DisplayHeader("Display Sea Monster Info");

            //
            // Display List of Sea Monster Names
            //
            foreach (SeaMonster seaMonster in seaMonsters)
            {                
                Console.Write(seaMonster.Name);              
            }
            Console.WriteLine();
            Console.WriteLine("Enter Sea Monster Name");
            Console.WriteLine();
            seaMonsterName = Console.ReadLine();
            bool monsterFound = false;
            foreach (SeaMonster seaMonster in seaMonsters)
            {
                if (seaMonster.Name == seaMonsterName)
                {
                    Console.WriteLine();
                    Console.WriteLine("Name: "  + seaMonster.Name);
                    Console.WriteLine("Weight lbs: " + seaMonster.Weight);
                    Console.WriteLine("Fresh Water?: " + seaMonster.CanUseFreshWater);
                    Console.WriteLine("Current Emotion: " + seaMonster.CurrentEmotionalState);
                    Console.WriteLine("Number of Teeth: " + seaMonster.NumberOfTeeth);
                    Console.WriteLine();
                    monsterFound = true;
                    break;
                }
            }
            if (!monsterFound)
            {
                Console.WriteLine("Monster unable to be found.");
            }
            DisplayContinuePrompt();
        }

        /// <summary>
        /// update a sea monsters information
        /// </summary>
        /// <param name="seaMonster">SeaMonster object</param>
        static void DisplayDeleteSeaMonster(List<SeaMonster> seaMonsters)
        {
            string seaMonsterName;
            DisplayHeader("Delete Sea Monster Info");

            //
            // Display List of Sea Monster Names
            //
            foreach (SeaMonster seaMonster in seaMonsters)
            {
                Console.Write(seaMonster.Name);
            }
            Console.WriteLine();
            Console.Write("Enter Name of Sea Monster to Delete");
            seaMonsterName = Console.ReadLine();
            bool monsterFound = false;
            foreach (SeaMonster seaMonster in seaMonsters)
            {
                if (seaMonster.Name == seaMonsterName)
                {
                    seaMonsters.Remove(seaMonster);

                    monsterFound = true;
                    break;
                }
            }
            if (!monsterFound)
            {
                Console.WriteLine("Monster unable to be found.");
            }
            DisplayContinuePrompt();
        }

        /// <summary>
        /// display a list of all sea monsters
        /// </summary>
        /// <param name="seaMonsters">list of SeaMonster</param>
        static void DisplayAllSeaMonsters(List<SeaMonster> seaMonsters)
        {
            DisplayHeader("List of Sea Monsters");
            foreach (SeaMonster seaMonster in seaMonsters)
            {
                Console.WriteLine(seaMonster.Name);
            }
            DisplayContinuePrompt();
        }

        static void DisplayGetUpdatedSeaMonster(List<SeaMonster> seaMonsters)
        {
            string seaMonsterName;
            DisplayHeader("Update Sea Monster Info");

            //
            // Display List of Sea Monster Names
            //
            foreach (SeaMonster seaMonster in seaMonsters)
            {
                Console.Write(seaMonster.Name);
            }
            Console.WriteLine();
            Console.Write("Enter Name of Sea Monster to Update");
            seaMonsterName = Console.ReadLine();
            bool monsterFound = false;
            foreach (SeaMonster seaMonster in seaMonsters)
            {
                if (seaMonster.Name == seaMonsterName)
                {
                    seaMonsters.Remove(seaMonster);

                    monsterFound = true;
                    break;
                }
            }
            if (!monsterFound)
            {
                Console.WriteLine("Monster unable to be found.");
            }
            DisplayContinuePrompt();

            SeaMonster updatedSeaMonster = new SeaMonster();
            string uv;
            DisplayHeader("Update a Sea Monster");

            Console.WriteLine("Enter Name");
            Console.WriteLine();
            updatedSeaMonster.Name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Enter Weight");
            Console.WriteLine();
            Double.TryParse(Console.ReadLine(), out double weight);
            updatedSeaMonster.Weight = weight;
            Console.Clear();
            Console.WriteLine($"Can " + updatedSeaMonster.Name + " Live in Fresh Water? Enter Yes or No:");
            Console.WriteLine();
            uv = Console.ReadLine();
            
            if (uv.ToUpper() == "YES")
            {
                updatedSeaMonster.CanUseFreshWater = true;
            }
            else
            {
                updatedSeaMonster.CanUseFreshWater = false;
            }
            Console.Clear();
            Console.WriteLine("Enter Emotional State, Happy, Sad, or Angry:");
            Console.WriteLine();
            Enum.TryParse(Console.ReadLine(), out SeaMonster.EmotionalState emotionalstate);
            updatedSeaMonster.CurrentEmotionalState = emotionalstate;
            Console.Clear();
            Console.WriteLine("Enter Sea Monster Home Sea:");
            Console.WriteLine();
            updatedSeaMonster.HomeSea = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Enter Number of Teeth");
            Console.WriteLine();
            double.TryParse(Console.ReadLine(), out double NumberOfTeeth);
            updatedSeaMonster.NumberOfTeeth = NumberOfTeeth;

            //
            // Add Updated Sea Monster to the List
            //
            seaMonsters.Add(updatedSeaMonster);

            DisplayContinuePrompt();

        }

        /// <summary>
        /// display a screen to get a new sea monster from the user
        /// </summary>
        /// <param name="seaMonsters">list of SeaMonster</param>
        static void DisplayGetUserSeaMonster(List<SeaMonster> seaMonsters)
        {
            SeaMonster newSeaMonster = new SeaMonster();
            string uv;
            DisplayHeader("Add a Sea Monster");

            Console.WriteLine("Enter Name");
            Console.WriteLine();
            newSeaMonster.Name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Enter Weight");
            Console.WriteLine();
            Double.TryParse(Console.ReadLine(), out double weight);
            newSeaMonster.Weight = weight;
            Console.Clear();
            Console.WriteLine("Can this Monster Live in Fresh Water? Enter Yes or No:");
            Console.WriteLine();
            uv = Console.ReadLine();
            if (uv.ToUpper() == "YES")
            {
                newSeaMonster.CanUseFreshWater = true;
            }
            else
            {
                newSeaMonster.CanUseFreshWater = false;
            }
            Console.Clear();
            Console.WriteLine("Enter Emotional State, Happy, Sad, or Angry:");
            Console.WriteLine();
            Enum.TryParse(Console.ReadLine(), out SeaMonster.EmotionalState emotionalstate);
            newSeaMonster.CurrentEmotionalState = emotionalstate;
            Console.Clear();
            Console.WriteLine("Enter Sea Monster Home Sea:");
            Console.WriteLine();
            newSeaMonster.HomeSea = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Enter Number of Teeth");
            Console.WriteLine();
            double.TryParse(Console.ReadLine(), out double NumberOfTeeth);
            newSeaMonster.NumberOfTeeth = NumberOfTeeth;

            //
            // Add a New Sea Monster to the List
            //
            seaMonsters.Add(newSeaMonster);

            DisplayContinuePrompt();

        }

        /// <summary>
        /// display menu and process user menu choices
        /// </summary>
        static void DisplayMenu()
        {
            //
            // instantiate sea monsters
            //
            SeaMonster suzy;
            suzy = InitializeSeaMonsterSuzy();
            SeaMonster sid;
            sid = InitializeSeaMonsterSid("Sid");
            //
            // add sea monsters to list
            //
            List<SeaMonster> seaMonsters = new List<SeaMonster>();
            seaMonsters.Add(suzy);
            seaMonsters.Add(sid);


            string menuChoice;
            bool exiting = false;

            while (!exiting)
            {
                DisplayHeader("Main Menu");

                Console.WriteLine("\tA) Display All Sea Monsters");
                Console.WriteLine("\tB) Add a Sea Monster");
                Console.WriteLine("\tC) Display Sea Monster Info");
                Console.WriteLine("\tD) Display Delete Sea Monster Info");
                Console.WriteLine("\tE) Update a Sea Monsters Info");
                Console.WriteLine("\tF) Exit");

                Console.Write("Enter Choice:");
                menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "A":
                    case "a":
                        DisplayAllSeaMonsters(seaMonsters);
                        break;

                    case "B":
                    case "b":
                        DisplayGetUserSeaMonster(seaMonsters);
                        break;

                    case "C":
                    case "c":
                        DisplaySeaMonsterInfo(seaMonsters);
                        break;

                    case "D":
                    case "d":
                        DisplayDeleteSeaMonster(seaMonsters);
                        break;

                    case "E":
                    case "e":
                        DisplayGetUpdatedSeaMonster(seaMonsters);
                        break;

                    case "F":
                    case "f":
                        exiting = true;
                        break;

                    default:
                        Console.WriteLine("Error, please try again.");
                        break;
                }
            }
        }

        #region HELPER METHODS

        /// <summary>
        /// display opening screen
        /// </summary>
        static void DisplayOpeningScreen()
        {
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("\t\tWelcome to Simple Monster Classes");
            Console.WriteLine();

            DisplayContinuePrompt();
        }

        /// <summary>
        /// display closing screen
        /// </summary>
        static void DisplayClosingScreen()
        {
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("\t\tThanks for using Simple Monster Classes.");
            Console.WriteLine();

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        /// <summary>
        /// display continue prompt
        /// </summary>
        static void DisplayContinuePrompt()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        /// <summary>
        /// display header
        /// </summary>
        static void DisplayHeader(string headerTitle)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t" + headerTitle);
            Console.WriteLine();
        }

        #endregion


    }
}
