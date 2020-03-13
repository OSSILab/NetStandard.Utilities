/*********************************************************************************
* The MIT License(MIT)                                                           *
*                                                                                *
* Copyright(c) Cristian-Claudiu Danila and Contributors                          *
*                                                                                *
* Permission is hereby granted, free of charge, to any person obtaining a copy   *
* of this software and associated documentation files (the "Software"), to deal  *
* in the Software without restriction, including without limitation the rights   *
* to use, copy, modify, merge, publish, distribute, sublicense, and/or sell      *
* copies of the Software, and to permit persons to whom the Software is          *
* furnished to do so, subject to the following conditions:                       *
*                                                                                *
* The above copyright notice and this permission notice shall be included in all *
* copies or substantial portions of the Software.                                *
*                                                                                *
* THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR     *
* IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,       *
* FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE    *
* AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER         *
* LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,  *
* OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE  *
* SOFTWARE.                                                                      *
*********************************************************************************/


using System;
using System.IO;
using System.Reflection;

namespace NetStandard.Utilities.Reflection
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
