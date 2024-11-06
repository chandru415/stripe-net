using Application.Commands.StripeCustomer;
using Application.Commands.StripeProduct;
using Application.Commands.StripeSessions;
using Application.Commands.StripeWebhook;
using Application.Queries.StripeProduct;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentsController : MainController
    {
        [HttpPost("create-checkout-session")]
        public async Task<IActionResult> CreateCheckoutSession([FromBody] CreateStripeCheckoutSessionCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }

        [HttpPost("create-stripe-customer")]
        public async Task<IActionResult> CreateCustomerInStripe([FromBody] CreateCustomerCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }

        [HttpPost("create-stripe-product")]
        public async Task<IActionResult> CreateProductInStripe([FromBody] CreateProductCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }

        [HttpPost("fetch-stripe-product")]
        public async Task<IActionResult> FetchProductInStripe([FromBody] RetrieveProductQuery query)
        {
            var result = await Mediator.Send(query);
            return Ok(result);
        }

        [HttpPost("fetch-stripe-price")]
        public async Task<IActionResult> FetchPriceInStripe([FromBody] RetrievePriceQuery query)
        {
            var result = await Mediator.Send(query);
            return Ok(result);
        }

        [HttpPost("create-stripe-price")]
        public async Task<IActionResult> CreatePriceInStripe([FromBody] CreatePriceForProductCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }

        [HttpPost("stripe-webhook")]
        public async Task<IActionResult> StripeWebHook()
        {
            var json = await new StreamReader(HttpContext.Request.Body).ReadToEndAsync();
            var result = await Mediator.Send(new StripeWebhookListenerCommand()
            {
                JSON = json,
                Signature = Request.Headers["Stripe-Signature"]
            });
            return Ok(result);
        }
    }
}
