using DSharpPlus;
using DSharpPlus.EventArgs;
using System.Threading.Tasks;

namespace EventHandler {
    public class EventGuildMember : EventHandlerBase{
        public EventGuildMember(DiscordClient _discord, string _configFile) : base(_discord, _configFile){
        }

        public Task MemberAddedHandler(DiscordClient s, GuildMemberAddEventArgs e) {
            return Task.CompletedTask;
        } 
    }
}
