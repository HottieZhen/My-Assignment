using System;
namespace OrderingWebsite.BLL
{
    public class QueryDto
    {
        public int PageNo { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public string KeyWord { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
        public string Type { get; set; }
    }
}
