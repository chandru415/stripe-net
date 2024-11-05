using MediatR;
using Stripe;

namespace Application.Commands.StripeProduct
{
    public class CreateProductCommand: IRequest<Product>
    {
        public string Description { get; set; } = string.Empty;
        public List<string> Images { get; set; } = [];
        public Dictionary<string, string> Metadata { get; set; } = [];
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string TaxCode { get; set; } = string.Empty;
        public string UnitLabel { get; set; } = string.Empty;
    }
}
