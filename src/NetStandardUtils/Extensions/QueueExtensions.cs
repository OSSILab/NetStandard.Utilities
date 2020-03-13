using System.Collections.Generic;

namespace NetStandardUtils
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