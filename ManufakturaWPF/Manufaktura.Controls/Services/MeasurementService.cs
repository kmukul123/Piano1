/*
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
using Manufaktura.Controls.Model;
using Manufaktura.Controls.Primitives;
using System.Collections.Generic;

namespace Manufaktura.Controls.Services
{
    /// <summary>
    /// Default implementation of IMeasurementService
    /// </summary>
    public class MeasurementService : IMeasurementService
    {
        public MeasurementService()
        {
            LastNotePositionX = 0; //for chords / dla akordów
            LastNoteEndXPosition = 0; //for many voices / dla wielu głosów

            TieStartPoint = new Point();
            LastNoteInMeasureEndXPosition = 0; //for many voices - location of the last note in the measure / dla wielu głosów - punkt ostatniej nuty w takcie
        }

        public double LastMeasurePositionX { get; set; }

        public double LastNoteEndXPosition { get; set; }

        //for many voices / dla wielu głosów
        //for many voices - starting point for all voices / dla wielu głosów - punkt rozpoczęcia wszystkich głosów
        public double LastNoteInMeasureEndXPosition { get; set; }

        public double LastNotePositionX { get; set; } //for chords / dla akordów

        public Dictionary<int, SlurInfo> Slurs { get; } = new Dictionary<int, SlurInfo>();

        public Point TieStartPoint { get; set; }

        //for many voices - location of the last note in the measure / dla wielu głosów - punkt ostatniej nuty w takcie
        public Tuplet TupletState { get; set; }
        public StaffSystem TieStartSystem { get; set; }

        public Note TieStartElement { get; set; }
    }
}