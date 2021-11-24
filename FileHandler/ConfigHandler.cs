using System.Text.Json.Serialization;
using UserLibrary;

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
        [JsonInclude]
        public LedUser[] ledUser { get; set; }

        /* Testing remove later */
        [JsonInclude]
        public ulong test_text_channel_guild_id { get; set; } //Bruh what is this lmao
        [JsonInclude]
        public ulong led_channel_text_id { get; set; }
    }
}
