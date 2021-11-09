using DSharpPlus;
using DSharpPlus.EventArgs;
using System.Threading.Tasks;

namespace EventHandler {
    public class EventMessageHandler {
        private static DiscordClient discord;
        public EventMessageHandler(DiscordClient _discord) {
            discord = _discord;
        }

        public async Task MessageCreatedHandler(DiscordClient s, MessageCreateEventArgs e) {
            if(e.Guild?.Id == 906664701214195712) {
                await e.Message.DeleteAsync();
            }
        }
    }
}
