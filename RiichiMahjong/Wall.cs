using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiichiMahjong
{
    internal class Wall
    {
        private int[] standardTiles = new int[136]
        {
            0x01, 0x01, 0x01, 0x01, // Man tiles (Characters)
            0x02, 0x02, 0x02, 0x02,
            0x03, 0x03, 0x03, 0x03,
            0x04, 0x04, 0x04, 0x04,
            0x05, 0x05, 0x05, 0x105,
            0x06, 0x06, 0x06, 0x06,
            0x07, 0x07, 0x07, 0x07,
            0x08, 0x08, 0x08, 0x08,
            0x09, 0x09, 0x09, 0x09,

            0x11, 0x11, 0x11, 0x11, // Pin tiles (Circles)
            0x12, 0x12, 0x12, 0x12,
            0x13, 0x13, 0x13, 0x13,
            0x14, 0x14, 0x14, 0x14,
            0x15, 0x15, 0x15, 0x115,
            0x16, 0x16, 0x16, 0x16,
            0x17, 0x17, 0x17, 0x17,
            0x18, 0x18, 0x18, 0x18,
            0x19, 0x19, 0x19, 0x19,

            0x21, 0x21, 0x21, 0x21, // Sou tiles (Bamboos)
            0x22, 0x22, 0x22, 0x22,
            0x23, 0x23, 0x23, 0x23,
            0x24, 0x24, 0x24, 0x24,
            0x25, 0x25, 0x25, 0x125,
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

        private List<string> randomizedWall = new List<string>();
        private string wallCode = string.Empty;

        public List<string> RandomizeWall() { return randomizedWall; }
        public string WallCode() { return wallCode; }

        /// <summary>
        /// Generates the wall and wall code within the class.
        /// </summary>
        public void GenerateWallAndCode()
        {
            Random random = new Random();
            int[] newTiles = standardTiles;

            int i = newTiles.Length;
            while (i > 1) // Shuffle
            {
                int j = random.Next(i--);
                int temp = newTiles[i];
                newTiles[i] = newTiles[j];
                newTiles[j] = temp;
            }

            char suit = '\0'; // Make suit to null as we don't know what the first suit is
            int length = newTiles.Length;
            for (int index = 0; index < length; index++)
            {
                string tile = TileCode(newTiles[index]); // Get the specific tile as a string
                char newSuit = tile[1]; // Add the suit for comparison later
                randomizedWall.Add(tile); // Add the tile to the list

                if (suit != newSuit) // Now we compare the suit with the previous ones, if they are the same then we wait adding the suit to the wall code until they're done.
                {
                    if (suit != '\0')
                    {
                        wallCode += suit;
                        suit = newSuit;
                    }
                    else
                        suit = newSuit;
                }

                wallCode += tile[0];
            }
            wallCode += TileCode(newTiles[135])[1]; // Add the remaining suit to the wall code
        }

        /// <summary>
        /// Turns the numbers into strings when we need to generate wall code but also the wall itself.
        /// </summary>
        /// <param name="tile"></param>
        /// <returns></returns>
        /// <exception cref="TileNotFoundException"></exception>
        private string TileCode(int tile)
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
            throw new TileNotFoundException("Tile not found or does not exist");
        }
    }
}
