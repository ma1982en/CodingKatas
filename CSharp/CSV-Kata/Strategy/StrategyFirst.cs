namespace CSV_Kata.Strategy
{
    public class StrategyFirst : Strategy
    {
        public StrategyFirst(char cmd, int pageLen, string[] rawLines, int previousPageNumber) : base(cmd, pageLen, rawLines, previousPageNumber)
        {
        }


        public override PageDto? operation() =>
            Cmd == 'f'
                ? new PageDto
                {
                    PageLines = RawLines.Take(this.PageLen + 1),
                    iFirstLineOfLastPage = 1
                }
                : null;
    }
}