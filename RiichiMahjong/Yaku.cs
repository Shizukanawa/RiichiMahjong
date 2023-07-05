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

        public string name { get { return _name; } set { _name = value; } }
        public int hanClosed { get { return _hanClosed; } set { _hanClosed = value; } }
        public int hanOpen { get { return _hanOpen; } set { _hanOpen = value; } }
        public bool isYakuman { get {  return _isYakuman; } set {_isYakuman = value; } }
    }
}
