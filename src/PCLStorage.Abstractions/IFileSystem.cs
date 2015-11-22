using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PCLStorage
{
    /// <summary>
    /// Represents a file system.
    /// </summary>
    public interface IFileSystem
    {
        /// <summary>
        /// Gets the local storage folder.
        /// </summary>
        /// <value>A folder representing storage which is local to the current device.</value>
        IFolder LocalStorage { get; }

        /// <summary>
        /// Gets the roaming storage folder.
        /// </summary>
        /// <value>A folder representing storage which may be synced with other devices for the same user.</value>
        IFolder RoamingStorage { get; }

        /// <summary>
        /// Gets a file, given its path.  Returns <c>null</c> if the file does not exist.
        /// </summary>
        /// <param name="path">The path to a file, as returned from the <see cref="IFile.Path"/> property.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A file for the given path, or <c>null</c> if it does not exist.</returns>
        Task<IFile> GetFileFromPathAsync(string path, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets a folder, given its path.  Returns <c>null</c> if the folder does not exist.
        /// </summary>
        /// <param name="path">The path to a folder, as returned from the <see cref="IFolder.Path"/> property.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A folder for the specified path, or <c>null</c> if it does not exist.</returns>
        Task<IFolder> GetFolderFromPathAsync(string path, CancellationToken cancellationToken = default(CancellationToken));
    }
}
