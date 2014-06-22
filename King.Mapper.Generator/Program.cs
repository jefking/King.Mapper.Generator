namespace King.Mapper.Generator
{
    using System.Diagnostics;
    using System.Linq;

    /// <summary>
    /// King.Mapper.Generator Program
    /// </summary>
    public class Program
    {
        #region Methods
        public static void Main(string[] args)
        {
            Trace.TraceInformation("King.Mapper.Generator Starting.");
            Trace.TraceInformation("Source Code @: https://github.com/jefking/King.Mapper.Generator");

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

            var code = new Code(connectionString, folder);

            Trace.WriteLine("No-Op");

            Trace.TraceInformation("King.Mapper.Generator Completed.");
        }
        #endregion
    }
}