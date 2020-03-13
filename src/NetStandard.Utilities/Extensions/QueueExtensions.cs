/*********************************************************************************
* The MIT License(MIT)                                                           *
*                                                                                *
* Copyright(c) Open Source Software Initiative Contributors                      *
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


using System.Collections.Generic;

namespace NetStandard.Utilities
{
    /// <summary>
    /// Provides a set of static (Shared in Visual Basic) methods for working with specific
    /// kinds of Queue instances.
    /// </summary>
    public static class QueueExtensions
    {
        /// <summary>
        /// Adds the elements of the specified collection to the the <see cref="Queue{TValue}"/>.
        /// </summary>
        /// <typeparam name="TValue">Specifies the type of elements in the queue.</typeparam>
        /// <param name="queue">The queue for which the elements will be added.</param>
        /// <param name="valuesToEnqueue">The collection whose elements should be added to the <see cref="Queue{TValue}"/>.</param>
        public static void Enqueue<TValue>(this Queue<TValue> queue, IEnumerable<TValue> valuesToEnqueue)
        {
            foreach (TValue value in valuesToEnqueue)
            {
                queue.Enqueue(value);
            }
        }
    }
}