namespace King.Mapper.Generator
{
    using System.Diagnostics;
    using System.Linq;

    public class Program
    {
        #region Methods
        public static void Main(string[] args)
        {
            if (args == null)
            {
                Trace.TraceError("No parameters specified, usage: \"Connection String\" Directory.");
            }
            if (2 > args.Length || args.Any(a => string.IsNullOrWhiteSpace(a)))
            {
                Trace.TraceError("Invalid parameters specified: '{0}'", args.Select(a => string.Format("'{0}'", a)));
            }

            var connectionString = args[0];
            var folder = args[1].Replace(@"\\", @"\").Replace("\"", string.Empty);

            Trace.WriteLine("No-Op");
        }
        #endregion
    }
}