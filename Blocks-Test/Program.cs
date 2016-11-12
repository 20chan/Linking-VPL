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
                Variable = new Variable("a", 1)
            };
            ChangeVariableValueBlock change = new ChangeVariableValueBlock(board)
            {
                Name = "a",
                Delegate = v => (int)v + 1
            };
            Block.Connect(entry, declare);
            Block.Connect(declare, change);
            //Block.Connect(change, change);

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
