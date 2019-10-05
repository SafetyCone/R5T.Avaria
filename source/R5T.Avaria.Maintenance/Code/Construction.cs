using System;

using BasePathUtilities = R5T.NetStandard.IO.Paths.Base.Utilities;


namespace R5T.Avaria.Maintenance
{
    public static class Construction
    {
        public static void SubMain()
        {
            //Construction.FindAvariaSolutionFile();
            //Construction.GetGitHubAccountDirectoryPath();
            Construction.GetLibraryProjectDirectoryPath();
        }

        private static void GetLibraryProjectDirectoryPath()
        {
            var libraryName = @"R5T.NetStandard.IO.Paths.Types";

            var currentExecutableFilePath = BasePathUtilities.ExecutablePathValue;

            Console.WriteLine($"Current executable file path:\n{currentExecutableFilePath}");

            var solutionFilePathProvider = new DevelopmentSolutionFilePathProvider();
            var gitHubAccountDirectoryPathProvider = new StandardGitHubAccountDirectoryPathProvider();
            var libraryProjectFilePathProvider = new StandardLibraryProjectFilePathProvider();

            var solutionFilePath = solutionFilePathProvider.GetSolutionFilePath(currentExecutableFilePath, @"R5T.Avaria.sln");
            var gitHubAccountDirectoryPath = gitHubAccountDirectoryPathProvider.GetGitHubAccountDirectoryPath(solutionFilePath);
            var libraryProjectFilePath = libraryProjectFilePathProvider.GetLibraryProjectFilePath(gitHubAccountDirectoryPath, libraryName);

            Console.WriteLine($"Library project file path:\n{libraryProjectFilePath}");
        }

        private static void GetGitHubAccountDirectoryPath()
        {
            var currentExecutableFilePath = BasePathUtilities.ExecutablePathValue;

            Console.WriteLine($"Current executable file path:\n{currentExecutableFilePath}");

            var solutionFilePathProvider = new DevelopmentSolutionFilePathProvider();
            var gitHubAccountDirectoryPathProvider = new StandardGitHubAccountDirectoryPathProvider();

            var solutionFilePath = solutionFilePathProvider.GetSolutionFilePath(currentExecutableFilePath, @"R5T.Avaria.sln");
            var gitHubAccountDirectoryPath = gitHubAccountDirectoryPathProvider.GetGitHubAccountDirectoryPath(solutionFilePath);

            Console.WriteLine($"GitHub account directory path:\n{gitHubAccountDirectoryPath}");
        }

        private static void FindAvariaSolutionFile()
        {
            var currentExecutableFilePath = BasePathUtilities.ExecutablePathValue;

            Console.WriteLine($"Current executable file path:\n{currentExecutableFilePath}");

            var solutionFilePathProvider = new DevelopmentSolutionFilePathProvider();

            var solutionFilePath = solutionFilePathProvider.GetSolutionFilePath(currentExecutableFilePath, @"R5T.Avaria.sln");

            Console.WriteLine($"Solution file path:\n{solutionFilePath}");
        }
    }
}
