namespace CSV_Kata.Strategy
{
    public class StrategyLast : Strategy
    {
        public StrategyLast(char cmd, int pageLen, string[] rawLines, int previousPageNumber) : base(cmd, pageLen, rawLines, previousPageNumber)
        {
        }


        public override PageDto? operation()
        {
            if (Cmd == 'l')
            {
                var pageDto = new PageDto();
                pageDto.iFirstLineOfLastPage = RawLines.Length - (RawLines.Length - 1)%this.PageLen;
                pageDto.PageLines = new[] { RawLines[0] }.Concat(RawLines.Where((l, i) => i>0 && i>=pageDto.iFirstLineOfLastPage));

                return pageDto;
            }
            return null;
        }
    }
}