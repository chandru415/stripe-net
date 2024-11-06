using Application.Commands.StripeProduct;
using MediatR;
using Stripe;

namespace Application.Handlers.CHandlers.StripeProduct
{
    public class CreatePriceForProductCommandHandler : IRequestHandler<CreatePriceForProductCommand, Price>
    {
        public async Task<Price> Handle(CreatePriceForProductCommand request, CancellationToken cancellationToken)
        {
            var options = new PriceCreateOptions()
            {
                Product = request.Product,
                Currency = request.Currency,
                Metadata = request.Metadata,
                Recurring = request.Recurring,
                TaxBehavior = request.TaxBehavior,
                UnitAmount = request.UnitAmount,
                UnitAmountDecimal = request.UnitAmountDecimal,
                BillingScheme = request.BillingScheme,
            };

            var serive = new PriceService();
            var price = await serive.CreateAsync(options, cancellationToken: cancellationToken);
            return price;
        }
    }
}
