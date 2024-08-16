using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using StarLight_Core.Models.Utilities;

namespace StarLight_Core.Models.Installer
{
    public class FabricLauncherMeta
    {
        [JsonPropertyName("mainClass")]
        public JsonNode MainClass { get; set; }

        [JsonPropertyName("libraries")]
        public Dictionary<string, List<Library>> Libraries { get; set; }
    }
}