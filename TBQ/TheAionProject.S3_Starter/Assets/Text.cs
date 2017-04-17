using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAionProject
{
    /// <summary>
    /// class to store static and to generate dynamic text for the message and input boxes
    /// </summary>
    public static class Text
    {
        public static List<string> HeaderText = new List<string>() { "Stargate SG-1" };
        public static List<string> FooterText = new List<string>() { "Jeremiah Woodward, 2017" };

        #region INTITIAL GAME SETUP

        public static string MissionIntro()
        {
            string messageBoxText =
            "You have been chosen by the US Airforce to participate in the  " +
            "in the Stargate program. " +
            "Your mission is to explore the galaxy via and ancient device known " +
            "as the Stargate. \n" +
            " \n" +
            "Press the Esc key to exit the game at any point.\n" +
            " \n" +
            "Your first mission begins now.\n" +
            " \n" +
            "\tYour first assignment is to travel to the planet P3X-255 and .\n" +
            " deliver a package to our allies there. \n" +
            "\tPress any key to begin the Mission Initialization Process.\n";

            return messageBoxText;
        }

        public static string InitialLocationInfo()
        {
            string messageBoxText =
            "You are now located in the US Airforce's Cheyenne mountain base in Colorado USA " +
            "on the planet Earth. Your journey begins deep inside the base in the Gate Room. " +
            "Here lies the Stargate where and your journey to many other worlds will begin." +
            "\n" +
            " \n" +
            "\tChoose from the menu options to proceed.\n";

            return messageBoxText;
        }

        #region Initialize Mission Text

        public static string InitializeMissionIntro()
        {
            string messageBoxText =
                "Before you begin your first mission we much gather your personel information.\n" +
                " \n" +
                "You will be prompted for the required information. Please enter the information below.\n" +
                " \n" +
                "\tPress any key to begin.";

            return messageBoxText;
        }

        public static string InitializeMissionGetTravelerName()
        {
            string messageBoxText =
                "Enter your name cadet.\n" +
                " \n" +
                "Please use the name you wish to be referred during your mission.";

            return messageBoxText;
        }

        public static string InitializeMissionGetTravelerAge(string name)
        {
            string messageBoxText =
                $"Very good then, we will call you {name} on this mission.\n" +
                " \n" +
                "Enter your age below.\n" +
                " \n" +
                "Please use the standard Earth year as your reference.";

            return messageBoxText;
        }

        public static string InitializeMissionGetTravelerRace(Traveler gameTraveler)
        {
            string messageBoxText =
                 $"{gameTraveler.Name}, it will be important for us to know your rank on this mission.\n" +
                " \n" +
                "Enter your rank below.\n" +
                " \n" +
                "" +
                " \n";

            string rankList = null;

            foreach (Cadet.Rank rank in Enum.GetValues(typeof(Cadet.Rank)))
            {
                if (rank != Cadet.Rank.None)
                {
                    rankList += $"\t{rank}\n";
                }
            }

            messageBoxText += rankList;

            return messageBoxText;
        }

        public static string InitializeMissionEchoTravelerInfo(Traveler gameTraveler)
        {
            string messageBoxText =
                $"Very good then {gameTraveler.Name}.\n" +
                " \n" +
                "It appears we have all the necessary data to begin your mission. You will find it" +
                " listed below.\n" +
                " \n" +
                $"\tTraveler Name: {gameTraveler.Name}\n" +
                $"\tTraveler Age: {gameTraveler.Age}\n" +
                $"\tTraveler Rank: {gameTraveler.Race}\n" +
                " \n" +
                "Press any key to begin your mission.";

            return messageBoxText;
        }

        #endregion

        #endregion

        #region MAIN MENU ACTION SCREENS

        public static string TravelerInfo(Traveler gameTraveler, Planets currentLocation)
        {
            string messageBoxText =
                $"\tTraveler Name: {gameTraveler.Name}\n" +
                $"\tTraveler Age: {gameTraveler.Age}\n" +
                $"\tTraveler Rank: {gameTraveler.Race}\n" +
                " \n" +
                $"\tCurrent Location: {currentLocation.CommonName}\n" +
                " \n";

            return messageBoxText;
        }

        public static string CurrentLocationInfo(Planets planetLocation)
        {
            string messageBoxText =
                $"Current Location: {planetLocation.CommonName}\n" +
                " \n" +
                planetLocation.Description;

            return messageBoxText;
        }

        public static string LookAround(Planets planetLocation)
        {
            string messageBoxText =
                $"Current Location: {planetLocation.CommonName}\n" +
                " \n" +
                planetLocation.GeneralContents;

            return messageBoxText;
        }

        public static string LookAt(TravelerObject gameObject)
        {
            string messageBoxText = "";

            messageBoxText =
                $"{gameObject.Name}\n" +
                " \n" +
                gameObject.Description + " \n" +
                " \n";

            if (gameObject is TravelerObject)
            {
                TravelerObject travelerObject = gameObject as TravelerObject;

                messageBoxText += $"The {travelerObject.Name} has a value of {travelerObject.Value} and ";

                if (travelerObject.CanInventory)
                {
                    messageBoxText += "may be added to your inventory.";
                }
                else
                {
                    messageBoxText += "may not be added to your inventory.";
                }
            }
            else
            {
                messageBoxText += $"The {gameObject.Name} may not be added to your inventory.";
            }

            return messageBoxText;
        }


        //public static string PickUpEquipment(Planets planetLocation)
        //{
        //    string messageBoxText =
        //        $"Availible Equipment: {planetLocation.AvailibleEquipment}\n" +
        //        " \n";


        //    return messageBoxText;

        //}

        public static string Travel(Traveler gametraveler, List<Planets> planetLocations)
        {
            string messageBoxText =
                $"{gametraveler.Name}, Stargate Command needs to know what address to dial the gate to.\n" +
                " \n" +
                "Enter the Planet ID number of your desired location from the table below.\n" +
                " \n" +

                //
                // display table header
                //
                "ID".PadRight(10) + "Name".PadRight(30) + "Accessible".PadRight(10) + "\n" +
                "---".PadRight(10) + "----------------------".PadRight(30) + "-------".PadRight(10) + "\n";

            //
            // display all locations except the current location
            //
            string planetLocationList = null;
            foreach (Planets planetLocation in planetLocations)
            {
                if (planetLocation.planetLocationId != gametraveler.PlanetLocationId)
                {
                    planetLocationList +=
                        $"{planetLocation.planetLocationId}".PadRight(10) +
                        $"{planetLocation.CommonName}".PadRight(30) +
                        $"{planetLocation.Accessible}".PadRight(10) +
                        Environment.NewLine;
                }
            }

            messageBoxText += planetLocationList;

            return messageBoxText;
        }

        public static string VisitedLocations(IEnumerable<Planets> planetLocations)
        {
            string messageBoxText =
                "Planets Visited\n" +
                " \n" +

                //
                // display table header
                //
                "ID".PadRight(10) + "Name".PadRight(30) + "\n" +
                "---".PadRight(10) + "----------------------".PadRight(30) +  "\n";

            //
            // display all locations
            //
            string planetLocationList = null;
            foreach (Planets planetLocation in planetLocations)
            {
                    planetLocationList +=
                        $"{planetLocation.planetLocationId}".PadRight(10) +
                        $"{planetLocation.CommonName}".PadRight(30) +
                        Environment.NewLine;
            }

            messageBoxText += planetLocationList;

            return messageBoxText;
        }

        public static string ListAllPlanetLocations(IEnumerable<Planets> planetLocations)
        {
            string messageBoxText =
                "Planet Locations\n" +
                " \n" +

                //
                // display table header
                //
                "ID".PadRight(10) + "Name".PadRight(30) + "\n" +
                "---".PadRight(10) + "----------------------".PadRight(30) + "\n";

            //
            // display all locations
            //
            string planetLocationList = null;
            foreach (Planets planetLocation in planetLocations)
            {
                planetLocationList +=
                    $"{planetLocation.planetLocationId}".PadRight(10) +
                    $"{planetLocation.CommonName}".PadRight(30) +
                    Environment.NewLine;
            }

            messageBoxText += planetLocationList;

            return messageBoxText;
        }

        public static string ListAllGameObjects(IEnumerable<TravelerObject> gameObjects)
        {
            //
            // display table name and column headers
            //
            string messageBoxText =
                "Game Objects\n" +
                " \n" +

                //
                // display table header
                //
                "ID".PadRight(10) +
                "Name".PadRight(30) +
                "Space-Time Location Id".PadRight(10) + "\n" +
                "---".PadRight(10) +
                "----------------------".PadRight(30) +
                "----------------------".PadRight(10) + "\n";

            //
            // display all traveler objects in rows
            //
            string gameObjectRows = null;
            foreach (TravelerObject gameObject in gameObjects)
            {
                gameObjectRows +=
                    $"{gameObject.Id}".PadRight(10) +
                    $"{gameObject.Name}".PadRight(30) +
                    $"{gameObject.PlanetLocationId}".PadRight(10) +
                    Environment.NewLine;
            }

            messageBoxText += gameObjectRows;

            return messageBoxText;
        }

        public static string CurrentInventory(IEnumerable<TravelerObject> inventory)
        {
            string messageBoxText = "";

            //
            // display table header
            //
            messageBoxText =
            "ID".PadRight(10) +
            "Name".PadRight(30) +
            "Type".PadRight(10) +
            "\n" +
            "---".PadRight(10) +
            "----------------------------".PadRight(30) +
            "----------------------".PadRight(10) +
            "\n";

            //
            // display all traveler objects in rows
            //
            string inventoryObjectRows = null;
            foreach (TravelerObject inventoryObject in inventory)
            {
                inventoryObjectRows +=
                    $"{inventoryObject.Id}".PadRight(10) +
                    $"{inventoryObject.Name}".PadRight(30) +
                    $"{inventoryObject.Type}".PadRight(10) +
                    Environment.NewLine;
            }

            messageBoxText += inventoryObjectRows;

            return messageBoxText;
        }

        public static string GameObjectsChooseList(IEnumerable<TravelerObject> gameObjects)
        {
            //
            // display table name and column headers
            //
            string messageBoxText =
                "Game Objects\n" +
                " \n" +

                //
                // display table header
                //
                "ID".PadRight(10) +
                "Name".PadRight(30) + "\n" +
                "---".PadRight(10) +
                "----------------------".PadRight(30) + "\n";

            //
            // display all traveler objects in rows
            //
            string gameObjectRows = null;
            foreach (TravelerObject gameObject in gameObjects)
            {
                gameObjectRows +=
                    $"{gameObject.Id}".PadRight(10) +
                    $"{gameObject.Name}".PadRight(30) +
                    Environment.NewLine;
            }

            messageBoxText += gameObjectRows;

            return messageBoxText;
        }

        #endregion

        public static List<string> StatusBox(Traveler cadet, Universe universe)
        {
            List<string> statusBoxText = new List<string>();

            statusBoxText.Add($"Experience Points: {cadet.ExperiencePoints}\n");
            statusBoxText.Add($"Health: {cadet.Health}\n");
            statusBoxText.Add($"Lives: {cadet.Lives}\n");
            statusBoxText.Add($"------------------------\n");
            //statusBoxText.Add($"Equipment: {cadet.Equipment}\n");

            return statusBoxText;
        }
    }
}
