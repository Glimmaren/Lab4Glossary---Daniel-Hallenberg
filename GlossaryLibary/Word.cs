using System;

namespace GlossaryLibary
{
    public class Word
    {
        public string[] Translations { get; }
        public int FromLanguage { get; }
        public int ToLanguage { get; }

        public Word(params string[] translations)
        {
            Translations = translations;
        }

        public Word(int fromLanguage, int toLanguage, params string[] translations)
        {
            FromLanguage = fromLanguage;
            ToLanguage = toLanguage;
            Translations = translations;
        }

        public override string ToString()
        {
            return $"{Translations[0]}";
        }

        public bool WordExist(Word word)
        {

            for (int i = 0; i < Translations.Length; i++)
            {
                for (int j = 0; j < Translations.Length; j++)
                {
                    if (word.Translations[i].Equals(this.Translations[j]))
                    {
                        return true;          
                    } 
                }
            }
            return false;  
        }
    }
}
