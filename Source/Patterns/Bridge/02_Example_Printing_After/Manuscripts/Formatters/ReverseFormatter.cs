﻿using System;
using System.Linq;

namespace Bridge._02_Example_Printing_After.Manuscripts.Formatters
{
    public class ReverseFormatter : IFormatter
    {
        public string Format(string key, string value) {
            return new String(value.ToArray().Reverse().ToArray());
        }
    }
}
