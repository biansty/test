using System.Text.RegularExpressions;

namespace EmbySubtitleMatcherPlugin
{
    public static class SubtitleMatcher
    {
        public static bool MatchSubtitle(string videoName, string subtitleName, bool matchLanguage, bool matchTitle)
        {
            var episodePattern = new Regex(@"S\d{2}E\d{2}", RegexOptions.IgnoreCase);
            var videoEpisode = episodePattern.Match(videoName).Value;
            var subtitleEpisode = episodePattern.Match(subtitleName).Value;

            if (videoEpisode != subtitleEpisode) return false;

            if (matchTitle)
            {
                var titlePart = videoName.Split('.')[0];
                if (!subtitleName.Contains(titlePart)) return false;
            }

            if (matchLanguage)
            {
                var langPattern = new Regex(@"(chs|zh|zh-CN|zh-TW|en|es|fr)", RegexOptions.IgnoreCase);
                if (!langPattern.IsMatch(subtitleName)) return false;
            }

            return true;
        }
    }
}
