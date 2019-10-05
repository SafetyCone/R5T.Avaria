using System;


namespace R5T.Avaria
{
    public interface ISolutionFilePathProvider
    {
        string GetSolutionFilePath(string currentExecutableFilePath, string solutionFileName);
    }
}
