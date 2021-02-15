using FizzBuzzLogic.Contract;

namespace FizzBuzzLogic.Implementation
{
    public class BuzzConverter : IBuzzConverter
    {
        public string Convert(int parameter)
        {
            return parameter % 5 == 0 ? "BUZZ" : string.Empty;
        }
    }
}