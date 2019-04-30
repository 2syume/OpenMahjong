using System;
using System.Collections.Generic;
using System.Text;
using static OpenMahjong.Logic.Common.Template.TileKind;

namespace OpenMahjong.Logic.Common.Template
{
    public static class TileTemplates
    {
        static TileTemplates()
        {
            initTemplates();
        }

        public static TileTemplate Get(string templateId)
        {
            if (templates.ContainsKey(templateId))
            {
                return templates[templateId];
            }
            return null;
        }

        private static Dictionary<string, TileTemplate> templates;

        // 所有牌的类型都在这里添加。
        private static void initTemplates()
        {
            templates = new Dictionary<string, TileTemplate>()
            {
                {"1m", new TileTemplate(1, CHARACTERS) },
                {"2m", new TileTemplate(2, CHARACTERS) },
                {"3m", new TileTemplate(3, CHARACTERS) },
                {"4m", new TileTemplate(4, CHARACTERS) },
                {"5m", new TileTemplate(5, CHARACTERS) },
                {"6m", new TileTemplate(6, CHARACTERS) },
                {"7m", new TileTemplate(7, CHARACTERS) },
                {"8m", new TileTemplate(8, CHARACTERS) },
                {"9m", new TileTemplate(9, CHARACTERS) },
                {"0m", new TileTemplate(5, CHARACTERS, 
                    P("red-dora", "yes")) },  // 五万 - 红宝牌（日麻）

                {"1p", new TileTemplate(1, DOTS) },
                {"2p", new TileTemplate(2, DOTS) },
                {"3p", new TileTemplate(3, DOTS) },
                {"4p", new TileTemplate(4, DOTS) },
                {"5p", new TileTemplate(5, DOTS) },
                {"6p", new TileTemplate(6, DOTS) },
                {"7p", new TileTemplate(7, DOTS) },
                {"8p", new TileTemplate(8, DOTS) },
                {"9p", new TileTemplate(9, DOTS) },
                {"0p", new TileTemplate(5, DOTS, 
                    P("red-dora", "yes")) },  // 五饼 - 红宝牌（日麻）

                {"1s", new TileTemplate(1, BAMBOO) },
                {"2s", new TileTemplate(2, BAMBOO) },
                {"3s", new TileTemplate(3, BAMBOO) },
                {"4s", new TileTemplate(4, BAMBOO) },
                {"5s", new TileTemplate(5, BAMBOO) },
                {"6s", new TileTemplate(6, BAMBOO) },
                {"7s", new TileTemplate(7, BAMBOO) },
                {"8s", new TileTemplate(8, BAMBOO) },
                {"9s", new TileTemplate(9, BAMBOO) },
                {"0s", new TileTemplate(5, BAMBOO, 
                    P("red-dora", "yes")) },  // 五条 - 红宝牌（日麻）

                {"1z", new TileTemplate(1, WINDS) },  // 东
                {"2z", new TileTemplate(2, WINDS) },  // 南
                {"3z", new TileTemplate(3, WINDS) },  // 西
                {"4z", new TileTemplate(4, WINDS) },  // 北

                {"5z", new TileTemplate(5, DRAGONS) },  // 白
                {"6z", new TileTemplate(6, DRAGONS) },  // 发
                {"7z", new TileTemplate(7, DRAGONS) },  // 中

                {"1f", new TileTemplate(1, FLOWERS) },  // 春
                {"2f", new TileTemplate(2, FLOWERS) },  // 夏
                {"3f", new TileTemplate(3, FLOWERS) },  // 秋
                {"4f", new TileTemplate(4, FLOWERS) },  // 冬

                {"5f", new TileTemplate(1, SEASON) },  // 梅
                {"6f", new TileTemplate(2, SEASON) },  // 兰
                {"7f", new TileTemplate(3, SEASON) },  // 菊
                {"8f", new TileTemplate(4, SEASON) },  // 竹

                {"<>", new TileTemplate(0, WILDCARD, 
                    P("wildcard", "true")) },  // 混儿
            };
        }

        private static KeyValuePair<string, string> P(string key, string value)
        {
            return new KeyValuePair<string, string>(key, value);
        }
    }
}
