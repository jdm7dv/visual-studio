﻿/*
Copyright (c) 2007 Gustavo G. Duarte (http://duartes.org/gustavo)

Permission is hereby granted, free of charge, to any person obtaining a copy of 
this software and associated documentation files (the "Software"), to deal in 
the Software without restriction, including without limitation the rights to 
use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies
of the Software, and to permit persons to whom the Software is furnished to do 
so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all 
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR 
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE 
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER 
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, 
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE 
SOFTWARE.
*/

using System;
using System.Runtime.Serialization;
using Common.Helpers;

namespace Iris.VimRegexConversion {
	/// <summary>
	/// This exception is thrown when a Vim-style regex cannot be converted to a Perl-style regex
	/// </summary>
	/// <remarks>
	/// <para>This indicates either a malformed Vim regex or a bug in the <see cref="VimRegexConverter" />.</para>
	/// </remarks>
	[Serializable]
	public class RegexConversionException : CognizantException {
		/// <summary>
		/// Initializes a new instance of the <see cref="RegexConversionException"/> class.
		/// </summary>
		public RegexConversionException() {}

		/// <summary>
		/// Initializes a new instance of the <see cref="RegexConversionException"/> class.
		/// </summary>
		public RegexConversionException(string message) : base(ExceptionInformation.NoRetry, message) {}

		/// <summary>
		/// Initializes a new instance of the <see cref="RegexConversionException"/> class.
		/// </summary>
		public RegexConversionException(string message, Exception innerException) : base(ExceptionInformation.Bug, message, innerException) {}

		/// <summary>
		/// Initializes a new instance of the <see cref="RegexConversionException"/> class.
		/// </summary>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo"/> that holds the serialized object data about the exception being thrown.</param>
		/// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext"/> that contains contextual information about the source or destination.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="info"/> parameter is null. </exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult"/> is zero (0). </exception>
		protected RegexConversionException(SerializationInfo info, StreamingContext context) : base(info, context) {}
	}
}