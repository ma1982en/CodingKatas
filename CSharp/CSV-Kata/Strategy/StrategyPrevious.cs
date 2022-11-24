namespace CSV_Kata.Strategy
{
    public class StrategyPrevious : Strategy
    {
        public StrategyPrevious(char cmd, int pageLen, string[] rawLines, int previousPageNumber): base(cmd, pageLen, rawLines, previousPageNumber)
        {
        }


        public override PageDto? operation()
        {
            if (Cmd == 'p')
            {
                var pageDto = new PageDto();
                pageDto.iFirstLineOfLastPage -= this.PageLen;
                if (pageDto.iFirstLineOfLastPage < 1)
                    pageDto.iFirstLineOfLastPage = 1;
                pageDto.PageLines = new[] { RawLines[0] }.Concat(RawLines.Where((l, i) => i > 0 && i >= pageDto.iFirstLineOfLastPage && i < (pageDto.iFirstLineOfLastPage+this.PageLen)));

                return pageDto;
            }
            return null;
        }
    }
}