using Volo.Abp.Settings;

namespace howtodev.Settings;

public class howtodevSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(howtodevSettings.MySetting1));
    }
}
