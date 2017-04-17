using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAionProject
{
    /// <summary>
    /// the character class the player uses in the game
    /// </summary>
    public class Traveler : Cadet
    {
        #region ENUMERABLES


        #endregion

        #region FIELDS

        private int _experiencePoints;
        private int _health;
        private int _lives;
        private List<int> _planetsVisited;
        private List<TravelerObject> _inventory;

       




        #endregion


        #region PROPERTIES

        public int ExperiencePoints
        {
            get { return _experiencePoints; }
            set { _experiencePoints = value; }
        }

        public int Health
        {
            get { return _health; }
            set { _health = value; }
        }

        public int Lives
        {
            get { return _lives; }
            set { _lives = value; }
        }
        
        public List<int> PlanetsVisited
        {
            get { return _planetsVisited; }
            set { _planetsVisited = value; }
        }

        public List<TravelerObject> Inventory
        {
            get { return _inventory; }
            set { _inventory = value; }
        }



        #endregion


        #region CONSTRUCTORS

        public Traveler()
        {
            _planetsVisited = new List<int>();
            _inventory = new List<TravelerObject>();
        }

        public Traveler(string name, Rank rank, int planetLocationId, string equipment) : base(name, rank, planetLocationId, equipment)
        {
            _planetsVisited = new List<int>();
            _inventory = new List<TravelerObject>();
        }

        

        #endregion


        #region METHODS

        public bool HasVisited(int _planetLocationId)
        {
            if (PlanetsVisited.Contains(_planetLocationId))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion
    }
}
