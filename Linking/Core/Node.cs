using System;
using System.Collections;
using System.Linq;

namespace Linking.Core
{
    public abstract class Node
    {
        public Node Parent { get; set; }

        public Node(Node parent)
        {
            Parent = parent;
        }
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
            throw new NotImplementedException();
        }

        public void AddRange(Node[] nodes)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public void RemoveAt(int index) => this.Remove(this[index]);

        int IList.Add(object value)
        {
            throw new NotImplementedException();
        }

        void IList.Remove(object value)
        {
            throw new NotImplementedException();
        }

        void IList.RemoveAt(int index)
        {
            throw new NotImplementedException();
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

        bool ICollection.IsSynchronized => _list.IsSynchronized;

        object ICollection.SyncRoot => _list.SyncRoot;

        object ICloneable.Clone()
        {
            throw new NotImplementedException();
        }

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
                if(current < (_nodes.Count - 1) && current < (originalCount - 1))
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
