// Guids.cs
// MUST match guids.h
using System;

namespace VSShellStub2.AboutBoxPackage
{
    static class GuidList
    {
        public const string guidAboutBoxPackagePkgString = "769dd01c-5a09-4e11-84f9-2a3de610cb94";
        public const string guidAboutBoxPackageCmdSetString = "f923ca61-fb69-4b30-8e86-36b48c871f0e";

        public static readonly Guid guidAboutBoxPackageCmdSet = new Guid(guidAboutBoxPackageCmdSetString);
    };
}