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
using System;
using System.Collections.Generic;

namespace Manufaktura.Music.MelodicTrails
{
    public class ConjunctMovementTrail : RandomIntervalsMelodicTrail
    {
        private MovementType movementType;
        private Dictionary<DiatonicInterval, double> allowedIntervals;

        public override Dictionary<Model.DiatonicInterval, double> AllowedIntervals
        {
            get { return allowedIntervals; }
        }

        public ConjunctMovementTrail(MovementType movementType, Pitch minPitch, Pitch maxPitch, int minNotes, int maxNotes)
            : base(minPitch, maxPitch, minNotes, maxNotes)
        {
            this.movementType = movementType;
            switch (movementType)
            {
                case MovementType.Anabasis:
                    allowedIntervals = new Dictionary<DiatonicInterval, double>
                    {
                        {DiatonicInterval.Second, 16},
                        {DiatonicInterval.Third, 8},
                        {DiatonicInterval.Second.MakeDescending(), 2},
                        {DiatonicInterval.Third.MakeDescending(), 1}
                    };
                    break;

                case MovementType.Katabasis:
                    allowedIntervals = new Dictionary<DiatonicInterval, double>
                    {
                        {DiatonicInterval.Second, 2},
                        {DiatonicInterval.Third, 1},
                        {DiatonicInterval.Second.MakeDescending(), 16},
                        {DiatonicInterval.Third.MakeDescending(), 8}
                    };
                    break;

                case MovementType.Metabasis:
                    allowedIntervals = new Dictionary<DiatonicInterval, double>
                    {
                        {DiatonicInterval.Second, 1},
                        {DiatonicInterval.Third, 1},
                        {DiatonicInterval.Second.MakeDescending(), 1},
                        {DiatonicInterval.Third.MakeDescending(), 1}
                    };
                    break;

                default:
                    throw new NotImplementedException("Unsupported movement type.");
            }
        }
    }
}