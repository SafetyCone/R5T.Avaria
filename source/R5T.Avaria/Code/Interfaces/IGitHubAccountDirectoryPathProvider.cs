using System;


namespace R5T.Avaria
{
    public interface IGitHubAccountDirectoryPathProvider
    {
        string GetGitHubAccountDirectoryPath(string solutionFilePath);
    }
}
