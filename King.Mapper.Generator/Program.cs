namespace King.Mapper.Generator
{
    using King.Mapper.Generator.Sql;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;

    /// <summary>
    /// King.Mapper.Generator Program
    /// </summary>
    public class Program
    {
        #region Methods
        public static int Main(string[] args)
        {
            Trace.TraceInformation("King.Mapper.Generator Starting.");
            Trace.TraceInformation("Source Code @: https://github.com/jefking/King.Mapper.Generator");

            if (args == null)
            {
                Trace.TraceError("No parameters specified, usage: \"Connection String\" Directory.");
                return -1;
            }
            if (2 > args.Length || args.Any(a => string.IsNullOrWhiteSpace(a)))
            {
                Trace.TraceError("Invalid parameters specified: '{0}'", args.Select(a => string.Format("'{0}'", a)));
                return -1;
            }

            var connectionString = args[0];
            var folder = args[1].Replace(@"\\", @"\").Replace("\"", string.Empty);

            try
            {
                Trace.TraceInformation("Loading schema from data source.");

                var loader = new DataLoader(connectionString);
                var task = loader.Load();
                task.Wait();

                Trace.TraceInformation("Processing schema.");

                var manifest = task.Result;

                Trace.TraceInformation("Loading renderers.");

                var renderers = new List<IRender>();
                renderers.Add(new Code(manifest));

                Trace.TraceInformation("Writing files.");

                var writer = new FileWriter(renderers, folder);
                writer.WriteAll();
            }
            catch (Exception ex)
            {
                Trace.TraceError("Failure: '{0}'", ex.Message);
                return -1;
            }

            Trace.TraceInformation("King.Mapper.Generator Completed.");

            return 0;
        }
        #endregion
    }
}