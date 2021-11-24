using DSharpPlus;
using DSharpPlus.EventArgs;
using FileHandler;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace EventHandler {
    public class EventMessageHandler {
        //int testTextChannelGuildId =
        private static DiscordClient discord;
        private static string configFile;
        public EventMessageHandler(DiscordClient _discord, string _configFile) {
            discord = _discord;
            configFile = _configFile;
        }

        public async Task MessageCreatedHandler(DiscordClient s, MessageCreateEventArgs e) {
            var options = new JsonSerializerOptions {
                IncludeFields = true,
            };

            //Open the filestream to read the config file
            using FileStream openStream = File.OpenRead(configFile);
            ConfigHandler _discordConfig =
                await JsonSerializer.DeserializeAsync<ConfigHandler>(openStream, options);

            if (e.Guild?.Id == /*lmao*/) {
                await e.Message.DeleteAsync();
            }
        }
    }
}
