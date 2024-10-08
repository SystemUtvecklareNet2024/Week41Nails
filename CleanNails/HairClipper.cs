﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanNails.Interfaces;

namespace CleanNails
{
    internal class HairClipper : IClipType
    {
        public void Clip(Person person, string staffName)
        {
            Printer.PrintClippedHair(person, staffName);
            person.Hair.HairLength = person.PrefferedHairLength;
        }        

        public bool ShouldClip(Person person)
        {
            if (person.Hair.HairLength >= person.PrefferedHairLength + 5.0f)
            {
                return true;
            }
            return false;
        }
    }
}
