using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GlossaryLibary;

namespace GlossaryConsoleApp
{
    public class GlossaryConsole
    {
        public void List(string[] args)
        {
            if (args.Length == 1)
            {
                var list = Wordlist.GetLists();
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                PrintErrorInstructionMessage();
            }
        }
        public void New(string[] args)
        {
            if (args.Length == 1)
            {
                string listName = args[1];
                string[] languages = args.Skip(2).ToArray();

                Wordlist wordlist = new Wordlist(listName, languages);
                wordlist.Save();
            }
            else
            {
                GlossaryConsole.PrintErrorInstructionMessage();
            }          
        }
        public void Add(string[] args)
        {
            if (args.Length == 2)
            {
                string listName = args[1];
                string word = "";

                try
                {
                    Wordlist wordlist = Wordlist.LoadList(listName);

                    do
                    {
                        Console.WriteLine($"Adding words to wordlist: {listName}.dat");
                        Console.WriteLine("Exit by type empty word!! Your current word will be lost");

                        string[] translation = new string[wordlist.Languages.Length];

                        for (int i = 0; i < wordlist.Languages.Length; i++)
                        {
                            Console.Write($"-Enter the word on {wordlist.Languages[i].ToUpper()}: ");
                            word = Console.ReadLine();

                            if (!word.Equals(""))
                            {
                                if (word.All(char.IsLetter))
                                {
                                    word = word.ToLower();
                                    translation[i] = word;
                                }
                                else
                                {
                                    throw new Exception("This is not a word.... only use A-Z");
                                }
                            }
                            else
                            {
                                goto start;
                            }
                        }

                        translation = translation.Where(x => !string.IsNullOrEmpty(x)).ToArray();
                        wordlist.Add(translation);
                        Console.WriteLine("\n");

                        wordlist.Save();

                    start:;

                    } while (!word.Equals(""));

                    wordlist.Save();
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("List not found");
                    PrintErrorInstructionMessage();
                }
            }
            else
            {
                PrintErrorInstructionMessage();
            }
        }
        public void Remove(string[] args)
        {
            if(args.Length > 3) { PrintErrorInstructionMessage(); }

            string listName = args[1];
            int intLanguage;
            string[] words = args.Skip(3).ToArray();

            try
            {
                Wordlist wordlist = Wordlist.LoadList(listName);

                if (wordlist.Languages.Any(args[2].Contains))
                {
                    intLanguage = Array.IndexOf(wordlist.Languages, args[2]);
                }
                else
                {
                    Console.WriteLine("Language not found!");
                    goto here;
                }

                for (int i = 0; i < args.Length - 3; i++)
                {
                    if (wordlist.Remove(intLanguage, words[i]))
                    {
                        wordlist.Save();
                        Console.WriteLine($"-{words[i]} removed!");
                    }
                    else
                    {
                        Console.WriteLine($"-{words[i]} not dosent exist!");
                    }
                }
            here:;
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("List not found");
                PrintErrorInstructionMessage();
            }
        }
        public void Words(string[] args)
        {
            if (args.Length == 2)
            {
                string listName = args[1];

                try
                {
                    int intLanguage;
                    Wordlist wordlist = Wordlist.LoadList(listName);

                    Action<string[]> showtrans = (x) =>
                    {
                        foreach (var item in x)
                        {
                            Console.Write(item + " ");
                        }

                        Console.WriteLine();
                    };

                    if (wordlist.Languages.Any(args[2].Contains))
                    {
                        intLanguage = Array.IndexOf(wordlist.Languages, args[2]);
                    }
                    else
                    {
                        Console.WriteLine("Language not found!");
                        goto here;
                    }

                    wordlist.List(intLanguage, showtrans);

                here:;
                }
                catch (FileLoadException)
                {
                    Console.WriteLine("List not found");
                    PrintErrorInstructionMessage();
                }
            }
            else 
            {
                PrintErrorInstructionMessage();
            }
        } 
        public void Count(string[] args)
        {
            if (args.Length == 1)
            {
                string listName = args[1];

                try
                {
                    Wordlist wordlist = Wordlist.LoadList(listName);

                    Console.WriteLine($"There are {wordlist.Count()} words in {listName}.dat");
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("List not found!");
                    PrintErrorInstructionMessage();
                }
            }
            else
            {
                PrintErrorInstructionMessage();
            }
        }
        public void Practice(string[] args) 
        {
            if (args.Length == 2)
            {

                string listName = args[1];
                string translateThis, rightWord, answer;

                try
                {
                    Wordlist wordlist = Wordlist.LoadList(listName);

                    do
                    {
                        Console.WriteLine($"Practicing on {listName}.dat\n" +
                            $"Enter empty line to quit;");
                        Word word = wordlist.GetWordToPractice();

                        translateThis = word.Translations[word.FromLanguage];
                        rightWord = word.Translations[word.ToLanguage];

                        Console.Write($"\nWhat is {translateThis.ToUpper()}\n" +
                            $"on {wordlist.Languages[word.ToLanguage].ToUpper()}:");
                        answer = Console.ReadLine();

                        if (answer.ToLower().Equals(rightWord))
                        {
                            Console.WriteLine("Thats Correct!!\n");
                        }
                        else if (answer.Equals(""))
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"You are wrong, sir!\n" +
                                $"The correct word is {rightWord.ToUpper()}\n");
                        }

                    } while (!answer.Equals(""));

                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("List Not Found!");
                    PrintErrorInstructionMessage();
                }
            }
            else
            {
                PrintErrorInstructionMessage();
            }
        }
        public static void PrintErrorInstructionMessage()
        {
            Console.WriteLine("Wrong command!\n" +
                "Use any of the following parameters:\n" +
                "-list\n" +
                "-new <listname> <language 1> <language 2> .. <language n>\n" +
                "-add <list name>\n" +
                "-remove <list name> <language> <word 1> <word 2> .. <word n>\n" +
                "-words <listname> <sortByLanguage>\n" +
                "-count <listname>\n" +
                "-practice <listname>");
        }
        
    }
}
