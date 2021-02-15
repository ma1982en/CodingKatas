using FizzBuzzLogic.Contract;

namespace FizzBuzzLogic.Implementation
{
    public class FizzConverter : IFizzConverter
    {
        public string Convert(int parameter)
        {
            return parameter % 3 == 0 ? "FIZZ" : string.Empty;
        }
    }
}