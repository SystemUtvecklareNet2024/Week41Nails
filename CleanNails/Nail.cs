using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanNails
{
    internal class Nail
    {
        public float CurrentLength { get; set; }
        public string Color { get; set; }

        private float _dailyGrowRate;
        public float DailyGrowRate { get { return _dailyGrowRate; } }

        public float PreferredLength { get; set; }

        private TypeOfFingerOrToe _typeOfFingerOrToe;
        public TypeOfFingerOrToe TypeOfFingerOrToe { get { return _typeOfFingerOrToe; } }

        private RightOrLeft _rightOrLeft;
        public RightOrLeft RightOrLeft { get { return _rightOrLeft; } }



        public Nail(string color, TypeOfFingerOrToe fingerOrToe, RightOrLeft rightOrLeft, float currentLength, float preferredLength, float dailyGrowRate)
        {
            Color = color;
            CurrentLength = currentLength;
            PreferredLength = preferredLength;
            _dailyGrowRate = dailyGrowRate;
            _typeOfFingerOrToe = fingerOrToe;
            _rightOrLeft = rightOrLeft;
        }

        public void Grow()
        {
            CurrentLength += DailyGrowRate;
        }

    }
}
