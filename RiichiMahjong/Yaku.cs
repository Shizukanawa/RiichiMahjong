using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiichiMahjong
{
    internal class Yaku
    {
        private string _name;
        private int _hanClosed;
        private int _hanOpen;
        private bool _isYakuman;

        /// <summary>
        /// Initializes a yaku with their han values when they are open, closed and whether or not the yaku is a yakuman.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="hanClosed"></param>
        /// <param name="hanOpen"></param>
        /// <param name="isYakuman"></param>
        public Yaku(string name, int hanClosed, int hanOpen, bool isYakuman)
        {
            _name = name;
            _hanOpen = hanOpen;
            _hanClosed = hanClosed;
            _isYakuman = isYakuman;
        }
        /// <summary>
        /// Returns the name of the yaku.
        /// </summary>
        public string Name { get { return _name; } }
        /// <summary>
        /// Returns the amount of han when the hand is closed.
        /// </summary>
        public int HanClosed { get { return _hanClosed; } }
        /// <summary>
        /// Returns the amount of han when the hand is open.
        /// </summary>
        public int HanOpen { get { return _hanOpen; } }
        /// <summary>
        /// Returns whether or not the specific yaku is a yakuman.
        /// </summary>
        public bool IsYakuman { get {  return _isYakuman; } }
    }
}
