using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_SimpleMonsterClasses
{
    public class SeaMonster
    {
        public enum EmotionalState
        {
            Happy,
            Sad,
            Angry
        }


        #region Fields
        private string _name;
        private double _weight;
        private bool _canUseFreshWater;
        private EmotionalState _currentEmotionalState;
        private string _homeSea;
        private double _numberOfTeeth;

        









        #endregion






        #region Properties
        public bool CanUseFreshWater
        {
            get { return _canUseFreshWater; }
            set { _canUseFreshWater = value; }
        }

        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public EmotionalState CurrentEmotionalState
        {
            get { return _currentEmotionalState; }
            set { _currentEmotionalState = value; }
        }
        public string HomeSea
        {
            get { return _homeSea; }
            set { _homeSea = value; }
        }
        public double NumberOfTeeth
        {
            get { return _numberOfTeeth; }
            set { _numberOfTeeth = value; }
        }
        #endregion

        #region constructors
        public SeaMonster()
        {

        }
        public SeaMonster(string name)
        {
            _name = name;
        }

        #endregion

        public string SeaMonsterAttitude()
        {
            return _name + "is" + _currentEmotionalState + ".";
        }
    }
}
