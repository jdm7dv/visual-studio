using System;
using EnvDTE;
using Microsoft.VisualStudio.Shell;
using EnvDTE;

namespace JSEssentials.JSESettings
{
	public static class Global
	{
		public static DTE DTE = InitGlobals();
		public static Version IdeVersion;

		private static DTE InitGlobals()
		{
			DTE dte = Package.GetGlobalService(typeof(DTE)) as DTE;
			IdeVersion = Version.Parse(dte.Version);
			return dte;
		}

	}
}
