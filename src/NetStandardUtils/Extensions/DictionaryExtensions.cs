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
using System.Collections.Generic;

namespace NetStandardUtils
{
    /// <summary>
    /// Provides a set of static (Shared in Visual Basic) methods for working with specific
    /// kinds of <see cref="IDictionary{TKey,TValue}"/> instances.
    /// </summary>
    public static class DictionaryExtensions
    {
        /// <summary>
        /// Adds the elements of the specified collection to the the <see cref="IDictionary{TKey,TValue}"/>.
        /// </summary>
        /// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
        /// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
        /// <param name="dictionary">The dictionary for which the elements will be added.</param>
        /// <param name="valuesToAdd">The collection whose elements should be added to the <see cref="IDictionary{TKey,TValue}"/>.</param>
        public static void AddRange<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, IEnumerable<KeyValuePair<TKey, TValue>> valuesToAdd)
        {
            foreach (var valueToAdd in valuesToAdd)
            {
                dictionary.Add(valueToAdd);
            }
        }

        /// <summary>
        /// Adds the elements of the specified collection to the the <see cref="IDictionary{TKey,TValue}"/>.
        /// </summary>
        /// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
        /// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
        /// <param name="dictionary">The dictionary for which the elements will be added.</param>
        /// <param name="valuesToAdd">The collection whose elements should be added to the <see cref="IDictionary{TKey,TValue}"/>.</param>
        /// <param name="keySelector">A function to extract a key from each element.</param>
        public static void AddRange<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, IEnumerable<TValue> valuesToAdd, Func<TValue, TKey> keySelector)
        {
            foreach (TValue valueToAdd in valuesToAdd)
            {
                TKey key = keySelector(valueToAdd);
                dictionary.Add(key, valueToAdd);
            }
        }
    }
}