using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiichiMahjong.Exceptions
{
    public class YakuNotFoundException : Exception
    {
        public YakuNotFoundException() { }

        public YakuNotFoundException(string message)
            : base(message) { }

        public YakuNotFoundException(string message, Exception inner)
            : base(message, inner) { }
    }
}
