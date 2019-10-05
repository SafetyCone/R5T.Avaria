using System;

using PathUtilities = R5T.NetStandard.IO.Paths.Utilities;


namespace R5T.Avaria
{
    /// <summary>
    /// Provides the GitHub account directory path from the solution file path assuming files are organized as:
    ///     ../{GitHub}/GitHub Account/Repository Directory/source/Solution file
    /// </summary>
    public class StandardGitHubAccountDirectoryPathProvider : IGitHubAccountDirectoryPathProvider
    {
        public string GetGitHubAccountDirectoryPath(string solutionFilePath)
        {
            var solutionDirectoryPath = PathUtilities.GetDirectoryPath(solutionFilePath);
            var sourceDirectoryPath = PathUtilities.GetParentDirectoryPath(solutionFilePath);
            var repositoryDirectoryPath = PathUtilities.GetParentDirectoryPath(sourceDirectoryPath);

            var gitHubAccountDirectoryPath = PathUtilities.GetParentDirectoryPath(repositoryDirectoryPath);
            return gitHubAccountDirectoryPath;
        }
    }
}
