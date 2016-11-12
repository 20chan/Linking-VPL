using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Linking.Core.Var
{
    public class VariableTable : ICollection
    {
        private Dictionary<string, Variable> _table;

        public int Count => _table.Count;
        public bool IsReadOnly => false;

        public VariableTable()
        {
            this._table = new Dictionary<string, Variable>();
        }

        protected object this[int index] => _table.Values.ElementAt(index);
        public Variable this[string key]
        {
            get { return _table[key]; }
            set
            {
                if (_table.ContainsKey(value.Name))
                    _table[key] = value;
                else
                    Add(value);
            }
        }

        public void Add(string name, object value)
            => Add(new Variable(name, value));

        public void Add(Variable var)
        {
            if (!_table.ContainsKey(var.Name))
                _table.Add(var.Name, var);
        }

        public void AddRange(Variable[] vars)
        {
            if (vars == null)
                throw new ArgumentNullException("vars");
            if (vars.Length != 0)
            {
                for (int i = 0; i < vars.Length; i++)
                    this.Add(vars[i]);
            }
        }

        public bool Contains(Variable var)
        {
            return _table.ContainsKey(var.Name);
        }

        public void CopyTo(Array array, int index)
        {
            _table.Values.ToArray().CopyTo(array, index);
        }

        public void Clear()
        {
            _table.Clear();
        }

        public bool Remove(Variable var)
        {
            return _table.Remove(var.Name);
        }

        public IEnumerator GetEnumerator() => new VariableTableEnumerator(this);

        bool ICollection.IsSynchronized
        {
            get { throw new NotSupportedException(); }
        }

        object ICollection.SyncRoot
        {
            get { throw new NotSupportedException(); }
        }

        private class VariableTableEnumerator : IEnumerator
        {
            private VariableTable _table;
            private int current;
            private int originalCount;

            public VariableTableEnumerator(VariableTable table)
            {
                this._table = table;
                this.originalCount = table.Count;
                this.current = -1;
            }

            public bool MoveNext()
            {
                if (current < (_table.Count - 1) && current < (originalCount - 1))
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
                    return this._table[this.current];
                }
            }
        }
    }
}
