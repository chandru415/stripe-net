using Application.Commands.StripeWebhook;
using Application.Responses;
using MediatR;
using Stripe;

namespace Application.Handlers.CHandlers.StripeWebhook
{
    public class StripeWebhookListenerCommandHandler : IRequestHandler<StripeWebhookListenerCommand, GenericPairResponse<string, Object>>
    {
        /** Need to call db 
         * To validate the signature 
         * Update corresponding details with to tenant or **/
        public StripeWebhookListenerCommandHandler()
        {
           
        }
        public async Task<GenericPairResponse<string, object>> Handle(StripeWebhookListenerCommand request, CancellationToken cancellationToken)
        {
            Event stripeEvent;
            var WebhookSecret = string.Empty; /** These will get it from the Stripe Options in appsettings */

            stripeEvent = EventUtility.ConstructEvent(
                request.JSON,
                request.Signature,
                WebhookSecret
            );

            switch (stripeEvent.Type)
            {
                case "checkout.session.async_payment_succeeded":
                    {
                        /** Logic to handle the event */
                        break;
                    }

                default:
                    break;
            }

            return new GenericPairResponse<string, Object>()
            {
                Key = "",
                Value = new { }
            };

        }
    }
}
