using System;
using System.Windows.Forms;

namespace Linking.Core.Conds
{
    public class Condition
    {
        public Condition()
        {

        }

        public bool Check(Board board)
        {
            
        }

        public enum ValueType { Var, Val, Cond }
        public enum CompareType { Equal, NotEqual, Smaller, Bigger, SmallerEqual, BiggerEqual, And, Or, Not }

        public CompareType Compare { get; set; }
        public ValueType LType { get; set; }
        public object L { get; set; }
        public ValueType RType { get; set; }
        public object R { get; set; }
        
    }
}
