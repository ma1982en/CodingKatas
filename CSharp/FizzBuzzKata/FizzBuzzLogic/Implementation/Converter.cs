using FizzBuzzLogic.Contract;

namespace FizzBuzzLogic.Implementation
{
    public class Converter : IConverter
    {
        private readonly IFizzConverter _fizzConverter;
        private readonly IBuzzConverter _buzzConverter;

        public Converter(IFizzConverter fizzConverter, IBuzzConverter buzzConverter)
        {
            _fizzConverter = fizzConverter;
            _buzzConverter = buzzConverter;
        }

        public string Convert(int parameter)
        {
            if (parameter == 0)
            {
                return "0";
            }
            var result = _fizzConverter.Convert(parameter);
            result += _buzzConverter.Convert(parameter);
            return string.IsNullOrEmpty(result) ? parameter.ToString() : result;
        }
    }
}