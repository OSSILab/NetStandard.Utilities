using System.Collections.Generic;

namespace DotNetStandardUtils.Collections
{
    /// <summary>
    /// Represents a read-only strongly-typed, set of elements.
    /// </summary>
    /// <typeparam name="T">The type of the elements.</typeparam>
    public interface IReadOnlySet<T> : IReadOnlyCollection<T>
    {
        /// <summary>
        /// Determines whether the current set is a proper (strict) subset of a specified collection.
        /// </summary>
        /// <param name="other">The collection to compare to the current set.</param>
        /// <returns><c>true</c> if the current set is a proper subset of other; otherwise, <c>false</c>.</returns>
        bool IsProperSubsetOf(IEnumerable<T> other);

        /// <summary>
        /// Determines whether the current set is a proper (strict) superset of a specified collection.
        /// </summary>
        /// <param name="other">The collection to compare to the current set.</param>
        /// <returns><c>true</c> if the current set is a proper superset of other; otherwise, <c>false</c>.</returns>
        bool IsProperSupersetOf(IEnumerable<T> other);

        /// <summary>
        /// Determines whether the current set is a subset of a specified collection.
        /// </summary>
        /// <param name="other">The collection to compare to the current set.</param>
        /// <returns><c>true</c> if the current set is a subset of other; otherwise, <c>false</c>.</returns>
        bool IsSubsetOf(IEnumerable<T> other);

        /// <summary>
        /// Determines whether the current set is a superset of a specified collection.
        /// </summary>
        /// <param name="other">The collection to compare to the current set.</param>
        /// <returns><c>true</c> if the current set is a superset of other; otherwise, <c>false</c>.</returns>
        bool IsSupersetOf(IEnumerable<T> other);

        /// <summary>
        /// Determines whether the current set overlaps with the specified collection.
        /// </summary>
        /// <param name="other">The collection to compare to the current set.</param>
        /// <returns><c>true</c> if the current set and other share at least one common element; otherwise, <c>false</c>.</returns>
        bool Overlaps(IEnumerable<T> other);

        /// <summary>
        /// Determines whether the current set and the specified collection contain the same elements.
        /// </summary>
        /// <param name="other">The collection to compare to the current set.</param>
        /// <returns><c>true</c> if the current set is equal to other; otherwise, <c>false</c>.</returns>
        bool SetEquals(IEnumerable<T> other);

        /// <summary>
        /// Determines whether a <see cref="ISet{T}"/> object contains the specified element.
        /// </summary>
        /// <param name="item">The element to locate in the <see cref="ISet{T}"/> object.</param>
        /// <returns><c>true</c> if the <see cref="ISet{T}"/> object contains the specified element; otherwise, <c>false</c>.</returns>
        bool Contains(T item);
    }
}