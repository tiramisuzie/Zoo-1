﻿using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_zoo.classes
{
    class Centaur : Unicorn
    {
        public override bool LiveForever { get; set; } = true;

        public override bool HaveWings { get; set; } = false;

        public override string MagicalPower()
        {
            return "I have superior strength and speed.";
        }
    }
}