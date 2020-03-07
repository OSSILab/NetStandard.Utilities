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

namespace DotNetStandardUtils
{
    /// <summary>
    /// Provides a set of static (Shared in Visual Basic) methods for working with enumerations.
    /// </summary>
    public static class EnumExtensions
    {
        /// <summary>
        /// Determines whether one or more bit fields are set to a specific value.
        /// If <paramref name="value"/> is 0 it will return <c>True</c>
        /// </summary>
        /// <param name="value">The value to be checked against <paramref name="flagsToCheck"/> flags.</param>
        /// <param name="flagsToCheck"></param>
        /// <returns><c>True</c> if <paramref name="value"/> contains any of bit fields that are set in
        /// <paramref name="flagsToCheck"/>, <c>False</c> otherwise.</returns>
        public static bool HasAnyFlag<TEnum>(this TEnum value, TEnum flagsToCheck) where TEnum : Enum
        {
            // handle each underlying type
            Type enumUnderlyingType = Enum.GetUnderlyingType(typeof(TEnum));

            object unboxedValue = value, unboxedFlagsToCheck = flagsToCheck;

            if (enumUnderlyingType == typeof(int))
            {
                return BitFlagsUtils.HasAnyFlag((int)unboxedValue, (int)unboxedFlagsToCheck);
            }
            else if (enumUnderlyingType == typeof(uint))
            {
                return BitFlagsUtils.HasAnyFlag((uint)unboxedValue, (uint)unboxedFlagsToCheck);
            }
            else if (enumUnderlyingType == typeof(ulong))
            {
                return BitFlagsUtils.HasAnyFlag((ulong)unboxedValue, (ulong)unboxedFlagsToCheck);
            }
            else if (enumUnderlyingType == typeof(long))
            {
                return BitFlagsUtils.HasAnyFlag((long)unboxedValue, (long)unboxedFlagsToCheck);
            }
            else if (enumUnderlyingType == typeof(sbyte))
            {
                return BitFlagsUtils.HasAnyFlag((sbyte)unboxedValue, (sbyte)unboxedFlagsToCheck);
            }
            else if (enumUnderlyingType == typeof(byte))
            {
                return BitFlagsUtils.HasAnyFlag((byte)unboxedValue, (byte)unboxedFlagsToCheck);
            }
            else if (enumUnderlyingType == typeof(short))
            {
                return BitFlagsUtils.HasAnyFlag((short)unboxedValue, (short)unboxedFlagsToCheck);
            }
            else if (enumUnderlyingType == typeof(ushort))
            {
                return BitFlagsUtils.HasAnyFlag((ushort)unboxedValue, (ushort)unboxedFlagsToCheck);
            }
            else if (enumUnderlyingType == typeof(char))
            {
                return BitFlagsUtils.HasAnyFlag((char)unboxedValue, (char)unboxedFlagsToCheck);
            }
            else
            {
                throw new ArgumentException($"Unknown enum underlying type {enumUnderlyingType.Name}.");
            }
        }
    }
}