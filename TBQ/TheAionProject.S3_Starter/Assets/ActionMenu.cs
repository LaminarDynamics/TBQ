using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAionProject
{
    /// <summary>
    /// static class to hold key/value pairs for menu options
    /// </summary>
    /// 
    public static class ActionMenu
    {

        public enum CurrentMenu
        {
            MissionIntro,
            InitializeMission,
            MainMenu,
            ObjectMenu,
            NpcMenu,
            TravelerMenu,
            AdminMenu

        }

        //
        // flag current operating menu
        //
        public static CurrentMenu currentMenu = CurrentMenu.MainMenu;


        public static Menu MissionIntro = new Menu()
        {
            MenuName = "MissionIntro",
            MenuTitle = "",
            MenuChoices = new Dictionary<char, TravelerAction>()
                    {
                        { ' ', TravelerAction.None }
                    }
        };

        public static Menu InitializeMission = new Menu()
        {
            MenuName = "InitializeMission",
            MenuTitle = "Initialize Mission",
            MenuChoices = new Dictionary<char, TravelerAction>()
                {
                    { '1', TravelerAction.Exit }
                }
        };

        public static Menu MainMenu = new Menu()
        {
            MenuName = "MainMenu",
            MenuTitle = "Main Menu",
            MenuChoices = new Dictionary<char, TravelerAction>()
                {
                    { '1', TravelerAction.TravelerInfo },
                    { '2', TravelerAction.LookAround },
                    { '3', TravelerAction.Travel },
                    { '4', TravelerAction.LookAt },
                    { '5', TravelerAction.PickUp },
                    { '6', TravelerAction.PutDown },
                    { '7', TravelerAction.Inventory },
                    { '8', TravelerAction.AdminMenu },
               //     { '9', TravelerAction.ReturnToMainMenu },
                    { '0', TravelerAction.Exit }
                }
        };

        public static Menu AdminMenu = new Menu()
        {
            MenuName = "AdminMenu",
            MenuTitle = "Admin Menu",
            MenuChoices = new Dictionary<char, TravelerAction>()
                {
                    { '1', TravelerAction.ListPlanets },
                    { '2', TravelerAction.ListGameObjects },
                    { '3', TravelerAction.ListNPCs},
                    { '0', TravelerAction.ReturnToMainMenu }
                }
        };

        //public static Menu ObjectMenu = new Menu()
        //{
        //    MenuName = "ObjectMenu",
        //    MenuTitle = "Object Menu",
        //    MenuChoices = new Dictionary<char, TravelerAction>()
        //        {
        //            { '1', TravelerAction.LookAt },
        //            { '2', TravelerAction.PickUp},
        //            { '3', TravelerAction.PutDown},
        //            { '0', TravelerAction.ReturnToMainMenu }
        //        }
        //};

        //public static Menu PickUpMenu = new Menu()
        //{
        //    MenuName = "PickUpMenu",
        //    MenuTitle = "Pick Up Menu",
        //    MenuChoices = new Dictionary<char, TravelerAction>()
        //        {
        //            { '1', TravelerAction.PickUpEquipment },
        //            { '2', TravelerAction.PutDownEquipment },
        //            { '0', TravelerAction.Exit }
        //        }
        //};

        //public static Menu ManageTraveler = new Menu()
        //{
        //    MenuName = "ManageTraveler",
        //    MenuTitle = "Manage Traveler",
        //    MenuChoices = new Dictionary<char, TravelerAction>()
        //            {
        //                TravelerAction.MissionSetup,
        //                TravelerAction.TravelerInfo,
        //                TravelerAction.Exit
        //            }
        //};
    }
}
