using Api.Installers.Interfaces;
using Application.Options;
using Stripe;

namespace Api.Installers.InstallServices
{
    public class StripeInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            var stripeSettings = new StripeSettings();
            configuration.Bind(nameof(StripeSettings), stripeSettings);

            services.AddSingleton(stripeSettings);

            StripeConfiguration.ApiKey = stripeSettings.Secret;
        }
    }
}
