using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAionProject
{
    /// <summary>
    /// static class to hold all objects in the game universe; locations, game objects, npc's
    /// </summary>
    public static partial class UniverseObjects
    {
        public static List<TravelerObject> gameObjects = new List<TravelerObject>()
        {
            new TravelerObject
            {
                Id = 1,
                Name = "Dial Home Device",
                PlanetLocationId = 1,
                Description = "A handheld device used to dial the gate for planets that do not have a planet based DHD.",
                Type = EquipmentType.DHD,
                Value = 45,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true
            },

            new TravelerObject
            {
                Id = 2,
                Name = "IDC",
                PlanetLocationId = 1,
                Description = "A handheld device used to allow access back to Stargate Command when dialing in from off-world.",
                Type = EquipmentType.IDC,
                Value = 45,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true
            },

            new TravelerObject
            {
                Id = 3,
                Name = "Puddle Jumper",
                PlanetLocationId = 3,
                Description = "A small ship that has weapons, supplies, and transport capabilities. -Can travel through the gate.",
                Type = EquipmentType.JumperShip,
                Value = 45,
                CanInventory = false,
                IsConsumable = true,
                IsVisible = true
            },

            new TravelerObject
            {
                Id = 4,
                Name = "Land Mines",
                PlanetLocationId = 3,
                Description = "A hand tool for avoiding any unfriendly contacts.",
                Type = EquipmentType.Landmine,
                Value = 0,
                CanInventory = true,
                IsConsumable = false,
                IsVisible = true
            },

            new TravelerObject
            {
                Id = 5,
                Name = "MALP",
                PlanetLocationId = 2,
                Description = "A robotik rover useful for carrying supplies through the gate.",
                Type = EquipmentType.MALP,
                Value = 0,
                CanInventory = true,
                IsConsumable = false,
                IsVisible = true
            },

            new TravelerObject
            {
                Id = 6,
                Name = "Milky Way Map (Gluten Free)",
                PlanetLocationId = 4,
                Description = "A useful map for the names and locations of various planets in the gate system.",
                Type = EquipmentType.MapData,
                Value = 0,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true
            },

           
        };
    }
}
