using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAionProject
{
    /// <summary>
    /// base class for the player and all game characters
    /// </summary>
    public class Cadet
    {
        #region ENUMERABLES

        public enum Rank
        {
            None,
            Airman,
            AirmanFirstClass,
            SeniorAirman
        }

        #endregion

        #region FIELDS

        protected string _name;
        protected int _planetLocationId;
        protected int _age;
        protected Rank _rank;


        #endregion

        #region PROPERTIES

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int PlanetLocationId
        {
            get { return _planetLocationId; }
            set { _planetLocationId = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public Rank Race
        {
            get { return _rank; }
            set { _rank = value; }
        }



        #endregion

        #region CONSTRUCTORS

        public Cadet()
        {

        }

        public Cadet(string name, Rank rank, int planetLocationId, string equipment)
        {
            _name = name;
            _rank = rank;
            _planetLocationId = planetLocationId;

        }

        #endregion

        #region METHODS



        #endregion
    }
}
