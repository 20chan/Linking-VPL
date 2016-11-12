using System;

namespace Linking.Core.Cond
{
    public class Condition
    {
        private Func<Board, bool> _conditionDelegate;
        private Board _board;
        protected Condition(Board board, Func<Board, bool> cond = null)
        {
            _board = board;
            _conditionDelegate = cond;
        }

        public bool Check()
        {
            if (_conditionDelegate == null)
                throw new ArgumentNullException("condition delegate");
            return _conditionDelegate(_board);
        }

        public static Condition VarSmallerCondition(Board board, string name, object value)
            => new Condition(board, b => (dynamic)b._table[name].Value < (dynamic)value);

        public static Condition VarSmallerEqualCondition(Board board, string name, object value)
            => new Condition(board, b => (dynamic)b._table[name].Value <= (dynamic)value);

        public static Condition VarBiggerCondition(Board board, string name, object value)
            => new Condition(board, b => (dynamic)b._table[name].Value > (dynamic)value);

        public static Condition VarBiggerEqualCondition(Board board, string name, object value)
            => new Condition(board, b => (dynamic)b._table[name].Value >= (dynamic)value);

        public static Condition VarEqualCondition(Board board, string name, object value)
            => new Condition(board, b => (dynamic)b._table[name].Value == (dynamic)value);
    }
}
