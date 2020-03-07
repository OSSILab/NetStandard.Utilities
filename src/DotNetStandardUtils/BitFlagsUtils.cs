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

namespace DotNetStandardUtils
{
    /// <summary>
    /// Utility class that provides bit flags operations.
    /// </summary>
    public static class BitFlagsUtils
    {
        /// <summary>
        /// Determines whether one or more bit fields are set to a specific value.
        /// If <paramref name="value"/> is 0 it will return <c>True</c>
        /// </summary>
        /// <param name="value">The value to be checked against <paramref name="flagsToCheck"/> flags.</param>
        /// <param name="flagsToCheck"></param>
        /// <returns><c>True</c> if <paramref name="value"/> contains any of bit fields that are set in
        /// <paramref name="flagsToCheck"/>, <c>False</c> otherwise.</returns>
        public static bool HasAnyFlag(int value, int flagsToCheck)
        {
            if (value == 0)
            {
                return true;
            }
            return (value & flagsToCheck) != 0;
        }

        /// <summary>
        /// Determines whether one or more bit fields are set to a specific value.
        /// If <paramref name="value"/> is 0 it will return <c>True</c>
        /// </summary>
        /// <param name="value">The value to be checked against <paramref name="flagsToCheck"/> flags.</param>
        /// <param name="flagsToCheck"></param>
        /// <returns><c>True</c> if <paramref name="value"/> contains any of bit fields that are set in
        /// <paramref name="flagsToCheck"/>, <c>False</c> otherwise.</returns>
        public static bool HasAnyFlag(uint value, uint flagsToCheck)
        {
            if (value == 0)
            {
                return true;
            }
            return (value & flagsToCheck) != 0;
        }

        /// <summary>
        /// Determines whether one or more bit fields are set to a specific value.
        /// If <paramref name="value"/> is 0 it will return <c>True</c>
        /// </summary>
        /// <param name="value">The value to be checked against <paramref name="flagsToCheck"/> flags.</param>
        /// <param name="flagsToCheck"></param>
        /// <returns><c>True</c> if <paramref name="value"/> contains any of bit fields that are set in
        /// <paramref name="flagsToCheck"/>, <c>False</c> otherwise.</returns>
        public static bool HasAnyFlag(ulong value, ulong flagsToCheck)
        {
            if (value == 0)
            {
                return true;
            }
            return (value & flagsToCheck) != 0;
        }

        /// <summary>
        /// Determines whether one or more bit fields are set to a specific value.
        /// If <paramref name="value"/> is 0 it will return <c>True</c>
        /// </summary>
        /// <param name="value">The value to be checked against <paramref name="flagsToCheck"/> flags.</param>
        /// <param name="flagsToCheck"></param>
        /// <returns><c>True</c> if <paramref name="value"/> contains any of bit fields that are set in
        /// <paramref name="flagsToCheck"/>, <c>False</c> otherwise.</returns>
        public static bool HasAnyFlag(long value, long flagsToCheck)
        {
            if (value == 0)
            {
                return true;
            }
            return (value & flagsToCheck) != 0;
        }

        /// <summary>
        /// Determines whether one or more bit fields are set to a specific value.
        /// If <paramref name="value"/> is 0 it will return <c>True</c>
        /// </summary>
        /// <param name="value">The value to be checked against <paramref name="flagsToCheck"/> flags.</param>
        /// <param name="flagsToCheck"></param>
        /// <returns><c>True</c> if <paramref name="value"/> contains any of bit fields that are set in
        /// <paramref name="flagsToCheck"/>, <c>False</c> otherwise.</returns>
        public static bool HasAnyFlag(sbyte value, sbyte flagsToCheck)
        {
            if (value == 0)
            {
                return true;
            }
            return (value & flagsToCheck) != 0;
        }

        /// <summary>
        /// Determines whether one or more bit fields are set to a specific value.
        /// If <paramref name="value"/> is 0 it will return <c>True</c>
        /// </summary>
        /// <param name="value">The value to be checked against <paramref name="flagsToCheck"/> flags.</param>
        /// <param name="flagsToCheck"></param>
        /// <returns><c>True</c> if <paramref name="value"/> contains any of bit fields that are set in
        /// <paramref name="flagsToCheck"/>, <c>False</c> otherwise.</returns>
        public static bool HasAnyFlag(byte value, byte flagsToCheck)
        {
            if (value == 0)
            {
                return true;
            }
            return (value & flagsToCheck) != 0;
        }

        /// <summary>
        /// Determines whether one or more bit fields are set to a specific value.
        /// If <paramref name="value"/> is 0 it will return <c>True</c>
        /// </summary>
        /// <param name="value">The value to be checked against <paramref name="flagsToCheck"/> flags.</param>
        /// <param name="flagsToCheck"></param>
        /// <returns><c>True</c> if <paramref name="value"/> contains any of bit fields that are set in
        /// <paramref name="flagsToCheck"/>, <c>False</c> otherwise.</returns>
        public static bool HasAnyFlag(short value, short flagsToCheck)
        {
            if (value == 0)
            {
                return true;
            }
            return (value & flagsToCheck) != 0;
        }

        /// <summary>
        /// Determines whether one or more bit fields are set to a specific value.
        /// If <paramref name="value"/> is 0 it will return <c>True</c>
        /// </summary>
        /// <param name="value">The value to be checked against <paramref name="flagsToCheck"/> flags.</param>
        /// <param name="flagsToCheck"></param>
        /// <returns><c>True</c> if <paramref name="value"/> contains any of bit fields that are set in
        /// <paramref name="flagsToCheck"/>, <c>False</c> otherwise.</returns>
        public static bool HasAnyFlag(ushort value, ushort flagsToCheck)
        {
            if (value == 0)
            {
                return true;
            }
            return (value & flagsToCheck) != 0;
        }

        /// <summary>
        /// Determines whether one or more bit fields are set to a specific value.
        /// If <paramref name="value"/> is 0 it will return <c>True</c>
        /// </summary>
        /// <param name="value">The value to be checked against <paramref name="flagsToCheck"/> flags.</param>
        /// <param name="flagsToCheck"></param>
        /// <returns><c>True</c> if <paramref name="value"/> contains any of bit fields that are set in
        /// <paramref name="flagsToCheck"/>, <c>False</c> otherwise.</returns>
        public static bool HasAnyFlag(char value, char flagsToCheck)
        {
            if (value == 0)
            {
                return true;
            }
            return (value & flagsToCheck) != 0;
        }
    }
}