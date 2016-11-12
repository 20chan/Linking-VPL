using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Linking.Core;
using Linking.Core.Blocks;
using Linking.Core.Blocks.Var;

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
                Variable = new Linking.Core.Var.Variable("a", 10)
            };
            ChangeVariableValueBlock change = new ChangeVariableValueBlock(board)
            {
                Variable = new Linking.Core.Var.Variable("a", 11)
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
