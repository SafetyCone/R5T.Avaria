using System;

using PathUtilities = R5T.NetStandard.IO.Paths.Utilities;


namespace R5T.Avaria
{
    /// <summary>
    /// Gets the solution file path from the current executable's file path assuming the directory structure:
    ///     ../{Solution Directory}/{Project Directory}/bin/Debug/netcoreapp2.2/{executable file}
    /// Solution file natm is required since there might be multiple solution files.
    /// </summary>
    public class DevelopmentSolutionFilePathProvider : ISolutionFilePathProvider
    {
        public string GetSolutionFilePath(string currentExecutableFilePath, string solutionFileName)
        {
            var binDebugNetCoreAppDirectoryPath = PathUtilities.GetDirectoryPath(currentExecutableFilePath);
            var binDebugDirectoryPath = PathUtilities.GetParentDirectoryPath(binDebugNetCoreAppDirectoryPath);
            var binDirectoryPath = PathUtilities.GetParentDirectoryPath(binDebugDirectoryPath);
            var projectDirectoryPath = PathUtilities.GetParentDirectoryPath(binDirectoryPath);
            var solutionDirectoryPath = PathUtilities.GetParentDirectoryPath(projectDirectoryPath);

            var solutionFilePath = PathUtilities.Combine(solutionDirectoryPath, solutionFileName);
            return solutionFilePath;
        }
    }
}
