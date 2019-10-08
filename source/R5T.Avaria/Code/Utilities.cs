using System;
using System.IO;

using BasePathUtilities = R5T.NetStandard.IO.Paths.Base.Utilities;
using VirconiumUtilities = R5T.Private.Virconium.Lib.Utilities;


namespace R5T.Avaria
{
    public static class Utilities
    {
        public static string GetExecutablePath()
        {
            var executablePath = BasePathUtilities.ExecutablePathValue;
            return executablePath;
        }

        public static void RemoveExtraneousDependencies(string solutionFilePath, string[] projectFilePaths, TextWriter writer, bool dryRun = true)
        {
            VirconiumUtilities.RemoveExtraneousDependencies(solutionFilePath, projectFilePaths, writer, dryRun);
        }

        public static void RemoveExtraneousDependencies(string solutionFilePath, string[] projectFilePaths, bool dryRun = true)
        {
            VirconiumUtilities.RemoveExtraneousDependencies(solutionFilePath, projectFilePaths, dryRun);
        }

        public static void RemoveExtraneousDependencies(string solutionFilePath, TextWriter writer, bool dryRun = true)
        {
            VirconiumUtilities.RemoveExtraneousDependencies(solutionFilePath, writer, dryRun);
        }

        public static void RemoveExtraneousDependencies(string solutionFilePath, bool dryRun = true)
        {
            VirconiumUtilities.RemoveExtraneousDependencies(solutionFilePath, dryRun);
        }

        public static void AddMissingDependencies(string solutionFilePath, TextWriter writer, bool dryRun = true)
        {
            VirconiumUtilities.AddMissingDependencies(solutionFilePath, writer, dryRun);
        }

        public static void AddMissingDependencies(string solutionFilePath, bool dryRun = true)
        {
            VirconiumUtilities.AddMissingDependencies(solutionFilePath, dryRun);
        }
    }
}
