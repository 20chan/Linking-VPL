using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Linking.Core;
using Linking.Core.Blocks;
using Linking.Core.Blocks.Var;
using Linking.Core.Var;

namespace Blocks_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();

            EntryBlock entry = new EntryBlock(board);
            DeclareVariableBlock declare = new DeclareVariableBlock(board)
            {
                Variable = new Variable("a", 10)
            };
            ChangeVariableValueBlock change = new ChangeVariableValueBlock(board)
            {
                Name = "a",
                Delegate = v => new Variable("a", (int)v.Value + 1)
            };
            Block.Connect(entry, declare);
            Block.Connect(declare, change);

            board.Entry = entry;

            board.Run();
            board.PrintAllVariables();

            Console.ReadLine();
        }
    }
}
