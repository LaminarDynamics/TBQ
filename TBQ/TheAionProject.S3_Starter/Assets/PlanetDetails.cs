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
    public static class PlanetDetails
    {
        public static List<Planets> Planets = new List<Planets>()
        {

            new Planets
            {
                CommonName = "Earth",
                planetLocationId = 1,
                Description = "The planet Earth is located closer to the outer edge of our " +
                    "galaxy. The race of beings there (Known as humans) have only recently discovered " +
                    "discovered the Stargate and the opportunities it offers. /n",
                GeneralContents = "The Gate Room at Stargate Command contains all the equipment " +
                    "you may need for travel to various other planets. This includes weapons; enviromental " +
                    "gear; and science equipment for research on other planets. \n",
                Accessible = true,
                ExperiencePoints = 10,
                
            },

            new Planets
            {
                CommonName = "Abidos",
               planetLocationId = 2,
                Description = "" +
                    "" +
                    "",
                GeneralContents = "- stuff in the room -",
                Accessible = true,
                ExperiencePoints = 10
            },

            new Planets
            {
                CommonName = "Valgoran",
                planetLocationId = 3,
                Description = "" +
                              "" +
                              "",
                GeneralContents = "- stuff in the room -",
                Accessible = true,
                ExperiencePoints = 20
            },

                        new Planets
            {
                CommonName = "Atlantis",
                planetLocationId = 4,
                Description = "" +
                              "" +
                              "",
                GeneralContents = "- stuff in the room -",
                Accessible = true,
                ExperiencePoints = 10
            },

                         new Planets
            {
                CommonName = "Angoria",
                planetLocationId = 5,
                Description = "" +
                              "" +
                              "",
                GeneralContents = "- stuff in the room -",
                Accessible = true,
                ExperiencePoints = 10
            },
        };
    }
}
