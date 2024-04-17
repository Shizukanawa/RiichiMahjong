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
        private List<Tile> _wall = new List<Tile>();
        private string _wallCode = string.Empty;

        /// <summary>
        /// Initializes the wall with default settings.
        /// </summary>
        public Wall()
        {
            GenerateWallAndCode();
        }
        public List<Tile> GetWall() { return _wall; }
        public string WallCode() { return _wallCode; }

        /// <summary>
        /// Generates the wall and wall code within the class.
        /// </summary>
        public void GenerateWallAndCode()
        {
            Random random = new Random();
            TileList tileList = new TileList();
            _wall = tileList.Tiles;

            int i = _wall.Count;
            while (i > 1) // Shuffles the list
            {
                int j = random.Next(i--);
                Tile temp = _wall[i];
                _wall[i] = _wall[j];
                _wall[j] = temp;
            }
            GenerateWallCode();
        }

        /// <summary>
        /// Generates the wall code based on the wall.
        /// </summary>
        private void GenerateWallCode()
        {
            _wallCode = string.Empty; // Make sure string is empty in case it gets called again.
            string suit = "\0"; // Make suit to null as we don't know what the first suit is
            int length = _wall.Count;
            for (int index = 0; index < length; index++)
            {
                Tile tile = _wall[index]; // Get the specific tile as a string
                string newSuit = tile.Suit; // Add the suit for comparison later
                _wall.Add(tile); // Add the tile to the list

                if (suit != newSuit) // Now we compare the suit with the previous ones, if they are the same then we wait adding the suit to the wall code until they're done.
                {
                    if (suit != "\0")
                    {
                        _wallCode += suit;
                        suit = newSuit;
                    }
                    else
                        suit = newSuit;
                }
                _wallCode += tile.Number;
            }
            _wallCode += _wall[_wall.Count - 1].Suit; // Add the remaining suit to the wall code.
        }

        public void ReadWallCode(string wallCode)
        {
            int numberPointer = 0, letterPointer = 0;
            _wall.Clear(); // If wall contains stuff, reset it.
            while (letterPointer < wallCode.Length)
            {
                if (char.IsLetter(wallCode[letterPointer])) // Checks if the pointer is on a letter.
                {
                    while(numberPointer < letterPointer)
                    {
                        _wall.Add(new Tile(int.Parse(wallCode[numberPointer].ToString()), wallCode[letterPointer].ToString()));
                        numberPointer++;
                    }
                    numberPointer++;
                }
                ++letterPointer;
            }
            GenerateWallCode(); // Could just replace the string but this feels more safe.
        }
    }
}
