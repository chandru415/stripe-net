using MediatR;
using Stripe;

namespace Application.Queries.StripeProduct
{
    public class RetrieveProductQuery: IRequest<Product>
    {
        public string ProductId { get; set; } = string.Empty;
    }
}
