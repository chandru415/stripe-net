using Application.Commands.StripeProduct;
using MediatR;
using Stripe;

namespace Application.Handlers.CHandlers.StripeProduct
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Product>
    {
        public async Task<Product> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var options = new ProductCreateOptions()
            {
                Name = request.Name,
                Description = request.Description,
                Type = request.Type,
                Images = request.Images,
                Metadata = request.Metadata,
                Shippable = false,
                TaxCode = request.TaxCode,
                UnitLabel = request.UnitLabel,
            };
            var service = new ProductService();
            var product = await service.CreateAsync(options, cancellationToken: cancellationToken);

            return product;
        }
    }
}
