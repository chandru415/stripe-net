using Application.Common.Models;

namespace Application.Responses.Categories
{
    public class CategoryResponse : BaseResponse
    {
        public string CategoryName { get; set; }
        public string CategoryTelugu { get; set; }
        public string Description { get; set; }
        public string DescriptionTelugu { get; set; }
    }
}
