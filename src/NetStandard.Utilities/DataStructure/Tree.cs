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

using System.Collections.Generic;
using System.Linq;

// modify the namespace as you wish
namespace NetStandard.Utilities.DataStructure
{
    /// <summary>
    /// Represents a tree data structure in which each element is attached to one or more elements directly beneath it.
    /// </summary>
    /// <typeparam name="TValue">The type of the value.</typeparam>
    public sealed class Tree<TValue>
    {
        private readonly List<Tree<TValue>> _children;

        /// <summary>Initializes a new instance of the <see cref="Tree{Value}"/> class.</summary>
        public Tree()
        {
            _children = new List<Tree<TValue>>();
        }

        /// <summary>Initializes a new instance of the <see cref="Tree{Value}"/> class.</summary>
        /// <param name="value">The data value stored by the current tree.</param>
        public Tree(TValue value)
        {
            Value = value;
            _children = new List<Tree<TValue>>();
        }

        /// <summary>Indicating if this tree have a parent tree.</summary>
        public bool HaveParent { get { return Parent != null; } }

        /// <summary>Indicating if this tree have children.</summary>
        public bool HaveChildren { get { return _children.Count > 0; } }

        /// <summary>Gets the parent of the current tree.</summary>
        public Tree<TValue> Parent { get; private set; }

        /// <summary>The data value stored by the current tree.</summary>
        public TValue Value { get; set; }

        /// <summary>Creates a new <see cref="Tree{TValue}"/> using a specified value 
        /// and adds it to the end of the <see cref="Children"/> collection.</summary>
        /// <param name="childValue">The value stored by the tree.</param>
        /// <returns>The tree that was added to the <see cref="Children"/> collection.</returns>
        public Tree<TValue> AddChild(TValue childValue = default)
        {
            Tree<TValue> child = new Tree<TValue>(childValue);
            child.Parent = this;
            _children.Add(child);
            return child;
        }

        /// <summary>
        /// Creates a new <see cref="Tree{TValue}" /> using a specified value
        /// and inserts it at a specified index to the <see cref="Children" /> collection.
        /// </summary>
        /// <param name="index">The zero-based index at which item should be inserted.</param>
        /// <param name="childValue">The value stored by the tree.</param>
        /// <returns>The tree that was inserted to the <see cref="Children" /> collection.</returns>
        public Tree<TValue> InsertChild(int index, TValue childValue = default)
        {
            Tree<TValue> child = new Tree<TValue>(childValue);
            child.Parent = this;
            _children.Insert(index, child);
            return child;
        }

        /// <summary>Removes all children from the <see cref="Children"/> collection.</summary>
        public void RemoveChildren()
        {
            _children.Clear();
        }

        /// <summary> Removes the first occurrence of a tree with a specific value from the <see cref="Children" /> collection.</summary>
        /// <param name="child">The tree to be removed from the <see cref="Children" /> collection.</param>
        /// <returns><c>true</c> if the operation succeeded; otherwise, <c>false</c>.</returns>
        public bool RemoveChild(Tree<TValue> child)
        {
            return _children.Remove(child);
        }

        /// <summary>Gets the children of the current tree.</summary>
        public IEnumerable<Tree<TValue>> Children()
        {
            return _children;
        }

        /// <summary>Returns a collection of items that contain the ancestors of this tree.</summary>
        public IEnumerable<Tree<TValue>> Ancestors()
        {
            Tree<TValue> tree = Parent;
            while (tree != null)
            {
                yield return tree;
                tree = tree.Parent;
            }
        }

        /// <summary>Returns a collection of items that contain this tree, and the ancestors of this tree.</summary>
        public IEnumerable<Tree<TValue>> AncestorsAndSelf()
        {
            yield return this;
            foreach (var ancestor in Ancestors())
            {
                yield return ancestor;
            }
        }

        /// <summary>Returns a collection of items that contain the descendants of this tree.</summary>
        public IEnumerable<Tree<TValue>> Descendants()
        {
            foreach (Tree<TValue> child in _children)
            {
                yield return child;
                foreach (Tree<TValue> descendant in child.Descendants())
                {
                    yield return descendant;
                }
            }
        }

        /// <summary>Returns a collection of items that contain this tree, and the descendants of this tree.</summary>
        public IEnumerable<Tree<TValue>> DescendantsAndSelf()
        {
            yield return this;
            foreach (var descendant in Descendants())
            {
                yield return descendant;
            }
        }

        /// <summary>Returns a collection of items that contain the siblings of this tree.</summary>
        public IEnumerable<Tree<TValue>> Siblings()
        {
            return Parent.Children().Where(sibling => sibling != this);
        }

        /// <summary>Returns a collection of items that contain this tree, and the siblings of this tree.</summary>
        public IEnumerable<Tree<TValue>> SiblingsAndSelf()
        {
            yield return this;
            foreach (var sibling in Siblings())
            {
                yield return sibling;
            }
        }
    }
}