using System.Text.RegularExpressions;

namespace FrameworkWhite.Utils.Common
{
    public class StringParser
    {
        public static int GetWidth(string size)
        {
            Regex regex = new Regex(@"^\d+");
            Match match = regex.Match(size);
            return int.Parse(match.ToString());
        }

        public static int GetHeight(string size)
        {
            Regex regex = new Regex(@"\s\d+");
            Match match = regex.Match(size);
            return int.Parse(match.ToString().Trim());
        }
    }
}
