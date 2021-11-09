using DSharpPlus;
using DSharpPlus.EventArgs;
using System;
using System.Threading.Tasks;

namespace EventHandler {
    public class EventGuildMember {
        private static DiscordClient discord;
        public EventGuildMember(DiscordClient _discord) {
            discord = _discord;
        }

        public Task MemberAddedHandler(DiscordClient s, GuildMemberAddEventArgs e) {
            return Task.CompletedTask;
        } 
    }
}
