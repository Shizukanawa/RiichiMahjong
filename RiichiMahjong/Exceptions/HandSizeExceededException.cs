using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiichiMahjong.Exceptions
{
    public class HandSizeExceededException : Exception
    {
        public HandSizeExceededException() { }

        public HandSizeExceededException(string message)
            : base(message) { }

        public HandSizeExceededException(string message, Exception inner)
            : base(message, inner) { }
    }
}
