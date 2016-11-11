using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Linking.Core.Variable
{
    public class VariableTable : ICollection<Variable>
    {
        private Dictionary<string, Variable> _table;

        public VariableTable()
        {
            this._table = new Dictionary<string, Variable>();
        }

        public void Add(string name, object value)
            => Add(new Variable(name, value));

        public void Add(Variable var)
        {
            if(_table.ContainsKey(var.Name))
                
            _table.Add(var.Name, var);
        }
    }
}
