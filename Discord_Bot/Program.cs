using DSharpPlus;
using EventHandler;
using Microsoft.Extensions.Logging;
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
                Intents = DiscordIntents.AllUnprivileged,
                MinimumLogLevel = LogLevel.Debug,
                LogTimestampFormat = "MMM dd yyyy - hh:mm:ss tt"
            });

            //Set up event handling
            EventGuildMember _eGuildMember = new EventGuildMember(discord);
            EventMessageHandler _eMessageHandler = new EventMessageHandler(discord);

            discord.MessageCreated += _eMessageHandler.MessageCreatedHandler;
            discord.GuildMemberAdded += _eGuildMember.MemberAddedHandler;

            await discord.ConnectAsync();
            await Task.Delay(-1);
        }
    }
}
