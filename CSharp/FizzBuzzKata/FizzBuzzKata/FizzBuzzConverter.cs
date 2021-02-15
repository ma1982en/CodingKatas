using System;

namespace FizzBuzzKata
{
    public interface IFizzBuzzConverter
    {
        string Convert(int parameter);
    }

    public class FizzBuzzConverter : IFizzBuzzConverter
    {
        public string Convert(int parameter)
        {
            if (parameter == 0)
            {
                return "0";
            }

            var fizzConverter = new FizzConverter();
            var result = fizzConverter.Convert(parameter);

            var buzzConverter = new BuzzConverter();
            result += buzzConverter.Convert(parameter);
            
            return string.IsNullOrEmpty(result) ? parameter.ToString() : result;
        }
    }

    public class FizzConverter : IFizzBuzzConverter
    {
        public string Convert(int parameter)
        {
            return parameter % 3 == 0 ? "FIZZ" : string.Empty;
        }
    }

    public class BuzzConverter : IFizzBuzzConverter
    {
        public string Convert(int parameter)
        {
            return parameter % 5 == 0 ? "BUZZ" : string.Empty;
        }
    }
}