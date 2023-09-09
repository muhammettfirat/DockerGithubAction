using Serender.Test.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Serender.Test;

public abstract class TestController : AbpControllerBase
{
    protected TestController()
    {
        LocalizationResource = typeof(TestResource);
    }
}
