using Application.Responses;
using MediatR;

namespace Application.Commands.StripeWebhook
{
    public class StripeWebhookListenerCommand: IRequest<GenericPairResponse<string, Object>>
    {
        public string? JSON { get; set; }
        public string? Signature { get; set; }
    }
}
