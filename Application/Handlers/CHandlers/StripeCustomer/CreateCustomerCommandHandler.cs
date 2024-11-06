using Application.Commands.StripeCustomer;
using Application.Responses;
using MediatR;
using Stripe;

namespace Application.Handlers.CHandlers.StripeCustomer
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, GenericPairResponse<string, Customer>>
    {
        public CreateCustomerCommandHandler() { }

        public async Task<GenericPairResponse<string, Customer>> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            var options = new CustomerCreateOptions()
            {
                Name = request.Name,
                Email = request.Email,
                Address = request.Address,
                Shipping = request.Shipping,
                Phone = request.Phone,
                PreferredLocales = request.PreferredLocales,
                Description = request.Description,
                Metadata = request.Metadata,
            };
            var service = new CustomerService();
            var customer = await service.CreateAsync(options, cancellationToken: cancellationToken);

            return new GenericPairResponse<string, Customer>() { Key = customer.Id , Value = customer };
        }
    }
}
