using DSharpPlus;
using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Discord_Bot {
    public class DiscordConfig {
        [JsonInclude]
        public string token { get; set; }
        [JsonInclude]
        public string client_secret { get; set; }
        [JsonInclude]
        public string command_prefix { get; set; }
    }

    public class Program {

        private static string _configFile = "config.json";
        static void Main(string[] args) {
            MainAsync().GetAwaiter().GetResult();
            Console.ReadLine();
        }
        static async Task MainAsync() {
            var options = new JsonSerializerOptions {
                IncludeFields = true,
            };
            using FileStream openStream = File.OpenRead(_configFile);
            DiscordConfig _discordConfig = 
                await JsonSerializer.DeserializeAsync<DiscordConfig>(openStream, options);

            //Set up the discord client
            var discord = new DiscordClient(new DiscordConfiguration() {
                Token = _discordConfig.token,
                TokenType = TokenType.Bot,
                Intents = DiscordIntents.AllUnprivileged
            });

            await discord.ConnectAsync();
            await Task.Delay(-1);
        }
    }
}
