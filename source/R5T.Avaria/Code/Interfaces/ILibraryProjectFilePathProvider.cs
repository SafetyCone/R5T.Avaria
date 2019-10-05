using System;


namespace R5T.Avaria
{
    /// <summary>
    /// Provides a library file path from the GitHub account directory path and the library name.
    /// </summary>
    public interface ILibraryProjectFilePathProvider
    {
        string GetLibraryProjectFilePath(string gitHubAccountDirectoryPath, string libraryName);
    }
}
