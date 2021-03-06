﻿/*
 *	The MIT License (MIT)
 *
 *	Copyright (c) 2017 Jerry Lee
 *
 *	Permission is hereby granted, free of charge, to any person obtaining a copy
 *	of this software and associated documentation files (the "Software"), to deal
 *	in the Software without restriction, including without limitation the rights
 *	to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 *	copies of the Software, and to permit persons to whom the Software is
 *	furnished to do so, subject to the following conditions:
 *
 *	The above copyright notice and this permission notice shall be included in all
 *	copies or substantial portions of the Software.
 *
 *	THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 *	IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 *	FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 *	AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 *	LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 *	OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 *	SOFTWARE.
 */

using System;
using UnityEngine;

namespace QuickUnity.Attributes
{
    /// <summary>
    /// Class EnumFlagsAttribute for marking attribute as enum flags.
    /// </summary>
    /// <seealso cref="UnityEngine.PropertyAttribute"/>
    [AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
    public class EnumFlagsAttribute : PropertyAttribute
    {
        /// <summary>
        /// Caption/label for the attribute.
        /// </summary>
        private string label;

        /// <summary>
        /// Gets the caption/label for the attribute.
        /// </summary>
        /// <value>The caption/label for the attribute.</value>
        public string Label
        {
            get { return label; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnumFlagsAttribute"/> class.
        /// </summary>
        public EnumFlagsAttribute()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnumFlagsAttribute"/> class.
        /// </summary>
        /// <param name="label">The label.</param>
        public EnumFlagsAttribute(string label)
        {
            this.label = label;
        }
    }
}