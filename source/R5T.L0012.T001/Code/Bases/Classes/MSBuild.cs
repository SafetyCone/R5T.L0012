using System;


namespace R5T.L0012.T001
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class MSBuild : IMSBuild
    {
        #region Static

        public static MSBuild Instance { get; } = new();

        #endregion
    }
}