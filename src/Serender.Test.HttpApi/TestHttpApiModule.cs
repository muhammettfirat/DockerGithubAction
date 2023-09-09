using Localization.Resources.AbpUi;
using Serender.Test.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Serender.Test;

[DependsOn(
    typeof(TestApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class TestHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(TestHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<TestResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
