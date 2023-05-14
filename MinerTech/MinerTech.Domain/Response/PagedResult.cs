namespace MinerTech.Domain.Response
{
    public class PagedResult : PagedResultBase
    {
        public IList<object> Results { get; set; }

        public PagedResult()
        {
            Results = new List<object>();
        }

        public void ToDto(IList<object> results) 
        {
            Results = results;
        }
    }
}
