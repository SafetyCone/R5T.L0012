using System;


namespace R5T.L0012.T001
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class MSBuildLocation : IMSBuildLocation
    {
        #region Static

        public static MSBuildLocation Instance { get; } = new();

        #endregion
    }
}