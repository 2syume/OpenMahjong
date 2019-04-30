using OpenMahjong.Logic.Common.Template;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenMahjong.Logic.Common.GameObject
{
    public class Tile
    {
        public Tile(string templateId) : this(templateId, null) { }

        public Tile(string templateId, Dictionary<string, string> properties)
        {
            this.TemplateId = templateId;
            if (properties == null)
            {
                this.properties = new Dictionary<string, string>();
            }
            else
            {
                this.properties = new Dictionary<string, string>(properties);
            }
        }

        public string TemplateId { get; private set; }

        public string this[string key]
        {
            get
            {
                string value = null;

                if (properties.ContainsKey(key))
                {
                    value = properties[key];
                }
                else if (TileTemplates.Get(TemplateId).Properties.ContainsKey(key))
                {
                    value = TileTemplates.Get(TemplateId).Properties[key];
                }

                return value ?? string.Empty;
            }
        }

        private readonly Dictionary<string, string> properties;
    }
}
