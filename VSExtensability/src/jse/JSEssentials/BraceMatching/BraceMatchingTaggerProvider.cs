using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Editor;
using Microsoft.VisualStudio.Text.Projection;
using Microsoft.VisualStudio.Text.Tagging;
using Microsoft.VisualStudio.Utilities;

namespace JSEssentials.BraceMatching
{
	[Export(typeof(IViewTaggerProvider))]
	[ContentType("JScript")]
	[ContentType("HTML")]
	[ContentType("CSS")]	
	[TagType(typeof(TextMarkerTag))]
	internal class BraceMatchingTaggerProvider : IViewTaggerProvider
	{
		public ITagger<T> CreateTagger<T>(ITextView textView, ITextBuffer buffer) where T : ITag
		{
			if (textView == null || buffer is IProjectionBuffer) return null;

			//provide highlighting only on the top-level buffer
			/*if (textView.TextBuffer != buffer)
				return null;*/

			return new BraceMatchingTagger(textView, buffer) as ITagger<T>;
		}
	}
}
