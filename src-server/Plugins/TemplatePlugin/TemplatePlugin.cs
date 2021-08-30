using Photon.Hive.Plugin;

namespace TemplatePlugin
{
    public class TemplatePlugin : PluginBase
    {
        public override string Name => "TemplatePlugin";

        public override void OnCreateGame(ICreateGameCallInfo info)
        {
            this.PluginHost.LogInfo(string.Format("OnCreateGame {0} by user {1}", info.Request.GameId, info.UserId));
            info.Continue();
        }
    }
}
