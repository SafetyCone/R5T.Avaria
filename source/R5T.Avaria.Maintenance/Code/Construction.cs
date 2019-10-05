using System;

using BasePathUtilities = R5T.NetStandard.IO.Paths.Base.Utilities;
using PathUtilities = R5T.NetStandard.IO.Paths.Utilities;




namespace R5T.Avaria.Maintenance
{
    public static class Construction
    {
        public static void SubMain()
        {
            Construction.FindAvariaSolutionFile();
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
