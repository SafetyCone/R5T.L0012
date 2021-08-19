using System;
using System.Threading.Tasks;

using Microsoft.Build.Locator;

using R5T.L0012.T001;


namespace System
{
    public static class IMSBuildLocationExtensions
    {
        /// <summary>
        /// Idempotent, unline <see cref="MSBuildLocator.RegisterDefaults"/>.
        /// </summary>
        public static void RegisterDefaults(this IMSBuildLocation _)
        {
            if (!MSBuildLocator.IsRegistered)
            {
                MSBuildLocator.RegisterDefaults();
            }
        }

        public static void RunInContext(this IMSBuildLocation mSBuildLocation,
            Action action)
        {
            mSBuildLocation.RegisterDefaults();

            action();
        }

        public static async Task RunInContext(this IMSBuildLocation mSBuildLocation,
            Func<Task> action)
        {
            mSBuildLocation.RegisterDefaults();

            await action();
        }

        public static Task<T> RunInContext<T>(this IMSBuildLocation mSBuildLocation,
            Func<Task<T>> action)
        {
            mSBuildLocation.RegisterDefaults();

            return action();
        }
    }
}
