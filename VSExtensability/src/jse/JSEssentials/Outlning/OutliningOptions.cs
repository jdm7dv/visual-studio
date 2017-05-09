using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JSEssentials.Outlining
{
	class OutliningOptions
	{
		public int TabSize { get; set; }
		public bool AutoCollapseRegions { get; set; }
		public bool AutoCollapseComments { get; set; }
		public bool AutoCollapseBraces { get; set; }
		public bool AutoCollapseToDefinitions { get; set; }
	}
}
