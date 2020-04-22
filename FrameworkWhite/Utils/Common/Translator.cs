using FrameworkWhite.AppFrame;
using FrameworkWhite.Utils.Constans;
using System.Collections.Generic;


namespace FrameworkWhite.Utils.Common
{
    public static class Translator
    {
        private static readonly Dictionary<string, string> fromEnToRU = EnRuDictionary.Get;

        public static string Translate(this string text)
        {
            if (string.Equals(LanguageText.Determinet(App.GetInstance().WindowName), "ru") 
                || string.Equals(LanguageText.Determinet(App.GetInstance().WindowName), "mix"))
            {
                return fromEnToRU[text];
            }
            return text;
        }
    }
}
