using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RiichiMahjong.Exceptions;

namespace RiichiMahjong
{
    public enum Seat { None, East, South, West, North }

    public class Hand
    {
        private List<Tile> _hand = new List<Tile>(); // This your starting hand.
        private List<Tile> _openHand = new List<Tile>();  // This is included in your hand if you make a call (Chii, Pon, Kan). Once a call is made, the meld cannot be changed.
        private List<Tile> _closedKans = new List<Tile>(); // If you somehow manage to make 4 closed kans, this will be filled if you get 4 tiles that you have drawn yourself.
        private Tile? _tsumogiri = null; // Tsumogiri is the tile you have just drawn.
        private Seat _seat = Seat.None;

        /// <summary>
        /// Sets the hand.
        /// </summary>
        /// <param name="hand"></param>
        public Hand(List<Tile> hand)
        {
            if (hand.Count <= 13)
                _hand = hand.ToList();
            else
                throw new HandSizeExceededException("Hand size exceeds 13 tiles excluding tsumogiri.");
        }

        /// <summary>
        /// Sets the tsumogiri variable to the given tile.
        /// </summary>
        /// <param name="tile"></param>
        public void DrawTile(Tile tile)
        {
            _tsumogiri = tile;
        }

        public void CallChii(Tile tile)
        {
            //TODO
            //NOTE = Remember only kamicha (Player to your left) can be stolen from with Chii.
        }

        public void CallPon(Tile tile)
        {
            //TODO
        }

        public void CallKan(Tile tile)
        {
            //TODO
        }

        public void SetSeat(Seat seat)
        {
            _seat = seat;
        }

        /// <summary>
        /// Returns the code of the hand in a string format
        /// </summary>
        /// <returns></returns>
        public string HandCode()
        {
            _hand.Sort(SortTiles);
            string handCode = string.Empty;
            string suit = string.Empty; // Make suit to null as we don't know what the first suit is
            int length = _hand.Count;

            for (int index = 0; index < length; index++)
            {
                string newSuit = _hand[index].Suit;
                if (suit != newSuit) // Now we compare the suit with the previous ones, if they are the same then we wait adding the suit to the hand code until they're done.
                {
                    if (suit != string.Empty)
                    {
                        handCode += suit;
                        suit = newSuit;
                    }
                    else
                        suit = newSuit;
                }
                handCode += _hand[index].Number;
            }
            handCode += suit; // Add the remaining suit to the hand code
            
            return handCode;
        }

        private static int SortTiles(Tile tile1, Tile tile2)
        {
            if (tile1.Number == tile2.Number) // If the numbers are the same, sort based off their suit.
                return tile1.Suit.CompareTo(tile2.Suit);
            else if (tile1.Number > tile2.Number)
                return -1; // Return tile1 if the number is lower than tile2.
            else return 1; // Return tile2 if the number is lower than tile1.
        }
    }
}
