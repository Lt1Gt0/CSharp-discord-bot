using DSharpPlus;
using DSharpPlus.EventArgs;
using System;
using System.Threading.Tasks;

namespace EventHandler {
    public class EventGuildMember {
        private static DiscordClient discord;
        private static string configFile;
        public EventGuildMember(DiscordClient _discord, string _configFile) {
            discord = _discord;
            configFile = _configFile;
        }

        public Task MemberAddedHandler(DiscordClient s, GuildMemberAddEventArgs e) {
            return Task.CompletedTask;
        } 
    }
}
