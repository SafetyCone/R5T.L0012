using System;
using System.Threading.Tasks;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.MSBuild;

using R5T.L0012.T002;


namespace System
{
    public static class MSBuildWorkspaceExtensions
    {
        public static Task<Project> OpenProject(this MSBuildWorkspace workspace,
            string projectFilePath)
        {
            var projectLoadingProgress = ProjectLoadingProgress.New();

            return workspace.OpenProjectAsync(projectFilePath, projectLoadingProgress);
        }

        public static Task<Solution> OpenSolution(this MSBuildWorkspace workspace,
            string solutionFilePath)
        {
            var projectLoadingProgress = ProjectLoadingProgress.New();

            return workspace.OpenSolutionAsync(solutionFilePath, projectLoadingProgress);
        }
    }
}
