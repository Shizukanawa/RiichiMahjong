using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiichiMahjong
{
    public class TileNotFoundException : Exception
    {
        public TileNotFoundException() { }

        public TileNotFoundException(string message) 
            : base(message) { }

        public TileNotFoundException(string message, Exception inner)
            : base(message, inner) { }
    }
}
