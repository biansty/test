using MediaBrowser.Common.Plugins;
using MediaBrowser.Model.Plugins;
using MediaBrowser.Model.Serialization;

namespace EmbySubtitleMatcherPlugin
{
    public class Plugin : BasePlugin<PluginConfiguration>, IHasWebPages
    {
        public override string Name => "Subtitle Matcher";
        public override string Description => "匹配字幕文件名中的剧集编号和语言代码";
    }

    public class PluginConfiguration : BasePluginConfiguration
    {
        public bool MatchLanguage { get; set; } = true;
        public bool MatchTitle { get; set; } = false;
    }
}
