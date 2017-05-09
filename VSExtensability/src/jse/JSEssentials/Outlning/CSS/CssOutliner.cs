using System;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Classification;

namespace JSEssentials.Outlining
{
	internal class CssOutliner: BaseOutliner
	{
		private static Regex RegionStartRegex = new Regex(@"^\/\*\s*#region\s(.+?)(\*\/)?$", RegexOptions.Compiled);
		private static Regex RegionEndRegex = new Regex(@"^\/\*\s*#endregion", RegexOptions.Compiled);

		/// <summary>
		/// parses input buffer, searches for region start
		/// </summary>
		/// <param name="parser"></param>
		/// <returns>created region or null</returns>
		public override TextRegion TryCreateRegion(SnapshotParser parser)
		{
			SnapshotPoint point = parser.CurrentPoint;
			ClassificationSpan span = parser.CurrentSpan;
			if (span == null)
			{
				char c = point.GetChar();
				if (c == '{')
					return new TextRegion(point, TextRegionType.Block);
			}
			else if (span.ClassificationType.Classification == "CSS Comment")
			{
				return ParseComment(parser, RegionStartRegex, RegionEndRegex);
			}
			return null;
		}

		

		/// <summary>
		/// tries to close region
		/// </summary>
		/// <param name="parser">parser</param>
		/// <returns>whether region was closed</returns>
		protected override bool TryComplete(TextRegion r, SnapshotParser parser)
		{
			SnapshotPoint point = parser.CurrentPoint;
			ClassificationSpan span = parser.CurrentSpan;

			if (span == null)
			{
				char c = point.GetChar();
				if (r.RegionType == TextRegionType.Block && c == '}')
				{
					r.EndPoint = point + 1;
				}
			}
			else
			{
				switch (r.RegionType)
				{
					case TextRegionType.Region:
						if (span.ClassificationType.Classification == "CSS Comment")
						{
							Match m = RegionEndRegex.Match(span.Span.GetText());
							if (m.Success)
								r.EndPoint = span.Span.End;
						}
						break;
				}
			}
			return r.Complete;
		}

		/// <summary>
		/// tries to merge sequential comments		
		/// </summary>
		/// <returns>true, if merged. In this case newRegion is not added to Children</returns>
		protected override bool TryMergeComments(TextRegion r, TextRegion newRegion)
		{
			if (r.Children.Count > 0)
			{
				TextRegion last = r.Children[r.Children.Count - 1];
				//merge conditions
				if (last.RegionType == TextRegionType.Comment
					&& newRegion.RegionType == TextRegionType.Comment
					//todo check if this is really needed
					&& !newRegion.InnerText.StartsWith("/*", StringComparison.Ordinal)
					&& string.IsNullOrWhiteSpace(new SnapshotSpan(last.EndPoint, newRegion.StartPoint).GetText()))
				{
					//instead of adding newRegion, we just move last child's end
					last.EndPoint = newRegion.EndPoint;
					return true;
				}
			}
			return false;
		}

	}
}