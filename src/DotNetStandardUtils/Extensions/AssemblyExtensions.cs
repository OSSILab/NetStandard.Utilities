using System;
using System.IO;
using System.Reflection;

namespace DotNetStandardUtils.Extensions
{
    /// <summary>
    /// Provides a set of static (Shared in Visual Basic) methods for working with specific
    /// kinds of <see cref="Assembly"/> instances.
    /// </summary>
    public static class AssemblyExtensions
    {
        /// <summary>
        /// Gets the directory path of the specified assembly.
        /// </summary>
        /// <param name="assembly">The assembly for which the location needs to be retrieved.</param>
        /// <returns>The directory path of the specified assembly.</returns>
        public static string GetLocation(this Assembly assembly)
        {
            UriBuilder uriBuilder = new UriBuilder(assembly.CodeBase);
            string unescapedPath = Uri.UnescapeDataString(uriBuilder.Path);
            string directoryLocation = Path.GetDirectoryName(unescapedPath);
            return directoryLocation;
        }
    }
}
