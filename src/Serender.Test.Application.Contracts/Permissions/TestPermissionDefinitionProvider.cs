using Serender.Test.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Serender.Test.Permissions;

public class TestPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(TestPermissions.GroupName, L("Permission:Test"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<TestResource>(name);
    }
}
