using Serender.Test.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Serender.Test;

/* Domain tests are configured to use the EF Core provider.
 * You can switch to MongoDB, however your domain tests should be
 * database independent anyway.
 */
[DependsOn(
    typeof(TestEntityFrameworkCoreTestModule)
    )]
public class TestDomainTestModule : AbpModule
{

}
