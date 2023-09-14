using RiichiMahjong.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiichiMahjong
{
    public class Tile
    {
        private int _number;
        private string _suit;

        public Tile(int value, string suit)
        {
            _number = value;
            _suit = suit;
        }

        /// <summary>
        /// Returns which number the tile is.
        /// </summary>
        public int Number { get { return _number; } }
        /// <summary>
        /// Returns which suit the tile is.
        /// </summary>
        public string Suit { get { return _suit; } }
        /// <summary>
        /// Returns the tile in string format.
        /// </summary>
        /// <returns></returns>
        public string TileCode()
        {
            return _number.ToString() + _suit;
        }
    }
}
