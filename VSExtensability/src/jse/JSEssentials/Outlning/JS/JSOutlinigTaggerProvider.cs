using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Text.Projection;
using Microsoft.VisualStudio.Text.Tagging;
using Microsoft.VisualStudio.Utilities;


namespace JSEssentials.Outlining
{
	[Export(typeof(ITaggerProvider))]
	[TagType(typeof(IOutliningRegionTag))]
	[ContentType("JScript")]
	//todo make separate provider for HTML
	[ContentType("HTML")]

	internal sealed class JSOutliningTaggerProvider : ITaggerProvider
	{
		[Import]
		IClassifierAggregatorService classifierAggregator;

		public ITagger<T> CreateTagger<T>(ITextBuffer buffer) where T : ITag
		{
			//no outlining for projection buffers
			if (buffer is IProjectionBuffer) return null;

			IClassifier classifier = classifierAggregator.GetClassifier(buffer);
			//var spans = c.GetClassificationSpans(new SnapshotSpan(buffer.CurrentSnapshot, 0, buffer.CurrentSnapshot.Length));
			//create a single tagger for each buffer.
			return buffer.Properties.GetOrCreateSingletonProperty(() => new JSOutliningTagger(buffer, classifier) as ITagger<T>);
		} 
	}
}
