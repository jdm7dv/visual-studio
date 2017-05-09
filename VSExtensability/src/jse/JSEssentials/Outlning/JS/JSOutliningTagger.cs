using JSEssentials.JSESettings;
using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Classification;


namespace JSEssentials.Outlining
{
	internal class JSOutliningTagger: BaseOutliningTagger
	{
		public JSOutliningTagger(ITextBuffer buffer, IClassifier classifier)
			: base(buffer, classifier)
		{
			
		}

		protected override void Init()
		{
			Outliner = new JSOutliner();
			base.Init();
		}

		protected override OutliningOptions GetOptions()
		{
			var customOptions = Global.DTE.Properties["JSEnhancements", "Options"];

			return new OutliningOptions
			{
				TabSize = Global.DTE.Properties["TextEditor", "JScript"].Item("TabSize").Value,
				AutoCollapseRegions = customOptions.Item("AutoCollapseJsRegions").Value,
				AutoCollapseComments = customOptions.Item("AutoCollapseJsComments").Value,
				AutoCollapseBraces = customOptions.Item("AutoCollapseJsBraces").Value,
				AutoCollapseToDefinitions = customOptions.Item("AutoCollapseJsToDefinitions").Value
			};			
		}
	}
}
