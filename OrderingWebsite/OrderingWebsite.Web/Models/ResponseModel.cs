using System;
namespace OrderingWebsite.Web.Models
{
    public class ResponseModel
    {
        public ResponseModel(bool status, object model = null, int total = 0)
        {
            Status = status;
            Data = model;
            Total = total;
        }

        public bool Status { get; set; }
        public object Data { get; set; }
        public int Total { get; set; }
    }
}
