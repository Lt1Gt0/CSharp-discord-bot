using DSharpPlus;
using EventHandler;
using FileHandler;
using Microsoft.Extensions.Logging;
using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace Discord_Bot {
    public class Bot {

        //Path to config file
        private static string _configFile = "config.json";
        
        //Non async main method
        static void Main(string[] args) {
            MainAsync().GetAwaiter().GetResult(); //Call the async main method and get the result
            Console.ReadLine();
        }
        static async Task MainAsync() {
            var options = new JsonSerializerOptions {
                IncludeFields = true,
            };

            //Open the filestream to read the config file
            using FileStream openStream = File.OpenRead(_configFile);
            ConfigHandler _discordConfig = 
                await JsonSerializer.DeserializeAsync<ConfigHandler>(openStream, options);

            //Set up the discord client
            var discord = new DiscordClient(new DiscordConfiguration() {
                Token = _discordConfig.token,
                TokenType = TokenType.Bot,
                Intents = DiscordIntents.AllUnprivileged,
                MinimumLogLevel = LogLevel.Debug,
                LogTimestampFormat = "MMM dd yyyy - hh:mm:ss tt"
            });

            //Set up event handling
            EventGuildMember _eGuildMember = new EventGuildMember(discord, _configFile);
            EventMessageHandler _eMessageHandler = new EventMessageHandler(discord, _configFile);

            //Set up command handling

            discord.MessageCreated += _eMessageHandler.MessageCreatedHandler;
            discord.GuildMemberAdded += _eGuildMember.MemberAddedHandler;

            await discord.ConnectAsync(); //Connect the bot
            await Task.Delay(-1);
        }
    }
}
