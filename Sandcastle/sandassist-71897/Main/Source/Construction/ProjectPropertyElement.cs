//
// ProjectPropertyElement.cs
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

using Sandcastle.Construction.Utils;

namespace Sandcastle.Construction
{
    [Serializable]
    public sealed class ProjectPropertyElement : ProjectElement
    {
        internal ProjectPropertyElement(string name, ProjectRootElement containingProject)
        {
            Name = name;
            RootElement = containingProject;
        }

        public override ProjectElementType ElementType
        {
            get
            {
                return ProjectElementType.Property;
            }
        }
        
        public string Name { get; set; }
        
        public string Value { get; set; }

        protected override string XmlName
        {
            get { return Name; }
        }

        protected override void WriteXmlValue(XmlWriter writer)
        {
            base.WriteXmlValue(writer);
            if (!StringUtils.IsNullOrWhiteSpace(Value))
                writer.WriteValue(Value);
        }

        protected override void ReadXmlValue(XmlReader reader)
        {
            while (reader.Read() & reader.NodeType != XmlNodeType.Text)
                ;
            Value = reader.Value;
        }
    }
}
