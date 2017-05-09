﻿//
// ProjectOnErrorElement.cs
//
// Author:
//   Leszek Ciesielski (skolima@gmail.com)
//
// (C) 2011 Leszek Ciesielski
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using System.Xml;
using System.Diagnostics;

namespace Sandcastle.Construction
{
    [Serializable]
    public sealed class ProjectOnErrorElement : ProjectElement
    {
        internal ProjectOnErrorElement(string executeTargets, ProjectRootElement containingProject)
            : this(containingProject)
        {
            ExecuteTargetsAttribute = executeTargets;
        }

        internal ProjectOnErrorElement(ProjectRootElement containingProject)
        {
            RootElement = containingProject;
        }

        public override ProjectElementType ElementType
        {
            get
            {
                return ProjectElementType.OnError;
            }
        }

        public string ExecuteTargetsAttribute { get; set; }
        
        protected override string XmlName
        {
            get { return "OnError"; }
        }

        protected override void WriteXmlValue(XmlWriter writer)
        {
            base.WriteXmlValue(writer);
            WriteXmlAttribute(writer, "ExecuteTargets", ExecuteTargetsAttribute);
        }

        protected override void ReadXmlAttribute(XmlReader reader,
            string name, string value)
        {
            switch (name)
            {
                case "ExecuteTargets":
                    ExecuteTargetsAttribute = value;
                    break;
                default:
                    base.ReadXmlAttribute(reader, name, value);
                    break;
            }
        }
    }
}
