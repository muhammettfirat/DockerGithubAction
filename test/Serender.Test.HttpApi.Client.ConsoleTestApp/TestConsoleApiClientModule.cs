using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Serender.Test;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(TestHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class TestConsoleApiClientModule : AbpModule
{

}
