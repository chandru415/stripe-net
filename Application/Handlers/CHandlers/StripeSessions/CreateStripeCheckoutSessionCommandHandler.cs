using Application.Commands.StripeSessions;
using Application.Options;
using MediatR;
using Microsoft.Extensions.Options;
using Stripe.Checkout;

namespace Application.Handlers.CHandlers.StripeSessions
{
    internal class CreateStripeCheckoutSessionCommandHandler : IRequestHandler<CreateStripeCheckoutSessionCommand, Session>
    {
        private readonly IOptions<StripeSettings> _options;
        public CreateStripeCheckoutSessionCommandHandler(IOptions<StripeSettings> options)
        {
            _options = options;
        }
        public Task<Session> Handle(CreateStripeCheckoutSessionCommand request, CancellationToken cancellationToken)
        {
            var options = new SessionCreateOptions
            {
                SuccessUrl = $"{_options.Value.SuccessUrl}?session_id={{CHECKOUT_SESSION_ID}}",
                ReturnUrl = $"{_options.Value.ReturnUrl}?session_id={{CHECKOUT_SESSION_ID}}",
                CancelUrl = $"{_options.Value.CancelUrl}?session_id={{CHECKOUT_SESSION_ID}}",
                Mode = request.Mode,
                Currency = request.Currency,
                Metadata = request.Metadata,
                LineItems = request.LineItems,
                ClientReferenceId = request.ClientReferenceId,
                Customer = request.Customer,
            };

            var service = new SessionService();
            var returnOptions = service.CreateAsync(options, cancellationToken: cancellationToken);

            return returnOptions;
        }

    }
}
