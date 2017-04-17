using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAionProject
{
    /// <summary>
    /// class of the game map
    /// </summary>
    public class Universe
    {
        #region ***** define all lists to be maintained by the Universe object *****

        //
        // list of all planet locations and game objects
        //
        private List<Planets> _planetLocations;
        private List<TravelerObject> _gameObjects;

        public List<Planets> SpaceTimeLocations
        {
            get { return _planetLocations; }
            set { _planetLocations = value; }
        }

        public List<TravelerObject> GameObjects
        {
            get { return _gameObjects; }
            set { _gameObjects = value; }
        }
        #endregion

        #region ***** constructor *****

        //
        // default Universe constructor
        //
        public Universe()
        {
            //
            // add all of the universe objects to the game
            // 
            IntializeUniverse();
        }

        #endregion

        #region ***** define methods to initialize all game elements *****

        /// <summary>
        /// initialize the universe with all of the space-time locations
        /// </summary>
        private void IntializeUniverse()
        {
            _planetLocations = PlanetDetails.Planets;
            _gameObjects = UniverseObjects.gameObjects;
        }

        #endregion

        #region ***** define methods to return game element objects and information *****

        public bool IsValidPlanetID(int planetLocationId)
        {
            List<int> planetLocationIds = new List<int>();

            //
            // create a list of space-time location ids
            //
            foreach (Planets pl in _planetLocations)
            {
                planetLocationIds.Add(pl.planetLocationId);
            }

            //
            // determine if the space-time location id is a valid id and return the result
            //
            if (planetLocationIds.Contains(planetLocationId))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// validate traveler object id number in current location
        /// </summary>
        /// <param name="travelerObjectId"></param>
        /// <returns>is Id valid</returns>
        public bool IsValidTravelerObjectByLocationId(int travelerObjectId, int planetLocationId)
        {
            List<int> travelerObjectIds = new List<int>();

            //
            // create a list of traveler object ids in current space-time location
            //
            foreach (TravelerObject gameObject in _gameObjects)
            {
                if (gameObject.PlanetLocationId == planetLocationId && gameObject is TravelerObject)
                {
                    travelerObjectIds.Add(gameObject.Id);
                }

            }

            //
            // determine if the game object id is a valid id and return the result
            //
            if (travelerObjectIds.Contains(travelerObjectId))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// get all traveler objects in a location
        /// </summary>
        /// <param name="planetLocationId">space-time location id</param>
        /// <returns>list of traveler objects</returns>
        public List<TravelerObject> GetTravelerObjectsBySpaceTimeLocationId(int planetLocationId)
        {
            List<TravelerObject> travelerObjects = new List<TravelerObject>();

            //
            // run through the game object list and grab all that are in the current space-time location
            //
            foreach (TravelerObject gameObject in _gameObjects)
            {
                if (gameObject.PlanetLocationId == planetLocationId && gameObject is TravelerObject)
                {
                    travelerObjects.Add(gameObject as TravelerObject);
                }
            }

            return travelerObjects;
        }

        /// <summary>
        /// validate game object id number in current location
        /// </summary>
        /// <param name="gameObjectId"></param>
        /// <returns>is Id valid</returns>
        public bool IsValidGameObjectByLocationId(int gameObjectId, int currentSpaceTimeLocation)
        {
            List<int> gameObjectIds = new List<int>();

            //
            // create a list of game object ids in current space-time location
            //
            foreach (TravelerObject gameObject in _gameObjects)
            {
                if (gameObject.PlanetLocationId == currentSpaceTimeLocation)
                {
                    gameObjectIds.Add(gameObject.Id);
                }

            }

            //
            // determine if the game object id is a valid id and return the result
            //
            if (gameObjectIds.Contains(gameObjectId))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// get a game object using an Id
        /// </summary>
        /// <param name="Id">game object Id</param>
        /// <returns>requested game object</returns>
        public TravelerObject GetGameObjectById(int Id)
        {
            TravelerObject gameObjectToReturn = null;

            //
            // run through the game object list and grab the correct one
            //
            foreach (TravelerObject gameObject in _gameObjects)
            {
                if (gameObject.Id == Id)
                {
                    gameObjectToReturn = gameObject;
                }
            }

            //
            // the specified ID was not found in the universe
            // throw and exception
            //
            if (gameObjectToReturn == null)
            {
                string feedbackMessage = $"The Game Object ID {Id} does not exist in the current Universe.";
                throw new ArgumentException(Id.ToString(), feedbackMessage);
            }

            return gameObjectToReturn;
        }

        public List<TravelerObject> GetGameObjectsBySpaceTimeLocationId(int planetLocationId)
        {
            List<TravelerObject> gameObjects = new List<TravelerObject>();

            //
            // run through the game object list and grab all that are in the current space-time location
            //
            foreach (TravelerObject gameObject in _gameObjects)
            {
                if (gameObject.PlanetLocationId == planetLocationId)
                {
                    gameObjects.Add(gameObject);
                }
            }

            return gameObjects;
        }

        /// <summary>
        /// determine if a location is accessible to the player
        /// </summary>
        /// <param name="planetLocationId"></param>
        /// <returns>accessible</returns>
        public bool IsAccessibleLocation(int planetLocationId)
        {
            Planets planetLocation = GetPlanetLocationById(planetLocationId);
            if (planetLocation.Accessible == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// return the next available ID for a Planets object
        /// </summary>
        /// <returns>next SpaceTimeLocationObjectID </returns>
        public int GetMaxSpaceTimeLocationId()
        {
            int MaxId = 0;

            foreach (Planets planetLocation in _planetLocations)
            {
                if (planetLocation.planetLocationId > MaxId)
                {
                    MaxId = planetLocation.planetLocationId;
                }
            }

            return MaxId;
        }

        /// <summary>
        /// get a Planets object using an Id
        /// </summary>
        /// <param name="Id">space-time location Id</param>
        /// <returns>requested space-time location</returns>
        public Planets GetPlanetLocationById(int Id)
        {
            Planets planetLocation = null;

            //
            // run through the space-time location list and grab the correct one
            //
            foreach (Planets location in _planetLocations)
            {
                if (location.planetLocationId == Id)
                {
                    planetLocation = location;
                }
            }

            //
            // the specified ID was not found in the universe
            // throw and exception
            //
            if (planetLocation == null)
            {
                string feedbackMessage = $"The Planet Address {Id} does not exist in the current Universe.";
                throw new ArgumentException(Id.ToString(), feedbackMessage);
            }

            return planetLocation;
        }

        #endregion
    }
}
