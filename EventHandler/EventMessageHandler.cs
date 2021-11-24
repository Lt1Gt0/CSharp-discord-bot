using DSharpPlus;
using DSharpPlus.EventArgs;
using FileHandler;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace EventHandler {
    public class EventMessageHandler : EventHandlerBase{
        public EventMessageHandler(DiscordClient _discord, string _configFile) : base(_discord, _configFile) {
        }

        public async Task MessageCreatedHandler(DiscordClient s, MessageCreateEventArgs e) {
            var options = new JsonSerializerOptions {
                IncludeFields = true,
            };

            //Open the filestream to read the config file
            using FileStream openStream = File.OpenRead(configFile);
            ConfigHandler _discordConfig =
                await JsonSerializer.DeserializeAsync<ConfigHandler>(openStream, options);

            if (e.Guild?.Id == _discordConfig.led_channel_text_id) {
                await e.Message.DeleteAsync();
            }
        }
    }
}
