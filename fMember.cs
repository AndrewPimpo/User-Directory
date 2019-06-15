using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pimpo_FellowshipEntry
{
    class fMember
    {
        private string _race;
        private string _country;
        private string _name;
        private string _title;
        private string _weapon;
        private int _cIndex;

        public fMember()
        {
            _race = "";
            _country = "";
            _name = "";
            _title = "";
            _weapon = "";
        }

        public string Race
        {
            get
            {
                return _race;
            }

            set
            {
                _race = value;
            }
        }

        public string Country
        {
            get
            {
                return _country;
            }

            set
            {
                _country = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public string Title
        {
            get
            {
                return _title;
            }

            set
            {
                _title = value;
            }
        }

        public string Weapon
        {
            get
            {
                return _weapon;
            }

            set
            {
                _weapon = value;
            }
        }

        public int CIndex
        {
            get
            {
                return _cIndex;
            }

            set
            {
                _cIndex = value;
            }
        }
    }
}
