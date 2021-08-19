using System;
using System.Threading.Tasks;

using Microsoft.CodeAnalysis.MSBuild;

using R5T.L0012.T001;

using Instances = R5T.L0012.T001.X002.Instances;


namespace System
{
    public static class IMSBuildExtensions
    {
        public static async Task UsingMSBuildWorkspace(this IMSBuild _,
            Func<MSBuildWorkspace, Task> workspaceAction)
        {
            Instances.MSBuildLocation.RegisterDefaults();

            using var workspace = MSBuildWorkspace.Create();

            // Await the action (instead of returning the task) since we do not want the IDisposable workspace to be disposed upon method return.
            await workspaceAction(workspace);
        }

        public static async Task<T> UsingMSBuildWorkspace<T>(this IMSBuild _,
            Func<MSBuildWorkspace, Task<T>> workspaceFunction)
        {
            Instances.MSBuildLocation.RegisterDefaults();

            using var workspace = MSBuildWorkspace.Create();

            // Await the action (instead of returning the task) since we do not want the IDisposable workspace to be disposed upon method return.
            var output = await workspaceFunction(workspace);
            return output;
        }
    }
}
