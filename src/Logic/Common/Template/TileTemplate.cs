using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenMahjong.Logic.Common.Template
{
    public class TileTemplate
    {
        public TileTemplate(int number, int kind)
        {
            initTileTemplate(number, kind, null);
        }
        public TileTemplate(int number, int kind, params KeyValuePair<string ,string>[] properties)
        {
            initTileTemplate(number, kind, properties.ToList());
        }

        private void initTileTemplate(int number, int kind, List<KeyValuePair<string, string>> properties)
        {
            this.Number = number;
            this.Kind = kind;

            this.Properties = new Dictionary<string, string>();
            properties.ForEach(x => this.Properties.Add(x.Key, x.Value));
        }

        public int Number { get; private set; }
        public int Kind { get; private set; }
        public Dictionary<string, string> Properties { get; private set; }
    }
}
