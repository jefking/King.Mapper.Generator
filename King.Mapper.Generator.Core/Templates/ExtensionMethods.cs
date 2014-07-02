namespace King.Mapper.Generator.Templates
{
    using System.Text;

    public static class ExtensionMethods
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string CamelCase(this string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return s;
            }

            var words = s.Split(' '); //, '-', '.'
            var sb = new StringBuilder();
            foreach (string word in words)
            {
                if (word.Length > 0)
                {
                    sb.Append(char.ToUpper(word[0]));
                    sb.Append(word.Substring(1).ToLower());
                }
                sb.Append(' ');
            }
            return sb.ToString().Trim();
        }
    }
}