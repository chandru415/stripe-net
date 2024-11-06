using Application.Responses;
using MediatR;
using Stripe;
using System.ComponentModel.DataAnnotations;

namespace Application.Commands.StripeCustomer
{
    public class CreateCustomerCommand: IRequest<GenericPairResponse<string, Customer>>
    {
        [Required]
        public string Email { get; set; } = string.Empty;
        public Dictionary<string, string> Metadata { get; set; } = [];
        [Required]
        public string Name { get; set; } = string.Empty;
        public string? Phone { get; set; }
        public List<string> PreferredLocales { get; set; } = [];
        public ShippingOptions Shipping { get; set; } = new ShippingOptions();
        public string Description { get; set; } = string.Empty;
        public AddressOptions Address { get; set; } = new AddressOptions();
        [Required]
        public Guid ReferenceIndentifer { get; set; } = new Guid();
    }
}
