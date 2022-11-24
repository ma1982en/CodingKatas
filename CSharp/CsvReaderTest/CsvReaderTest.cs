using CSVViewer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CsvKataTest
{
    [TestClass]
    public class CsvReaderTest
    {
        [TestMethod]
        public void TestCsvReader()
        {
            //arrange
            const string filePath = "";
            const int pagelen = 0;

            //act
            var csvReader = new CsvReader(filePath, pagelen);
            //assert
        }
    }
}