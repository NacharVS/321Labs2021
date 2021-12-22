using System;
using System.Collections.Generic;
using System.Text;

namespace Group321
{
    class Singer
    {
        public string Label { get; private set; }
        public string Style { get; private set; }
        public string Composition { get; private set; }
        public string Album { get; private set; }
        public int Year { get; private set; }

        public Singer(string label, string style, string composition, string album, int year)
        {
            Label = label;
            Style = style;
            Composition = composition;
            Album = album;
            Year = year;
        }
    }
}
