using Serender.Test.Localization;
using Volo.Abp.Application.Services;

namespace Serender.Test;

public abstract class TestAppService : ApplicationService
{
    protected TestAppService()
    {
        LocalizationResource = typeof(TestResource);
        ObjectMapperContext = typeof(TestApplicationModule);
    }
}
