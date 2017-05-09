using JSEssentials.JSESettings;
using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Classification;

namespace JSEssentials.Outlining
{
	internal class CssOutliningTagger: BaseOutliningTagger
	{
		public CssOutliningTagger(ITextBuffer buffer, IClassifier classifier)
			: base(buffer, classifier)
		{
			
		}

		protected override void Init()
		{
			Outliner = new CssOutliner();
			base.Init();
		}

		protected override OutliningOptions GetOptions()
		{
			var customOptions = Global.DTE.Properties["JSEssentials", "Options"];

			return new OutliningOptions
			{
				TabSize = Global.DTE.Properties["TextEditor", "CSS"].Item("TabSize").Value,
				AutoCollapseRegions = customOptions.Item("AutoCollapseCssRegions").Value,
				AutoCollapseComments = customOptions.Item("AutoCollapseCssComments").Value,
				AutoCollapseBraces = customOptions.Item("AutoCollapseCssBraces").Value
			};			
		}
	}
}
