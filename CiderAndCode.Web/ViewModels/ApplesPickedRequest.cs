using CiderAndCode.Web.DataModels;

namespace CiderAndCode.Web.ViewModels
{
    public class ApplesPickedRequest
    {
        public AppleType Type { get; set; }
        public int NumberOfBushels { get; set; }
        public int UserId { get; set; }
    }
}