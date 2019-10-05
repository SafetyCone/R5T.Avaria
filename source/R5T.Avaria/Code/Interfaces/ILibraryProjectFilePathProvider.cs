using System;


namespace R5T.Avaria
{
    public interface ILibraryProjectFilePathProvider
    {
        string GetLibraryProjectFilePath(string gitHubAccountDirectoryPath, string libraryName);
    }
}
