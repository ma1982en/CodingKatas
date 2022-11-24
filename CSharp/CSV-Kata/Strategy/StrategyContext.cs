namespace CSV_Kata.Strategy
{
    public class StrategyContext
    {
        List<Strategy> strategyList = new();


        public char Cmd { get; }
        public int PageLen { get; }
        public string[] RawLines { get; }
        public int PreviousPageNumber { get; }

        public StrategyContext(char cmd, int pageLen, string[] rawLines, int previousPageNumber)
        {
            Cmd=cmd;
            PageLen=pageLen;
            RawLines=rawLines;
            PreviousPageNumber=previousPageNumber;

            strategyList.Add(new StrategyExit(cmd,pageLen,rawLines, previousPageNumber));
            strategyList.Add(new StrategyFirst(cmd, pageLen, rawLines, previousPageNumber));
            strategyList.Add(new StrategyLast(cmd, pageLen, rawLines, previousPageNumber));
            strategyList.Add(new StrategyNext(cmd, pageLen, rawLines, previousPageNumber));
            strategyList.Add(new StrategyPrevious(cmd, pageLen, rawLines, previousPageNumber));

        }

        public PageDto? Run()
        {
            foreach (var strategy in strategyList)
            {
               var  pageDto = strategy.operation();
               if (pageDto != null)
               {
                   return pageDto;
               }
            }
            return null;
        }
    }
}