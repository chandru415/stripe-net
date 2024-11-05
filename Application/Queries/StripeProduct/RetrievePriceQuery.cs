using MediatR;
using Stripe;

namespace Application.Queries.StripeProduct
{
    public class RetrievePriceQuery: IRequest<Price>
    {
        public string PriceId { get; set; } = string.Empty;
    }
}
