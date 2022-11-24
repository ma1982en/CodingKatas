namespace CSV_Kata.Strategy
{
    public class PageDto
    {
        public IEnumerable<string>? PageLines { get; set; }
        public int iFirstLineOfLastPage { get; set;}
    }
}