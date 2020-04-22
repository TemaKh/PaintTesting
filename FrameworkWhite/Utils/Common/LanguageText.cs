namespace FrameworkWhite.Utils.Common
{
    public class LanguageText
    {
        public static string Determinet(string text)
        {
            bool rus = false, eng = false;

            text = text.ToLower();

            byte[] Ch = System.Text.Encoding.Default.GetBytes(text);
            foreach (byte ch in Ch)
            {
                if ((ch >= 97) && (ch <= 122)) eng = true;
                if ((ch >= 224) && (ch <= 255)) rus = true;
            }

            if (eng & !rus) return "en";
            if (rus & !eng) return "ru";
            if (eng & rus) return "mix"; 
            return "uni"; 
        }
    }
}
