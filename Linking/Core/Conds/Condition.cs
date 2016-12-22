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

        public object L { get; set; }
        public object R { get; set; }

        public static Condition VarEqualVarCondition(Board board)
        {
            Condition c = new Condition();
            c._conditionDelegate = (b =>(dynamic)b._table[c.L.ToString()].Value == (dynamic)b._table[c.R.ToString()].Value);
            return c;
        }

        public static Condition VarEqualValCondition(Board board)
        {
            Condition c = new Condition();
            c._conditionDelegate = (b => (dynamic)b._table[c.L.ToString()].Value == (dynamic)c.R);
            return c;
        }

        public static Condition ValEqualValCondition(Board board)
        {
            Condition c = new Condition();
            c._conditionDelegate = (b => (dynamic)c.L == (dynamic)c.R);
            return c;
        }
        
        public static Condition VarSmallerVarCondition(Board board)
        {
            Condition c = new Condition();
            c._conditionDelegate = (b => (dynamic)b._table[c.L.ToString()].Value < (dynamic)b._table[c.R.ToString()].Value);
            return c;
        }

        public static Condition VarSmallerValCondition(Board board)
        {
            Condition c = new Condition();
            c._conditionDelegate = (b => (dynamic)b._table[c.L.ToString()].Value == (dynamic)c.R);
            return c;
        }

        public static Condition ValSmallerValCondition(Board board)
        {
            Condition c = new Condition();
            c._conditionDelegate = (b => (dynamic)c.L == (dynamic)c.R);
            return c;
        }

        public static Condition VarSmallerEqualVarCondition(Board board)
        {
            Condition c = new Condition();
            c._conditionDelegate = (b => (dynamic)b._table[c.L.ToString()].Value <= (dynamic)b._table[c.R.ToString()].Value);
            return c;
        }

        public static Condition VarSmallerEqualValCondition(Board board)
        {
            Condition c = new Condition();
            c._conditionDelegate = (b => (dynamic)b._table[c.L.ToString()].Value <= (dynamic)c.R);
            return c;
        }

        public static Condition ValSmallerEqualValCondition(Board board)
        {
            Condition c = new Condition();
            c._conditionDelegate = (b => (dynamic)c.L <= (dynamic)c.R);
            return c;
        }

        public static Condition VarBiggerVarCondition(Board board)
        {
            Condition c = new Condition();
            c._conditionDelegate = (b => (dynamic)b._table[c.L.ToString()].Value > (dynamic)b._table[c.R.ToString()].Value);
            return c;
        }

        public static Condition VarBiggerValCondition(Board board)
        {
            Condition c = new Condition();
            c._conditionDelegate = (b => (dynamic)b._table[c.L.ToString()].Value > (dynamic)c.R);
            return c;
        }

        public static Condition ValBiggerValCondition(Board board)
        {
            Condition c = new Condition();
            c._conditionDelegate = (b => (dynamic)c.L > (dynamic)c.R);
            return c;
        }

        public static Condition VarBiggerEqualVarCondition(Board board)
        {
            Condition c = new Condition();
            c._conditionDelegate = (b => (dynamic)b._table[c.L.ToString()].Value >= (dynamic)b._table[c.R.ToString()]);
            return c;
        }

        public static Condition VarBiggerEqualValCondition(Board board)
        {
            Condition c = new Condition();
            c._conditionDelegate = (b => (dynamic)b._table[c.L.ToString()].Value >= (dynamic)c.R);
            return c;
        }

        public static Condition ValBiggerEqualValCondition(Board board)
        {
            Condition c = new Condition();
            c._conditionDelegate = (b => (dynamic)c.L >= (dynamic)c.R);
            return c;
        }

        public static Condition AndCond(Board board)
        {
            Condition c = new Condition();
            c._conditionDelegate = (b => ((dynamic)c.L).Check(b) && ((dynamic)c.R).Check(b));
            return c;
        }

        public static Condition OrCond(Board board)
        {
            Condition c = new Condition();
            c._conditionDelegate = (b => ((dynamic)c.L).Check(b) || ((dynamic)c.R).Check(b));
            return c;
        }

        public static Condition NotCond(Board board)
        {
            Condition c = new Condition();
            c._conditionDelegate = (b => !((dynamic)c.L).Check(b));
            return c;
        }
    }
}
