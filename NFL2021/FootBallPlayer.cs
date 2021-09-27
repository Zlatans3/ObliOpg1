using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFL2021
{
     public class FootBallPlayer
    {
        string _name;
        int _price;
        int _shirtNumber;
        
        public int Id { get; set; }

        public string Name
        {
            get => _name;
            set
            {
                if(value == null) throw new ArgumentNullException();
                if (value.Length < 4) throw new ArgumentException();
                _name = value;
            }
        }
        public int Price
        {
            get => _price;
            set
            {
                if(value < 0) throw new ArgumentOutOfRangeException();
                _price = value;
            }
        }
        public int ShirtNumber
        {
            get => _shirtNumber;
            set
            {
                if (value < 0 || value > 100) throw new ArgumentOutOfRangeException();
                _shirtNumber = value;
            }
        }

        public FootBallPlayer(String name)
        {
            Name = name;
        }
        
    }
}
