using RiichiMahjong.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiichiMahjong
{
    internal class TileList
    {
        private int[] _standardTiles = new int[136]
        {
            0x01, 0x01, 0x01, 0x01, // Man tiles (Characters)
            0x02, 0x02, 0x02, 0x02,
            0x03, 0x03, 0x03, 0x03,
            0x04, 0x04, 0x04, 0x04,
            0x05, 0x05, 0x05, 0x105, // 0x105 is 0m or Red 5 Man
            0x06, 0x06, 0x06, 0x06,
            0x07, 0x07, 0x07, 0x07,
            0x08, 0x08, 0x08, 0x08,
            0x09, 0x09, 0x09, 0x09,

            0x11, 0x11, 0x11, 0x11, // Pin tiles (Circles)
            0x12, 0x12, 0x12, 0x12,
            0x13, 0x13, 0x13, 0x13,
            0x14, 0x14, 0x14, 0x14,
            0x15, 0x15, 0x15, 0x115, // 0x115 is 0p or Red 5 Pin
            0x16, 0x16, 0x16, 0x16,
            0x17, 0x17, 0x17, 0x17,
            0x18, 0x18, 0x18, 0x18,
            0x19, 0x19, 0x19, 0x19,

            0x21, 0x21, 0x21, 0x21, // Sou tiles (Bamboos)
            0x22, 0x22, 0x22, 0x22,
            0x23, 0x23, 0x23, 0x23,
            0x24, 0x24, 0x24, 0x24,
            0x25, 0x25, 0x25, 0x125, // 0x125 is 0s or Red 5 Sou
            0x26, 0x26, 0x26, 0x26,
            0x27, 0x27, 0x27, 0x27,
            0x28, 0x28, 0x28, 0x28,
            0x29, 0x29, 0x29, 0x29,

            0x31, 0x31, 0x31, 0x31, // East
            0x32, 0x32, 0x32, 0x32, // South
            0x33, 0x33, 0x33, 0x33, // West
            0x34, 0x34, 0x34, 0x34, // North
            0x35, 0x35, 0x35, 0x35, // Haku (White)
            0x36, 0x36, 0x36, 0x36, // Hatsu (Green)
            0x37, 0x37, 0x37, 0x37  // Chun (Red)
        };

        List<Tile> _tiles = new List<Tile>();

        /// <summary>
        /// Initializes TileList using standard tiles.
        /// </summary>
        public TileList()
        {
            int length = _standardTiles.Length;
            for(int tile = 0; tile < _standardTiles.Length; tile++)
            {
                _tiles.Add(ToTile(TileToString(_standardTiles[tile])));
            }
        }

        /// <summary>
        /// Returns the list of tiles
        /// </summary>
        public List<Tile> Tiles { get { return _tiles; } }

        /// <summary>
        /// Turns the numbers into strings when generating the wall code but also the wall itself.
        /// </summary>
        /// <param name="tile"></param>
        /// <returns></returns>
        /// <exception cref="TileNotFoundException"></exception>
        public string TileToString(int tile)
        {
            string tileString = string.Empty;
            if (tile <= 0x09) // Man
                return tileString = $"{tile - 0x00}m"; // Subtract the value in order to get the real tile number
            else if (tile <= 0x19)
                return tileString = $"{tile - 0x10}p"; // Pin
            else if (tile <= 0x29)
                return tileString = $"{tile - 0x20}s"; // Sou
            else if (tile <= 0x37)
                return tileString = $"{tile - 0x30}z"; // Honour
            else if (tile == 0x105) // Red Five Man
                return "0m";
            else if (tile == 0x115) // Red Five Pin
                return "0p";
            else if (tile == 0x125) // Red Five Sou
                return "0s";
            else throw new TileNotFoundException("Tile not found or does not exist");
        }

        /// <summary>
        /// Returns a tile from string form to object Tile.
        /// </summary>
        /// <param name="tile"></param>
        /// <returns></returns>
        public Tile ToTile(string tile)
        {
            string x = tile.Substring(0, 1);
            string d = tile.Substring(1, 1);
            return new Tile(int.Parse(tile.Substring(0, 1)), tile.Substring(1, 1));
        }
    }
}
