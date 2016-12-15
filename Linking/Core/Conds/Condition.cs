using System;
using System.Windows.Forms;

namespace Linking.Core.Conds
{
    public class Condition
    {
        private Func<Board, bool> _conditionDelegate;
        private Condition(Func<Board, bool> cond = null)
        {
            _conditionDelegate = cond;
        }

        public bool Check(Board board)
        {
            if (_conditionDelegate == null)
                throw new ArgumentNullException("condition delegate");
            return _conditionDelegate(board);
        }

        public static Condition VarSmallerCondition(Board board, string name, object value)
            => new Condition(b => (dynamic)b._table[name].Value < (dynamic)value);

        public static Condition VarSmallerEqualCondition(Board board, string name, object value)
            => new Condition(b => (dynamic)b._table[name].Value <= (dynamic)value);

        public static Condition VarBiggerCondition(Board board, string name, object value)
            => new Condition(b => (dynamic)b._table[name].Value > (dynamic)value);

        public static Condition VarBiggerEqualCondition(Board board, string name, object value)
            => new Condition(b => (dynamic)b._table[name].Value >= (dynamic)value);

        public static Condition VarEqualCondition(Board board, string name, object value)
            => new Condition(b => (dynamic)b._table[name].Value == (dynamic)value);

        public static Condition AndCond(Board board, Condition cond1, Condition cond2)
            => new Condition(b => cond1.Check(b) && cond2.Check(b));

        public static Condition OrCond(Board board, Condition cond1, Condition cond2)
            => new Condition(b => cond1.Check(b) || cond2.Check(b));

        public static Condition NotCond(Board board, Condition cond)
            => new Condition(b => !cond.Check(b));
    }
}
