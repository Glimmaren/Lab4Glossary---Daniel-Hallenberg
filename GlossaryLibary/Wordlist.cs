using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace GlossaryLibary
{
    public class Wordlist
    {
        public string Name { get; private set; }
        public string[] Languages { get; private set; }
        private List<Word> Words { get; set; }
        public Wordlist(string name, params string[] languages)
        {
            Name = name;
            Languages = languages;
        }
        public static string[] GetLists()
        {
            try
            {
                return Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "*.dat")
                                                .Select(Path.GetFileNameWithoutExtension).ToArray();
            }
            catch (ArgumentException)
            {
                throw new Exception("Invalid path");
            }
            catch (FileNotFoundException)
            {
                throw new Exception("File not found");
            }
            catch (PathTooLongException)
            {
                throw new Exception("Path was too long");
            }

        }
        public static Wordlist LoadList(string name)
        {
            string fileName = name + ".dat";
            string fullPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\" + fileName;
            List<string> lines = new List<string>();
            List<string> words = new List<string>();
            List<Word> translationWords = new List<Word>();
            
            using (StreamReader reader = new StreamReader(fullPath))
            {
                while (!reader.EndOfStream)
                {
                    lines.Add(reader.ReadLine());
                }
            }

            string[] language = lines[0].Split(';');
            language = language.Where(x => !string.IsNullOrEmpty(x)).ToArray();

            if (language.Length > 1)
            {
                for (int i = 0; i < language.Length; i++)
                {
                    if (!language[i].All(char.IsLetter))
                    {
                        throw new Exception($"{language[i]} is not a valid language, check file");
                    }
                }
            }
            else
            {
                throw new Exception($"Number of langues är to low, check file!");
            }

            var wordList = new Wordlist(name, language.ToArray());

            for (int i = 1; i < lines.Count; i++)
            {
                string[] translation = lines[i].Split(';').ToArray();
                translation = translation.Where(x => !string.IsNullOrEmpty(x)).ToArray();

                translationWords.Add(new Word(translation));
            }

            wordList.Words = translationWords;

            return wordList;
        } // kolla över denna om det går att refactora
        public void Save()
        {
            string fullPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\" + this.Name + ".dat";

            using (StreamWriter writer = new StreamWriter(fullPath))
            {
                string languageLine = String.Join(";", Languages) + ";";
                writer.WriteLine(languageLine);
                
                if (this.Words != null)
                {
                    for (int i = 0; i < this.Words.Count; i++)
                    {
                        if (Words[i].Translations != null)
                        {
                            var wordLine = String.Join(";", Words[i].Translations) + ";";
                            writer.WriteLine(wordLine);
                        }
                    } 
                }

            }
        }
        public void Add(params string[] translations)
        {
            if (this.Languages.Length != translations.Length)
            {
                throw new ArgumentException("translations is out of bounds");
            }

            foreach (var t in translations)
            {
                t.ToLower();
            }

            Word word = new Word(translations);

            // kolla om man skall ha exceptions
            for (int i = 0; i < Words.Count; i++)
            {
                if (this.Words[i].WordExist(word))
                {
                    Console.WriteLine("Word Exist!");
                    goto here;
                }
            }

            this.Words.Add(word);
        here:;
        } 
        public bool Remove(int translation, string word)
        {
            word = word.ToLower();
            int count = 0;
            

            for (int i = 0; i < this.Words.Count; i++)
            {
                if (this.Words[i].Translations[translation].Equals(word))
                {
                    this.Words.RemoveAt(i);
                    count++;
                }         
            }

            if (count >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }     
        }
        public int Count()
        {
            return this.Words.Count;
        }

        //Vet att list är kopierad ifrån dig Claes, men jag förstod förstod mig verkligen inte på Actions så jag började bakvägen
        //med din metod. Sedan när jag väl förstod så var det omöjligt att skriva en ny metod när jag har din framför mig!
        public void List(int sortByTranslation, Action<string[]> showTranslations)
        {
            if(sortByTranslation < 0 || sortByTranslation >= Languages.Length)
            {
                throw new ArgumentException("sortByTranslations out of range");
            }

            foreach (Word word in Words.OrderBy(w => w.Translations[sortByTranslation]).ToArray())
            {
                showTranslations?.Invoke(word.Translations);
            }
        }
        public Word GetWordToPractice()
        {
            Random rand = new Random();
            int fromLanguage, toLanguage;
            Word wordTemp = Words[rand.Next(0, this.Words.Count)];

            do
            {
                fromLanguage = rand.Next(0, this.Languages.Length);
                toLanguage = rand.Next(0, this.Languages.Length);

            } while (fromLanguage == toLanguage);

            return new Word(fromLanguage, toLanguage, wordTemp.Translations);

        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}


