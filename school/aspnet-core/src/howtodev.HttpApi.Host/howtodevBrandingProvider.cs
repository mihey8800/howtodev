using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace howtodev;

[Dependency(ReplaceServices = true)]
public class howtodevBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "howtodev";
}
