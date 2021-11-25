using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using FileHandler;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace CommandHandler
{
    public class CommandLEDControl : BaseCommandModule {
        private const string configFile = "config.json";
        private static ConfigHandler discordConfig { get; set; }

        [Command("roomcolor")]
        public async Task RoomColorCommand(CommandContext context, params byte[] rgbValues) {
            await getConfigHandler();

            if (context.Message.ChannelId.Equals(discordConfig.led_channel_text_id)) {
                //await context.RespondAsync($"{discordConfig.LedUsers}");
                await context.RespondAsync($"Params passed: R: {rgbValues[0]}, G: {rgbValues[1]}, B: {rgbValues[2]}");
            }
            else {
                await context.RespondAsync($"You can't use this command in this text channel");
            }
        }

        static async Task getConfigHandler(){
            var options = new JsonSerializerOptions {
                IncludeFields = true,
            };

            //Open the filestream to read the config file
            using FileStream openStream = File.OpenRead(configFile);
            discordConfig = await JsonSerializer.DeserializeAsync<ConfigHandler>(openStream, options);
        }
    }
}
