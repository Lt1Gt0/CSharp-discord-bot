using DSharpPlus;

namespace EventHandler {
    public abstract class EventHandlerBase {
        protected static DiscordClient discord;
        protected static string configFile;

        public EventHandlerBase(DiscordClient _discord, string _configFile) {
            discord = _discord;
            configFile = _configFile;
        }
    }
}
