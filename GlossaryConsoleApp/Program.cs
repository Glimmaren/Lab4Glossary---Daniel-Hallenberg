using System;
using System.Linq;
using GlossaryLibary;

namespace GlossaryConsoleApp
{
    class Program
    {

        static void Main(string[] args)
        {
            GlossaryConsole glossary = new GlossaryConsole();

            switch (args[0])
            {
                case "-list": { glossary.List(args); break; }
                case "-new": { glossary.New(args); break; }
                case "-add": { glossary.Add(args); break; }
                case "-remove": { glossary.Remove(args); break; }
                case "-words": { glossary.Words(args); break; }
                case "-count": { glossary.Count(args); break; }
                case "-practice": { glossary.Practice(args); break; }
                default: { GlossaryConsole.PrintErrorInstructionMessage(); break; }
            }
        }
    }
}