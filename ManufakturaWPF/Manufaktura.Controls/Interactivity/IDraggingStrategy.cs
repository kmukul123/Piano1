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
using Manufaktura.Controls.Primitives;
using Manufaktura.Controls.Rendering;
using System;

namespace Manufaktura.Controls.Interactivity
{
	/// <summary>
	/// Strategy that describes dragging behavior of specific elements
	/// </summary>
	public interface IDraggingStrategy
	{
		/// <summary>
		/// Type of MusicalSymbol which dragging behavior is managed by this class
		/// </summary>
		Type ElementType { get; }

		/// <summary>
		/// Manages dragging behavior
		/// </summary>
		/// <param name="renderer">Score renderer</param>
		/// <param name="draggedElement">Dragged element</param>
		/// <param name="draggingState">Dragging state</param>
		/// <param name="currentPosition">Current cursor position</param>
		void Drag(ScoreRendererBase renderer, object draggedElement, DraggingState draggingState, Point currentPosition);
	}
}