using System;

using PathUtilities = R5T.NetStandard.IO.Paths.Utilities;


namespace R5T.Avaria
{
    public class StandardLibraryProjectFilePathProvider : ILibraryProjectFilePathProvider
    {
        public string GetLibraryProjectFilePath(string gitHubAccountDirectoryPath, string libraryName)
        {
            var repositoryDirectoryName = libraryName;
            var sourceDirectoryName = @"source";
            var libraryProjectDirectoryName = libraryName;
            var libraryProjectFileName = $"{libraryName}.csproj";

            var libraryProjectFilePath = PathUtilities.CombineWindows(gitHubAccountDirectoryPath, repositoryDirectoryName, sourceDirectoryName, libraryProjectDirectoryName, libraryProjectFileName);
            return libraryProjectFilePath;
        }
    }
}
