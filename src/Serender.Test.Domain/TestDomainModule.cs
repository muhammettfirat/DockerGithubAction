using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Serender.Test;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(TestDomainSharedModule)
)]
public class TestDomainModule : AbpModule
{

}
