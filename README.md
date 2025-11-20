# Emby Subtitle Matcher Visual Studio 项目

## 功能
- 可选识别字幕文件名中的剧集名称、剧集编号（SxxExx）、语言代码。

## 使用方法
1. 打开 Visual Studio，加载 EmbySubtitleMatcherPlugin.csproj。
2. 编译项目，生成 DLL。
3. 将 DLL 和 manifest.json 放入 Emby 插件目录：`plugins/SubtitleMatcher`。
4. 重启 Emby 服务器并配置插件选项。
