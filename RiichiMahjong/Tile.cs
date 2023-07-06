using RiichiMahjong.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiichiMahjong
{
    internal class Tile
    {
        private int _value;
        private string _suit;
        
        public Tile(int value, string suit)
        {
            _value = value;
            _suit = suit;
        }

        public int value { get { return _value; } }
        public string suit { get { return _suit; } }
        public string TileCode()
        {
            return _value.ToString() + _suit;
        }
    }
}
