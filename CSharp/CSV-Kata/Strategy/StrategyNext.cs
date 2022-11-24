namespace CSV_Kata.Strategy
{
    public class StrategyNext : Strategy
    {
        public StrategyNext(char cmd, int pageLen, string[] rawLines, int previousPageNumber): base(cmd, pageLen, rawLines, previousPageNumber) 
        {
        }


        public override PageDto? operation()
        {
            if (Cmd == 'n')
            {
                var pageDto = new PageDto
                {
                    iFirstLineOfLastPage = PreviousPageNumber + PageLen
                };

                if (pageDto.iFirstLineOfLastPage >= RawLines.Length)
                    pageDto.iFirstLineOfLastPage = RawLines.Length - (RawLines.Length - 1) % this.PageLen;
                pageDto.PageLines = new[] { RawLines[0] }.Concat(RawLines.Where((l, i) => i > 0 && i >= pageDto.iFirstLineOfLastPage && i < (pageDto.iFirstLineOfLastPage+this.PageLen)));

                return pageDto;
            }
            return null;
        }
    }
}
