using Domain.Common;

namespace Domain.Entities.Categories
{
    public class Category : EntityBase
    {
        public Category() { }
        public string CategoryName { get; set; }
        public string CategoryTelugu { get; set; }
        public string Description { get; set; }
        public string DescriptionTelugu { get; set; }
    }
}
