using static Restaurant.Web.Utility.StaticDetails;

namespace Restaurant.Web.Dto
{
    public class RequestDto
    {
        public ApiType ApiType { get; set; } = ApiType.GET;

        public string Url { get; set; }

        public Object Data { get; set; }

        public string AccessToken { get; set; }
    }
}
