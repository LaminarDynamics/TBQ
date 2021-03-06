﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAionProject
{
    public abstract class Equipment
    {
        public abstract int Id { get; set; }
        public abstract string Name { get; set; }
        public abstract string Description { get; set; }
        public abstract int PlanetLocationId { get; set; }
    }
}
