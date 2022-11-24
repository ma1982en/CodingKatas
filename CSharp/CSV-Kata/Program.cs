using CSVViewer;
using static System.Int32;

// Sample data: https://www.census.gov/econ/cbp/download/index.htm

namespace CSV_Kata
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int pageLen;
            if (args.Length <= 1)
            {
                pageLen = 5;
            }
            else
            {
                TryParse(args[1], out pageLen);
            }

            var csvReader = new CsvReader(args[0], pageLen);
            csvReader.Read();
        }
    }
}