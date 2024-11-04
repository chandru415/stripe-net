

namespace Application.Options
{
    public class StripeSettings
    {
        public StripeSettings() { }
        public string Secret { get; set; } = string.Empty;
        public string PublishableKey { get; set; } = string.Empty;
        public string WebhookSecret { get; set; } = string.Empty;
    }
}
