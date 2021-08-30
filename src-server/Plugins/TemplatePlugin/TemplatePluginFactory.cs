using Photon.Hive.Plugin;

namespace TemplatePlugin
{
    public class TemplatePluginFactory : PluginFactoryBase
    {
        public override IGamePlugin CreatePlugin(string pluginName)
        {
            return new TemplatePlugin();
        }
    }
}
