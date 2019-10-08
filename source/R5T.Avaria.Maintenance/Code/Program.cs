using System;

using AvariaUtilities = R5T.Avaria.Utilities;


namespace R5T.Avaria.Maintenance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Construction.SubMain();

            Program.SubMain();
        }

        private static void SubMain()
        {
            //Program.RemoveExtraneousDependencies(true);
            Program.AddMissingDependencies(true);
        }

        private static void RemoveExtraneousDependencies(bool dryRun)
        {
            var currentExecutableFilePath = AvariaUtilities.GetExecutablePath();

            Console.WriteLine($"Current executable file path:\n{currentExecutableFilePath}");

            var solutionFilePathProvider = new DevelopmentSolutionFilePathProvider();

            var solutionFilePath = solutionFilePathProvider.GetSolutionFilePath(currentExecutableFilePath, @"R5T.Avaria.sln");

            Console.WriteLine($"Solution file path:\n{solutionFilePath}");

            AvariaUtilities.RemoveExtraneousDependencies(solutionFilePath, dryRun);
        }

        private static void AddMissingDependencies(bool dryRun)
        {
            var currentExecutableFilePath = AvariaUtilities.GetExecutablePath();

            Console.WriteLine($"Current executable file path:\n{currentExecutableFilePath}");

            var solutionFilePathProvider = new DevelopmentSolutionFilePathProvider();

            var solutionFilePath = solutionFilePathProvider.GetSolutionFilePath(currentExecutableFilePath, @"R5T.Avaria.sln");

            Console.WriteLine($"Solution file path:\n{solutionFilePath}");

            AvariaUtilities.AddMissingDependencies(solutionFilePath, dryRun);
        }
    }
}
