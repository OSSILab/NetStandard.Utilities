using System.Collections;
using System.Collections.Generic;

namespace NetStandardUtils.Collections
{
    /// <summary>
    /// Represents a read-only strongly-typed, set of elements.
    /// </summary>
    /// <typeparam name="T">The type of the elements.</typeparam>
    public class ReadOnlySet<T>:IReadOnlySet<T>
    {
        private readonly HashSet<T> _set;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadOnlySet{T}"/> class 
        /// that uses the default equality comparer for the set type, contains elements copied 
        /// from the specified collection, and has sufficient capacity to accommodate the 
        /// number of elements copied.
        /// </summary>
        /// <param name="collection">The collection whose elements are copied to the new set.</param>
        public ReadOnlySet(IEnumerable<T> collection)
        {
            _set = new HashSet<T>(collection);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadOnlySet{T}"/> class 
        /// that is empty and uses the specified equality comparer for the set type.
        /// </summary>
        /// <param name="comparer">The <see cref="IEqualityComparer{T}"/> implementation to use when
        /// comparing values in the set, or null to use the default <see cref="EqualityComparer{T}"/> 
        /// implementation for the set type.</param>
        public ReadOnlySet(IEqualityComparer<T> comparer)
        {
            _set = new HashSet<T>(comparer);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadOnlySet{T}"/> class 
        /// that uses the specified equality comparer for the set type, contains elements 
        /// copied from the specified collection, and has sufficient capacity to accommodate 
        /// the number of elements copied.
        /// </summary>
        /// <param name="collection">The collection whose elements are copied to the new set.</param>
        /// <param name="comparer">The <see cref="IEqualityComparer{T}"/> implementation to use when
        /// comparing values in the set, or null to use the default <see cref="EqualityComparer{T}"/> 
        /// implementation for the set type.</param>
        public ReadOnlySet(IEnumerable<T> collection, IEqualityComparer<T> comparer)
        {
            _set = new HashSet<T>(collection, comparer);
        }

        /// <inheritdoc />
        public IEnumerator<T> GetEnumerator()
        {
            return _set.GetEnumerator();
        }

        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator()
        {
            IEnumerable enumerable = _set;
            return enumerable.GetEnumerator();
        }

        /// <inheritdoc />
        public int Count => _set.Count;

        /// <inheritdoc />
        public bool IsProperSubsetOf(IEnumerable<T> other)
        {
            return _set.IsProperSubsetOf(other);
        }

        /// <inheritdoc />
        public bool IsProperSupersetOf(IEnumerable<T> other)
        {
            return _set.IsProperSupersetOf(other);
        }

        /// <inheritdoc />
        public bool IsSubsetOf(IEnumerable<T> other)
        {
            return _set.IsSubsetOf(other);
        }

        /// <inheritdoc />
        public bool IsSupersetOf(IEnumerable<T> other)
        {
            return _set.IsSupersetOf(other);
        }

        /// <inheritdoc />
        public bool Overlaps(IEnumerable<T> other)
        {
            return _set.Overlaps(other);
        }

        /// <inheritdoc />
        public bool SetEquals(IEnumerable<T> other)
        {
            return _set.SetEquals(other);
        }

        /// <inheritdoc />
        public bool Contains(T item)
        {
            return _set.Contains(item);
        }
    }
}