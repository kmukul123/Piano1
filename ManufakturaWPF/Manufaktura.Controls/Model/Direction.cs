﻿/*
 * Copyright 2018 Manufaktura Programów Jacek Salamon http://musicengravingcontrols.com/
 * MIT LICENCE
 
Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), 
to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, 
and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, 
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/
using Manufaktura.Music.Model;

namespace Manufaktura.Controls.Model
{
    /// <summary>
    /// Represents text directions.
    /// </summary>
    public class Direction : MusicalSymbol, IHasCustomYPosition
    {
        private double? defaultY = 0;
        private DirectionPlacementType placement = DirectionPlacementType.Above;
        private string text = "";

        /// <summary>
        /// Initializes a new instance of Direction.
        /// </summary>
        public Direction()
        {
        }

        /// <summary>
        /// Default Y position
        /// </summary>
		public double? DefaultYPosition { get { return defaultY; } set { defaultY = value; OnPropertyChanged(); } }

        /// <summary>
        /// Direction placement.
        /// </summary>
        public DirectionPlacementType Placement { get { return placement; } set { placement = value; OnPropertyChanged(); } }

        /// <summary>
        /// Direction text.
        /// </summary>
        public string Text { get { return text; } set { text = value; OnPropertyChanged(); } }

        public DirectionPlaybackEffect PlaybackEffect { get; set; }
    }

    public struct DirectionPlaybackEffect
    {
        public string DalSegno { get; set; }
        public bool IsFine { get; set; }

        public Tempo? Tempo { get; set; }
    }
}