using System;
using System.Collections;
using System.Linq;

namespace Linking.Core
{
    public abstract class Node
    {
        public Node Parent { get; set; }

        private NodeCollection _nodes;
        public virtual NodeCollection Nodes
        {
            get
            {
                if (_nodes == null)
                    _nodes = this.CreateNodesInstance();
                return _nodes;
            }
        }

        protected NodeCollection CreateNodesInstance() => new NodeCollection(this);

        public Node(Node parent)
        {
            Parent = parent;
        }

        protected virtual void OnNodeAdded()
        {

        }


        public class NodeCollection : IList, ICollection, IEnumerable, ICloneable
        {
            private Node _owner;
            public Node Owner => _owner;

            private ArrayList _list;

            public int Count => _list.Count;

            public NodeCollection(Node owner)
            {
                _owner = owner;
                this._list = new ArrayList();
            }

            public void Add(Node value)
            {
                _list.Add(value);
                _owner.OnNodeAdded();
            }

            public void AddRange(Node[] nodes)
            {
                if (nodes == null)
                    throw new ArgumentNullException("nodes");
                if (nodes.Length != 0)
                {
                    for (int i = 0; i < nodes.Length; i++)
                        this.Add(nodes[i]);
                }
            }

            public void Clear()
            {
                while (Count != 0)
                    RemoveAt(Count - 1);
            }

            public bool Contains(Node node) => _list.Contains(node);

            public void CopyTo(Array array, int index)
            {
                this._list.CopyTo(array, index);
            }

            public IEnumerator GetEnumerator() => new NodeCollectionEnumerator(this);

            public int IndexOf(Node node) => _list.IndexOf(node);

            public void Remove(Node node)
            {
                if (node != null)
                {
                    _list.Remove(node);
                }
            }

            public void RemoveAt(int index) => this.Remove(this[index]);

            #region IList

            int IList.Add(object value)
            {
                if (!(value is Node))
                    throw new ArgumentException("NodeBadNode", "node");
                this.Add((Node)value);
                return this.IndexOf((Node)value);
            }

            void IList.Remove(object value)
            {
                if (value is Node)
                {
                    this.Remove((Node)value);
                }
            }

            void IList.RemoveAt(int index)
            {
                this.RemoveAt(index);
            }

            void IList.Clear() => _list.Clear();

            bool IList.Contains(object value) => _list.Contains(value);

            int IList.IndexOf(object value) => _list.IndexOf(value);

            void IList.Insert(int index, object value)
            {
                throw new NotSupportedException();
            }

            bool IList.IsReadOnly => _list.IsReadOnly;

            bool IList.IsFixedSize => _list.IsFixedSize;

            object IList.this[int index]
            {
                get
                {
                    return _list[index];
                }
                set
                {
                    throw new NotSupportedException();
                }
            }

            #endregion
            #region ICollection

            bool ICollection.IsSynchronized => _list.IsSynchronized;

            object ICollection.SyncRoot => _list.SyncRoot;

            #endregion
            #region ICloneable

            object ICloneable.Clone()
            {
                throw new NotImplementedException();
            }

            #endregion

            public Node this[int index]
            {
                get
                {
                    return (Node)_list[index];
                }
            }

            private class NodeCollectionEnumerator : IEnumerator
            {
                private NodeCollection _nodes;
                private int current;
                private int originalCount;

                public NodeCollectionEnumerator(NodeCollection nodes)
                {
                    this._nodes = nodes;
                    this.originalCount = nodes.Count;
                    this.current = -1;
                }

                public bool MoveNext()
                {
                    if (current < (_nodes.Count - 1) && current < (originalCount - 1))
                    {
                        current++;
                        return true;
                    }
                    return false;
                }

                public void Reset()
                {
                    this.current = -1;
                }

                public object Current
                {
                    get
                    {
                        if (this.current == -1)
                            return null;
                        return this._nodes[this.current];
                    }
                }
            }
        }
    }
}
