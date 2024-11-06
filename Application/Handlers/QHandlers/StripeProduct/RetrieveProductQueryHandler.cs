using Application.Queries.StripeProduct;
using MediatR;
using Stripe;

namespace Application.Handlers.QHandlers.StripeProduct
{
    internal class RetrieveProductQueryHandler : IRequestHandler<RetrieveProductQuery, Product>
    {
        public async Task<Product> Handle(RetrieveProductQuery request, CancellationToken cancellationToken)
        {
            var service = new ProductService();
            var product = await service.GetAsync(request.ProductId, cancellationToken: cancellationToken);

            return product;
        }
    }
}
