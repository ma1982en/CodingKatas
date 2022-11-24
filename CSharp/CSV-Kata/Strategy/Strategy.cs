namespace CSV_Kata.Strategy
{
    public abstract class Strategy
    {
        protected Strategy(char cmd, int pageLen, string[] rawLines, int previosPageNumber)
        {
            Cmd = cmd;
            PageLen = pageLen;
            PreviousPageNumber = previosPageNumber;
            RawLines = rawLines;
        }

        /// <summary>
        /// Keystroke
        /// </summary>
        public char Cmd { get; }

        public int PreviousPageNumber { get; }
        public int PageLen { get; }
        public string[] RawLines { get; }

        public abstract PageDto? operation();
    }
}