﻿using lab05_zoo.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_zoo.classes
{
    public class Pegasus : Centaur, IFly, ILive
    {
        /// <summary>
        /// properties
        /// </summary>
        public override bool LiveForever { get; set; } = true;

        public override bool HaveWings { get; set; } = true;

        /// <summary>
        /// methods
        /// </summary>
        /// <returns></returns>
        public override string MagicalPower()
        {
            return "I can fly at incredible speeds.";
        }

        public new string FlightCapability()
        {
            return "I can fly great distances.";
        }

        public new string BirthPlace()
        {
            return "I was born in Norway.";
        }
    }
}
