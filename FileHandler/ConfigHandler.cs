using System.Text.Json.Serialization;

namespace FileHandler
{
    public class ConfigHandler
    {
        [JsonInclude]
        public string token { get; set; }
        [JsonInclude]
        public string client_secret { get; set; }
        [JsonInclude]
        public string command_prefix { get; set; }

        /* Testing remove later */
        [JsonInclude]
        public int test_text_channel_guild_id { get; set; } //Bruh what is this lmao
    }
}
