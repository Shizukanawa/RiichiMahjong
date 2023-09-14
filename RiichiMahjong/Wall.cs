using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RiichiMahjong.Exceptions;

namespace RiichiMahjong
{
    public class Wall
    {
        private List<string> _wall = new List<string>();
        private string _wallCode = string.Empty;

        /// <summary>
        /// Initializes the wall with default settings.
        /// </summary>
        public Wall()
        {
            GenerateWallAndCode();
        }
        public List<string> GetWall() { return _wall; }
        public string WallCode() { return _wallCode; }

        /// <summary>
        /// Generates the wall and wall code within the class.
        /// </summary>
        public void GenerateWallAndCode()
        {
            Random random = new Random();
            TileList tileList = new TileList();
            List<Tile> newTiles = tileList.Tiles;

            int i = newTiles.Count;
            while (i > 1) // Shuffles the list
            {
                int j = random.Next(i--);
                Tile temp = newTiles[i];
                newTiles[i] = newTiles[j];
                newTiles[j] = temp;
            }

            char suit = '\0'; // Make suit to null as we don't know what the first suit is
            int length = newTiles.Count;
            for (int index = 0; index < length; index++)
            {
                string tile = newTiles[index].TileCode(); // Get the specific tile as a string
                char newSuit = tile[1]; // Add the suit for comparison later
                _wall.Add(tile); // Add the tile to the list

                if (suit != newSuit) // Now we compare the suit with the previous ones, if they are the same then we wait adding the suit to the wall code until they're done.
                {
                    if (suit != '\0')
                    {
                        _wallCode += suit;
                        suit = newSuit;
                    }
                    else
                        suit = newSuit;
                }
                _wallCode += tile[0];
            }
            _wallCode += newTiles[135].TileCode()[1]; // Add the remaining suit to the wall code
        }
    }
}
