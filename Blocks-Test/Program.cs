using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Linking.Core;
using Linking.Core.Blocks;
using Linking.Core.Blocks.Var;
using Linking.Core.Var;
using Linking.Core.Conds;

namespace Blocks_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            
            EntryBlock entry = new EntryBlock(board);
            DeclareVariableBlock declare1 = new DeclareVariableBlock(board)
            {
                Variable = new Variable("a", 1)
            };
            DeclareVariableBlock declare2 = new DeclareVariableBlock(board)
            {
                Variable = new Variable("i", 1)
            };
            ConditionBlock small = new ConditionBlock(board, null, new ConditionBoolBlock(board, null)
            {
                Condition = new Condition()
                {
                    LType = Condition.ValueType.Var,
                    L = "i",
                    RType = Condition.ValueType.Num,
                    R = 10,
                    Compare = Condition.CompareType.Smaller
                }});
            ChangeVariableValueBlock change = ChangeVariableValueBlock.VarVar(board, "a", "i", (a, i) => (dynamic)a * (dynamic)i);
            ChangeVariableValueBlock change2 = ChangeVariableValueBlock.VarVal(board, "i", 1, (i, v) => (dynamic)i + (dynamic)v);

            Block.Connect(entry, declare1);
            Block.Connect(declare1, declare2);
            Block.Connect(declare2, small);
            Block.Connect(small, change);
            Block.Connect(change, change2);
            Block.Connect(change2, small);

            board.Entry = entry;
            board.Initialize();

            while (!board.Ended)
            {
                board.RunStep();
                board.PrintAllVariables();
            }

            Console.ReadLine();
        }
    }
}
