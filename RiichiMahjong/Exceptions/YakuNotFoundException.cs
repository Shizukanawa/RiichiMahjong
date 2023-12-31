﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiichiMahjong.Exceptions
{
    public class YakuNotFoundException : Exception
    {
        public YakuNotFoundException() { }

        public YakuNotFoundException(string yakuName)
            : base($"Yaku not found: {yakuName}") { }

        public YakuNotFoundException(string message, Exception inner)
            : base(message, inner) { }
    }
}
