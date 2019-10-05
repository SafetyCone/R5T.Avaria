using System;


namespace R5T.Avaria
{
    /// <summary>
    /// Provides the GitHub account directory path from the solution file path.
    /// </summary>
    public interface IGitHubAccountDirectoryPathProvider
    {
        string GetGitHubAccountDirectoryPath(string solutionFilePath);
    }
}
