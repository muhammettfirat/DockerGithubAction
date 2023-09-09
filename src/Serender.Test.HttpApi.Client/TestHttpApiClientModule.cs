using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Serender.Test;

[DependsOn(
    typeof(TestApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class TestHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(TestApplicationContractsModule).Assembly,
            TestRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<TestHttpApiClientModule>();
        });

    }
}
