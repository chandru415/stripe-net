using MediatR;
using Stripe.Checkout;

namespace Application.Commands.StripeSessions
{
    public class CreateStripeCheckoutSessionCommand: IRequest<Session>
    {
        public string ClientReferenceId { get; set; } = Guid.NewGuid().ToString();
        public string Currency { get; set; } = string.Empty;
        public string Customer { get; set; } = string.Empty;
        public List<SessionLineItemOptions> LineItems { get; set; } = [];
        public Dictionary<string, string> Metadata { get; set; } = [];
        public string Mode { get; set; } = string.Empty;
    }
}
