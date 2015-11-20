using System;

namespace PCLStorage
{
    /// <summary>
    /// File attributes
    /// </summary>
    [Flags]
    public enum FileAttributes
    {
        /// <summary>
        /// Default value
        /// </summary>
        Normal = 0,

        /// <summary>
        /// Symbolic link
        /// </summary>
        SymbolicLink,
    }
}
