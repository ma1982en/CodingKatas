using CSV_Kata.Strategy;

namespace CSVViewer
{
    public class CsvReader
    {
        public string FilePath { get; private set; }
        public int PageLen { get; private set; }

        public CsvReader(string filePath, int pageLen)
        {
           this.FilePath = filePath;
           this.PageLen = pageLen;
        }

        public void Read()
        {
            var rawLines = File.ReadAllLines(this.FilePath);
            var pageLines = rawLines.Take(this.PageLen + 1);
            var iFirstLineOfLastPage = 1;

            while (true)
            {
                var records = pageLines.Select(l => Convert_line_to_record_fields(l, ","));

                var colWidths = Enumerable.Range(0, records.First().Count())
                                          .Select(i => records.Select(r => r[i].Length).Max())
                                          .ToArray();
                var headline = Create_disply_line_for_record(records.First(), colWidths);

                var underlineRecord = Enumerable.Range(0, colWidths.Length).Select(i => new string('-', colWidths[i]));
                var underline = string.Join("+", underlineRecord);

                var displayLines = new[] { headline, underline }.Concat(records.Where((r, i) => i>0).Select(r => Create_disply_line_for_record(r, colWidths)));
                Console.WriteLine(string.Join("\n", displayLines));

                Console.Write("F(irst, L(ast, N(ext, P(rev, eX(it: ");
                var cmd = char.ToLower(Console.ReadKey().KeyChar);
                Console.WriteLine("\n");

                StrategyContext strategyContext = new StrategyContext(cmd,this.PageLen, rawLines, iFirstLineOfLastPage);
                var pageDto = strategyContext.Run();
                if (pageDto != null)
                {
                    pageLines = pageDto.PageLines;
                    iFirstLineOfLastPage = pageDto.iFirstLineOfLastPage;
                }
            }
        }

        private static string[] Convert_line_to_record_fields(string line, string delimiter)
        {
            return Convert_line_to_record_fields(line, delimiter, new List<string>()).ToArray();
        }

        private static List<string> Convert_line_to_record_fields(string line, string delimiter, List<string> fields)
        {
            if (line == "") return fields;

            if (line.StartsWith("\""))
            {
                line = line.Substring(1);
                var iApo = line.IndexOf("\"");
                fields.Add(line.Substring(0, iApo).Trim());

                line = line.Substring(iApo + 1);
                var iDelim = line.IndexOf(delimiter);
                if (iDelim >= 0)
                    line = line.Substring(iDelim + 1);
                else
                    line = "";
            }
            else
            {
                var iDelim = line.IndexOf(delimiter);
                if (iDelim >= 0)
                {
                    fields.Add(line.Substring(0, iDelim).Trim());
                    line = line.Substring(iDelim + 1);
                }
                else
                {
                    fields.Add(line.Trim());
                    line = "";
                }
            }

            return Convert_line_to_record_fields(line, delimiter, fields);
        }


        private static string Create_disply_line_for_record(string[] recordFields, int[] colWidths)
        {
            return string.Join("|", recordFields.Select((f, i) => f.PadRight(colWidths[i])));
        }
    }
}