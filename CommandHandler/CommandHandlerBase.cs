using DSharpPlus;

namespace CommandHandler {
    public abstract class CommandHandlerBase {
        protected static DiscordClient discord;
        protected static string configFile;

        public CommandHandlerBase(DiscordClient _discord, string _configFile) {
            discord = _discord;
            configFile = _configFile;
        }
    }
}
