using Application.Queries.StripeProduct;
using MediatR;
using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Handlers.QHandlers.StripeProduct
{
    public class RetrievePriceQueryHandler : IRequestHandler<RetrievePriceQuery, Price>
    {
        public async Task<Price> Handle(RetrievePriceQuery request, CancellationToken cancellationToken)
        {
            var serive = new PriceService();
            var price = await serive.GetAsync(request.PriceId, cancellationToken: cancellationToken);

            return price;
        }
    }
}
