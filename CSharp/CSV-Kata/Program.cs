using CSVViewer;

// Sample data: https://www.census.gov/econ/cbp/download/index.htm

namespace CSV_Kata
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            uint pageLen = 5;
            if (args.Length > 1)
            {
                if (uint.TryParse(args[1], out var parsedResult))
                {
                    if (parsedResult < 5)
                    {
                        pageLen = parsedResult;
                    }
                    
                }
            }
            

            var csvReader = new CsvReader(args[0],(int) pageLen);
            csvReader.Read();
        }
    }
}