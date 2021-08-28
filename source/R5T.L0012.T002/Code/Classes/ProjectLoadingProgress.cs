using System;

using Microsoft.CodeAnalysis.MSBuild;


namespace R5T.L0012.T002
{
    public class ProjectLoadingProgress : IProgress<ProjectLoadProgress>
    {
        #region Static

        public static ProjectLoadingProgress New()
        {
            var output = new ProjectLoadingProgress();
            return output;
        }

        #endregion


        public void Report(ProjectLoadProgress progress)
        {
            var representation = $"{progress.FilePath}\n{progress.ElapsedTime}: {progress.Operation}";

            Console.WriteLine(representation);
        }
    }
}
