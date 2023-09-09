using Volo.Abp.Modularity;

namespace Serender.Test;

[DependsOn(
    typeof(TestApplicationModule),
    typeof(TestDomainTestModule)
    )]
public class TestApplicationTestModule : AbpModule
{

}
