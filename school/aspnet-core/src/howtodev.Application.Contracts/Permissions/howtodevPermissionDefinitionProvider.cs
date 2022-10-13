using howtodev.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace howtodev.Permissions;

public class howtodevPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(howtodevPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(howtodevPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<howtodevResource>(name);
    }
}
