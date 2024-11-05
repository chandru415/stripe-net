using MediatR;
using Stripe;

namespace Application.Commands.StripeProduct
{
    public class CreatePriceForProductCommand: IRequest<Price>
    {
        public string Currency { get; set; } =  string.Empty;
        public Dictionary<string, string> Metadata { get; set; } = [];
        public string Product { get; set; } = string.Empty;
        public PriceRecurringOptions Recurring { get; set; } = new PriceRecurringOptions();
        public string TaxBehavior { get; set; } = string.Empty;
        public long? UnitAmount { get; set; } = 0;
        public decimal? UnitAmountDecimal { get; set; } = decimal.Zero;
        public string BillingScheme { get; set; } = string.Empty;
    }
}
