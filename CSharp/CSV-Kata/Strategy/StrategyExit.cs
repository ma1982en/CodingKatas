namespace CSV_Kata.Strategy
{
    public class StrategyExit : Strategy
    {
        public StrategyExit(char cmd, int pageLen, string[] rawLines, int previousPageNumber) : base(cmd, pageLen, rawLines, previousPageNumber)
        {
        }

        public override PageDto? operation()
        {
            if (Cmd == 'x')
            {
                Environment.Exit(0);
            }
            return null;
        }

    }
}