using System;


namespace R5T.Avaria
{
    /// <summary>
    /// Provides the solution file path from the executable file path.
    /// The solution file name is required since there might be multiple solution files in the solution directory.
    /// </summary>
    public interface ISolutionFilePathProvider
    {
        string GetSolutionFilePath(string currentExecutableFilePath, string solutionFileName);
    }
}
