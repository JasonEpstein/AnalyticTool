using System.Collections.Generic;
using LINQtoCSV;
using StatGenerator.Domain;

namespace StatGenerator
{
    internal class GenerateOutputStats
    {
        public static void OutputCSV(IEnumerable<ResultLine> rows, string outputFileName)
        {
            var outputFileDescription = new CsvFileDescription
            {
                SeparatorChar = ',',
                FirstLineHasColumnNames = true
            };

            var cc = new CsvContext();

            cc.Write(
                rows,
                outputFileName,
                outputFileDescription
            );
        }
    }
}